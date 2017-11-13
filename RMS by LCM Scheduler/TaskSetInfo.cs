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

        public Task[] Tasks { get; set; }

        public int Count { get; set; }

        public Timeline Timeline { get; set; }

        public TaskSetInfo(double numtasks)
        {
            this.NumTasks = numtasks;
            this.Tasks = new Task[Convert.ToInt32(numtasks)];
            for (int i = 0; i < numtasks; i++)
            {
                this.Tasks[i] = new Task
                {
                    Number = i + 1
                };
            }
            this.GuaranteedLevel = Math.Round((numtasks * (Math.Pow(2d, (1d / numtasks)) - 1d)), 2);
        }

        public void FindTotalUtilization()
        {
            this.TotalUtilization = 0;
            //Find TotalUtilization for all Tasks[]
            for (int i = 0; i < this.NumTasks; i++)
            {
                this.TotalUtilization = this.TotalUtilization + this.Tasks[i].Utilization;
            }
            //Determine Overload, Feasibility, Guaranteed from TotalUtilization
            if (this.TotalUtilization > 1)
            {
                this.Overload = true;
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
            }

            if (this.Overload == true)
            {
                this.Feasible = false;
            }
            else if (this.Guaranteed == true)
            {
                this.Feasible = true;
            }
            else if (this.Overload == false && this.Guaranteed == false)
            {
                //Temporary, must test to LCM at this point to determine feasibility
                this.Feasible = true;
            }
        }

        public void FindLCM()
        {
            double[] numbers = new double[Convert.ToInt32(this.NumTasks)];
            //Creates array numbers[] of all Periods for Tasks in TaskSetInfo
            for (int i = 0; i < this.NumTasks; i++)
            {
                numbers[i] = this.Tasks[i].Period;
            }
            //Calculates the LCM from numbers[]
            Methods methods = new Methods();
            this.PeriodLCM = methods.LCM(numbers);
            //Finds Deadlines for Tasks using TaskSetInfo LCM
            for (int i = 0; i < this.NumTasks; i++)
            {
                this.Tasks[i].FindDeadlines(this.PeriodLCM);
            }
        }

        public void FindPriorityLCM()
        {
            Comparison<Task> comparison = (x, y) => x.Period.CompareTo(y.Period);
            Array.Sort(this.Tasks, delegate (Task x, Task y) { return x.Period.CompareTo(y.Period); });
        }

        public void FindPriorityEDF(int current)
        {
            foreach (var task in this.Tasks)
            {
                task.FindNextDeadline(current, this.Timeline.Length);
            }
            Comparison<Task> comparison = (x, y) => x.NextDeadline.CompareTo(y.NextDeadline);
            Array.Sort(this.Tasks, delegate (Task x, Task y) { return x.NextDeadline.CompareTo(y.NextDeadline); });
        }

        public void BuildTimeline()
        {
            Timeline = new Timeline(PeriodLCM + 1);
        }
    }
}
