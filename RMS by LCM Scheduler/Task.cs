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

        public double[] Deadlines { get; set; }

        public Task(double number, double period, double execution)
        {
            this.Number = number;
            this.Period = period;
            this.Execution = execution;
            this.Utilization = Math.Round((execution / period), 2);
            this.Completed = false;
        }

        public void FindDeadlines (double LCM)
        {
            this.Deadlines = new double[Convert.ToInt32(LCM) + 1];
            Methods methods = new Methods();
            for (int i = 0; i <= LCM; i++)
            {
                if (methods.IsMultiple(i, this.Period))
                {
                    this.Deadlines[i] = 1;
                }
                else
                {
                    this.Deadlines[i] = 0;
                }
            }
        }
    }
}
