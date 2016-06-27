namespace C_DentalClaimTracker
{
    partial class frmStatusManager
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
            this.lstStatusList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdMoveDown = new System.Windows.Forms.Button();
            this.cmdMoveUp = new System.Windows.Forms.Button();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.txtClassifications = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstStatusList
            // 
            this.lstStatusList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStatusList.FormattingEnabled = true;
            this.lstStatusList.IntegralHeight = false;
            this.lstStatusList.Location = new System.Drawing.Point(0, 24);
            this.lstStatusList.Name = "lstStatusList";
            this.lstStatusList.Size = new System.Drawing.Size(263, 282);
            this.lstStatusList.TabIndex = 0;
            this.lstStatusList.SelectedIndexChanged += new System.EventHandler(this.lstStatusList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(3, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(351, 20);
            this.txtName.TabIndex = 6;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(3, 94);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(351, 104);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdAdd.Image = global::C_DentalClaimTracker.Properties.Resources.add;
            this.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAdd.Location = new System.Drawing.Point(167, 5);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(91, 48);
            this.cmdAdd.TabIndex = 8;
            this.cmdAdd.Text = " &Add";
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdMoveDown
            // 
            this.cmdMoveDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdMoveDown.Image = global::C_DentalClaimTracker.Properties.Resources.arrow_down;
            this.cmdMoveDown.Location = new System.Drawing.Point(0, 54);
            this.cmdMoveDown.Name = "cmdMoveDown";
            this.cmdMoveDown.Size = new System.Drawing.Size(33, 54);
            this.cmdMoveDown.TabIndex = 5;
            this.cmdMoveDown.UseVisualStyleBackColor = true;
            this.cmdMoveDown.Click += new System.EventHandler(this.cmdMoveDown_Click);
            // 
            // cmdMoveUp
            // 
            this.cmdMoveUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdMoveUp.Image = global::C_DentalClaimTracker.Properties.Resources.arrow_up;
            this.cmdMoveUp.Location = new System.Drawing.Point(0, 0);
            this.cmdMoveUp.Name = "cmdMoveUp";
            this.cmdMoveUp.Size = new System.Drawing.Size(33, 54);
            this.cmdMoveUp.TabIndex = 4;
            this.cmdMoveUp.UseVisualStyleBackColor = true;
            this.cmdMoveUp.Click += new System.EventHandler(this.cmdMoveUp_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdRemove.Image = global::C_DentalClaimTracker.Properties.Resources.cancel;
            this.cmdRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRemove.Location = new System.Drawing.Point(3, 29);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(72, 24);
            this.cmdRemove.TabIndex = 9;
            this.cmdRemove.Text = "&Remove";
            this.cmdRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // txtClassifications
            // 
            this.txtClassifications.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtClassifications.Location = new System.Drawing.Point(0, 219);
            this.txtClassifications.Multiline = true;
            this.txtClassifications.Name = "txtClassifications";
            this.txtClassifications.ReadOnly = true;
            this.txtClassifications.Size = new System.Drawing.Size(366, 147);
            this.txtClassifications.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Classifications with this status";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 30);
            this.panel1.TabIndex = 12;
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Location = new System.Drawing.Point(280, 3);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.lstStatusList);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chkVisible);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtClassifications);
            this.splitContainer1.Panel2.Controls.Add(this.txtName);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtDescription);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(633, 366);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmdRemove);
            this.panel2.Controls.Add(this.cmdAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 60);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdMoveDown);
            this.panel3.Controls.Add(this.cmdMoveUp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(230, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(33, 282);
            this.panel3.TabIndex = 13;
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Enabled = false;
            this.chkVisible.Location = new System.Drawing.Point(13, 56);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(113, 17);
            this.chkVisible.TabIndex = 12;
            this.chkVisible.Text = "Is User Assignable";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.Leave += new System.EventHandler(this.chkVisible_Leave);
            // 
            // frmStatusManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdClose;
            this.ClientSize = new System.Drawing.Size(633, 396);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmStatusManager";
            this.Text = "Status Manager";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstStatusList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdMoveUp;
        private System.Windows.Forms.Button cmdMoveDown;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.TextBox txtClassifications;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkVisible;
    }
}