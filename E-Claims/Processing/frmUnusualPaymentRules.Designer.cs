namespace C_DentalClaimTracker
{
    partial class frmUnusualPaymentRules
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
            this.grpAddNew = new System.Windows.Forms.GroupBox();
            this.cmdAddNew = new System.Windows.Forms.Button();
            this.ctlUnusualPaymentRuleAddNew = new C_DentalClaimTracker.ctlUnusualPaymentRule();
            this.grpExistingRules = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.grpAddNew.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddNew
            // 
            this.grpAddNew.Controls.Add(this.cmdAddNew);
            this.grpAddNew.Controls.Add(this.ctlUnusualPaymentRuleAddNew);
            this.grpAddNew.Location = new System.Drawing.Point(12, 12);
            this.grpAddNew.Name = "grpAddNew";
            this.grpAddNew.Size = new System.Drawing.Size(600, 52);
            this.grpAddNew.TabIndex = 1;
            this.grpAddNew.TabStop = false;
            this.grpAddNew.Text = "Add New Rule";
            // 
            // cmdAddNew
            // 
            this.cmdAddNew.Image = global::C_DentalClaimTracker.Properties.Resources.add;
            this.cmdAddNew.Location = new System.Drawing.Point(541, 19);
            this.cmdAddNew.Name = "cmdAddNew";
            this.cmdAddNew.Size = new System.Drawing.Size(53, 27);
            this.cmdAddNew.TabIndex = 1;
            this.cmdAddNew.Text = "&Add";
            this.cmdAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAddNew.UseVisualStyleBackColor = true;
            this.cmdAddNew.Click += new System.EventHandler(this.cmdAddNew_Click);
            // 
            // ctlUnusualPaymentRuleAddNew
            // 
            this.ctlUnusualPaymentRuleAddNew.AutoSave = false;
            this.ctlUnusualPaymentRuleAddNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlUnusualPaymentRuleAddNew.LinkedRule = null;
            this.ctlUnusualPaymentRuleAddNew.Location = new System.Drawing.Point(6, 19);
            this.ctlUnusualPaymentRuleAddNew.Name = "ctlUnusualPaymentRuleAddNew";
            this.ctlUnusualPaymentRuleAddNew.OrderID = 0;
            this.ctlUnusualPaymentRuleAddNew.Size = new System.Drawing.Size(529, 25);
            this.ctlUnusualPaymentRuleAddNew.TabIndex = 0;
            // 
            // grpExistingRules
            // 
            this.grpExistingRules.Location = new System.Drawing.Point(12, 70);
            this.grpExistingRules.Name = "grpExistingRules";
            this.grpExistingRules.Size = new System.Drawing.Size(600, 266);
            this.grpExistingRules.TabIndex = 2;
            this.grpExistingRules.TabStop = false;
            this.grpExistingRules.Text = "Existing Rules";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 32);
            this.panel1.TabIndex = 3;
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdClose.Location = new System.Drawing.Point(276, 6);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmUnusualPaymentRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpExistingRules);
            this.Controls.Add(this.grpAddNew);
            this.Name = "frmUnusualPaymentRules";
            this.Text = "Unusual Payment Rules";
            this.Load += new System.EventHandler(this.frmUnusualPaymentRules_Load);
            this.grpAddNew.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddNew;
        private ctlUnusualPaymentRule ctlUnusualPaymentRuleAddNew;
        private System.Windows.Forms.Button cmdAddNew;
        private System.Windows.Forms.GroupBox grpExistingRules;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdClose;
    }
}