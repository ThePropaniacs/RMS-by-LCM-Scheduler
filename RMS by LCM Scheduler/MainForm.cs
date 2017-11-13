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

            //TasksInfoForm tasksinfoform = new TasksInfoForm(this);
            //tasksinfoform.Show();

            foreach(var task in tasksetinfo.Tasks)
            {
                TasksInfoForm tasksinfoform = new TasksInfoForm(task);
                if (tasksinfoform.ShowDialog() == DialogResult.OK)
                {
                    
                };
            }

            cmdTestRMS.Enabled = true;
            cmdTestEDF.Enabled = true;

            //while (tasksetinfo.Count < tasksetinfo.NumTasks)
            //{
            //    TasksInfoForm tasksinfoform = new TasksInfoForm(this);
            //    if (tasksinfoform.ShowDialog() == DialogResult.OK) {

            //    };
            //}

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
            cmdTestRMS.Enabled = false;
            cmdTestEDF.Enabled = false;
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
            cmdTestRMS.Enabled = true;
        }

        private void cmdTestRMS_Click(object sender, EventArgs e)
        {
            Methods methods = new Methods();
            tasksetinfo.FindTotalUtilization();
            tasksetinfo.FindLCM();

            txtTotalUtilization.Text = tasksetinfo.TotalUtilization.ToString();

            if (tasksetinfo.Overload == true)
            {
                txtOverloaded.Text = "Yes";
                txtFeasible.Text = "Not feasible by RMS, overloaded.";
            }
            else
            {
                txtOverloaded.Text = "No";
            }

            if (tasksetinfo.Guaranteed == true)
            {
                txtGuaranteed.Text = "Yes";
                txtFeasible.Text = "Feasible by RMS, guaranteed by LCM.";
            }
            else
            {
                txtGuaranteed.Text = "No";
            }

            txtGuaranteedLevel.Text = tasksetinfo.GuaranteedLevel.ToString();

            txtLCM.Text = tasksetinfo.PeriodLCM.ToString();

            if (tasksetinfo.Overload == false && tasksetinfo.Guaranteed == false)
            {
                tasksetinfo.FindPriorityLCM();
                tasksetinfo.BuildTimeline();
                if (methods.RMS(tasksetinfo) == false)
                {
                    for (int i = 0; i < tasksetinfo.Timeline.Length; i ++)
                    {
                        if (tasksetinfo.Timeline.Intervals[i].Missed == true)
                        {
                            txtFeasible.Text = "Not feasible by RMS, Task " + tasksetinfo.Timeline.Intervals[i].TaskNumber +
                                " missed its deadline at Time " + tasksetinfo.Timeline.Intervals[i].Time + ".";
                            break;
                        }
                    }
                }
                else
                {
                    txtFeasible.Text = "Feasible by RMS, verified by testing up to LCM of Periods of Tasks";
                }
            }

            cmdTestRMS.Enabled = false;
            cmdTestEDF.Enabled = true;
        }

        private void cmdTestEDF_Click(object sender, EventArgs e)
        {
            Methods methods = new Methods();
            tasksetinfo.FindTotalUtilization();
            tasksetinfo.FindLCM();

            txtTotalUtilization.Text = tasksetinfo.TotalUtilization.ToString();

            if (tasksetinfo.Overload == true)
            {
                txtOverloaded.Text = "Yes";
                txtFeasible.Text = "Not feasible by EDF, overloaded.";
            }
            else
            {
                txtOverloaded.Text = "No";
                txtFeasible.Text = "Feasible by EDF, not overloaded.";
            }

            if (tasksetinfo.Guaranteed == true)
            {
                txtGuaranteed.Text = "Yes";
            }
            else
            {
                txtGuaranteed.Text = "No";
            }

            txtGuaranteedLevel.Text = tasksetinfo.GuaranteedLevel.ToString();

            txtLCM.Text = tasksetinfo.PeriodLCM.ToString();

            if (tasksetinfo.Overload == true)
            {
                //Find initial priority
                tasksetinfo.FindPriorityLCM();
                tasksetinfo.BuildTimeline();
                if (methods.EDF(tasksetinfo) == false)
                {
                    for (int i = 0; i < tasksetinfo.Timeline.Length; i++)
                    {
                        if (tasksetinfo.Timeline.Intervals[i].Missed == true)
                        {
                            txtFeasible.Text = "Not feasible by EDF, Task " + tasksetinfo.Timeline.Intervals[i].TaskNumber +
                                " missed its deadline at Time " + tasksetinfo.Timeline.Intervals[i].Time + ".";
                            break;
                        }
                    }
                }
                else
                {
                    txtFeasible.Text = "Feasible by EDF, verified by testing up to LCM of Periods of Tasks";
                }
            }

            cmdTestEDF.Enabled = false;
            cmdTestRMS.Enabled = true;
        }
    }
}
