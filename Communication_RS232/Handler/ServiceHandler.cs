using Communication_RS232.Entity;
using Communication_RS232.Provider;
using Communication_RS232.Repository;
using Communication_RS232.Service;
using System.Linq;

namespace Communication_RS232.Handler
{
    public class ServiceHandler
    {
        public event JobDoneHandler OnJobDone;

        public string JobListAsJSON(string sData)
        {
            JobRepository jobRepository = JobRepository.Instance;

            JobRs232 job = jobRepository.GetJobs().First();

            return job.GetAsString();
        }

        /// <summary>
        /// 동기 작업
        /// </summary>
        /// <param name="jobAsJSON"></param>
        /// <returns></returns>
        public string Run(string jobAsJSON)
        {
            Job tempJob = Job.SetFromString(jobAsJSON);

            JobRs232 job = JobRepository.Instance.GetById(tempJob.Id);

            RS232c rs232 = ((RS232c)ServiceProvider.Instance.GetService("RS232"));

            string result = rs232.RunJob(job);

            OnOnJobDoneEvent(job.Id, job.Name, result);

            return result;
        }

        protected virtual void OnOnJobDoneEvent(string id, string name, string result)
        {
            OnJobDone?.Invoke(new JobDoneEventArgs(id, name, result));
        }

        protected virtual void OnOnJobDoneEvent(JobDoneEventArgs jobDoneEventArgs)
        {
            OnJobDone?.Invoke(jobDoneEventArgs);
        }
    }
}
