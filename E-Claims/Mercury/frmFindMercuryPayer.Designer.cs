namespace C_DentalClaimTracker.E_Claims.Mercury
{
    partial class frmFindMercuryPayer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstAllPayers = new System.Windows.Forms.ListBox();
            this.lblAllPayers = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstSearchResults = new System.Windows.Forms.ListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSelectPayer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtProviderName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProviderInfo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtOverrideCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUseCode = new System.Windows.Forms.Button();
            this.ttipMain = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lstAllPayers);
            this.panel1.Controls.Add(this.lblAllPayers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 454);
            this.panel1.TabIndex = 0;
            // 
            // lstAllPayers
            // 
            this.lstAllPayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAllPayers.FormattingEnabled = true;
            this.lstAllPayers.IntegralHeight = false;
            this.lstAllPayers.Location = new System.Drawing.Point(0, 37);
            this.lstAllPayers.Name = "lstAllPayers";
            this.lstAllPayers.Size = new System.Drawing.Size(81, 415);
            this.lstAllPayers.TabIndex = 0;
            this.lstAllPayers.DoubleClick += new System.EventHandler(this.lstAllPayers_DoubleClick);
            // 
            // lblAllPayers
            // 
            this.lblAllPayers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblAllPayers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAllPayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllPayers.Location = new System.Drawing.Point(0, 0);
            this.lblAllPayers.Name = "lblAllPayers";
            this.lblAllPayers.Size = new System.Drawing.Size(81, 37);
            this.lblAllPayers.TabIndex = 2;
            this.lblAllPayers.Text = "All Payers";
            this.lblAllPayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstSearchResults);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 454);
            this.panel2.TabIndex = 1;
            // 
            // lstSearchResults
            // 
            this.lstSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSearchResults.FormattingEnabled = true;
            this.lstSearchResults.Location = new System.Drawing.Point(0, 94);
            this.lstSearchResults.Name = "lstSearchResults";
            this.lstSearchResults.Size = new System.Drawing.Size(600, 303);
            this.lstSearchResults.TabIndex = 30;
            this.lstSearchResults.DoubleClick += new System.EventHandler(this.lstSearchResults_DoubleClick);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnSelectPayer);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 397);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(600, 57);
            this.panel6.TabIndex = 29;
            // 
            // btnSelectPayer
            // 
            this.btnSelectPayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectPayer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPayer.Image = global::C_DentalClaimTracker.Properties.Resources.accept;
            this.btnSelectPayer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectPayer.Location = new System.Drawing.Point(453, 6);
            this.btnSelectPayer.Name = "btnSelectPayer";
            this.btnSelectPayer.Size = new System.Drawing.Size(140, 46);
            this.btnSelectPayer.TabIndex = 2;
            this.btnSelectPayer.Text = "&Select";
            this.btnSelectPayer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSelectPayer.UseVisualStyleBackColor = true;
            this.btnSelectPayer.Click += new System.EventHandler(this.btnSelectPayer_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Matching Payers";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.txtProviderName);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.btnSearch);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 57);
            this.panel5.TabIndex = 1;
            // 
            // txtProviderName
            // 
            this.txtProviderName.Location = new System.Drawing.Point(101, 7);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.Size = new System.Drawing.Size(100, 20);
            this.txtProviderName.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Provider Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::C_DentalClaimTracker.Properties.Resources.arrow_rotate_clockwise;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(207, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 46);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "&Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblProviderInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 37);
            this.panel3.TabIndex = 2;
            // 
            // lblProviderInfo
            // 
            this.lblProviderInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblProviderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProviderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProviderInfo.ForeColor = System.Drawing.Color.White;
            this.lblProviderInfo.Location = new System.Drawing.Point(0, 0);
            this.lblProviderInfo.Name = "lblProviderInfo";
            this.lblProviderInfo.Size = new System.Drawing.Size(687, 37);
            this.lblProviderInfo.TabIndex = 1;
            this.lblProviderInfo.Text = "AARP";
            this.lblProviderInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttipMain.SetToolTip(this.lblProviderInfo, "The name of the provider as it appears in Dentrix");
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 491);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(687, 48);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(200, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "If there is no match listed, you may manually enter a code here.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtOverrideCode);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.btnUseCode);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 46);
            this.panel7.TabIndex = 4;
            // 
            // txtOverrideCode
            // 
            this.txtOverrideCode.Location = new System.Drawing.Point(6, 20);
            this.txtOverrideCode.Name = "txtOverrideCode";
            this.txtOverrideCode.Size = new System.Drawing.Size(100, 20);
            this.txtOverrideCode.TabIndex = 2;
            this.txtOverrideCode.Text = "GENERIC";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Override Code";
            // 
            // btnUseCode
            // 
            this.btnUseCode.BackColor = System.Drawing.Color.Silver;
            this.btnUseCode.Location = new System.Drawing.Point(112, 18);
            this.btnUseCode.Name = "btnUseCode";
            this.btnUseCode.Size = new System.Drawing.Size(78, 24);
            this.btnUseCode.TabIndex = 3;
            this.btnUseCode.Text = "Use Code";
            this.btnUseCode.UseVisualStyleBackColor = false;
            this.btnUseCode.Click += new System.EventHandler(this.btnUseCode_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 37);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(687, 454);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 25;
            // 
            // frmFindMercuryPayer
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 539);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "frmFindMercuryPayer";
            this.Text = "Select Mercury Payer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFindMercuryPayer_FormClosing);
            this.Load += new System.EventHandler(this.frmFindMercuryPayer_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstAllPayers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblProviderInfo;
        private System.Windows.Forms.ToolTip ttipMain;
        private System.Windows.Forms.Label lblAllPayers;
        private System.Windows.Forms.TextBox txtOverrideCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUseCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtProviderName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSelectPayer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListBox lstSearchResults;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}