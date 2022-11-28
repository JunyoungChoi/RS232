using Communication_RS232.Provider;
using Communication_RS232.Repository;
using Communication_RS232.Service;
using Communication_RS232.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Communication_RS232
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((FormConfig)ServiceProvider.Instance.GetForm("FormConfig")).ShowDialog();

        }
        private void toolStripMenuItem_FormTest_Click(object sender, EventArgs e)
        {
            ((FormTest)ServiceProvider.Instance.GetForm("FormTest")).ShowDialog();
        }

        private void jobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((FormJob)ServiceProvider.Instance.GetForm("FormJob")).ShowDialog();

        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OpenDevice(ConfigRepository.Instance.Config.IOInfoRS232);
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text += string.Format(" v{0}", this.ProductVersion);

            Communication_RS232.Handler.LogHandler.WriteLog(string.Format("Program Started. Version={0}", this.ProductVersion));

            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnClose += RS232c_OnClose;
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnConnect += RS232c_OnConnect;
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnError += RS232c_OnError;
        }

        private void RS232c_OnError(string message)
        {
            if (this.Visible == true)
            {
                System.Windows.Forms.MessageBox.Show(message);
            }
        }

        private void RS232c_OnConnect(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    button_Status.BackColor = Color.LimeGreen;
                    button_Status.FlatAppearance.BorderColor = Color.LimeGreen;
                    button_Status.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
                    button_Status.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
                    button_Status.FlatAppearance.CheckedBackColor = Color.LimeGreen;
                    button_Status.Text = "Status : Connected";
                });
            }
            else
            {
                button_Status.BackColor = Color.LimeGreen;
                button_Status.FlatAppearance.BorderColor = Color.LimeGreen;
                button_Status.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
                button_Status.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
                button_Status.FlatAppearance.CheckedBackColor = Color.LimeGreen;
                button_Status.Text = "Status : Connected";
            }

        }

        private void RS232c_OnClose(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    button_Status.BackColor = SystemColors.Control;
                    button_Status.FlatAppearance.BorderColor = SystemColors.Control;
                    button_Status.FlatAppearance.MouseOverBackColor = SystemColors.Control;
                    button_Status.FlatAppearance.MouseDownBackColor = SystemColors.Control;
                    button_Status.FlatAppearance.CheckedBackColor = SystemColors.Control;
                    button_Status.Text = "Status : Disconnected";
                });
            }
            else
            {
                button_Status.BackColor = SystemColors.Control;
                button_Status.FlatAppearance.BorderColor = SystemColors.Control;
                button_Status.FlatAppearance.MouseOverBackColor = SystemColors.Control;
                button_Status.FlatAppearance.MouseDownBackColor = SystemColors.Control;
                button_Status.FlatAppearance.CheckedBackColor = SystemColors.Control;
                button_Status.Text = "Status : Disconnected";
            }
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (((RS232c)ServiceProvider.Instance.GetService("RS232")).IsConnected)
            {
                RS232c_OnConnect(null, null);
            }
            else
            {
                RS232c_OnClose(null, null);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Communication_RS232.Handler.LogHandler.WriteLog(string.Format("Program Ended. Version={0}", this.ProductVersion));

            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnClose -= RS232c_OnClose;
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnConnect -= RS232c_OnConnect;
            ((RS232c)ServiceProvider.Instance.GetService("RS232")).OnError -= RS232c_OnError;

        }
    }
}
