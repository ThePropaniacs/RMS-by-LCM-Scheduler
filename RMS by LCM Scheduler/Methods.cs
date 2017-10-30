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

        public bool RMS (Task[] tasks, TaskSetInfo tasksetinfo)
        {
            bool feasible = false;
            //Uses RMS to return true if feasible, false if not
            for(int i = 0; i <= tasksetinfo.PeriodLCM; i++)
            {

            }
            if (feasible == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
