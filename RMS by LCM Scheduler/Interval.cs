using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_by_LCM_Scheduler
{
    public class Interval
    {
        public double Time { get; set; }

        public bool Completed { get; set; }

        public bool Missed { get; set; }

        public double TaskNumber { get; set; }

        public bool Occupied { get; set; }

        public Interval(double n)
        {
            Time = n + 1;
        }
    }
}
