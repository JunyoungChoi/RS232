
namespace Communication_RS232.View
{
    partial class FormConfig
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
            this.groupBox_ConnectionSetting = new System.Windows.Forms.GroupBox();
            this.button_ReloadSerialPort = new System.Windows.Forms.Button();
            this.comboBox_SerialPort = new System.Windows.Forms.ComboBox();
            this.textBox_BaudRate = new System.Windows.Forms.TextBox();
            this.comboBox_HandShake = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_StopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_DataBits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Parity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_SaveConfig = new System.Windows.Forms.Button();
            this.groupBox_ConnectionSetting.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_ConnectionSetting
            // 
            this.groupBox_ConnectionSetting.Controls.Add(this.button_ReloadSerialPort);
            this.groupBox_ConnectionSetting.Controls.Add(this.comboBox_SerialPort);
            this.groupBox_ConnectionSetting.Controls.Add(this.textBox_BaudRate);
            this.groupBox_ConnectionSetting.Controls.Add(this.comboBox_HandShake);
            this.groupBox_ConnectionSetting.Controls.Add(this.label6);
            this.groupBox_ConnectionSetting.Controls.Add(this.comboBox_StopBits);
            this.groupBox_ConnectionSetting.Controls.Add(this.label5);
            this.groupBox_ConnectionSetting.Controls.Add(this.textBox_DataBits);
            this.groupBox_ConnectionSetting.Controls.Add(this.label4);
            this.groupBox_ConnectionSetting.Controls.Add(this.comboBox_Parity);
            this.groupBox_ConnectionSetting.Controls.Add(this.label3);
            this.groupBox_ConnectionSetting.Controls.Add(this.label2);
            this.groupBox_ConnectionSetting.Controls.Add(this.label1);
            this.groupBox_ConnectionSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_ConnectionSetting.Location = new System.Drawing.Point(0, 0);
            this.groupBox_ConnectionSetting.Name = "groupBox_ConnectionSetting";
            this.groupBox_ConnectionSetting.Size = new System.Drawing.Size(420, 209);
            this.groupBox_ConnectionSetting.TabIndex = 0;
            this.groupBox_ConnectionSetting.TabStop = false;
            this.groupBox_ConnectionSetting.Text = "Connection";
            // 
            // button_ReloadSerialPort
            // 
            this.button_ReloadSerialPort.Location = new System.Drawing.Point(243, 27);
            this.button_ReloadSerialPort.Name = "button_ReloadSerialPort";
            this.button_ReloadSerialPort.Size = new System.Drawing.Size(130, 23);
            this.button_ReloadSerialPort.TabIndex = 14;
            this.button_ReloadSerialPort.Text = "Reload";
            this.button_ReloadSerialPort.UseVisualStyleBackColor = true;
            this.button_ReloadSerialPort.Click += new System.EventHandler(this.button_ReloadSerialPort_Click);
            // 
            // comboBox_SerialPort
            // 
            this.comboBox_SerialPort.FormattingEnabled = true;
            this.comboBox_SerialPort.Location = new System.Drawing.Point(98, 27);
            this.comboBox_SerialPort.Name = "comboBox_SerialPort";
            this.comboBox_SerialPort.Size = new System.Drawing.Size(121, 20);
            this.comboBox_SerialPort.TabIndex = 13;
            // 
            // textBox_BaudRate
            // 
            this.textBox_BaudRate.Location = new System.Drawing.Point(98, 57);
            this.textBox_BaudRate.Name = "textBox_BaudRate";
            this.textBox_BaudRate.Size = new System.Drawing.Size(100, 21);
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
            // textBox_DataBits
            // 
            this.textBox_DataBits.Location = new System.Drawing.Point(98, 117);
            this.textBox_DataBits.Name = "textBox_DataBits";
            this.textBox_DataBits.Size = new System.Drawing.Size(100, 21);
            this.textBox_DataBits.TabIndex = 7;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port Name";
            // 
            // button_Close
            // 
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Close.Location = new System.Drawing.Point(345, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 36);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_SaveConfig);
            this.panel1.Controls.Add(this.button_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 36);
            this.panel1.TabIndex = 2;
            // 
            // button_SaveConfig
            // 
            this.button_SaveConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_SaveConfig.Location = new System.Drawing.Point(270, 0);
            this.button_SaveConfig.Name = "button_SaveConfig";
            this.button_SaveConfig.Size = new System.Drawing.Size(75, 36);
            this.button_SaveConfig.TabIndex = 2;
            this.button_SaveConfig.Text = "Save";
            this.button_SaveConfig.UseVisualStyleBackColor = true;
            this.button_SaveConfig.Click += new System.EventHandler(this.button_SaveConfig_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(420, 245);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_ConnectionSetting);
            this.Name = "FormConfig";
            this.Text = "FormConfig";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.groupBox_ConnectionSetting.ResumeLayout(false);
            this.groupBox_ConnectionSetting.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ConnectionSetting;
        private System.Windows.Forms.TextBox textBox_BaudRate;
        private System.Windows.Forms.ComboBox comboBox_HandShake;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_StopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_DataBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Parity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ReloadSerialPort;
        private System.Windows.Forms.ComboBox comboBox_SerialPort;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_SaveConfig;
    }
}