namespace RMS_by_LCM_Scheduler
{
    partial class TasksInfoForm
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
            this.txtTaskPeriod = new System.Windows.Forms.TextBox();
            this.txtTaskExecution = new System.Windows.Forms.TextBox();
            this.lblTaskPeriod = new System.Windows.Forms.Label();
            this.lblTaskExecution = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTaskPeriod
            // 
            this.txtTaskPeriod.Location = new System.Drawing.Point(24, 52);
            this.txtTaskPeriod.Name = "txtTaskPeriod";
            this.txtTaskPeriod.Size = new System.Drawing.Size(100, 26);
            this.txtTaskPeriod.TabIndex = 0;
            // 
            // txtTaskExecution
            // 
            this.txtTaskExecution.Location = new System.Drawing.Point(162, 52);
            this.txtTaskExecution.Name = "txtTaskExecution";
            this.txtTaskExecution.Size = new System.Drawing.Size(100, 26);
            this.txtTaskExecution.TabIndex = 1;
            // 
            // lblTaskPeriod
            // 
            this.lblTaskPeriod.AutoSize = true;
            this.lblTaskPeriod.Location = new System.Drawing.Point(20, 29);
            this.lblTaskPeriod.Name = "lblTaskPeriod";
            this.lblTaskPeriod.Size = new System.Drawing.Size(105, 20);
            this.lblTaskPeriod.TabIndex = 2;
            this.lblTaskPeriod.Text = "Task n Period";
            // 
            // lblTaskExecution
            // 
            this.lblTaskExecution.AutoSize = true;
            this.lblTaskExecution.Location = new System.Drawing.Point(158, 29);
            this.lblTaskExecution.Name = "lblTaskExecution";
            this.lblTaskExecution.Size = new System.Drawing.Size(130, 20);
            this.lblTaskExecution.TabIndex = 3;
            this.lblTaskExecution.Text = "Task n Execution";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(24, 101);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(91, 52);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(162, 101);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(91, 52);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "RANDOM";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // TasksInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 244);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblTaskExecution);
            this.Controls.Add(this.lblTaskPeriod);
            this.Controls.Add(this.txtTaskExecution);
            this.Controls.Add(this.txtTaskPeriod);
            this.Name = "TasksInfoForm";
            this.Text = "RMS by LCM Scheduling Tasks Info";
            this.Load += new System.EventHandler(this.TasksInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaskPeriod;
        private System.Windows.Forms.TextBox txtTaskExecution;
        private System.Windows.Forms.Label lblTaskPeriod;
        private System.Windows.Forms.Label lblTaskExecution;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnRandom;
    }
}