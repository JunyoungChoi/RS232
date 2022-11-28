using System;

namespace Communication_RS232.Entity
{
    public class JobDoneEventArgs : EventArgs
    {
        public string Id { get; private set; }
        public string Result { get; private set; }
        public string Name { get; private set; }

        public JobDoneEventArgs(string id, string name, string result)
        {
            this.Id = id;
            this.Name = name;
            this.Result = result;
        }
    }
}
