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
    public partial class TasksForm : Form
    {
        public TasksForm()
        {
            InitializeComponent();
        }

        static Random random = new Random();

        private void btnRandom_Click(object sender, EventArgs e)
        {
            txtNumTasks.Text = Convert.ToString(random.Next(1, 15));
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int n;
            if (!String.IsNullOrWhiteSpace(txtNumTasks.Text) &&
                int.TryParse(txtNumTasks.Text, out n))
            {
                TasksInfoForm tasksInfoForm = new TasksInfoForm(n);
                tasksInfoForm.Show();
                btnGo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the number of tasks!");
            }
        }

        private void TasksForm_Load(object sender, EventArgs e)
        {

        }
    }
}
