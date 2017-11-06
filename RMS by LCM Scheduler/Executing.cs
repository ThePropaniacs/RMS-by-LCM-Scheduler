using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_by_LCM_Scheduler
{
    public class Executing
    {
        public double TaskNumber { get; set; }

        public double Execution { get; set; }

        public double Count { get; set; }

        public Executing(double n, double e)
        {
            TaskNumber = n;
            Execution = e;
            Count = 0;
        }
    }
}
