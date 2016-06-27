namespace C_DentalClaimTracker
{
    partial class frmBadPaymentClaimViewer
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
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.chkIssueResolved = new System.Windows.Forms.CheckBox();
            this.lblVerifiedBy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExpectedAmount = new System.Windows.Forms.Label();
            this.lblAmountReceived = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(12, 48);
            this.txtNotes.MaxLength = 4999;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(452, 197);
            this.txtNotes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdCancel);
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 32);
            this.panel1.TabIndex = 33;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(328, 2);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(65, 25);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Location = new System.Drawing.Point(399, 2);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(65, 25);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // chkIssueResolved
            // 
            this.chkIssueResolved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIssueResolved.AutoSize = true;
            this.chkIssueResolved.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIssueResolved.Location = new System.Drawing.Point(365, 251);
            this.chkIssueResolved.Name = "chkIssueResolved";
            this.chkIssueResolved.Size = new System.Drawing.Size(99, 17);
            this.chkIssueResolved.TabIndex = 34;
            this.chkIssueResolved.Text = "Issue Resolved";
            this.chkIssueResolved.UseVisualStyleBackColor = true;
            // 
            // lblVerifiedBy
            // 
            this.lblVerifiedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVerifiedBy.AutoSize = true;
            this.lblVerifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVerifiedBy.Location = new System.Drawing.Point(12, 251);
            this.lblVerifiedBy.Name = "lblVerifiedBy";
            this.lblVerifiedBy.Size = new System.Drawing.Size(64, 15);
            this.lblVerifiedBy.TabIndex = 35;
            this.lblVerifiedBy.Text = "Verified by: ";
            this.lblVerifiedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Notes";
            // 
            // lblExpectedAmount
            // 
            this.lblExpectedAmount.BackColor = System.Drawing.Color.White;
            this.lblExpectedAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExpectedAmount.Location = new System.Drawing.Point(12, 9);
            this.lblExpectedAmount.Name = "lblExpectedAmount";
            this.lblExpectedAmount.Size = new System.Drawing.Size(142, 21);
            this.lblExpectedAmount.TabIndex = 37;
            this.lblExpectedAmount.Text = "Amount Expected:";
            this.lblExpectedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAmountReceived
            // 
            this.lblAmountReceived.BackColor = System.Drawing.Color.White;
            this.lblAmountReceived.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountReceived.Location = new System.Drawing.Point(160, 9);
            this.lblAmountReceived.Name = "lblAmountReceived";
            this.lblAmountReceived.Size = new System.Drawing.Size(142, 21);
            this.lblAmountReceived.TabIndex = 38;
            this.lblAmountReceived.Text = "Amount Received:";
            this.lblAmountReceived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBadPaymentClaimViewer
            // 
            this.AcceptButton = this.cmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(473, 306);
            this.Controls.Add(this.lblAmountReceived);
            this.Controls.Add(this.lblExpectedAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVerifiedBy);
            this.Controls.Add(this.chkIssueResolved);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNotes);
            this.Name = "frmBadPaymentClaimViewer";
            this.Text = "Claims with Bad Payments";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.CheckBox chkIssueResolved;
        private System.Windows.Forms.Label lblVerifiedBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExpectedAmount;
        private System.Windows.Forms.Label lblAmountReceived;
    }
}