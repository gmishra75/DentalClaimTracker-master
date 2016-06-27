namespace C_DentalClaimTracker
{
    partial class frmInsuranceCompanyList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsuranceCompanyList));
            this.lblTitle = new System.Windows.Forms.Label();
            this.clbInsuranceCompanies = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(317, 110);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = resources.GetString("lblTitle.Text");
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clbInsuranceCompanies
            // 
            this.clbInsuranceCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbInsuranceCompanies.FormattingEnabled = true;
            this.clbInsuranceCompanies.IntegralHeight = false;
            this.clbInsuranceCompanies.Location = new System.Drawing.Point(0, 110);
            this.clbInsuranceCompanies.Name = "clbInsuranceCompanies";
            this.clbInsuranceCompanies.Size = new System.Drawing.Size(317, 345);
            this.clbInsuranceCompanies.TabIndex = 1;
            this.clbInsuranceCompanies.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbInsuranceCompanies_ItemCheck);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdCancel);
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 36);
            this.panel1.TabIndex = 2;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(158, 6);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(239, 6);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // frmInsuranceCompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 491);
            this.Controls.Add(this.clbInsuranceCompanies);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "frmInsuranceCompanyList";
            this.Text = "Insurance Company List";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckedListBox clbInsuranceCompanies;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
    }
}