
namespace Communication_RS232.View
{
    partial class FormTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_SendMessage = new System.Windows.Forms.TextBox();
            this.button_SendMessage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_MessageLog = new System.Windows.Forms.TextBox();
            this.groupBox_ConnectionSetting = new System.Windows.Forms.GroupBox();
            this.textBox_BaudRate = new System.Windows.Forms.TextBox();
            this.comboBox_HandShake = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_StopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Databits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Parity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PortName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_ConnectionSetting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_SendMessage
            // 
            this.textBox_SendMessage.Location = new System.Drawing.Point(6, 82);
            this.textBox_SendMessage.Name = "textBox_SendMessage";
            this.textBox_SendMessage.Size = new System.Drawing.Size(213, 21);
            this.textBox_SendMessage.TabIndex = 7;
            // 
            // button_SendMessage
            // 
            this.button_SendMessage.Location = new System.Drawing.Point(6, 109);
            this.button_SendMessage.Name = "button_SendMessage";
            this.button_SendMessage.Size = new System.Drawing.Size(75, 23);
            this.button_SendMessage.TabIndex = 8;
            this.button_SendMessage.Text = "Send";
            this.button_SendMessage.UseVisualStyleBackColor = true;
            this.button_SendMessage.Click += new System.EventHandler(this.button_SendMessage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Disconnect);
            this.groupBox1.Controls.Add(this.textBox_SendMessage);
            this.groupBox1.Controls.Add(this.button_Connect);
            this.groupBox1.Controls.Add(this.button_SendMessage);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 141);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Message";
            // 
            // textBox_MessageLog
            // 
            this.textBox_MessageLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_MessageLog.Location = new System.Drawing.Point(243, 3);
            this.textBox_MessageLog.Multiline = true;
            this.textBox_MessageLog.Name = "textBox_MessageLog";
            this.tableLayoutPanel1.SetRowSpan(this.textBox_MessageLog, 2);
            this.textBox_MessageLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_MessageLog.Size = new System.Drawing.Size(420, 361);
            this.textBox_MessageLog.TabIndex = 10;
            // 
            // groupBox_ConnectionSetting
            // 
            this.groupBox_ConnectionSetting.Controls.Add(this.textBox_BaudRate);
            this.groupBox_ConnectionSetting.Controls.Add(this.comboBox_HandShake);
            this.groupBox_ConnectionSetting.Controls.Add(this.label6);
            this.groupBox_ConnectionSetting.Controls.Add(this.comboBox_StopBits);
            this.groupBox_ConnectionSetting.Controls.Add(this.label5);
            this.groupBox_ConnectionSetting.Controls.Add(this.textBox_Databits);
            this.groupBox_ConnectionSetting.Controls.Add(this.label4);
            this.groupBox_ConnectionSetting.Controls.Add(this.comboBox_Parity);
            this.groupBox_ConnectionSetting.Controls.Add(this.label3);
            this.groupBox_ConnectionSetting.Controls.Add(this.label2);
            this.groupBox_ConnectionSetting.Controls.Add(this.textBox_PortName);
            this.groupBox_ConnectionSetting.Controls.Add(this.label1);
            this.groupBox_ConnectionSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_ConnectionSetting.Location = new System.Drawing.Point(3, 3);
            this.groupBox_ConnectionSetting.Name = "groupBox_ConnectionSetting";
            this.groupBox_ConnectionSetting.Size = new System.Drawing.Size(234, 214);
            this.groupBox_ConnectionSetting.TabIndex = 11;
            this.groupBox_ConnectionSetting.TabStop = false;
            this.groupBox_ConnectionSetting.Text = "Connection";
            // 
            // textBox_BaudRate
            // 
            this.textBox_BaudRate.Location = new System.Drawing.Point(98, 57);
            this.textBox_BaudRate.Name = "textBox_BaudRate";
            this.textBox_BaudRate.Size = new System.Drawing.Size(121, 21);
            this.textBox_BaudRate.TabIndex = 12;
            // 
            // comboBox_HandShake
            // 
            this.comboBox_HandShake.FormattingEnabled = true;
            this.comboBox_HandShake.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RequestToSend",
            "RequestToSendXOnXOff"});
            this.comboBox_HandShake.Location = new System.Drawing.Point(98, 177);
            this.comboBox_HandShake.Name = "comboBox_HandShake";
            this.comboBox_HandShake.Size = new System.Drawing.Size(121, 20);
            this.comboBox_HandShake.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "HandShake";
            // 
            // comboBox_StopBits
            // 
            this.comboBox_StopBits.FormattingEnabled = true;
            this.comboBox_StopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.comboBox_StopBits.Location = new System.Drawing.Point(98, 147);
            this.comboBox_StopBits.Name = "comboBox_StopBits";
            this.comboBox_StopBits.Size = new System.Drawing.Size(121, 20);
            this.comboBox_StopBits.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "StopBits";
            // 
            // textBox_Databits
            // 
            this.textBox_Databits.Location = new System.Drawing.Point(98, 117);
            this.textBox_Databits.Name = "textBox_Databits";
            this.textBox_Databits.Size = new System.Drawing.Size(121, 21);
            this.textBox_Databits.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data bits";
            // 
            // comboBox_Parity
            // 
            this.comboBox_Parity.FormattingEnabled = true;
            this.comboBox_Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBox_Parity.Location = new System.Drawing.Point(98, 87);
            this.comboBox_Parity.Name = "comboBox_Parity";
            this.comboBox_Parity.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Parity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // textBox_PortName
            // 
            this.textBox_PortName.Location = new System.Drawing.Point(98, 27);
            this.textBox_PortName.Name = "textBox_PortName";
            this.textBox_PortName.Size = new System.Drawing.Size(121, 21);
            this.textBox_PortName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_ConnectionSetting, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_MessageLog, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 367);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(6, 20);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(102, 23);
            this.button_Connect.TabIndex = 9;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(117, 20);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(102, 23);
            this.button_Disconnect.TabIndex = 13;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(666, 367);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTest_FormClosing);
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_ConnectionSetting.ResumeLayout(false);
            this.groupBox_ConnectionSetting.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SendMessage;
        private System.Windows.Forms.Button button_SendMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_MessageLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_ConnectionSetting;
        private System.Windows.Forms.TextBox textBox_BaudRate;
        private System.Windows.Forms.ComboBox comboBox_HandShake;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_StopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Databits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Parity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_PortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Button button_Connect;
    }
}