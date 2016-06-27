namespace DCTUpdater
{
    partial class frmUpdater
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrentTask = new System.Windows.Forms.Label();
            this.pbarMain = new System.Windows.Forms.ProgressBar();
            this.chkStepOne = new System.Windows.Forms.CheckBox();
            this.chkStepTwo = new System.Windows.Forms.CheckBox();
            this.chkStepThree = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblCurrentTask);
            this.panel1.Controls.Add(this.pbarMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 26);
            this.panel1.TabIndex = 2;
            // 
            // lblCurrentTask
            // 
            this.lblCurrentTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentTask.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentTask.Name = "lblCurrentTask";
            this.lblCurrentTask.Size = new System.Drawing.Size(193, 22);
            this.lblCurrentTask.TabIndex = 2;
            this.lblCurrentTask.Text = "Initializing...";
            this.lblCurrentTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbarMain
            // 
            this.pbarMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbarMain.Location = new System.Drawing.Point(193, 0);
            this.pbarMain.Name = "pbarMain";
            this.pbarMain.Size = new System.Drawing.Size(120, 22);
            this.pbarMain.TabIndex = 3;
            // 
            // chkStepOne
            // 
            this.chkStepOne.AutoCheck = false;
            this.chkStepOne.AutoSize = true;
            this.chkStepOne.Location = new System.Drawing.Point(12, 12);
            this.chkStepOne.Name = "chkStepOne";
            this.chkStepOne.Size = new System.Drawing.Size(184, 17);
            this.chkStepOne.TabIndex = 3;
            this.chkStepOne.Text = "1. Checking for available updates";
            this.chkStepOne.UseVisualStyleBackColor = true;
            // 
            // chkStepTwo
            // 
            this.chkStepTwo.AutoCheck = false;
            this.chkStepTwo.AutoSize = true;
            this.chkStepTwo.ForeColor = System.Drawing.Color.Gray;
            this.chkStepTwo.Location = new System.Drawing.Point(12, 35);
            this.chkStepTwo.Name = "chkStepTwo";
            this.chkStepTwo.Size = new System.Drawing.Size(121, 17);
            this.chkStepTwo.TabIndex = 5;
            this.chkStepTwo.Text = "2. Downloading files";
            this.chkStepTwo.UseVisualStyleBackColor = true;
            // 
            // chkStepThree
            // 
            this.chkStepThree.AutoCheck = false;
            this.chkStepThree.AutoSize = true;
            this.chkStepThree.ForeColor = System.Drawing.Color.Gray;
            this.chkStepThree.Location = new System.Drawing.Point(12, 58);
            this.chkStepThree.Name = "chkStepThree";
            this.chkStepThree.Size = new System.Drawing.Size(120, 17);
            this.chkStepThree.TabIndex = 6;
            this.chkStepThree.Text = "3. Installing updates";
            this.chkStepThree.UseVisualStyleBackColor = true;
            // 
            // frmUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 120);
            this.Controls.Add(this.chkStepThree);
            this.Controls.Add(this.chkStepTwo);
            this.Controls.Add(this.chkStepOne);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdater";
            this.Text = "Claim Tracker Updater";
            this.Load += new System.EventHandler(this.frmUpdater_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrentTask;
        private System.Windows.Forms.ProgressBar pbarMain;
        private System.Windows.Forms.CheckBox chkStepOne;
        private System.Windows.Forms.CheckBox chkStepTwo;
        private System.Windows.Forms.CheckBox chkStepThree;

    }
}

