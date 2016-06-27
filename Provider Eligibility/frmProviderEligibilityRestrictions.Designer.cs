namespace C_DentalClaimTracker.Provider_Eligibility
{
    partial class frmProviderEligibilityRestrictions
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSearchOptions = new System.Windows.Forms.Label();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRunTests = new System.Windows.Forms.Button();
            this.lblDisabled = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.cmbCurrentProvider = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.providereligibilityrestrictionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlEnabled = new System.Windows.Forms.Panel();
            this.pnlDisabled = new System.Windows.Forms.Panel();
            this.chkShowXProviders = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providereligibilityrestrictionsBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 496);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 47);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 45);
            this.panel1.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(661, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 45);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "&Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(758, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "- Always verify that the same provider does not have multiple restrictions in the" +
    " same date range";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSearchOptions
            // 
            this.lblSearchOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lblSearchOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSearchOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSearchOptions.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchOptions.Location = new System.Drawing.Point(0, 0);
            this.lblSearchOptions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchOptions.Name = "lblSearchOptions";
            this.lblSearchOptions.Size = new System.Drawing.Size(760, 56);
            this.lblSearchOptions.TabIndex = 5;
            this.lblSearchOptions.Text = "Provider Eligibility Restrictions";
            this.lblSearchOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.AutoScroll = true;
            this.pnlDisplay.Controls.Add(this.pnlDisabled);
            this.pnlDisplay.Controls.Add(this.pnlEnabled);
            this.pnlDisplay.Controls.Add(this.panel4);
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(0, 120);
            this.pnlDisplay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlDisplay.Size = new System.Drawing.Size(760, 376);
            this.pnlDisplay.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkShowXProviders);
            this.panel2.Controls.Add(this.btnRunTests);
            this.panel2.Controls.Add(this.cmbCurrentProvider);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 64);
            this.panel2.TabIndex = 0;
            // 
            // btnRunTests
            // 
            this.btnRunTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunTests.Location = new System.Drawing.Point(658, 33);
            this.btnRunTests.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRunTests.Name = "btnRunTests";
            this.btnRunTests.Size = new System.Drawing.Size(101, 30);
            this.btnRunTests.TabIndex = 4;
            this.btnRunTests.Text = "Run Tests";
            this.btnRunTests.UseVisualStyleBackColor = true;
            this.btnRunTests.Click += new System.EventHandler(this.btnRunTests_Click);
            // 
            // lblDisabled
            // 
            this.lblDisabled.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblDisabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisabled.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisabled.ForeColor = System.Drawing.Color.Black;
            this.lblDisabled.Location = new System.Drawing.Point(152, 0);
            this.lblDisabled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisabled.Name = "lblDisabled";
            this.lblDisabled.Size = new System.Drawing.Size(140, 40);
            this.lblDisabled.TabIndex = 3;
            this.lblDisabled.Text = "Inactive";
            this.lblDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisabled.Click += new System.EventHandler(this.lblDisabled_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrent.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.ForeColor = System.Drawing.Color.White;
            this.lblCurrent.Location = new System.Drawing.Point(0, 0);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(152, 40);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "Active";
            this.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrent.Click += new System.EventHandler(this.lblCurrent_Click);
            // 
            // cmbCurrentProvider
            // 
            this.cmbCurrentProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrentProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurrentProvider.FormattingEnabled = true;
            this.cmbCurrentProvider.Location = new System.Drawing.Point(3, 31);
            this.cmbCurrentProvider.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbCurrentProvider.Name = "cmbCurrentProvider";
            this.cmbCurrentProvider.Size = new System.Drawing.Size(268, 28);
            this.cmbCurrentProvider.TabIndex = 5;
            this.cmbCurrentProvider.SelectedIndexChanged += new System.EventHandler(this.cmbCurrentProvider_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Provider";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.panel2);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(0, 56);
            this.pnlFilters.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(760, 64);
            this.pnlFilters.TabIndex = 11;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRule.Image = global::C_DentalClaimTracker.Properties.Resources.bullet_add;
            this.btnAddRule.Location = new System.Drawing.Point(622, 0);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(137, 54);
            this.btnAddRule.TabIndex = 10;
            this.btnAddRule.Text = "&Add Restriction";
            this.btnAddRule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // pnlEnabled
            // 
            this.pnlEnabled.AutoScroll = true;
            this.pnlEnabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEnabled.Location = new System.Drawing.Point(2, 43);
            this.pnlEnabled.Name = "pnlEnabled";
            this.pnlEnabled.Size = new System.Drawing.Size(756, 330);
            this.pnlEnabled.TabIndex = 4;
            // 
            // pnlDisabled
            // 
            this.pnlDisabled.AutoScroll = true;
            this.pnlDisabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisabled.Location = new System.Drawing.Point(2, 43);
            this.pnlDisabled.Name = "pnlDisabled";
            this.pnlDisabled.Size = new System.Drawing.Size(756, 330);
            this.pnlDisabled.TabIndex = 5;
            this.pnlDisabled.Visible = false;
            // 
            // chkShowXProviders
            // 
            this.chkShowXProviders.AutoSize = true;
            this.chkShowXProviders.Location = new System.Drawing.Point(276, 36);
            this.chkShowXProviders.Name = "chkShowXProviders";
            this.chkShowXProviders.Size = new System.Drawing.Size(156, 20);
            this.chkShowXProviders.TabIndex = 7;
            this.chkShowXProviders.Text = "Show \'X\' Providers";
            this.chkShowXProviders.UseVisualStyleBackColor = true;
            this.chkShowXProviders.CheckedChanged += new System.EventHandler(this.chkShowXProviders_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblDisabled);
            this.panel4.Controls.Add(this.lblCurrent);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(756, 40);
            this.panel4.TabIndex = 6;
            // 
            // frmProviderEligibilityRestrictions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 543);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblSearchOptions);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmProviderEligibilityRestrictions";
            this.Text = "Provider Eligibility Restrictions";
            this.Load += new System.EventHandler(this.frmProviderEligibilityRestrictions_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlDisplay.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.providereligibilityrestrictionsBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSearchOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblDisabled;
        private System.Windows.Forms.Button btnRunTests;
        private System.Windows.Forms.BindingSource providereligibilityrestrictionsBindingSource;
        private System.Windows.Forms.ComboBox cmbCurrentProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDisabled;
        private System.Windows.Forms.Panel pnlEnabled;
        private System.Windows.Forms.CheckBox chkShowXProviders;
        private System.Windows.Forms.Panel panel4;
    }
}