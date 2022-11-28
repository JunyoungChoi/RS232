using Communication_RS232.Constants;
using Communication_RS232.Provider;
using Communication_RS232.Repository;
using Communication_RS232.Service;
using System;
using System.Windows.Forms;

namespace Communication_RS232.View
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        private void button_ReloadSerialPort_Click(object sender, EventArgs e)
        {
            comboBox_SerialPort.Items.Clear();
            comboBox_SerialPort.SelectedItem = null;

            string[] ports = System.IO.Ports.SerialPort.GetPortNames();

            comboBox_SerialPort.Items.AddRange(ports);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_SaveConfig_Click(object sender, EventArgs e)
        {
            IOInfoRS232 iOInfoRS232 = new IOInfoRS232();

            if (comboBox_SerialPort.SelectedItem == null)
            {
                iOInfoRS232.Portname = string.Empty;
            }
            else
            {
                iOInfoRS232.Portname = comboBox_SerialPort.SelectedItem?.ToString();
            }

            int.TryParse(textBox_BaudRate.Text, out iOInfoRS232.BaudRate);
            Enum.TryParse(comboBox_Parity.SelectedItem?.ToString(), out iOInfoRS232.Parity);
            int.TryParse(textBox_DataBits.Text, out iOInfoRS232.DataBit);
            Enum.TryParse(comboBox_StopBits.SelectedItem?.ToString(), out iOInfoRS232.StopBits);
            Enum.TryParse(comboBox_HandShake.SelectedItem?.ToString(), out iOInfoRS232.HandShake);

            ConfigRepository.Instance.Config.IOInfoRS232 = iOInfoRS232;

            ConfigRepository.Instance.Save();

            if (((RS232c)ServiceProvider.Instance.GetService("RS232")).IsConnected == true)
            {
                ((RS232c)ServiceProvider.Instance.GetService("RS232")).Close();
            }
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            button_ReloadSerialPort_Click(null, null);
            
            if (comboBox_SerialPort.Items.Contains(ConfigRepository.Instance.Config.IOInfoRS232.Portname))
            {
                comboBox_SerialPort.SelectedItem = ConfigRepository.Instance.Config.IOInfoRS232.Portname;
            }

            textBox_BaudRate.Text = ConfigRepository.Instance.Config.IOInfoRS232.BaudRate.ToString();

            if (comboBox_Parity.Items.Contains(ConfigRepository.Instance.Config.IOInfoRS232.Parity.ToString()))
            {
                comboBox_Parity.SelectedItem = ConfigRepository.Instance.Config.IOInfoRS232.Parity.ToString();
            }

            textBox_DataBits.Text = ConfigRepository.Instance.Config.IOInfoRS232.DataBit.ToString();

            if (comboBox_StopBits.Items.Contains(ConfigRepository.Instance.Config.IOInfoRS232.StopBits.ToString()))
            {
                comboBox_StopBits.SelectedItem = ConfigRepository.Instance.Config.IOInfoRS232.StopBits.ToString();
            }

            if (comboBox_HandShake.Items.Contains(ConfigRepository.Instance.Config.IOInfoRS232.HandShake.ToString()))
            {
                comboBox_HandShake.SelectedItem = ConfigRepository.Instance.Config.IOInfoRS232.HandShake.ToString();
            }
        }
    }
}
