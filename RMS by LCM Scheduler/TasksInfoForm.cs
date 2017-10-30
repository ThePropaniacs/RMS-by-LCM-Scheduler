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
        private int numTasks;

        static Random random = new Random();

        public TasksInfoForm()
        {
            InitializeComponent();
        }

        public TasksInfoForm(int n)
        {
            this.numTasks = n;
            InitializeComponent();
        }

        private void TasksInfoForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            txtTaskPeriod.Text = Convert.ToString(random.Next(1, 100));
            txtTaskExecution.Text = Convert.ToString(random.Next(1, 100));
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int nPeriod, nExecution;
            if (!String.IsNullOrWhiteSpace(txtTaskPeriod.Text) && !String.IsNullOrWhiteSpace(txtTaskExecution.Text) &&
                int.TryParse(txtTaskPeriod.Text, out nPeriod) && int.TryParse(txtTaskExecution.Text, out nExecution)) ;
            else
            {
                MessageBox.Show("Please enter valid integers for the period and execution!");
            }
        }
    }
}
