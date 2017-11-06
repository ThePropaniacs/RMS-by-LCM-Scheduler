using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_by_LCM_Scheduler
{
    public class Task
    {
        public double Number { get; set; }

        public double Period { get; set; }

        public double Execution { get; set; }

        public double Utilization { get; set; }

        public bool Completed { get; set; }

        public bool[] Deadlines { get; set; }

        public Task()
        {

        }

        public void SetTaskInfo(double number, double period, double execution)
        {
            this.Number = number;
            this.Period = period;
            this.Execution = execution;
            this.Utilization = Math.Round((execution / period), 2);
        }

        public void FindDeadlines (double LCM)
        {
            this.Deadlines = new bool[Convert.ToInt64(LCM)];
            Methods methods = new Methods();
            for (int i = 0; i < LCM; i++)
            {
                if (methods.IsMultiple(i + 1, this.Period))
                {
                    this.Deadlines[i] = true;
                }
                else
                {
                    this.Deadlines[i] = false;
                }
            }
        }
    }
}
