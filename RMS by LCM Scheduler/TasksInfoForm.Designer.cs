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
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtExecution = new System.Windows.Forms.TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblExecution = new System.Windows.Forms.Label();
            this.cmdGo = new System.Windows.Forms.Button();
            this.cmdRandom = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUtilization = new System.Windows.Forms.TextBox();
            this.lblUtilization = new System.Windows.Forms.Label();
            this.cmdClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(66, 99);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(100, 26);
            this.txtPeriod.TabIndex = 0;
            this.txtPeriod.Validating += new System.ComponentModel.CancelEventHandler(this.txtPeriod_Validating);
            // 
            // txtExecution
            // 
            this.txtExecution.Location = new System.Drawing.Point(176, 99);
            this.txtExecution.Name = "txtExecution";
            this.txtExecution.Size = new System.Drawing.Size(100, 26);
            this.txtExecution.TabIndex = 1;
            this.txtExecution.Validating += new System.ComponentModel.CancelEventHandler(this.txtExecution_Validating);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(78, 71);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(68, 25);
            this.lblPeriod.TabIndex = 2;
            this.lblPeriod.Text = "Period";
            // 
            // lblExecution
            // 
            this.lblExecution.AutoSize = true;
            this.lblExecution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblExecution.Location = new System.Drawing.Point(178, 71);
            this.lblExecution.Name = "lblExecution";
            this.lblExecution.Size = new System.Drawing.Size(98, 25);
            this.lblExecution.TabIndex = 3;
            this.lblExecution.Text = "Execution";
            // 
            // cmdGo
            // 
            this.cmdGo.Enabled = false;
            this.cmdGo.Location = new System.Drawing.Point(176, 148);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(100, 52);
            this.cmdGo.TabIndex = 4;
            this.cmdGo.Text = "GO";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // cmdRandom
            // 
            this.cmdRandom.Location = new System.Drawing.Point(66, 148);
            this.cmdRandom.Name = "cmdRandom";
            this.cmdRandom.Size = new System.Drawing.Size(100, 52);
            this.cmdRandom.TabIndex = 5;
            this.cmdRandom.Text = "RANDOM";
            this.cmdRandom.UseVisualStyleBackColor = true;
            this.cmdRandom.Click += new System.EventHandler(this.cmdRandom_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(174, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 37);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Task n";
            // 
            // txtUtilization
            // 
            this.txtUtilization.BackColor = System.Drawing.SystemColors.Control;
            this.txtUtilization.Location = new System.Drawing.Point(288, 99);
            this.txtUtilization.Name = "txtUtilization";
            this.txtUtilization.ReadOnly = true;
            this.txtUtilization.Size = new System.Drawing.Size(139, 26);
            this.txtUtilization.TabIndex = 32;
            // 
            // lblUtilization
            // 
            this.lblUtilization.AutoSize = true;
            this.lblUtilization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilization.Location = new System.Drawing.Point(312, 71);
            this.lblUtilization.Name = "lblUtilization";
            this.lblUtilization.Size = new System.Drawing.Size(95, 25);
            this.lblUtilization.TabIndex = 31;
            this.lblUtilization.Text = "Utilization";
            this.lblUtilization.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(288, 148);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(139, 52);
            this.cmdClear.TabIndex = 33;
            this.cmdClear.Text = "CLEAR";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // TasksInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 244);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.txtUtilization);
            this.Controls.Add(this.lblUtilization);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmdRandom);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.lblExecution);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.txtExecution);
            this.Controls.Add(this.txtPeriod);
            this.Name = "TasksInfoForm";
            this.Text = "RMS by LCM Scheduling Tasks Info";
            this.Load += new System.EventHandler(this.TasksInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtExecution;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblExecution;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.Button cmdRandom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUtilization;
        private System.Windows.Forms.Label lblUtilization;
        private System.Windows.Forms.Button cmdClear;
    }
}