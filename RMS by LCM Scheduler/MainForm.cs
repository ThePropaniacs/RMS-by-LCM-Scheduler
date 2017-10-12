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
        public MainForm()
        {
            InitializeComponent();
        }

        private void txtGo_Click(object sender, EventArgs e)
        {
            TasksForm tasksForm = new TasksForm();
            tasksForm.Show();
            txtGo.Enabled = false;
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
