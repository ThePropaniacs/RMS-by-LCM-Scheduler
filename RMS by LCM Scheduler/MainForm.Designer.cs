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
            this.txtTask1Period = new System.Windows.Forms.TextBox();
            this.txtTask2Period = new System.Windows.Forms.TextBox();
            this.txtTask3Period = new System.Windows.Forms.TextBox();
            this.txtTask4Period = new System.Windows.Forms.TextBox();
            this.txtTask5Period = new System.Windows.Forms.TextBox();
            this.txtTask5Execution = new System.Windows.Forms.TextBox();
            this.txtTask4Execution = new System.Windows.Forms.TextBox();
            this.txtTask3Execution = new System.Windows.Forms.TextBox();
            this.txtTask2Execution = new System.Windows.Forms.TextBox();
            this.txtTask1Execution = new System.Windows.Forms.TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblTask1 = new System.Windows.Forms.Label();
            this.lblTask2 = new System.Windows.Forms.Label();
            this.lblTask3 = new System.Windows.Forms.Label();
            this.lblTask4 = new System.Windows.Forms.Label();
            this.lblTask5 = new System.Windows.Forms.Label();
            this.lblExecution = new System.Windows.Forms.Label();
            this.cmdRandom = new System.Windows.Forms.Button();
            this.lblUtilization = new System.Windows.Forms.Label();
            this.txtTask5Utilization = new System.Windows.Forms.TextBox();
            this.txtTask4Utilization = new System.Windows.Forms.TextBox();
            this.txtTask3Utilization = new System.Windows.Forms.TextBox();
            this.txtTask2Utilization = new System.Windows.Forms.TextBox();
            this.txtTask1Utilization = new System.Windows.Forms.TextBox();
            this.txtTotalUtilization = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(209, 309);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(100, 41);
            this.cmdGo.TabIndex = 0;
            this.cmdGo.Text = "GO";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(577, 580);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 41);
            this.cmdExit.TabIndex = 1;
            this.cmdExit.Text = "EXIT";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(403, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(356, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "RMS by LCM Scheduler";
            // 
            // txtTask1Period
            // 
            this.txtTask1Period.Location = new System.Drawing.Point(93, 109);
            this.txtTask1Period.Name = "txtTask1Period";
            this.txtTask1Period.Size = new System.Drawing.Size(100, 26);
            this.txtTask1Period.TabIndex = 3;
            this.txtTask1Period.TextChanged += new System.EventHandler(this.txtTask1Period_TextChanged);
            this.txtTask1Period.Validating += new System.ComponentModel.CancelEventHandler(this.txtTask1Period_Validating);
            // 
            // txtTask2Period
            // 
            this.txtTask2Period.Location = new System.Drawing.Point(93, 141);
            this.txtTask2Period.Name = "txtTask2Period";
            this.txtTask2Period.Size = new System.Drawing.Size(100, 26);
            this.txtTask2Period.TabIndex = 4;
            this.txtTask2Period.TextChanged += new System.EventHandler(this.txtTask2Period_TextChanged);
            this.txtTask2Period.Validating += new System.ComponentModel.CancelEventHandler(this.txtTask2Period_Validating);
            // 
            // txtTask3Period
            // 
            this.txtTask3Period.Location = new System.Drawing.Point(93, 173);
            this.txtTask3Period.Name = "txtTask3Period";
            this.txtTask3Period.Size = new System.Drawing.Size(100, 26);
            this.txtTask3Period.TabIndex = 5;
            this.txtTask3Period.TextChanged += new System.EventHandler(this.txtTask3Period_TextChanged);
            this.txtTask3Period.Validating += new System.ComponentModel.CancelEventHandler(this.txtTask3Period_Validating);
            // 
            // txtTask4Period
            // 
            this.txtTask4Period.Location = new System.Drawing.Point(93, 205);
            this.txtTask4Period.Name = "txtTask4Period";
            this.txtTask4Period.Size = new System.Drawing.Size(100, 26);
            this.txtTask4Period.TabIndex = 6;
            this.txtTask4Period.TextChanged += new System.EventHandler(this.txtTask4Period_TextChanged);
            this.txtTask4Period.Validating += new System.ComponentModel.CancelEventHandler(this.txtTask4Period_Validating);
            // 
            // txtTask5Period
            // 
            this.txtTask5Period.Location = new System.Drawing.Point(93, 237);
            this.txtTask5Period.Name = "txtTask5Period";
            this.txtTask5Period.Size = new System.Drawing.Size(100, 26);
            this.txtTask5Period.TabIndex = 7;
            this.txtTask5Period.TextChanged += new System.EventHandler(this.txtTask5Period_TextChanged);
            this.txtTask5Period.Validating += new System.ComponentModel.CancelEventHandler(this.txtTask5Period_Validating);
            // 
            // txtTask5Execution
            // 
            this.txtTask5Execution.Enabled = false;
            this.txtTask5Execution.Location = new System.Drawing.Point(209, 237);
            this.txtTask5Execution.Name = "txtTask5Execution";
            this.txtTask5Execution.Size = new System.Drawing.Size(100, 26);
            this.txtTask5Execution.TabIndex = 12;
            this.txtTask5Execution.Validating += new System.ComponentModel.CancelEventHandler(this.txtTask5Execution_Validating);
            // 
            // txtTask4Execution
            // 
            this.txtTask4Execution.Enabled = false;
            this.txtTask4Execution.Location = new System.Drawing.Point(209, 205);
            this.txtTask4Execution.Name = "txtTask4Execution";
            this.txtTask4Execution.Size = new System.Drawing.Size(100, 26);
            this.txtTask4Execution.TabIndex = 11;
            this.txtTask4Execution.Validating += new System.ComponentModel.CancelEventHandler(this.txtTask4Execution_Validating);
            // 
            // txtTask3Execution
            // 
            this.txtTask3Execution.Enabled = false;
            this.txtTask3Execution.Location = new System.Drawing.Point(209, 173);
            this.txtTask3Execution.Name = "txtTask3Execution";
            this.txtTask3Execution.Size = new System.Drawing.Size(100, 26);
            this.txtTask3Execution.TabIndex = 10;
            this.txtTask3Execution.Validating += new System.ComponentModel.CancelEventHandler(this.txtTask3Execution_Validating);
            // 
            // txtTask2Execution
            // 
            this.txtTask2Execution.Enabled = false;
            this.txtTask2Execution.Location = new System.Drawing.Point(209, 141);
            this.txtTask2Execution.Name = "txtTask2Execution";
            this.txtTask2Execution.Size = new System.Drawing.Size(100, 26);
            this.txtTask2Execution.TabIndex = 9;
            this.txtTask2Execution.Validating += new System.ComponentModel.CancelEventHandler(this.txtTask2Execution_Validating);
            // 
            // txtTask1Execution
            // 
            this.txtTask1Execution.Enabled = false;
            this.txtTask1Execution.Location = new System.Drawing.Point(209, 109);
            this.txtTask1Execution.Name = "txtTask1Execution";
            this.txtTask1Execution.Size = new System.Drawing.Size(100, 26);
            this.txtTask1Execution.TabIndex = 8;
            this.txtTask1Execution.Validating += new System.ComponentModel.CancelEventHandler(this.txtTask1Execution_Validating);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(110, 81);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(68, 25);
            this.lblPeriod.TabIndex = 13;
            this.lblPeriod.Text = "Period";
            this.lblPeriod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTask1
            // 
            this.lblTask1.AutoSize = true;
            this.lblTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask1.Location = new System.Drawing.Point(15, 108);
            this.lblTask1.Name = "lblTask1";
            this.lblTask1.Size = new System.Drawing.Size(72, 25);
            this.lblTask1.TabIndex = 14;
            this.lblTask1.Text = "Task 1";
            this.lblTask1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTask2
            // 
            this.lblTask2.AutoSize = true;
            this.lblTask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask2.Location = new System.Drawing.Point(15, 142);
            this.lblTask2.Name = "lblTask2";
            this.lblTask2.Size = new System.Drawing.Size(72, 25);
            this.lblTask2.TabIndex = 15;
            this.lblTask2.Text = "Task 2";
            this.lblTask2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTask3
            // 
            this.lblTask3.AutoSize = true;
            this.lblTask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask3.Location = new System.Drawing.Point(15, 174);
            this.lblTask3.Name = "lblTask3";
            this.lblTask3.Size = new System.Drawing.Size(72, 25);
            this.lblTask3.TabIndex = 16;
            this.lblTask3.Text = "Task 3";
            this.lblTask3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTask4
            // 
            this.lblTask4.AutoSize = true;
            this.lblTask4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask4.Location = new System.Drawing.Point(15, 206);
            this.lblTask4.Name = "lblTask4";
            this.lblTask4.Size = new System.Drawing.Size(72, 25);
            this.lblTask4.TabIndex = 17;
            this.lblTask4.Text = "Task 4";
            this.lblTask4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTask5
            // 
            this.lblTask5.AutoSize = true;
            this.lblTask5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask5.Location = new System.Drawing.Point(15, 238);
            this.lblTask5.Name = "lblTask5";
            this.lblTask5.Size = new System.Drawing.Size(72, 25);
            this.lblTask5.TabIndex = 18;
            this.lblTask5.Text = "Task 5";
            this.lblTask5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblExecution
            // 
            this.lblExecution.AutoSize = true;
            this.lblExecution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExecution.Location = new System.Drawing.Point(211, 81);
            this.lblExecution.Name = "lblExecution";
            this.lblExecution.Size = new System.Drawing.Size(98, 25);
            this.lblExecution.TabIndex = 19;
            this.lblExecution.Text = "Execution";
            this.lblExecution.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdRandom
            // 
            this.cmdRandom.Location = new System.Drawing.Point(93, 309);
            this.cmdRandom.Name = "cmdRandom";
            this.cmdRandom.Size = new System.Drawing.Size(100, 41);
            this.cmdRandom.TabIndex = 20;
            this.cmdRandom.Text = "RANDOM";
            this.cmdRandom.UseVisualStyleBackColor = true;
            this.cmdRandom.Click += new System.EventHandler(this.cmdRandom_Click);
            // 
            // lblUtilization
            // 
            this.lblUtilization.AutoSize = true;
            this.lblUtilization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilization.Location = new System.Drawing.Point(329, 81);
            this.lblUtilization.Name = "lblUtilization";
            this.lblUtilization.Size = new System.Drawing.Size(95, 25);
            this.lblUtilization.TabIndex = 26;
            this.lblUtilization.Text = "Utilization";
            this.lblUtilization.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTask5Utilization
            // 
            this.txtTask5Utilization.BackColor = System.Drawing.SystemColors.Control;
            this.txtTask5Utilization.Location = new System.Drawing.Point(327, 237);
            this.txtTask5Utilization.Name = "txtTask5Utilization";
            this.txtTask5Utilization.ReadOnly = true;
            this.txtTask5Utilization.Size = new System.Drawing.Size(100, 26);
            this.txtTask5Utilization.TabIndex = 25;
            // 
            // txtTask4Utilization
            // 
            this.txtTask4Utilization.BackColor = System.Drawing.SystemColors.Control;
            this.txtTask4Utilization.Location = new System.Drawing.Point(327, 205);
            this.txtTask4Utilization.Name = "txtTask4Utilization";
            this.txtTask4Utilization.ReadOnly = true;
            this.txtTask4Utilization.Size = new System.Drawing.Size(100, 26);
            this.txtTask4Utilization.TabIndex = 24;
            // 
            // txtTask3Utilization
            // 
            this.txtTask3Utilization.BackColor = System.Drawing.SystemColors.Control;
            this.txtTask3Utilization.Location = new System.Drawing.Point(327, 173);
            this.txtTask3Utilization.Name = "txtTask3Utilization";
            this.txtTask3Utilization.ReadOnly = true;
            this.txtTask3Utilization.Size = new System.Drawing.Size(100, 26);
            this.txtTask3Utilization.TabIndex = 23;
            // 
            // txtTask2Utilization
            // 
            this.txtTask2Utilization.BackColor = System.Drawing.SystemColors.Control;
            this.txtTask2Utilization.Location = new System.Drawing.Point(327, 141);
            this.txtTask2Utilization.Name = "txtTask2Utilization";
            this.txtTask2Utilization.ReadOnly = true;
            this.txtTask2Utilization.Size = new System.Drawing.Size(100, 26);
            this.txtTask2Utilization.TabIndex = 22;
            // 
            // txtTask1Utilization
            // 
            this.txtTask1Utilization.BackColor = System.Drawing.SystemColors.Control;
            this.txtTask1Utilization.Location = new System.Drawing.Point(327, 109);
            this.txtTask1Utilization.Name = "txtTask1Utilization";
            this.txtTask1Utilization.ReadOnly = true;
            this.txtTask1Utilization.Size = new System.Drawing.Size(100, 26);
            this.txtTask1Utilization.TabIndex = 21;
            // 
            // txtTotalUtilization
            // 
            this.txtTotalUtilization.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalUtilization.Location = new System.Drawing.Point(327, 269);
            this.txtTotalUtilization.Name = "txtTotalUtilization";
            this.txtTotalUtilization.ReadOnly = true;
            this.txtTotalUtilization.Size = new System.Drawing.Size(100, 26);
            this.txtTotalUtilization.TabIndex = 30;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(15, 270);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOverloaded
            // 
            this.lblOverloaded.AutoSize = true;
            this.lblOverloaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverloaded.Location = new System.Drawing.Point(445, 81);
            this.lblOverloaded.Name = "lblOverloaded";
            this.lblOverloaded.Size = new System.Drawing.Size(114, 25);
            this.lblOverloaded.TabIndex = 32;
            this.lblOverloaded.Text = "Overloaded";
            this.lblOverloaded.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtOverloaded
            // 
            this.txtOverloaded.BackColor = System.Drawing.SystemColors.Control;
            this.txtOverloaded.Location = new System.Drawing.Point(443, 109);
            this.txtOverloaded.Name = "txtOverloaded";
            this.txtOverloaded.ReadOnly = true;
            this.txtOverloaded.Size = new System.Drawing.Size(116, 26);
            this.txtOverloaded.TabIndex = 31;
            // 
            // lblGuaranteedLevel
            // 
            this.lblGuaranteedLevel.AutoSize = true;
            this.lblGuaranteedLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuaranteedLevel.Location = new System.Drawing.Point(579, 81);
            this.lblGuaranteedLevel.Name = "lblGuaranteedLevel";
            this.lblGuaranteedLevel.Size = new System.Drawing.Size(167, 25);
            this.lblGuaranteedLevel.TabIndex = 34;
            this.lblGuaranteedLevel.Text = "Guaranteed Level";
            this.lblGuaranteedLevel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGuaranteedLevel
            // 
            this.txtGuaranteedLevel.BackColor = System.Drawing.SystemColors.Control;
            this.txtGuaranteedLevel.Location = new System.Drawing.Point(577, 109);
            this.txtGuaranteedLevel.Name = "txtGuaranteedLevel";
            this.txtGuaranteedLevel.ReadOnly = true;
            this.txtGuaranteedLevel.Size = new System.Drawing.Size(169, 26);
            this.txtGuaranteedLevel.TabIndex = 33;
            // 
            // lblGuaranteed
            // 
            this.lblGuaranteed.AutoSize = true;
            this.lblGuaranteed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuaranteed.Location = new System.Drawing.Point(765, 81);
            this.lblGuaranteed.Name = "lblGuaranteed";
            this.lblGuaranteed.Size = new System.Drawing.Size(115, 25);
            this.lblGuaranteed.TabIndex = 36;
            this.lblGuaranteed.Text = "Guaranteed";
            this.lblGuaranteed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGuaranteed
            // 
            this.txtGuaranteed.BackColor = System.Drawing.SystemColors.Control;
            this.txtGuaranteed.Location = new System.Drawing.Point(763, 109);
            this.txtGuaranteed.Name = "txtGuaranteed";
            this.txtGuaranteed.ReadOnly = true;
            this.txtGuaranteed.Size = new System.Drawing.Size(116, 26);
            this.txtGuaranteed.TabIndex = 35;
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(327, 309);
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
            this.lblFeasible.Location = new System.Drawing.Point(572, 161);
            this.lblFeasible.Name = "lblFeasible";
            this.lblFeasible.Size = new System.Drawing.Size(98, 25);
            this.lblFeasible.TabIndex = 39;
            this.lblFeasible.Text = "Feasibility";
            this.lblFeasible.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFeasible
            // 
            this.txtFeasible.BackColor = System.Drawing.SystemColors.Control;
            this.txtFeasible.Location = new System.Drawing.Point(443, 189);
            this.txtFeasible.Name = "txtFeasible";
            this.txtFeasible.ReadOnly = true;
            this.txtFeasible.Size = new System.Drawing.Size(436, 26);
            this.txtFeasible.TabIndex = 38;
            // 
            // lblLCM
            // 
            this.lblLCM.AutoSize = true;
            this.lblLCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLCM.Location = new System.Drawing.Point(927, 79);
            this.lblLCM.Name = "lblLCM";
            this.lblLCM.Size = new System.Drawing.Size(55, 25);
            this.lblLCM.TabIndex = 41;
            this.lblLCM.Text = "LCM";
            this.lblLCM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLCM
            // 
            this.txtLCM.BackColor = System.Drawing.SystemColors.Control;
            this.txtLCM.Location = new System.Drawing.Point(897, 107);
            this.txtLCM.Name = "txtLCM";
            this.txtLCM.ReadOnly = true;
            this.txtLCM.Size = new System.Drawing.Size(116, 26);
            this.txtLCM.TabIndex = 40;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 646);
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
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblUtilization);
            this.Controls.Add(this.txtTask5Utilization);
            this.Controls.Add(this.txtTask4Utilization);
            this.Controls.Add(this.txtTask3Utilization);
            this.Controls.Add(this.txtTask2Utilization);
            this.Controls.Add(this.txtTask1Utilization);
            this.Controls.Add(this.cmdRandom);
            this.Controls.Add(this.lblExecution);
            this.Controls.Add(this.lblTask5);
            this.Controls.Add(this.lblTask4);
            this.Controls.Add(this.lblTask3);
            this.Controls.Add(this.lblTask2);
            this.Controls.Add(this.lblTask1);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.txtTask5Execution);
            this.Controls.Add(this.txtTask4Execution);
            this.Controls.Add(this.txtTask3Execution);
            this.Controls.Add(this.txtTask2Execution);
            this.Controls.Add(this.txtTask1Execution);
            this.Controls.Add(this.txtTask5Period);
            this.Controls.Add(this.txtTask4Period);
            this.Controls.Add(this.txtTask3Period);
            this.Controls.Add(this.txtTask2Period);
            this.Controls.Add(this.txtTask1Period);
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
        private System.Windows.Forms.TextBox txtTask1Period;
        private System.Windows.Forms.TextBox txtTask2Period;
        private System.Windows.Forms.TextBox txtTask3Period;
        private System.Windows.Forms.TextBox txtTask4Period;
        private System.Windows.Forms.TextBox txtTask5Period;
        private System.Windows.Forms.TextBox txtTask5Execution;
        private System.Windows.Forms.TextBox txtTask4Execution;
        private System.Windows.Forms.TextBox txtTask3Execution;
        private System.Windows.Forms.TextBox txtTask2Execution;
        private System.Windows.Forms.TextBox txtTask1Execution;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblTask1;
        private System.Windows.Forms.Label lblTask2;
        private System.Windows.Forms.Label lblTask3;
        private System.Windows.Forms.Label lblTask4;
        private System.Windows.Forms.Label lblTask5;
        private System.Windows.Forms.Label lblExecution;
        private System.Windows.Forms.Button cmdRandom;
        private System.Windows.Forms.Label lblUtilization;
        private System.Windows.Forms.TextBox txtTask5Utilization;
        private System.Windows.Forms.TextBox txtTask4Utilization;
        private System.Windows.Forms.TextBox txtTask3Utilization;
        private System.Windows.Forms.TextBox txtTask2Utilization;
        private System.Windows.Forms.TextBox txtTask1Utilization;
        private System.Windows.Forms.TextBox txtTotalUtilization;
        private System.Windows.Forms.Label lblTotal;
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
    }
}