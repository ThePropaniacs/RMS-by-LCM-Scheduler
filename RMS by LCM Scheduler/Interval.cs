using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_by_LCM_Scheduler
{
    class Interval
    {
        public int Time { get; set; }

        public double Completed { get; set; }

        public double Missed { get; set; }

        public double TaskNumber { get; set; }

        public Interval(int n)
        {
            Time = n;
        }
    }
}
