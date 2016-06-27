namespace C_DentalClaimTracker
{
    partial class frmApexRulesEdit
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPrimary = new System.Windows.Forms.CheckBox();
            this.chkSecondary = new System.Windows.Forms.CheckBox();
            this.chkPredeterm = new System.Windows.Forms.CheckBox();
            this.txtProcFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstProcFilterList = new System.Windows.Forms.ListBox();
            this.cmdAddProcedure = new System.Windows.Forms.Button();
            this.cmdAddInsuranceFilter = new System.Windows.Forms.Button();
            this.lstInsuranceFilters = new System.Windows.Forms.ListBox();
            this.txtInsuranceFilter = new System.Windows.Forms.TextBox();
            this.lstInsuranceMatches = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRuleText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstProcMatches = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(38, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 22);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "applies to";
            // 
            // chkPrimary
            // 
            this.chkPrimary.AutoSize = true;
            this.chkPrimary.Location = new System.Drawing.Point(232, 24);
            this.chkPrimary.Name = "chkPrimary";
            this.chkPrimary.Size = new System.Drawing.Size(60, 17);
            this.chkPrimary.TabIndex = 3;
            this.chkPrimary.Text = "Primary";
            this.chkPrimary.UseVisualStyleBackColor = true;
            // 
            // chkSecondary
            // 
            this.chkSecondary.AutoSize = true;
            this.chkSecondary.Location = new System.Drawing.Point(298, 24);
            this.chkSecondary.Name = "chkSecondary";
            this.chkSecondary.Size = new System.Drawing.Size(77, 17);
            this.chkSecondary.TabIndex = 4;
            this.chkSecondary.Text = "Secondary";
            this.chkSecondary.UseVisualStyleBackColor = true;
            // 
            // chkPredeterm
            // 
            this.chkPredeterm.AutoSize = true;
            this.chkPredeterm.Location = new System.Drawing.Point(381, 24);
            this.chkPredeterm.Name = "chkPredeterm";
            this.chkPredeterm.Size = new System.Drawing.Size(74, 17);
            this.chkPredeterm.TabIndex = 5;
            this.chkPredeterm.Text = "Predeterm";
            this.chkPredeterm.UseVisualStyleBackColor = true;
            // 
            // txtProcFilter
            // 
            this.txtProcFilter.Location = new System.Drawing.Point(6, 19);
            this.txtProcFilter.Name = "txtProcFilter";
            this.txtProcFilter.Size = new System.Drawing.Size(130, 20);
            this.txtProcFilter.TabIndex = 7;
            this.txtProcFilter.Leave += new System.EventHandler(this.txtProcFilter_Leave);
            this.txtProcFilter.Enter += new System.EventHandler(this.txtProcFilter_Enter);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 171);
            this.label4.TabIndex = 8;
            this.label4.Text = "Help: \r\n\r\nType a specific code above or use sql to specify a group of codes. Not " +
                "case sensitive.\r\n\r\nExamples:\r\n\r\nD1110\r\nD1%\r\n%27%\r\n";
            // 
            // lstProcFilterList
            // 
            this.lstProcFilterList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProcFilterList.FormattingEnabled = true;
            this.lstProcFilterList.IntegralHeight = false;
            this.lstProcFilterList.Location = new System.Drawing.Point(200, 32);
            this.lstProcFilterList.Name = "lstProcFilterList";
            this.lstProcFilterList.Size = new System.Drawing.Size(252, 181);
            this.lstProcFilterList.TabIndex = 9;
            this.lstProcFilterList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstProcFilterList_KeyDown);
            // 
            // cmdAddProcedure
            // 
            this.cmdAddProcedure.Location = new System.Drawing.Point(142, 18);
            this.cmdAddProcedure.Name = "cmdAddProcedure";
            this.cmdAddProcedure.Size = new System.Drawing.Size(52, 23);
            this.cmdAddProcedure.TabIndex = 10;
            this.cmdAddProcedure.Text = "Add";
            this.cmdAddProcedure.UseVisualStyleBackColor = true;
            this.cmdAddProcedure.Click += new System.EventHandler(this.cmdAddProcedure_Click);
            // 
            // cmdAddInsuranceFilter
            // 
            this.cmdAddInsuranceFilter.Location = new System.Drawing.Point(142, 18);
            this.cmdAddInsuranceFilter.Name = "cmdAddInsuranceFilter";
            this.cmdAddInsuranceFilter.Size = new System.Drawing.Size(52, 23);
            this.cmdAddInsuranceFilter.TabIndex = 15;
            this.cmdAddInsuranceFilter.Text = "Add";
            this.cmdAddInsuranceFilter.UseVisualStyleBackColor = true;
            this.cmdAddInsuranceFilter.Click += new System.EventHandler(this.cmdAddInsuranceFilter_Click);
            // 
            // lstInsuranceFilters
            // 
            this.lstInsuranceFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstInsuranceFilters.FormattingEnabled = true;
            this.lstInsuranceFilters.IntegralHeight = false;
            this.lstInsuranceFilters.Location = new System.Drawing.Point(200, 42);
            this.lstInsuranceFilters.Name = "lstInsuranceFilters";
            this.lstInsuranceFilters.Size = new System.Drawing.Size(259, 142);
            this.lstInsuranceFilters.TabIndex = 14;
            this.lstInsuranceFilters.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstInsuranceFilters_KeyDown);
            // 
            // txtInsuranceFilter
            // 
            this.txtInsuranceFilter.Location = new System.Drawing.Point(6, 19);
            this.txtInsuranceFilter.Name = "txtInsuranceFilter";
            this.txtInsuranceFilter.Size = new System.Drawing.Size(130, 20);
            this.txtInsuranceFilter.TabIndex = 12;
            this.txtInsuranceFilter.Leave += new System.EventHandler(this.txtInsuranceFilter_Leave);
            this.txtInsuranceFilter.Enter += new System.EventHandler(this.txtInsuranceFilter_Enter);
            // 
            // lstInsuranceMatches
            // 
            this.lstInsuranceMatches.FormattingEnabled = true;
            this.lstInsuranceMatches.IntegralHeight = false;
            this.lstInsuranceMatches.Items.AddRange(new object[] {
            "(Under construction...)"});
            this.lstInsuranceMatches.Location = new System.Drawing.Point(6, 58);
            this.lstInsuranceMatches.Name = "lstInsuranceMatches";
            this.lstInsuranceMatches.Size = new System.Drawing.Size(188, 126);
            this.lstInsuranceMatches.TabIndex = 16;
            this.lstInsuranceMatches.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRuleText);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkPrimary);
            this.groupBox1.Controls.Add(this.chkSecondary);
            this.groupBox1.Controls.Add(this.chkPredeterm);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 112);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rule Name";
            // 
            // txtRuleText
            // 
            this.txtRuleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuleText.Location = new System.Drawing.Point(38, 47);
            this.txtRuleText.MaxLength = 255;
            this.txtRuleText.Multiline = true;
            this.txtRuleText.Name = "txtRuleText";
            this.txtRuleText.Size = new System.Drawing.Size(411, 59);
            this.txtRuleText.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Text";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lstProcMatches);
            this.groupBox2.Controls.Add(this.txtProcFilter);
            this.groupBox2.Controls.Add(this.lstProcFilterList);
            this.groupBox2.Controls.Add(this.cmdAddProcedure);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 220);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procedure Code Filter";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Filter List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Matches";
            this.label1.Visible = false;
            // 
            // lstProcMatches
            // 
            this.lstProcMatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstProcMatches.FormattingEnabled = true;
            this.lstProcMatches.IntegralHeight = false;
            this.lstProcMatches.Items.AddRange(new object[] {
            "(Under construction...)"});
            this.lstProcMatches.Location = new System.Drawing.Point(6, 58);
            this.lstProcMatches.Name = "lstProcMatches";
            this.lstProcMatches.Size = new System.Drawing.Size(188, 78);
            this.lstProcMatches.TabIndex = 19;
            this.lstProcMatches.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtInsuranceFilter);
            this.groupBox3.Controls.Add(this.lstInsuranceFilters);
            this.groupBox3.Controls.Add(this.cmdAddInsuranceFilter);
            this.groupBox3.Controls.Add(this.lstInsuranceMatches);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 192);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insurance Company Filter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Matches";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Filter List";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdCancel);
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 581);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 61);
            this.panel1.TabIndex = 20;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Image = global::C_DentalClaimTracker.Properties.Resources.cancel;
            this.cmdCancel.Location = new System.Drawing.Point(256, 27);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(82, 29);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Image = global::C_DentalClaimTracker.Properties.Resources.accept;
            this.cmdSave.Location = new System.Drawing.Point(344, 3);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(112, 53);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "&Save";
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 57);
            this.panel2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(459, 55);
            this.label7.TabIndex = 0;
            this.label7.Text = "Edit Apex Rule";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.BackColor = System.Drawing.Color.Cornsilk;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(6, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 140);
            this.label10.TabIndex = 24;
            this.label10.Text = "Type a specific company name or use sql to specify a group of codes. Not case sen" +
                "sitive.";
            // 
            // frmApexRulesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(461, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmApexRulesEdit";
            this.Text = "Edit Apex Rule";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkPrimary;
        private System.Windows.Forms.CheckBox chkSecondary;
        private System.Windows.Forms.CheckBox chkPredeterm;
        private System.Windows.Forms.TextBox txtProcFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstProcFilterList;
        private System.Windows.Forms.Button cmdAddProcedure;
        private System.Windows.Forms.Button cmdAddInsuranceFilter;
        private System.Windows.Forms.ListBox lstInsuranceFilters;
        private System.Windows.Forms.TextBox txtInsuranceFilter;
        private System.Windows.Forms.ListBox lstInsuranceMatches;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstProcMatches;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRuleText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}