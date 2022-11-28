using Communication_RS232.Constants;
using Communication_RS232.Entity;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace Communication_RS232.Service
{
    public delegate void JobDoneHandler(JobDoneEventArgs eventArgs);

	class RS232c
	{
		private static RS232c _instance = null;

		Timer timerTimeOut;
		private AutoResetEvent checkReceiveTimeOut = new AutoResetEvent(false);
		private bool ack = false;
		private bool ackWorking = false;
		private string _checkReceiveMessage = string.Empty;

		public static RS232c Instance
        {
            get
            {
				lock (typeof(RS232c))
                {
					if (_instance == null)
                    {
						_instance = new RS232c();
                    }

					return _instance;
                }
            }
        }

		private RS232c()
        {
			serialPort = new SerialPort();
        }

		SerialPort serialPort = null;

		Queue<byte> receivedQueue = new Queue<byte>();

		object lockQueueAccess = new object();

		object lockSend = new object();

		public delegate void SendCommandHandler(byte[] sendBytes);
		public event SendCommandHandler OnSend;

		public delegate void ReceiveHandler(byte[] readBytes);
		public event ReceiveHandler OnReceive;

		public delegate void ErrorHandler(string message);
		public event ErrorHandler OnError;

		public event EventHandler OnClose;
		public event EventHandler OnConnect;

		public bool IsConnected 
		{
			get 
			{ 
				if (serialPort == null)
                {
					return false;
                }

				return serialPort.IsOpen; 
			} 
		}

		public string RunJob(JobRs232 job)
		{
			char[] message = job.Message.ToCharArray();

			byte[] messageByte = new byte[message.Length];

			for (int i = 0; i < message.Length; i++)
            {
				messageByte[i] = (byte)message[i];
            }

			if (job.CheckReceive)
            {
				ackWorking = true;
				ack = false;
				this._checkReceiveMessage = job.CheckReceiveMessage;
				timerTimeOut = new Timer(new TimerCallback(timerTimeOutCallback), null, job.ReceiveTimeOut, job.ReceiveTimeOut + 100);
			}

			try
            {
				WriteBytes(messageByte);
			}
            catch (Exception ex)
            {

				ErrorOccured(ex.Message);

				if (job.CheckReceive)
                {
					ackWorking = false;

					timerTimeOut.Dispose();

					checkReceiveTimeOut.Reset();
                }

				return string.Format("NG : {0}", ex.Message);
            }
        

			if (job.CheckReceive)
            {
				checkReceiveTimeOut.WaitOne();

				timerTimeOut.Dispose();
            }

			ackWorking = false;

			if (ack == false)
            {
				return "NG : TimeOut";
            }

			return "OK";
		}

        private void timerTimeOutCallback(object state)
        {
			ack = false;

			checkReceiveTimeOut.Reset();

			timerTimeOut.Dispose();
        }

		public void OpenDevice(IOInfoRS232 in_info)
		{
			if (serialPort != null && serialPort.IsOpen)
			{
				Close();
				//throw new Exception("Already Opened COM Port");
			}

			try
			{
				if (serialPort == null)
				{
					serialPort = new SerialPort();
				}

				serialPort.PortName = in_info.Portname;
				serialPort.BaudRate = in_info.BaudRate;
				serialPort.Parity = in_info.Parity;
				serialPort.DataBits = in_info.DataBit;
				serialPort.StopBits = in_info.StopBits;
				serialPort.ReadTimeout = 3000;
				serialPort.ReadBufferSize = 4096;
				serialPort.WriteBufferSize = 4096;
				serialPort.Handshake = Handshake.None;
				serialPort.DtrEnable = true;

				serialPort.DataReceived += CommDataReceived;

				serialPort.Open();

				Connected();
			}
			catch (Exception ex)
			{
				ErrorOccured(ex.Message);
				//throw ex;
			}
		}

		protected virtual void ErrorOccured(string message)
        {
			if (OnError != null)
            {
				OnError(message);
            }
        }

		protected virtual void Connected()
        {
			if (OnConnect != null)
            {
				OnConnect(this, EventArgs.Empty);
            }
        }

		void CommDataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			int readableBytes = serialPort.BytesToRead;
			if (readableBytes > 0)
			{
				byte[] readbytes = new byte[readableBytes];
				serialPort.Read(readbytes, 0, readableBytes);

				lock (lockQueueAccess)
				{
					foreach (byte data in readbytes)
					{
						receivedQueue.Enqueue(data);
					}

					ReceiveDone(readbytes);
				}
			}
		}

		public void Close()
		{
			if (serialPort == null || serialPort.IsOpen == false)
			{
				return;
			}

			try
			{
				if (serialPort.IsOpen)
				{
					serialPort.Close();
					serialPort = null;

					GC.Collect();
					GC.WaitForPendingFinalizers();

					Closed();
				}
			}
			catch (Exception ex)
			{
				ErrorOccured(ex.Message);
				//throw ex;
			}
		}

		protected virtual void Closed()
        {
			if (OnClose != null)
            {
				OnClose(this, EventArgs.Empty);
            }
        }

		public void WriteBytes(byte[] inputBytes, bool clearReceiveBuffer = true)
		{
			try
			{
				if (clearReceiveBuffer)
				{
					lock (lockQueueAccess)
					{
						receivedQueue.Clear();
					}
				}

                lock (lockSend)
                {
					serialPort.Write(inputBytes, 0, inputBytes.Length);

					SendDone(inputBytes);
				}
			}
			catch (Exception ex)
			{
                //ErrorOccured(ex.Message);
                throw ex;
            }
		}

		///// <summary>
		///// 수신한 데이터 읽어오기
		///// </summary>
		///// <param name="outputBuffer"></param>
		///// <returns>count of readable bytes</returns>
		//public int ReadBytes(ref byte[] outputBuffer)
		//{
		//	int dataRead = 0;

		//	lock (lockQueueAccess)
		//	{
		//		while (receivedQueue.Count > 0)
		//		{
		//			if (dataRead >= outputBuffer.Length)
		//			{
		//				break;
		//			}

		//			byte curByte = receivedQueue.Peek();

		//			if (curByte == ServiceConstants.ETX)
		//			{
		//				outputBuffer[dataRead++] = receivedQueue.Dequeue();

		//				break;
		//			}

		//			// 하나의 return 문장까지만 가져옴
		//			if (curByte == ServiceConstants.STX || curByte == ServiceConstants.ACK)
		//			{
		//				break;
		//			}

		//			outputBuffer[dataRead++] = receivedQueue.Dequeue();
		//		}
		//	}

		//	return dataRead;
		//}

		protected virtual void SendDone(byte[] sendBytes)
		{
			if (OnSend != null)
			{
				OnSend(sendBytes);
			}
		}

		protected virtual void ReceiveDone(byte[] readBytes)
		{
			string message = System.Text.Encoding.Default.GetString(readBytes);

			if (ackWorking)
            {
				ack = this._checkReceiveMessage.Equals(message);
            }

			if (OnReceive != null)
			{
				OnReceive(readBytes);
			}
		}
	}
}
