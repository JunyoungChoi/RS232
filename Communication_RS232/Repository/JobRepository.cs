using Communication_RS232.Constants;
using Communication_RS232.Entity;
using ISSOFT.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Communication_RS232.Repository
{
    class JobRepository
    {
        private static JobRepository _instance = null;
        public static JobRepository Instance
        {
            get
            {
                lock (typeof(JobRepository))
                {
                    if (_instance == null)
                    {
                        _instance = new JobRepository();
                    }
                    return _instance;
                }
            }
        }

        private Ini iniConfig;

        private JobRepository()
        {
            string Dir = Path.Combine(ServiceConstants.ConfigMainLocation, "RS232");

            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }

            iniConfig = new Ini(Path.Combine(Dir, "Job.ini"));

            load();
        }

        public event EventHandler OnUpdateJobs;

        public List<JobRs232> jobs = new List<JobRs232>();

        public List<JobRs232> GetJobs()
        {
            return jobs;
        }

        public void ModifyJob(JobRs232 job)
        {
            for (int i = 0; i < jobs.Count; i++)
            {
                if (jobs[i].Id.Equals(job.Id))
                {
                    jobs[i].Name = job.Name;
                    jobs[i].Message = job.Message;
                    jobs[i].CheckReceive = job.CheckReceive;
                    jobs[i].CheckReceiveMessage = job.CheckReceiveMessage;
                    jobs[i].ReceiveTimeOut = job.ReceiveTimeOut;
                }
            }
        }

        public JobRs232 GetById(string id)
        {
            return (JobRs232)GetJobs().FirstOrDefault(job => job.Id.Equals(id));
        }
        public void RemoveById(string id)
        {
            jobs = GetJobs().Where(job => !job.Id.Equals(id)).ToList();

            OnUpdateJobsEvent();
        }

        public bool IsEmpty()
        {
            return jobs.Count == 0;
        }

        public bool Add(JobRs232 job)
        {
            jobs.Add(job);

            OnUpdateJobsEvent();

            return true;
        }

        public bool Save()
        {
            if (IsEmpty()) return false;

            foreach (var item in GetJobs().Select((value, index) => (value, index)))
            {
                JobRs232 job = item.value;
                int index = item.index;

                string sectionName = string.Format("Job/{0}", index);
                iniConfig.IniWriteValue(sectionName, "Id", job.Id);
                iniConfig.IniWriteValue(sectionName, "Name", job.Name);
                iniConfig.IniWriteValue(sectionName, "Message", job.Message);
                iniConfig.IniWriteValue(sectionName, "CheckReceive", job.CheckReceive.ToString());
                iniConfig.IniWriteValue(sectionName, "CheckReceiveMessage", job.CheckReceiveMessage);
                iniConfig.IniWriteValue(sectionName, "ReceiveTimeOut", job.ReceiveTimeOut.ToString());
            }

            return true;
        }

        private bool load()
        {
            string[] sectionNames = iniConfig.GetSectionNames();

            foreach (string sectionName in sectionNames)
            {
                if (sectionName.StartsWith("Job/"))
                {
                    string id = iniConfig.IniReadValue(sectionName, "Id");
                    string name = iniConfig.IniReadValue(sectionName, "Name");
                    string message = iniConfig.IniReadValue(sectionName, "Message");

                    bool checkReceive;
                    bool.TryParse(iniConfig.IniReadValue(sectionName, "CheckReceive"), out checkReceive);

                    string checkMessage = string.Empty;
                    int receiveTimeOut = 0;

                    if (checkReceive == true)
                    {
                        checkMessage = iniConfig.IniReadValue(sectionName, "CheckReceiveMessage");
                        int.TryParse(iniConfig.IniReadValue(sectionName, "ReceiveTimeOut"), out receiveTimeOut);
                    }


                    JobRs232 job = new JobRs232(id);
                    job.Name = name;
                    job.Message = message;
                    job.CheckReceive = checkReceive;
                    job.CheckReceiveMessage = checkMessage;
                    job.ReceiveTimeOut = receiveTimeOut;

                    Add(job);
                }
            }

            return true;
        }

        private void OnUpdateJobsEvent()
        {
            OnUpdateJobs?.Invoke(this, EventArgs.Empty);
        }
    }
}
