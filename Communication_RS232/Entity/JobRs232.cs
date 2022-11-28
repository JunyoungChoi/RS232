namespace Communication_RS232.Entity
{
    class JobRs232 : Job
    {
        public string Message = string.Empty;
        public bool CheckReceive = false;
        public string CheckReceiveMessage = string.Empty;
        public int ReceiveTimeOut = 0;

        public JobRs232(string id) : base(id)
        {

        }

        public JobRs232() : base()
        {

        }

    }
}
