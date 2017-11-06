using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_by_LCM_Scheduler
{
    public class Timeline
    {
        public Interval[] Intervals { get; set; }

        public double Length { get; set; }

        public Timeline()
        {

        }

        public Timeline(double n)
        {
            Length = n;
            this.Intervals = new Interval[Convert.ToInt64(Length)];
            for (int i = 0; i < Length; i++)
            {
                this.Intervals[i] = new Interval(i);
            }
        }
    }
}
