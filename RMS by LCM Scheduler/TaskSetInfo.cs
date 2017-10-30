using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_by_LCM_Scheduler
{
    public class TaskSetInfo
    {
        public double NumTasks { get; set; }

        public double TotalUtilization { get; set; }

        public double GuaranteedLevel { get; set; }

        public double PeriodLCM { get; set; }

        public bool Overload { get; set; }

        public bool Guaranteed { get; set; }

        public bool Feasible { get; set; }

        public TaskSetInfo(double numtasks, double totalutilization)
        {
            this.NumTasks = numtasks;
            this.TotalUtilization = totalutilization;
            this.GuaranteedLevel = Math.Round((numtasks * (Math.Pow(2d, (1d / numtasks)) - 1d)), 2);

            if (this.TotalUtilization > 1)
            {
                this.Overload = true;
                this.Feasible = false;
            }
            else
            {
                this.Overload = false;
            }

            if (this.TotalUtilization > this.GuaranteedLevel)
            {
                this.Guaranteed = false;
            }
            else
            {
                this.Guaranteed = true;
                this.Feasible = true;
            }
        }

        public void FindLCM(double[] numbers)
        {
            Methods methods = new Methods();
            this.PeriodLCM = methods.LCM(numbers);
        }
    }
}
