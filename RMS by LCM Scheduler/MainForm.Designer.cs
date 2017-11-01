namespace RMS_by_LCM_Scheduler
{
    partial class MainForm
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
            this.cmdGo = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNumTasks = new System.Windows.Forms.TextBox();
            this.lblNumTasks = new System.Windows.Forms.Label();
            this.cmdRandom = new System.Windows.Forms.Button();
            this.lblTotalUtilization = new System.Windows.Forms.Label();
            this.txtTotalUtilization = new System.Windows.Forms.TextBox();
            this.lblOverloaded = new System.Windows.Forms.Label();
            this.txtOverloaded = new System.Windows.Forms.TextBox();
            this.lblGuaranteedLevel = new System.Windows.Forms.Label();
            this.txtGuaranteedLevel = new System.Windows.Forms.TextBox();
            this.lblGuaranteed = new System.Windows.Forms.Label();
            this.txtGuaranteed = new System.Windows.Forms.TextBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.lblFeasible = new System.Windows.Forms.Label();
            this.txtFeasible = new System.Windows.Forms.TextBox();
            this.lblLCM = new System.Windows.Forms.Label();
            this.txtLCM = new System.Windows.Forms.TextBox();
            this.cmdTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdGo
            // 
            this.cmdGo.Enabled = false;
            this.cmdGo.Location = new System.Drawing.Point(346, 247);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(100, 41);
            this.cmdGo.TabIndex = 0;
            this.cmdGo.Text = "GO";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(346, 318);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(100, 41);
            this.cmdExit.TabIndex = 1;
            this.cmdExit.Text = "EXIT";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(234, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(356, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "RMS by LCM Scheduler";
            // 
            // txtNumTasks
            // 
            this.txtNumTasks.Location = new System.Drawing.Point(13, 111);
            this.txtNumTasks.Name = "txtNumTasks";
            this.txtNumTasks.Size = new System.Drawing.Size(100, 26);
            this.txtNumTasks.TabIndex = 3;
            this.txtNumTasks.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumTasks_Validating);
            // 
            // lblNumTasks
            // 
            this.lblNumTasks.AutoSize = true;
            this.lblNumTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTasks.Location = new System.Drawing.Point(19, 83);
            this.lblNumTasks.Name = "lblNumTasks";
            this.lblNumTasks.Size = new System.Drawing.Size(82, 25);
            this.lblNumTasks.TabIndex = 13;
            this.lblNumTasks.Text = "# Tasks";
            this.lblNumTasks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdRandom
            // 
            this.cmdRandom.Location = new System.Drawing.Point(230, 247);
            this.cmdRandom.Name = "cmdRandom";
            this.cmdRandom.Size = new System.Drawing.Size(100, 41);
            this.cmdRandom.TabIndex = 20;
            this.cmdRandom.Text = "RANDOM";
            this.cmdRandom.UseVisualStyleBackColor = true;
            this.cmdRandom.Click += new System.EventHandler(this.cmdRandom_Click);
            // 
            // lblTotalUtilization
            // 
            this.lblTotalUtilization.AutoSize = true;
            this.lblTotalUtilization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUtilization.Location = new System.Drawing.Point(125, 81);
            this.lblTotalUtilization.Name = "lblTotalUtilization";
            this.lblTotalUtilization.Size = new System.Drawing.Size(144, 25);
            this.lblTotalUtilization.TabIndex = 26;
            this.lblTotalUtilization.Text = "Total Utilization";
            this.lblTotalUtilization.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTotalUtilization
            // 
            this.txtTotalUtilization.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalUtilization.Location = new System.Drawing.Point(128, 111);
            this.txtTotalUtilization.Name = "txtTotalUtilization";
            this.txtTotalUtilization.ReadOnly = true;
            this.txtTotalUtilization.Size = new System.Drawing.Size(139, 26);
            this.txtTotalUtilization.TabIndex = 30;
            // 
            // lblOverloaded
            // 
            this.lblOverloaded.AutoSize = true;
            this.lblOverloaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverloaded.Location = new System.Drawing.Point(282, 83);
            this.lblOverloaded.Name = "lblOverloaded";
            this.lblOverloaded.Size = new System.Drawing.Size(114, 25);
            this.lblOverloaded.TabIndex = 32;
            this.lblOverloaded.Text = "Overloaded";
            this.lblOverloaded.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtOverloaded
            // 
            this.txtOverloaded.BackColor = System.Drawing.SystemColors.Control;
            this.txtOverloaded.Location = new System.Drawing.Point(280, 111);
            this.txtOverloaded.Name = "txtOverloaded";
            this.txtOverloaded.ReadOnly = true;
            this.txtOverloaded.Size = new System.Drawing.Size(116, 26);
            this.txtOverloaded.TabIndex = 31;
            // 
            // lblGuaranteedLevel
            // 
            this.lblGuaranteedLevel.AutoSize = true;
            this.lblGuaranteedLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuaranteedLevel.Location = new System.Drawing.Point(409, 83);
            this.lblGuaranteedLevel.Name = "lblGuaranteedLevel";
            this.lblGuaranteedLevel.Size = new System.Drawing.Size(167, 25);
            this.lblGuaranteedLevel.TabIndex = 34;
            this.lblGuaranteedLevel.Text = "Guaranteed Level";
            this.lblGuaranteedLevel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGuaranteedLevel
            // 
            this.txtGuaranteedLevel.BackColor = System.Drawing.SystemColors.Control;
            this.txtGuaranteedLevel.Location = new System.Drawing.Point(407, 111);
            this.txtGuaranteedLevel.Name = "txtGuaranteedLevel";
            this.txtGuaranteedLevel.ReadOnly = true;
            this.txtGuaranteedLevel.Size = new System.Drawing.Size(169, 26);
            this.txtGuaranteedLevel.TabIndex = 33;
            // 
            // lblGuaranteed
            // 
            this.lblGuaranteed.AutoSize = true;
            this.lblGuaranteed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuaranteed.Location = new System.Drawing.Point(595, 83);
            this.lblGuaranteed.Name = "lblGuaranteed";
            this.lblGuaranteed.Size = new System.Drawing.Size(115, 25);
            this.lblGuaranteed.TabIndex = 36;
            this.lblGuaranteed.Text = "Guaranteed";
            this.lblGuaranteed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGuaranteed
            // 
            this.txtGuaranteed.BackColor = System.Drawing.SystemColors.Control;
            this.txtGuaranteed.Location = new System.Drawing.Point(593, 111);
            this.txtGuaranteed.Name = "txtGuaranteed";
            this.txtGuaranteed.ReadOnly = true;
            this.txtGuaranteed.Size = new System.Drawing.Size(116, 26);
            this.txtGuaranteed.TabIndex = 35;
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(574, 247);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(100, 41);
            this.cmdClear.TabIndex = 37;
            this.cmdClear.Text = "CLEAR";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // lblFeasible
            // 
            this.lblFeasible.AutoSize = true;
            this.lblFeasible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeasible.Location = new System.Drawing.Point(348, 154);
            this.lblFeasible.Name = "lblFeasible";
            this.lblFeasible.Size = new System.Drawing.Size(98, 25);
            this.lblFeasible.TabIndex = 39;
            this.lblFeasible.Text = "Feasibility";
            this.lblFeasible.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFeasible
            // 
            this.txtFeasible.BackColor = System.Drawing.SystemColors.Control;
            this.txtFeasible.Location = new System.Drawing.Point(13, 182);
            this.txtFeasible.Name = "txtFeasible";
            this.txtFeasible.ReadOnly = true;
            this.txtFeasible.Size = new System.Drawing.Size(830, 26);
            this.txtFeasible.TabIndex = 38;
            // 
            // lblLCM
            // 
            this.lblLCM.AutoSize = true;
            this.lblLCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLCM.Location = new System.Drawing.Point(757, 81);
            this.lblLCM.Name = "lblLCM";
            this.lblLCM.Size = new System.Drawing.Size(55, 25);
            this.lblLCM.TabIndex = 41;
            this.lblLCM.Text = "LCM";
            this.lblLCM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLCM
            // 
            this.txtLCM.BackColor = System.Drawing.SystemColors.Control;
            this.txtLCM.Location = new System.Drawing.Point(727, 109);
            this.txtLCM.Name = "txtLCM";
            this.txtLCM.ReadOnly = true;
            this.txtLCM.Size = new System.Drawing.Size(116, 26);
            this.txtLCM.TabIndex = 40;
            // 
            // cmdTest
            // 
            this.cmdTest.Enabled = false;
            this.cmdTest.Location = new System.Drawing.Point(461, 247);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(100, 41);
            this.cmdTest.TabIndex = 42;
            this.cmdTest.Text = "TEST";
            this.cmdTest.UseVisualStyleBackColor = true;
            this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 383);
            this.Controls.Add(this.cmdTest);
            this.Controls.Add(this.lblLCM);
            this.Controls.Add(this.txtLCM);
            this.Controls.Add(this.lblFeasible);
            this.Controls.Add(this.txtFeasible);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.lblGuaranteed);
            this.Controls.Add(this.txtGuaranteed);
            this.Controls.Add(this.lblGuaranteedLevel);
            this.Controls.Add(this.txtGuaranteedLevel);
            this.Controls.Add(this.lblOverloaded);
            this.Controls.Add(this.txtOverloaded);
            this.Controls.Add(this.txtTotalUtilization);
            this.Controls.Add(this.lblTotalUtilization);
            this.Controls.Add(this.cmdRandom);
            this.Controls.Add(this.lblNumTasks);
            this.Controls.Add(this.txtNumTasks);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdGo);
            this.Name = "MainForm";
            this.Text = "RMS by LCM Scheduler Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNumTasks;
        private System.Windows.Forms.Label lblNumTasks;
        private System.Windows.Forms.Button cmdRandom;
        private System.Windows.Forms.Label lblTotalUtilization;
        private System.Windows.Forms.TextBox txtTotalUtilization;
        private System.Windows.Forms.Label lblOverloaded;
        private System.Windows.Forms.TextBox txtOverloaded;
        private System.Windows.Forms.Label lblGuaranteedLevel;
        private System.Windows.Forms.TextBox txtGuaranteedLevel;
        private System.Windows.Forms.Label lblGuaranteed;
        private System.Windows.Forms.TextBox txtGuaranteed;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Label lblFeasible;
        private System.Windows.Forms.TextBox txtFeasible;
        private System.Windows.Forms.Label lblLCM;
        private System.Windows.Forms.TextBox txtLCM;
        private System.Windows.Forms.Button cmdTest;
    }
}