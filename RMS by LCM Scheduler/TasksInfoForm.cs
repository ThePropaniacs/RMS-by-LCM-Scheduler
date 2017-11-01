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
    public partial class TasksInfoForm : Form
    {
        private int count;

        private MainForm main;

        static Random random = new Random();

        public TasksInfoForm(MainForm m)
        {
            this.main = m;
            InitializeComponent();
            main.tasksetinfo.Count++;
            count = main.tasksetinfo.Count;
        }

        private void TasksInfoForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Task " + count.ToString();
        }

        private void cmdRandom_Click(object sender, EventArgs e)
        {
            int period, execution;
            double utilization;
            txtUtilization.Text = null;

            period = random.Next(1, 25);
            execution = random.Next(1, period);

            txtPeriod.Text = period.ToString();
            txtExecution.Text = execution.ToString();

            utilization = Math.Round((Convert.ToDouble(execution) / Convert.ToDouble(period)), 2);

            txtUtilization.Text = utilization.ToString();
            cmdGo.Enabled = true;
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            double period, execution;

            double.TryParse(txtPeriod.Text, out period);
            double.TryParse(txtExecution.Text, out execution);

            main.tasksetinfo.Tasks[(count - 1)].SetTaskInfo(count, period, execution);

            main.tasksetinfo.Count--;
            if (main.tasksetinfo.Count == 0)
            {
                main.Enable_cmdTest();
            }

            this.Close();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtPeriod.Text = null;
            txtExecution.Text = null;
            txtUtilization.Text = null;

            cmdRandom.Enabled = true;
            cmdGo.Enabled = false;
        }

        private void txtPeriod_Validating(object sender, CancelEventArgs e)
        {
            string error_msg;
            double utilization, period, execution;
            Methods methods = new Methods();
            if (String.IsNullOrWhiteSpace(txtPeriod.Text) || String.IsNullOrWhiteSpace(txtExecution.Text))
            {
                cmdGo.Enabled = false;
            }
            else if (!methods.ValidNumber(txtPeriod.Text, out error_msg))
            {
                //Cancels event and selects incorrect text
                e.Cancel = true;
                txtPeriod.Select(0, txtPeriod.Text.Length);

                //Warns user of error
                MessageBox.Show(error_msg);

                cmdGo.Enabled = false;
            }
            else
            {
                double.TryParse(txtPeriod.Text, out period);
                double.TryParse(txtExecution.Text, out execution);
                if (execution > period)
                {
                    e.Cancel = true;
                    txtPeriod.Select(0, txtPeriod.Text.Length);

                    MessageBox.Show("Period cannot be less than Execution");

                    cmdGo.Enabled = false;
                }
                else
                {
                    utilization = Math.Round((execution / period), 2);
                    txtUtilization.Text = utilization.ToString();
                    cmdGo.Enabled = true;
                }
            }
        }

        private void txtExecution_Validating(object sender, CancelEventArgs e)
        {
            string error_msg;
            double utilization, period, execution;
            Methods methods = new Methods();
            if (String.IsNullOrWhiteSpace(txtPeriod.Text) || String.IsNullOrWhiteSpace(txtExecution.Text))
            {
                cmdGo.Enabled = false;
            }
            else if (!methods.ValidNumber(txtExecution.Text, out error_msg))
            {
                //Cancels event and selects incorrect text
                e.Cancel = true;
                txtExecution.Select(0, txtExecution.Text.Length);

                //Warns user of error
                MessageBox.Show(error_msg);

                cmdGo.Enabled = false;
            }
            else
            {
                double.TryParse(txtPeriod.Text, out period);
                double.TryParse(txtExecution.Text, out execution);
                if (execution > period)
                {
                    e.Cancel = true;
                    txtExecution.Select(0, txtExecution.Text.Length);

                    MessageBox.Show("Execution cannot be greater than Period");

                    cmdGo.Enabled = false;
                }
                else
                {
                    utilization = Math.Round((execution / period), 2);
                    txtUtilization.Text = utilization.ToString();
                    cmdGo.Enabled = true;
                }
            }
        }
    }
}
