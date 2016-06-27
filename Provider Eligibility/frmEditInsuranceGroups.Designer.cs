namespace C_DentalClaimTracker.Provider_Eligibility
{
    partial class frmEditInsuranceGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditInsuranceGroup));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSwitchToProvider = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnkProviderEligibility = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstProcFilterList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lnkShowExcluded = new System.Windows.Forms.LinkLabel();
            this.lblMatches = new System.Windows.Forms.Label();
            this.lstMatches = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProcFilter = new System.Windows.Forms.TextBox();
            this.cmdAddFilter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkContainsMultipleCarriers = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(0, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(387, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtSwitchToProvider
            // 
            this.txtSwitchToProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSwitchToProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSwitchToProvider.Location = new System.Drawing.Point(3, 60);
            this.txtSwitchToProvider.Multiline = true;
            this.txtSwitchToProvider.Name = "txtSwitchToProvider";
            this.txtSwitchToProvider.Size = new System.Drawing.Size(536, 60);
            this.txtSwitchToProvider.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lnkProviderEligibility);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 593);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 50);
            this.panel1.TabIndex = 32;
            // 
            // lnkProviderEligibility
            // 
            this.lnkProviderEligibility.AutoSize = true;
            this.lnkProviderEligibility.Location = new System.Drawing.Point(6, 25);
            this.lnkProviderEligibility.Name = "lnkProviderEligibility";
            this.lnkProviderEligibility.Size = new System.Drawing.Size(150, 16);
            this.lnkProviderEligibility.TabIndex = 1;
            this.lnkProviderEligibility.TabStop = true;
            this.lnkProviderEligibility.Text = "Edit Provider Eligibility...";
            this.lnkProviderEligibility.Visible = false;
            this.lnkProviderEligibility.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProviderEligibility_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = global::C_DentalClaimTracker.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(339, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 26);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::C_DentalClaimTracker.Properties.Resources.accept;
            this.btnSave.Location = new System.Drawing.Point(437, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 41);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstProcFilterList);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lnkShowExcluded);
            this.groupBox2.Controls.Add(this.lblMatches);
            this.groupBox2.Controls.Add(this.lstMatches);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtProcFilter);
            this.groupBox2.Controls.Add(this.cmdAddFilter);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox2.Size = new System.Drawing.Size(536, 469);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Has these Insurance Companies";
            // 
            // lstProcFilterList
            // 
            this.lstProcFilterList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstProcFilterList.FormattingEnabled = true;
            this.lstProcFilterList.IntegralHeight = false;
            this.lstProcFilterList.ItemHeight = 16;
            this.lstProcFilterList.Location = new System.Drawing.Point(3, 63);
            this.lstProcFilterList.Name = "lstProcFilterList";
            this.lstProcFilterList.Size = new System.Drawing.Size(274, 187);
            this.lstProcFilterList.TabIndex = 2;
            this.lstProcFilterList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstProcFilterList_KeyUp);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Cornsilk;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(277, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 235);
            this.label7.TabIndex = 8;
            this.label7.Text = resources.GetString("label7.Text");
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkShowExcluded
            // 
            this.lnkShowExcluded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkShowExcluded.AutoSize = true;
            this.lnkShowExcluded.Location = new System.Drawing.Point(430, 254);
            this.lnkShowExcluded.Name = "lnkShowExcluded";
            this.lnkShowExcluded.Size = new System.Drawing.Size(99, 16);
            this.lnkShowExcluded.TabIndex = 36;
            this.lnkShowExcluded.TabStop = true;
            this.lnkShowExcluded.Text = "Show excluded";
            this.lnkShowExcluded.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowExcluded_LinkClicked);
            // 
            // lblMatches
            // 
            this.lblMatches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMatches.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMatches.Location = new System.Drawing.Point(3, 250);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(530, 25);
            this.lblMatches.TabIndex = 35;
            this.lblMatches.Text = "Showing Matching Companies";
            this.lblMatches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstMatches
            // 
            this.lstMatches.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstMatches.FormattingEnabled = true;
            this.lstMatches.IntegralHeight = false;
            this.lstMatches.ItemHeight = 16;
            this.lstMatches.Location = new System.Drawing.Point(3, 275);
            this.lstMatches.Name = "lstMatches";
            this.lstMatches.Size = new System.Drawing.Size(530, 194);
            this.lstMatches.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Filter List";
            // 
            // txtProcFilter
            // 
            this.txtProcFilter.Location = new System.Drawing.Point(6, 19);
            this.txtProcFilter.Name = "txtProcFilter";
            this.txtProcFilter.Size = new System.Drawing.Size(202, 22);
            this.txtProcFilter.TabIndex = 0;
            this.txtProcFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProcFilter_KeyDown);
            // 
            // cmdAddFilter
            // 
            this.cmdAddFilter.Location = new System.Drawing.Point(213, 17);
            this.cmdAddFilter.Name = "cmdAddFilter";
            this.cmdAddFilter.Size = new System.Drawing.Size(58, 24);
            this.cmdAddFilter.TabIndex = 1;
            this.cmdAddFilter.Text = "Add";
            this.cmdAddFilter.UseVisualStyleBackColor = true;
            this.cmdAddFilter.Click += new System.EventHandler(this.cmdAddFilter_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.chkContainsMultipleCarriers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 24);
            this.panel2.TabIndex = 34;
            // 
            // chkContainsMultipleCarriers
            // 
            this.chkContainsMultipleCarriers.AutoSize = true;
            this.chkContainsMultipleCarriers.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkContainsMultipleCarriers.Location = new System.Drawing.Point(387, 0);
            this.chkContainsMultipleCarriers.Name = "chkContainsMultipleCarriers";
            this.chkContainsMultipleCarriers.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.chkContainsMultipleCarriers.Size = new System.Drawing.Size(149, 24);
            this.chkContainsMultipleCarriers.TabIndex = 1;
            this.chkContainsMultipleCarriers.Text = "Contains Multiple Carriers";
            this.chkContainsMultipleCarriers.UseVisualStyleBackColor = true;
            // 
            // frmEditInsuranceGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 646);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSwitchToProvider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditInsuranceGroup";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Insurance Groups";
            this.Load += new System.EventHandler(this.frmEditProviderEligibilityRestriction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSwitchToProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProcFilter;
        private System.Windows.Forms.ListBox lstProcFilterList;
        private System.Windows.Forms.Button cmdAddFilter;
        private System.Windows.Forms.ListBox lstMatches;
        private System.Windows.Forms.Label lblMatches;
        private System.Windows.Forms.LinkLabel lnkProviderEligibility;
        private System.Windows.Forms.LinkLabel lnkShowExcluded;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkContainsMultipleCarriers;
    }
}