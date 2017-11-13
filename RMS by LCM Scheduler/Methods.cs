using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_by_LCM_Scheduler
{
    class Methods
    {
        public bool ValidNumber(string number, out string error_msg)
        {
            //Determines if string is double, null, empty, or whitespace
            //if so returns true and no error
            //if false returns false and error message
            double num;
            bool isnum;
            if (!string.IsNullOrWhiteSpace(number))
            {
                isnum = double.TryParse(number, out num);
                if (!isnum)
                {
                    error_msg = "Please enter a numeric value";
                    return false;
                }
                else
                {
                    error_msg = null;
                    return true;
                }
            }
            else
            {
                error_msg = null;
                return true;
            }
        }

        public long LCM(double[] numbers)
        {
            //LCM for array of n numbers by table method
            long lcm = 1;
            int divisor = 2;
            while (true)
            {
                int count = 0;
                bool divisible = false;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 0)
                    {
                        return 0;
                    }
                    else if (numbers[i] < 0)
                    {
                        numbers[i] = numbers[i] * (-1);
                    }
                    if (numbers[i] == 1)
                    {
                        count++;
                    }

                    if (numbers[i] % divisor == 0)
                    {
                        divisible = true;
                        numbers[i] = numbers[i] / divisor;
                    }
                }

                if (divisible)
                {
                    lcm = lcm * divisor;
                }
                else
                {
                    divisor++;
                }

                if (count == numbers.Length)
                {
                    return lcm;
                }
            }
        }

        public bool IsMultiple (double a, double b)
        {
            //Returns true if a is a multiple of b
            if ( a == 0)
            {
                return false;
            }
            else
            {
                return (a % b) == 0;

            }
        }

        public bool RMS (TaskSetInfo tasksetinfo)
        {
            Executing[] executing = new Executing[Convert.ToInt64(tasksetinfo.NumTasks)];
            for (int i = 0; i < tasksetinfo.NumTasks; i++)
            {
                //Create Executing for each task to count execution times to track completion of task
                executing[i] = new Executing(tasksetinfo.Tasks[i].Number, tasksetinfo.Tasks[i].Execution);
            }

            //Begin iterating throughout the Timeline
            for (int i = 0; i < tasksetinfo.Timeline.Length; i++)
            {
                //Check each task in order of priority for deadline and completion status to determine action
                for (int n = 0; n < tasksetinfo.NumTasks; n++)
                {
                    //If it is the task's deadline then check completion status
                    if (tasksetinfo.Tasks[n].Deadlines[i] == true)
                    {
                        //If task has not been completed, then mark as missed, not feasible, and return false
                        if (tasksetinfo.Tasks[n].Completed == false)
                        {
                            tasksetinfo.Timeline.Intervals[i].Missed = true;
                            tasksetinfo.Timeline.Intervals[i].TaskNumber = tasksetinfo.Tasks[n].Number;
                            tasksetinfo.Feasible = false;
                            return false;
                        }
                        //If task has been completed, then task is requested again
                        else if (tasksetinfo.Tasks[n].Completed == true)
                        {
                            //Reset task's completion status and Execute for the interval if interval not occupied, 
                            //mark the interval as occupied and executing for that task
                            if (tasksetinfo.Timeline.Intervals[i].Occupied == false)
                            {
                                tasksetinfo.Tasks[n].Completed = false;
                                executing[n].Count++;
                                tasksetinfo.Timeline.Intervals[i].TaskNumber = tasksetinfo.Tasks[n].Number;
                                //If this execution completes the task then mark interval as completion and task as completed
                                //and reset the execution for the task
                                if (executing[n].Count == executing[n].Execution)
                                {
                                    tasksetinfo.Timeline.Intervals[i].Completed = true;
                                    tasksetinfo.Tasks[n].Completed = true;
                                    executing[n].Count = 0;
                                }
                                tasksetinfo.Timeline.Intervals[i].Occupied = true;
                            }
                            //If interval occupied then cannot execute
                            else
                            {
                                //No action
                            }
                        }
                    }
                    //If it is not the task's deadline then check completion status
                    else
                    {
                        //If task has not been completed, then will attempt to execute
                        if (tasksetinfo.Tasks[n].Completed == false)
                        {
                            //If interval is not occupied then Execute for the interval and
                            //mark the interval as occupied and executing for that task
                            if (tasksetinfo.Timeline.Intervals[i].Occupied == false)
                            {
                                executing[n].Count++;
                                tasksetinfo.Timeline.Intervals[i].TaskNumber = tasksetinfo.Tasks[n].Number;
                                //If this execution completes the task then mark interval as completion and task as completed 
                                //and reset the execution count for the task
                                if (executing[n].Count == executing[n].Execution)
                                {
                                    tasksetinfo.Timeline.Intervals[i].Completed = true;
                                    tasksetinfo.Tasks[n].Completed = true;
                                    executing[n].Count = 0;
                                }
                                tasksetinfo.Timeline.Intervals[i].Occupied = true;
                            }
                            //If interval occupied then cannot execute
                            else
                            {
                                //No action
                            }
                        }
                        //If the task has been completed then no action is required for the task
                        else if (tasksetinfo.Tasks[n].Completed == true)
                        {
                            //No action required
                        }
                    }
                }
            }

            //If no task missed its deadline then mark as feasible and return true
            tasksetinfo.Feasible = true;
            return true;
        }

        public bool EDF(TaskSetInfo tasksetinfo)
        {
            Executing[] executing = new Executing[Convert.ToInt64(tasksetinfo.NumTasks)];
            for (int i = 0; i < tasksetinfo.NumTasks; i++)
            {
                //Create Executing for each task to count execution times to track completion of task
                executing[i] = new Executing(tasksetinfo.Tasks[i].Number, tasksetinfo.Tasks[i].Execution);
            }

            //Begin iterating throughout the Timeline
            for (int i = 0; i < tasksetinfo.Timeline.Length; i++)
            {
                //Check each task in order of priority for deadline and completion status to determine action
                for (int n = 0; n < tasksetinfo.NumTasks; n++)
                {
                    //If it is the task's deadline then check completion status
                    if (tasksetinfo.Tasks[n].Deadlines[i] == true)
                    {
                        //If task has not been completed, then mark as missed, not feasible, and return false
                        if (tasksetinfo.Tasks[n].Completed == false)
                        {
                            tasksetinfo.Timeline.Intervals[i].Missed = true;
                            tasksetinfo.Timeline.Intervals[i].TaskNumber = tasksetinfo.Tasks[n].Number;
                            tasksetinfo.Feasible = false;
                            return false;
                        }
                        //If task has been completed, then task is requested again
                        else if (tasksetinfo.Tasks[n].Completed == true)
                        {
                            //Reset task's completion status and Execute for the interval if interval not occupied, 
                            //mark the interval as occupied and executing for that task
                            if (tasksetinfo.Timeline.Intervals[i].Occupied == false)
                            {
                                tasksetinfo.Tasks[n].Completed = false;
                                executing[n].Count++;
                                tasksetinfo.Timeline.Intervals[i].TaskNumber = tasksetinfo.Tasks[n].Number;
                                //If this execution completes the task then mark interval as completion and task as completed
                                //and reset the execution for the task
                                if (executing[n].Count == executing[n].Execution)
                                {
                                    tasksetinfo.Timeline.Intervals[i].Completed = true;
                                    tasksetinfo.Tasks[n].Completed = true;
                                    executing[n].Count = 0;
                                }
                                tasksetinfo.Timeline.Intervals[i].Occupied = true;
                            }
                            //If interval occupied then cannot execute
                            else
                            {
                                //No action
                            }
                        }
                    }
                    //If it is not the task's deadline then check completion status
                    else
                    {
                        //If task has not been completed, then will attempt to execute
                        if (tasksetinfo.Tasks[n].Completed == false)
                        {
                            //If interval is not occupied then Execute for the interval and
                            //mark the interval as occupied and executing for that task
                            if (tasksetinfo.Timeline.Intervals[i].Occupied == false)
                            {
                                executing[n].Count++;
                                tasksetinfo.Timeline.Intervals[i].TaskNumber = tasksetinfo.Tasks[n].Number;
                                //If this execution completes the task then mark interval as completion and task as completed 
                                //and reset the execution count for the task
                                if (executing[n].Count == executing[n].Execution)
                                {
                                    tasksetinfo.Timeline.Intervals[i].Completed = true;
                                    tasksetinfo.Tasks[n].Completed = true;
                                    executing[n].Count = 0;
                                }
                                tasksetinfo.Timeline.Intervals[i].Occupied = true;
                            }
                            //If interval occupied then cannot execute
                            else
                            {
                                //No action
                            }
                        }
                        //If the task has been completed then no action is required for the task
                        else if (tasksetinfo.Tasks[n].Completed == true)
                        {
                            //No action required
                        }
                    }
                }
                //Re-calculate priority from next interval based on deadlines
                tasksetinfo.FindPriorityEDF(i + 1);
            }

            //If no task missed its deadline then mark as feasible and return true
            tasksetinfo.Feasible = true;
            return true;
        }
    }
}
