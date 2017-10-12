namespace RMS_by_LCM_Scheduler
{
    partial class TasksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtNumTasks = new System.Windows.Forms.TextBox();
            this.lblNumTasks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(334, 65);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(100, 46);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "RANDOM";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(334, 117);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(100, 46);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtNumTasks
            // 
            this.txtNumTasks.Location = new System.Drawing.Point(16, 75);
            this.txtNumTasks.Name = "txtNumTasks";
            this.txtNumTasks.Size = new System.Drawing.Size(254, 26);
            this.txtNumTasks.TabIndex = 2;
            // 
            // lblNumTasks
            // 
            this.lblNumTasks.AutoSize = true;
            this.lblNumTasks.Location = new System.Drawing.Point(12, 42);
            this.lblNumTasks.Name = "lblNumTasks";
            this.lblNumTasks.Size = new System.Drawing.Size(129, 20);
            this.lblNumTasks.TabIndex = 3;
            this.lblNumTasks.Text = "Number of Tasks";
            // 
            // TasksForm
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 244);
            this.Controls.Add(this.lblNumTasks);
            this.Controls.Add(this.txtNumTasks);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnRandom);
            this.Name = "TasksForm";
            this.Text = "RMS by LCM Scheduling Tasks";
            this.Load += new System.EventHandler(this.TasksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtNumTasks;
        private System.Windows.Forms.Label lblNumTasks;
    }
}

