namespace C_DentalClaimTracker.E_Claims.Mercury
{
    partial class ctlPatientEligibility
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
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkCheckState = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblPatientName
            // 
            this.lblPatientName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(38, 0);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(231, 41);
            this.lblPatientName.TabIndex = 10;
            this.lblPatientName.Text = "Patient Name";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTime.Location = new System.Drawing.Point(269, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 41);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time\r\nLength";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(344, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(270, 41);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStatus.Location = new System.Drawing.Point(614, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(89, 41);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Unverified";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkCheckState
            // 
            this.chkCheckState.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCheckState.Checked = true;
            this.chkCheckState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCheckState.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkCheckState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheckState.Location = new System.Drawing.Point(0, 0);
            this.chkCheckState.Name = "chkCheckState";
            this.chkCheckState.Size = new System.Drawing.Size(38, 41);
            this.chkCheckState.TabIndex = 15;
            this.chkCheckState.UseVisualStyleBackColor = true;
            // 
            // ctlPatientEligibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.chkCheckState);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctlPatientEligibility";
            this.Size = new System.Drawing.Size(703, 41);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkCheckState;



    }
}
