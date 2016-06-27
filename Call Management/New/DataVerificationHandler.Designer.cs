namespace C_DentalClaimTracker.Call_Management
{
    partial class DataVerificationHandler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAnswers = new System.Windows.Forms.Panel();
            this.cmdHide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlAnswers
            // 
            this.pnlAnswers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnswers.Location = new System.Drawing.Point(0, 0);
            this.pnlAnswers.Name = "pnlAnswers";
            this.pnlAnswers.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlAnswers.Size = new System.Drawing.Size(644, 30);
            this.pnlAnswers.TabIndex = 1;
            // 
            // cmdHide
            // 
            this.cmdHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHide.Location = new System.Drawing.Point(614, 0);
            this.cmdHide.Name = "cmdHide";
            this.cmdHide.Size = new System.Drawing.Size(31, 30);
            this.cmdHide.TabIndex = 2;
            this.cmdHide.Text = "X";
            this.cmdHide.UseVisualStyleBackColor = true;
            this.cmdHide.Visible = false;
            this.cmdHide.Click += new System.EventHandler(this.cmdHide_Click);
            // 
            // DataVerificationHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdHide);
            this.Controls.Add(this.pnlAnswers);
            this.Name = "DataVerificationHandler";
            this.Size = new System.Drawing.Size(644, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAnswers;
        private System.Windows.Forms.Button cmdHide;
    }
}
