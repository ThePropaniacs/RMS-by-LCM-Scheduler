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

        public TaskSetInfo tasksetinfo;

        public MainForm()
        {
            InitializeComponent();
        }

        private void cmdRandom_Click(object sender, EventArgs e)
        {
            int n;

            txtNumTasks.Text = null;
            txtTotalUtilization.Text = null;
            txtOverloaded.Text = null;
            txtGuaranteedLevel.Text = null;
            txtGuaranteed.Text = null;
            txtLCM.Text = null;
            txtFeasible.Text = null;

            n = random.Next(1, 50);

            txtNumTasks.Text = n.ToString();

            cmdGo.Enabled = true;
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            double numtasks;
            double.TryParse(txtNumTasks.Text, out numtasks);
            tasksetinfo = new TaskSetInfo(numtasks)
            {
                Count = 0
            };

            TasksInfoForm tasksinfoform = new TasksInfoForm(this);
            tasksinfoform.Show();

            while (tasksetinfo.Count < tasksetinfo.NumTasks)
            {
                tasksinfoform = new TasksInfoForm(this);
                tasksinfoform.Show();
            }

            cmdRandom.Enabled = false;
            cmdGo.Enabled = false;
            txtNumTasks.ReadOnly = true;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtNumTasks.Text = null;
            txtTotalUtilization.Text = null;
            txtOverloaded.Text = null;
            txtGuaranteedLevel.Text = null;
            txtGuaranteed.Text = null;
            txtLCM.Text = null;
            txtFeasible.Text = null;

            cmdRandom.Enabled = true;
            cmdGo.Enabled = false;
            cmdTest.Enabled = false;
            txtNumTasks.ReadOnly = false;
        }

        private void txtNumTasks_Validating(object sender, CancelEventArgs e)
        {
            string error_msg;
            Methods methods = new Methods();
            if (String.IsNullOrWhiteSpace(txtNumTasks.Text))
            {
                cmdGo.Enabled = false;
            }
            else if(!methods.ValidNumber(txtNumTasks.Text, out error_msg))
            {
                //Cancels event and selects incorrect text
                e.Cancel = true;
                txtNumTasks.Select(0, txtNumTasks.Text.Length);

                //Warns user of error
                MessageBox.Show(error_msg);

                cmdGo.Enabled = false;
            }
            else
            {
                cmdGo.Enabled = true;
            }
        }

        public void Enable_cmdTest()
        {
            cmdTest.Enabled = true;
        }

        private void cmdTest_Click(object sender, EventArgs e)
        {
            tasksetinfo.FindTotalUtilization();
            tasksetinfo.FindLCM();
            //Must change way Deadlines are calc. to prevent overflow
            //for (int i = 0; i < tasksetinfo.NumTasks; i++)
            //{
                //tasksetinfo.Tasks[i].FindDeadlines(tasksetinfo.PeriodLCM);
            //}

            txtTotalUtilization.Text = tasksetinfo.TotalUtilization.ToString();

            if (tasksetinfo.Overload == true)
            {
                txtOverloaded.Text = "Yes";
                txtFeasible.Text = "No, overloaded.";
            }
            else
            {
                txtOverloaded.Text = "No";
            }

            if (tasksetinfo.Guaranteed == true)
            {
                txtGuaranteed.Text = "Yes";
                txtFeasible.Text = "Yes, guaranteed by LCM.";
            }
            else
            {
                txtGuaranteed.Text = "No";
            }

            txtGuaranteedLevel.Text = tasksetinfo.GuaranteedLevel.ToString();

            txtLCM.Text = tasksetinfo.PeriodLCM.ToString();

            if (tasksetinfo.Overload == false && tasksetinfo.Guaranteed == false)
            {
                txtFeasible.Text = "Utilization > Guarnteed Level and not Overloaded, test up to LCM.";
            }

            tasksetinfo.FindPriority();

            cmdTest.Enabled = false;
        }
    }
}
