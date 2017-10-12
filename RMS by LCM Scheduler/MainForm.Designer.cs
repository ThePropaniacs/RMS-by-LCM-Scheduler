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
            this.txtGo = new System.Windows.Forms.Button();
            this.txtExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGo
            // 
            this.txtGo.Location = new System.Drawing.Point(41, 133);
            this.txtGo.Name = "txtGo";
            this.txtGo.Size = new System.Drawing.Size(75, 41);
            this.txtGo.TabIndex = 0;
            this.txtGo.Text = "GO";
            this.txtGo.UseVisualStyleBackColor = true;
            this.txtGo.Click += new System.EventHandler(this.txtGo_Click);
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(315, 133);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(75, 41);
            this.txtExit.TabIndex = 1;
            this.txtExit.Text = "EXIT";
            this.txtExit.UseVisualStyleBackColor = true;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(34, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(356, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "RMS by LCM Scheduler";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 302);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.txtGo);
            this.Name = "MainForm";
            this.Text = "RMS by LCM Scheduler Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtGo;
        private System.Windows.Forms.Button txtExit;
        private System.Windows.Forms.Label lblTitle;
    }
}