
namespace Communication_RS232.View
{
    partial class FormJob
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
            this.button_RunJob = new System.Windows.Forms.Button();
            this.listBox_Result = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_JobList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_JobName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_SendMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_NewJob = new System.Windows.Forms.Button();
            this.button_RemoveJob = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button_ModifyJob = new System.Windows.Forms.Button();
            this.button_AddJob = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_CheckAck = new System.Windows.Forms.GroupBox();
            this.checkBox_CheckAck = new System.Windows.Forms.CheckBox();
            this.textBox_AckMessage = new System.Windows.Forms.TextBox();
            this.textBox_AckReceiveTimeout = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_JobList)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_CheckAck.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_RunJob
            // 
            this.button_RunJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_RunJob.Location = new System.Drawing.Point(988, 400);
            this.button_RunJob.Name = "button_RunJob";
            this.button_RunJob.Size = new System.Drawing.Size(163, 47);
            this.button_RunJob.TabIndex = 11;
            this.button_RunJob.Text = "RUN";
            this.button_RunJob.UseVisualStyleBackColor = true;
            this.button_RunJob.Click += new System.EventHandler(this.button_RunJob_Click);
            // 
            // listBox1
            // 
            this.listBox_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Result.FormattingEnabled = true;
            this.listBox_Result.ItemHeight = 12;
            this.listBox_Result.Location = new System.Drawing.Point(988, 3);
            this.listBox_Result.Name = "listBox1";
            this.listBox_Result.Size = new System.Drawing.Size(163, 391);
            this.listBox_Result.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.12035F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.87965F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.Controls.Add(this.button_RunJob, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_JobList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox_Result, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1154, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView_JobList
            // 
            this.dataGridView_JobList.AllowUserToAddRows = false;
            this.dataGridView_JobList.AllowUserToDeleteRows = false;
            this.dataGridView_JobList.AllowUserToResizeRows = false;
            this.dataGridView_JobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_JobList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_JobList.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_JobList.MultiSelect = false;
            this.dataGridView_JobList.Name = "dataGridView_JobList";
            this.dataGridView_JobList.ReadOnly = true;
            this.dataGridView_JobList.RowHeadersVisible = false;
            this.dataGridView_JobList.RowTemplate.Height = 23;
            this.dataGridView_JobList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_JobList.Size = new System.Drawing.Size(340, 391);
            this.dataGridView_JobList.TabIndex = 2;
            this.dataGridView_JobList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_JobList_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(349, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.53846F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.46154F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(633, 391);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_JobName);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBox_Id);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(627, 47);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "작업속성";
            // 
            // textBox_JobName
            // 
            this.textBox_JobName.Location = new System.Drawing.Point(363, 14);
            this.textBox_JobName.Name = "textBox_JobName";
            this.textBox_JobName.Size = new System.Drawing.Size(248, 21);
            this.textBox_JobName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name :";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(36, 14);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(248, 21);
            this.textBox_Id.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Id :";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.textBox_SendMessage, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(627, 140);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // textBox_SendMessage
            // 
            this.textBox_SendMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SendMessage.Location = new System.Drawing.Point(100, 3);
            this.textBox_SendMessage.Name = "textBox_SendMessage";
            this.textBox_SendMessage.Size = new System.Drawing.Size(524, 21);
            this.textBox_SendMessage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Send Message";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_NewJob, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_RemoveJob, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 400);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(340, 47);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // button_NewJob
            // 
            this.button_NewJob.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_NewJob.Location = new System.Drawing.Point(270, 3);
            this.button_NewJob.Name = "button_NewJob";
            this.button_NewJob.Size = new System.Drawing.Size(67, 41);
            this.button_NewJob.TabIndex = 4;
            this.button_NewJob.Text = "NEW";
            this.button_NewJob.UseVisualStyleBackColor = true;
            this.button_NewJob.Click += new System.EventHandler(this.button_NewJob_Click);
            // 
            // button_RemoveJob
            // 
            this.button_RemoveJob.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_RemoveJob.Enabled = false;
            this.button_RemoveJob.Location = new System.Drawing.Point(3, 3);
            this.button_RemoveJob.Name = "button_RemoveJob";
            this.button_RemoveJob.Size = new System.Drawing.Size(67, 41);
            this.button_RemoveJob.TabIndex = 3;
            this.button_RemoveJob.Text = "REMOVE";
            this.button_RemoveJob.UseVisualStyleBackColor = true;
            this.button_RemoveJob.Click += new System.EventHandler(this.button_RemoveJob_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_Save, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(349, 400);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(633, 47);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.button_ModifyJob, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.button_AddJob, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(221, 47);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // button_ModifyJob
            // 
            this.button_ModifyJob.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ModifyJob.Enabled = false;
            this.button_ModifyJob.Location = new System.Drawing.Point(147, 3);
            this.button_ModifyJob.Name = "button_ModifyJob";
            this.button_ModifyJob.Size = new System.Drawing.Size(71, 41);
            this.button_ModifyJob.TabIndex = 8;
            this.button_ModifyJob.Text = "MODIFY";
            this.button_ModifyJob.UseVisualStyleBackColor = true;
            this.button_ModifyJob.Click += new System.EventHandler(this.button_ModifyJob_Click);
            // 
            // button_AddJob
            // 
            this.button_AddJob.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_AddJob.Location = new System.Drawing.Point(3, 3);
            this.button_AddJob.Name = "button_AddJob";
            this.button_AddJob.Size = new System.Drawing.Size(68, 41);
            this.button_AddJob.TabIndex = 3;
            this.button_AddJob.Text = "ADD";
            this.button_AddJob.UseVisualStyleBackColor = true;
            this.button_AddJob.Click += new System.EventHandler(this.button_AddJob_Click);
            // 
            // button_Save
            // 
            this.button_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Save.Location = new System.Drawing.Point(445, 3);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(185, 41);
            this.button_Save.TabIndex = 9;
            this.button_Save.Text = "SAVE";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_CheckAck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 201);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 190);
            this.panel1.TabIndex = 8;
            // 
            // groupBox_CheckAck
            // 
            this.groupBox_CheckAck.Controls.Add(this.tableLayoutPanel7);
            this.groupBox_CheckAck.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_CheckAck.Location = new System.Drawing.Point(0, 0);
            this.groupBox_CheckAck.Name = "groupBox_CheckAck";
            this.groupBox_CheckAck.Size = new System.Drawing.Size(321, 190);
            this.groupBox_CheckAck.TabIndex = 10;
            this.groupBox_CheckAck.TabStop = false;
            this.groupBox_CheckAck.Text = "Check Ack";
            // 
            // checkBox_CheckAck
            // 
            this.checkBox_CheckAck.AutoSize = true;
            this.tableLayoutPanel7.SetColumnSpan(this.checkBox_CheckAck, 2);
            this.checkBox_CheckAck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_CheckAck.Location = new System.Drawing.Point(3, 3);
            this.checkBox_CheckAck.Name = "checkBox_CheckAck";
            this.checkBox_CheckAck.Size = new System.Drawing.Size(309, 16);
            this.checkBox_CheckAck.TabIndex = 11;
            this.checkBox_CheckAck.Text = "Check Receive";
            this.checkBox_CheckAck.UseVisualStyleBackColor = true;
            this.checkBox_CheckAck.CheckedChanged += new System.EventHandler(this.checkBox_CheckAck_CheckedChanged);
            // 
            // textBox_AckMessage
            // 
            this.textBox_AckMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_AckMessage.Enabled = false;
            this.textBox_AckMessage.Location = new System.Drawing.Point(143, 25);
            this.textBox_AckMessage.Name = "textBox_AckMessage";
            this.textBox_AckMessage.Size = new System.Drawing.Size(169, 21);
            this.textBox_AckMessage.TabIndex = 12;
            // 
            // textBox_AckReceiveTimeout
            // 
            this.textBox_AckReceiveTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_AckReceiveTimeout.Enabled = false;
            this.textBox_AckReceiveTimeout.Location = new System.Drawing.Point(143, 52);
            this.textBox_AckReceiveTimeout.Name = "textBox_AckReceiveTimeout";
            this.textBox_AckReceiveTimeout.Size = new System.Drawing.Size(169, 21);
            this.textBox_AckReceiveTimeout.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Receive TimeOut (ms)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.checkBox_CheckAck, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBox_AckMessage, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.textBox_AckReceiveTimeout, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(315, 170);
            this.tableLayoutPanel7.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ack Message";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1154, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormJob";
            this.Text = "FormJob";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJob_FormClosing);
            this.Load += new System.EventHandler(this.FormJob_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_JobList)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox_CheckAck.ResumeLayout(false);
            this.groupBox_CheckAck.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_RunJob;
        private System.Windows.Forms.ListBox listBox_Result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_JobList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox_JobName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_NewJob;
        private System.Windows.Forms.Button button_RemoveJob;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button button_ModifyJob;
        private System.Windows.Forms.Button button_AddJob;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_SendMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_CheckAck;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.CheckBox checkBox_CheckAck;
        private System.Windows.Forms.TextBox textBox_AckMessage;
        private System.Windows.Forms.TextBox textBox_AckReceiveTimeout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}