using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_by_LCM_Scheduler
{
    public partial class MainForm : Form
    {
        static Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void cmdRandom_Click(object sender, EventArgs e)
        {
            int i, n;
            double period, execution;

            txtTask1Period.Text = null;
            txtTask1Execution.Text = null;
            txtTask1Utilization.Text = null;
            txtTask2Period.Text = null;
            txtTask2Execution.Text = null;
            txtTask2Utilization.Text = null;
            txtTask3Period.Text = null;
            txtTask3Execution.Text = null;
            txtTask3Utilization.Text = null;
            txtTask4Period.Text = null;
            txtTask4Execution.Text = null;
            txtTask4Utilization.Text = null;
            txtTask5Period.Text = null;
            txtTask5Execution.Text = null;
            txtTask5Utilization.Text = null;
            txtTotalUtilization.Text = null;
            txtOverloaded.Text = null;
            txtGuaranteedLevel.Text = null;
            txtGuaranteed.Text = null;
            txtLCM.Text = null;
            txtFeasible.Text = null;

            n = random.Next(1, 6);

            for (i = 0; i < n; i++)
            {
                period = random.Next(1, 100);
                execution = random.Next(1, 100);

                if (i == 0)
                {
                    txtTask1Period.Text = period.ToString();
                    txtTask1Execution.Text = execution.ToString();
                }
                else if (i == 1)
                {
                    txtTask2Period.Text = period.ToString();
                    txtTask2Execution.Text = execution.ToString();
                }
                else if (i == 2)
                {
                    txtTask3Period.Text = period.ToString();
                    txtTask3Execution.Text = execution.ToString();
                }
                else if (i == 3)
                {
                    txtTask4Period.Text = period.ToString();
                    txtTask4Execution.Text = execution.ToString();
                }
                else if (i == 4)
                {
                    txtTask5Period.Text = period.ToString();
                    txtTask5Execution.Text = execution.ToString();
                }
            }
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            int i, n = 0;
            double period, execution, total_utilization = 0;

            if (!String.IsNullOrWhiteSpace(txtTask1Period.Text))
            {
                n++;
            }
            if (!String.IsNullOrWhiteSpace(txtTask2Period.Text))
            {
                n++;
            }
            if (!String.IsNullOrWhiteSpace(txtTask3Period.Text))
            {
                n++;
            }
            if (!String.IsNullOrWhiteSpace(txtTask4Period.Text))
            {
                n++;
            }
            if (!String.IsNullOrWhiteSpace(txtTask5Period.Text))
            {
                n++;
            }

            double[] numbers = new double[n];
            Task[] tasks = new Task[n];

            for (i = 0; i < n; i++)
            {
                switch (i)
                {
                    case 0:
                        double.TryParse(txtTask1Period.Text, out period);
                        double.TryParse(txtTask1Execution.Text, out execution);

                        numbers[i] = period;
                        tasks[i] = new Task(i, period, execution);

                        txtTask1Utilization.Text = tasks[i].Utilization.ToString();
                        break;

                    case 1:
                        double.TryParse(txtTask2Period.Text, out period);
                        double.TryParse(txtTask2Execution.Text, out execution);

                        numbers[i] = period;
                        tasks[i] = new Task(i, period, execution);

                        txtTask2Utilization.Text = tasks[i].Utilization.ToString();
                        break;

                    case 2:
                        double.TryParse(txtTask3Period.Text, out period);
                        double.TryParse(txtTask3Execution.Text, out execution);

                        numbers[i] = period;
                        tasks[i] = new Task(i, period, execution);

                        txtTask3Utilization.Text = tasks[i].Utilization.ToString();
                        break;
                    case 3:
                        double.TryParse(txtTask4Period.Text, out period);
                        double.TryParse(txtTask4Execution.Text, out execution);

                        numbers[i] = period;
                        tasks[i] = new Task(i, period, execution);

                        txtTask4Utilization.Text = tasks[i].Utilization.ToString();

                        break;

                    case 4:
                        double.TryParse(txtTask5Period.Text, out period);
                        double.TryParse(txtTask5Execution.Text, out execution);

                        numbers[i] = period;
                        tasks[i] = new Task(i, period, execution);

                        txtTask5Utilization.Text = tasks[i].Utilization.ToString();

                        break;

                    default:
                        break;
                }

                total_utilization += tasks[i].Utilization;
            }

            TaskSetInfo tasksetinfo = new TaskSetInfo(n, total_utilization);
            tasksetinfo.FindLCM(numbers);

            for (i = 0; i < n; i++)
            {
                tasks[i].FindDeadlines(tasksetinfo.PeriodLCM);
            }

            txtTotalUtilization.Text = tasksetinfo.TotalUtilization.ToString();
            txtOverloaded.Text = tasksetinfo.Overload.ToString();
            txtGuaranteedLevel.Text = tasksetinfo.GuaranteedLevel.ToString();
            txtGuaranteed.Text = tasksetinfo.Guaranteed.ToString();
            txtLCM.Text = tasksetinfo.PeriodLCM.ToString();

            if (tasksetinfo.Overload == true && tasksetinfo.Feasible == false)
            {
                txtFeasible.Text = "No, overloaded";
            }
            else if (tasksetinfo.Guaranteed == true && tasksetinfo.Feasible == true)
            {
                txtFeasible.Text = "Yes, guaranteed by RMS";
            }
            else if (tasksetinfo.Guaranteed == false)
            {
                txtFeasible.Text = "Unclear, test up to LCM of periods";
            }

            cmdRandom.Enabled = false;
            cmdGo.Enabled = false;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtTask1Period.Text = null;
            txtTask1Execution.Text = null;
            txtTask1Utilization.Text = null;
            txtTask2Period.Text = null;
            txtTask2Execution.Text = null;
            txtTask2Utilization.Text = null;
            txtTask3Period.Text = null;
            txtTask3Execution.Text = null;
            txtTask3Utilization.Text = null;
            txtTask4Period.Text = null;
            txtTask4Execution.Text = null;
            txtTask4Utilization.Text = null;
            txtTask5Period.Text = null;
            txtTask5Execution.Text = null;
            txtTask5Utilization.Text = null;
            txtTotalUtilization.Text = null;
            txtOverloaded.Text = null;
            txtGuaranteedLevel.Text = null;
            txtGuaranteed.Text = null;
            txtLCM.Text = null;
            txtFeasible.Text = null;

            cmdRandom.Enabled = true;
            cmdGo.Enabled = true;
        }

        private void txtTask1Period_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtTask1Period.Text))
            {
                txtTask1Execution.Enabled = true;
            }
            else
            {
                txtTask1Execution.Enabled = false;
            }
        }

        private void txtTask2Period_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtTask2Period.Text))
            {
                txtTask2Execution.Enabled = true;
            }
            else
            {
                txtTask2Execution.Enabled = false;
            }
        }

        private void txtTask3Period_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtTask3Period.Text))
            {
                txtTask3Execution.Enabled = true;
            }
            else
            {
                txtTask3Execution.Enabled = false;
            }
        }

        private void txtTask4Period_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtTask4Period.Text))
            {
                txtTask4Execution.Enabled = true;
            }
            else
            {
                txtTask4Execution.Enabled = false;
            }
        }

        private void txtTask5Period_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtTask5Period.Text))
            {
                txtTask5Execution.Enabled = true;
            }
            else
            {
                txtTask5Execution.Enabled = false;
            }
        }

        private void txtTask1Period_Validating(object sender, CancelEventArgs e)
        {
            string error_msg;
            Methods methods = new Methods();
            if(!methods.ValidNumber(txtTask1Period.Text, out error_msg))
            {
                //Cancels event and selects incorrect text
                e.Cancel = true;
                txtTask1Period.Select(0, txtTask1Period.Text.Length);

                //Warns user of error
                MessageBox.Show(error_msg);
            }
        }

        private void txtTask2Period_Validating(object sender, CancelEventArgs e)
        {
            string error_msg;
            Methods methods = new Methods();
            if (!methods.ValidNumber(txtTask2Period.Text, out error_msg))
            {
                //Cancels event and selects incorrect text
                e.Cancel = true;
                txtTask2Period.Select(0, txtTask2Period.Text.Length);

                //Warns user of error
                MessageBox.Show(error_msg);
            }
        }

        private void txtTask3Period_Validating(object sender, CancelEventArgs e)
        {
            string error_msg;
            Methods methods = new Methods();
            if (!methods.ValidNumber(txtTask3Period.Text, out error_msg))
            {
                //Cancels event and selects incorrect text
                e.Cancel = true;
                txtTask3Period.Select(0, txtTask3Period.Text.Length);

                //Warns user of error
                MessageBox.Show(error_msg);
            }
        }

        private void txtTask4Period_Validating(object sender, CancelEventArgs e)
        {
            string error_msg;
            Methods methods = new Methods();
            if (!methods.ValidNumber(txtTask4Period.Text, out error_msg))
            {
                //Cancels event and selects incorrect text
                e.Cancel = true;
                txtTask4Period.Select(0, txtTask4Period.Text.Length);

                //Warns user of error
                MessageBox.Show(error_msg);
            }
        }

        private void txtTask5Period_Validating(object sender, CancelEventArgs e)
        {
            string error_msg;
            Methods methods = new Methods();
            if (!methods.ValidNumber(txtTask5Period.Text, out error_msg))
            {
                //Cancels event and selects incorrect text
                e.Cancel = true;
                txtTask5Period.Select(0, txtTask5Period.Text.Length);

                //Warns user of error
                MessageBox.Show(error_msg);
            }
        }

        private void txtTask1Execution_Validating(object sender, CancelEventArgs e)
        {
            string error_msg;
            Methods methods = new Methods();
            if (!methods.ValidNumber(txtTask1Execution.Text, out error_msg))
            {
                //Cancels event and selects incorrect text
                e.Cancel = true;
                txtTask1Execution.Select(0, txtTask1Execution.Text.Length);

                //Warns user of error
                MessageBox.Show(error_msg);
            }
        }

        private void txtTask2Execution_Validating(object sender, CancelEventArgs e)
        {
            string error_msg;
            Methods methods = new Methods();
            if (!methods.ValidNumber(txtTask2Execution.Text, out error_msg))
            {
                //Cancels event and selects incorrect text
                e.Cancel = true;
                txtTask2Execution.Select(0, txtTask2Execution.Text.Length);

                //Warns user of error
                MessageBox.Show(error_msg);
            }
        }

        private void txtTask3Execution_Validating(object sender, CancelEventArgs e)
        {
            string error_msg;
            Methods methods = new Methods();
            if (!methods.ValidNumber(txtTask3Execution.Text, out error_msg))
            {
                //Cancels event and selects incorrect text
                e.Cancel = true;
                txtTask3Execution.Select(0, txtTask3Execution.Text.Length);

                //Warns user of error
                MessageBox.Show(error_msg);
            }
        }

        private void txtTask4Execution_Validating(object sender, CancelEventArgs e)
        {
            string error_msg;
            Methods methods = new Methods();
            if (!methods.ValidNumber(txtTask4Execution.Text, out error_msg))
            {
                //Cancels event and selects incorrect text
                e.Cancel = true;
                txtTask4Execution.Select(0, txtTask4Execution.Text.Length);

                //Warns user of error
                MessageBox.Show(error_msg);
            }
        }

        private void txtTask5Execution_Validating(object sender, CancelEventArgs e)
        {
            string error_msg;
            Methods methods = new Methods();
            if (!methods.ValidNumber(txtTask5Execution.Text, out error_msg))
            {
                //Cancels event and selects incorrect text
                e.Cancel = true;
                txtTask5Execution.Select(0, txtTask5Execution.Text.Length);

                //Warns user of error
                MessageBox.Show(error_msg);
            }
        }
    }
}
