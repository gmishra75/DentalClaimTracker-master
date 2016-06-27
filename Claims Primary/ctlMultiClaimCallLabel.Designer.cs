namespace C_DentalClaimTracker
{
    partial class ctlMultiClaimCallLabel
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblGroupNamePhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCompanyName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.SlateGray;
            this.lblCompanyName.Location = new System.Drawing.Point(416, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(166, 20);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company Name";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGroupNamePhone
            // 
            this.lblGroupNamePhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGroupNamePhone.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupNamePhone.Location = new System.Drawing.Point(0, 0);
            this.lblGroupNamePhone.Name = "lblGroupNamePhone";
            this.lblGroupNamePhone.Size = new System.Drawing.Size(416, 20);
            this.lblGroupNamePhone.TabIndex = 1;
            this.lblGroupNamePhone.Text = "label2";
            this.lblGroupNamePhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctlMultiClaimCallLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblGroupNamePhone);
            this.Controls.Add(this.lblCompanyName);
            this.Name = "ctlMultiClaimCallLabel";
            this.Size = new System.Drawing.Size(582, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblGroupNamePhone;
    }
}
