using System.IO.Ports;

namespace Communication_RS232.Constants
{
    class ServiceConstants
    {
        public static string ConfigMainLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public static string ServiceName = "RS232";

        public static string StartOfJob = "SOJ";
        public static string EndOfJob = "EOJ";
        public static string ManualPassword = "1";

        public const byte ENQ = 0x05;
        public const byte EOT = 0x04;
        public const byte ACK = 0x06;
        public const byte NAK = 0x15;
        public const byte STX = 0x02;
        public const byte ETB = 0x17;
        public const byte ETX = 0x03;

        public enum LogLevel { None, Velbose, Debug, Information, Warning, Error, Fatal };
    }

    public struct IOInfoRS232
    {
        public string Portname;
        public int BaudRate;
        public Parity Parity;
        public int DataBit;
        public StopBits StopBits;
        public Handshake HandShake;
    }
}
