using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_152
{
    class Job
    {
        private string CodeJob;
        private int TimeJob;

        public Job()
        {
            this.CodeJob = null;
            this.TimeJob = 0;
        }

        public Job(string cj, int tj)
        {
            this.CodeJob = cj;
            this.TimeJob = tj;
        }

        public int Get_Time_Job()
        {
            return this.TimeJob;
        }

        public string Get_Code_Job()
        {
            return this.CodeJob;
        }

        public void Set_Time_Job(int t)
        {
            this.TimeJob = t;
        }

        public void Set_Code_Job(string c)
        {
            this.CodeJob = c;
        }

        public override string ToString()
        {
            return "Code Job: " + this.CodeJob + "\nTime Job: " + this.TimeJob;
        }


    }
}
