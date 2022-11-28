using Communication_RS232.Entity;
using Communication_RS232.Repository;
using ISSOFT;
using System;
using System.Data;
using System.Windows.Forms;

namespace Communication_RS232.View
{
    public partial class FormJob : Form
    {
        DataTable dt = new DataTable();

        public FormJob()
        {
            InitializeComponent();

            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("NAME", typeof(string));
            dt.Columns.Add("MESSAGE", typeof(string));
            dt.Columns.Add("CHECK ACK", typeof(bool));
            dt.Columns.Add("ACK MESSAGE", typeof(string));
            dt.Columns.Add("ACK TIMEOUT", typeof(int));
        }

        private void FormJob_Load(object sender, EventArgs e)
        {
            ExtensionMethods.DoubleBuffered(dataGridView_JobList, true);

            dataGridView_JobList.DataSource = dt;

            JobRepository.Instance.OnUpdateJobs += UpdateJobs;

            UpdateJobs(null, null);
        }

        private void UpdateJobs(object sender, EventArgs e)
        {
            if (dataGridView_JobList.InvokeRequired)
            {
                dataGridView_JobList.Invoke((MethodInvoker)delegate
                {
                    dataGridView_JobList.SuspendLayout();

                    dt.Clear();

                    foreach (JobRs232 job in JobRepository.Instance.GetJobs())
                    {
                        DataRow dr = dt.NewRow();

                        dr["ID"] = job.Id;
                        dr["NAME"] = job.Name;
                        dr["MESSAGE"] = job.Message;
                        dr["CHECK ACK"] = job.CheckReceive;
                        dr["ACK MESSAGE"] = job.CheckReceiveMessage;
                        dr["ACK TIMEOUT"] = job.ReceiveTimeOut;
                        dt.Rows.Add(dr);
                    }

                    dataGridView_JobList.ResumeLayout();
                });
            }
            else
            {
                dataGridView_JobList.SuspendLayout();

                dt.Clear();

                foreach (JobRs232 job in JobRepository.Instance.GetJobs())
                {
                    DataRow dr = dt.NewRow();

                    dr["ID"] = job.Id;
                    dr["NAME"] = job.Name;
                    dr["MESSAGE"] = job.Message;
                    dr["CHECK ACK"] = job.CheckReceive;
                    dr["ACK MESSAGE"] = job.CheckReceiveMessage;
                    dr["ACK TIMEOUT"] = job.ReceiveTimeOut;
                    dt.Rows.Add(dr);
                }

                dataGridView_JobList.ResumeLayout();
            }
        }

        private void FormJob_FormClosing(object sender, FormClosingEventArgs e)
        {
            JobRepository.Instance.OnUpdateJobs -= UpdateJobs;
        }

        private void dataGridView_JobList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            string id = dt.Rows[e.RowIndex]["ID"].ToString();

            JobRs232 job = JobRepository.Instance.GetById(id);

            textBox_Id.Text = job.Id;
            textBox_JobName.Text = job.Name;
            textBox_SendMessage.Text = job.Message;
            checkBox_CheckAck.Checked = job.CheckReceive;
            textBox_AckMessage.Text = job.CheckReceiveMessage;
            textBox_AckReceiveTimeout.Text = job.ReceiveTimeOut.ToString();
        }

        private void button_NewJob_Click(object sender, EventArgs e)
        {
            initInput();
        }

        private void initInput()
        {
            textBox_Id.Text = string.Empty;
            textBox_JobName.Text = string.Empty;
            textBox_SendMessage.Text = string.Empty;
        }

        private bool isModyfyMode()
        {
            return textBox_Id.Text.Equals("") ? false : true;
        }

        private void button_RemoveJob_Click(object sender, EventArgs e)
        {
            if (isModyfyMode())
            {
                JobRepository.Instance.RemoveById(textBox_Id.Text);
            }
        }

        private JobRs232 makeJobFromInput()
        {
            JobRs232 jobRs232 = new JobRs232();

            jobRs232.Message = textBox_SendMessage.Text;
            jobRs232.Name = textBox_JobName.Text;
            jobRs232.CheckReceive = checkBox_CheckAck.Checked;
            if (jobRs232.CheckReceive)
            {
                jobRs232.CheckReceiveMessage = textBox_AckMessage.Text;
                int.TryParse(textBox_AckReceiveTimeout.Text, out jobRs232.ReceiveTimeOut);
            }

            return jobRs232;
        }

        private void button_AddJob_Click(object sender, EventArgs e)
        {
            if (!isModyfyMode())
            {
                JobRs232 job = makeJobFromInput();

                JobRepository.Instance.Add(job);

                textBox_Id.Text = job.Id;
            }
        }

        private void button_ModifyJob_Click(object sender, EventArgs e)
        {
            if (isModyfyMode())
            {
                JobRepository.Instance.ModifyJob(makeJobFromInput());

                UpdateJobs(null, null);
            }
        }

        private void checkBox_CheckAck_CheckedChanged(object sender, EventArgs e)
        {
            textBox_AckMessage.Enabled = checkBox_CheckAck.Checked;
            textBox_AckReceiveTimeout.Enabled = checkBox_CheckAck.Checked;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            JobRepository.Instance.Save();
        }

        private void button_RunJob_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Id.Text))
            {
                MessageBox.Show("Select job.");

                return;
            }

            string result = ((Service.RS232c)Provider.ServiceProvider.Instance.GetService("RS232")).RunJob(JobRepository.Instance.GetById(textBox_Id.Text));

            listBox_Result.Items.Add(string.Format("{0} Run.", textBox_Id.Text));
            listBox_Result.Items.Add(string.Format("Result : {0}", result));
        }
    }
}
