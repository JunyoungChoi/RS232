using Communication_RS232.Repository;
using Communication_RS232.Service;
using Communication_RS232.Provider;
using System;
using System.Text;
using System.Windows.Forms;

namespace Communication_RS232.View
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void button_SendMessage_Click(object sender, EventArgs e)
        {
            if (((RS232c)ServiceProvider.Instance.GetService("RS232")).IsConnected == true)
            {
                ((RS232c)ServiceProvider.Instance.GetService("RS232")).WriteBytes(Encoding.Default.GetBytes(textBox_SendMessage.Text));

                textBox_SendMessage.Text = string.Empty;
            }
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            textBox_PortName.Text = ConfigRepository.Instance.Config.IOInfoRS232.Portname;
            textBox_BaudRate.Text = ConfigRepository.Instance.Config.IOInfoRS232.BaudRate.ToString();

            if (comboBox_Parity.Items.Contains(ConfigRepository.Instance.Config.IOInfoRS232.Parity.ToString()))
            {
                comboBox_Parity.SelectedItem = ConfigRepository.Instance.Config.IOInfoRS232.Parity.ToString();
            }

            textBox_Databits.Text = ConfigRepository.Instance.Config.IOInfoRS232.DataBit.ToString();

            if (comboBox_StopBits.Items.Contains(ConfigRepository.Instance.Config.IOInfoRS232.StopBits.ToString()))
            {
                comboBox_StopBits.SelectedItem = ConfigRepository.Instance.Config.IOInfoRS232.StopBits.ToString();
            }

            if (comboBox_HandShake.Items.Contains(ConfigRepository.Instance.Config.IOInfoRS232.HandShake.ToString()))
            {
                comboBox_HandShake.SelectedItem = ConfigRepository.Instance.Config.IOInfoRS232.HandShake.ToString();
            }

            updateForm(((RS232c)ServiceProvider.Instance.GetService("RS232")).IsConnected);

            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnConnect += Instance_OnConnect;
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnClose += Instance_OnClose;
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnError += Instance_OnError;
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnSend += Instance_OnSend;
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnReceive += Instance_OnReceive;
        }

        private void updateForm(bool isConnected)
        {
            this.SuspendLayout();

            textBox_PortName.Enabled = !isConnected;
            textBox_BaudRate.Enabled = !isConnected;
            comboBox_Parity.Enabled = !isConnected;
            textBox_Databits.Enabled = !isConnected;
            comboBox_StopBits.Enabled = !isConnected;
            comboBox_HandShake.Enabled = !isConnected;

            button_Connect.Enabled = !isConnected;
            button_Disconnect.Enabled = isConnected;

            textBox_SendMessage.Enabled = isConnected;
            button_SendMessage.Enabled = isConnected;

            this.ResumeLayout();
        }

        private void Instance_OnReceive(byte[] readBytes)
        {
            showLog(string.Format("[Recv] : {0}", System.Text.Encoding.Default.GetString(readBytes)));
        }

        private void Instance_OnSend(byte[] sendBytes)
        {

            showLog(string.Format("[Send] : {0}", Encoding.Default.GetString(sendBytes)));
        }

        private void Instance_OnError(string message)
        {
            showLog(string.Format("[Error] : {0}", message));

            updateForm(((RS232c)ServiceProvider.Instance.GetService("RS232")).IsConnected);
        }

        private void Instance_OnClose(object sender, EventArgs e)
        {
            updateForm(false);

            showLog("Closed");
        }

        private void Instance_OnConnect(object sender, EventArgs e)
        {
            updateForm(true);

            showLog("Connected");
        }

        private void showLog(string text)
        {
            if (textBox_MessageLog.InvokeRequired)
            {
                textBox_MessageLog.Invoke((MethodInvoker)delegate
                {
                    textBox_MessageLog.AppendText(string.Format("[{0}] : {1}{2}", DateTime.Now.ToString("HH:mm:ss"), text, System.Environment.NewLine));
                });
            }
            else
            {
                textBox_MessageLog.AppendText(string.Format("[{0}] : {1}{2}", DateTime.Now.ToString("HH:mm:ss"), text, System.Environment.NewLine));
            }
        }

        private void FormTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnConnect -= Instance_OnConnect;
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnClose -= Instance_OnClose;
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnError -= Instance_OnError;
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnSend -= Instance_OnSend;
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnReceive -= Instance_OnReceive;
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            Constants.IOInfoRS232 iOInfoRS232 = new Constants.IOInfoRS232();

            iOInfoRS232.Portname = textBox_PortName.Text;
            int.TryParse(textBox_BaudRate.Text, out iOInfoRS232.BaudRate);
            Enum.TryParse(comboBox_Parity.SelectedItem?.ToString(), out iOInfoRS232.Parity);
            int.TryParse(textBox_Databits.Text, out iOInfoRS232.DataBit);
            Enum.TryParse(comboBox_StopBits.SelectedItem?.ToString(), out iOInfoRS232.StopBits);
            Enum.TryParse(comboBox_HandShake.SelectedItem?.ToString(), out iOInfoRS232.HandShake);

            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OpenDevice(iOInfoRS232);
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).Close();
        }
    }
}
