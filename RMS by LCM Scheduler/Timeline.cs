using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_by_LCM_Scheduler
{
    class Timeline
    {
        public Interval[] Intervals { get; set; }

        public int Length { get; set; }

        public Timeline(int n)
        {
            Length = n;
            this.Intervals = new Interval[Length];
            for (int i = 0; i < Length; i++)
            {
                this.Intervals[i] = new Interval(i);
            }
        }
    }
}
