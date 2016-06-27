namespace C_DentalClaimTracker
{
    partial class frmEditMultipleChoiceQuestions
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
            this.lblActualQuestionText = new System.Windows.Forms.Label();
            this.lblquestionText = new System.Windows.Forms.Label();
            this.lstAnswerList = new System.Windows.Forms.ListBox();
            this.ctextAnswerBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveTotopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movedownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveTobottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMoveTop = new System.Windows.Forms.Label();
            this.lblMoveUp = new System.Windows.Forms.Label();
            this.lblMoveDown = new System.Windows.Forms.Label();
            this.lblMoveBottom = new System.Windows.Forms.Label();
            this.txtAnswerText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.lnkAddNew = new System.Windows.Forms.LinkLabel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.ctextAnswerBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActualQuestionText
            // 
            this.lblActualQuestionText.BackColor = System.Drawing.Color.White;
            this.lblActualQuestionText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActualQuestionText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualQuestionText.Location = new System.Drawing.Point(0, 0);
            this.lblActualQuestionText.Name = "lblActualQuestionText";
            this.lblActualQuestionText.Size = new System.Drawing.Size(677, 22);
            this.lblActualQuestionText.TabIndex = 11;
            this.lblActualQuestionText.Text = "Editing answer for question:";
            this.lblActualQuestionText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblquestionText
            // 
            this.lblquestionText.BackColor = System.Drawing.Color.White;
            this.lblquestionText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblquestionText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestionText.Location = new System.Drawing.Point(0, 22);
            this.lblquestionText.Name = "lblquestionText";
            this.lblquestionText.Size = new System.Drawing.Size(677, 22);
            this.lblquestionText.TabIndex = 12;
            this.lblquestionText.Text = "question text...";
            this.lblquestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstAnswerList
            // 
            this.lstAnswerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAnswerList.ContextMenuStrip = this.ctextAnswerBox;
            this.lstAnswerList.FormattingEnabled = true;
            this.lstAnswerList.IntegralHeight = false;
            this.lstAnswerList.Location = new System.Drawing.Point(11, 80);
            this.lstAnswerList.Name = "lstAnswerList";
            this.lstAnswerList.Size = new System.Drawing.Size(638, 108);
            this.lstAnswerList.TabIndex = 13;
            this.lstAnswerList.SelectedIndexChanged += new System.EventHandler(this.lstAnswerList_SelectedIndexChanged);
            // 
            // ctextAnswerBox
            // 
            this.ctextAnswerBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveTotopToolStripMenuItem,
            this.moveUpToolStripMenuItem,
            this.movedownToolStripMenuItem,
            this.moveTobottomToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewToolStripMenuItem,
            this.mnuDelete});
            this.ctextAnswerBox.Name = "contextMenuStrip1";
            this.ctextAnswerBox.Size = new System.Drawing.Size(162, 142);
            // 
            // moveTotopToolStripMenuItem
            // 
            this.moveTotopToolStripMenuItem.Name = "moveTotopToolStripMenuItem";
            this.moveTotopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.moveTotopToolStripMenuItem.Text = "Move to &top";
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.moveUpToolStripMenuItem.Text = "Move &up";
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
            // 
            // movedownToolStripMenuItem
            // 
            this.movedownToolStripMenuItem.Name = "movedownToolStripMenuItem";
            this.movedownToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.movedownToolStripMenuItem.Text = "Move &down";
            // 
            // moveTobottomToolStripMenuItem
            // 
            this.moveTobottomToolStripMenuItem.Name = "moveTobottomToolStripMenuItem";
            this.moveTobottomToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.moveTobottomToolStripMenuItem.Text = "Move to &bottom";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 6);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addNewToolStripMenuItem.Text = "&Add new";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(161, 22);
            this.mnuDelete.Text = "&Delete";
            this.mnuDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(642, 127);
            this.label3.TabIndex = 14;
            this.label3.Text = "Current Answers";
            // 
            // lblMoveTop
            // 
            this.lblMoveTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoveTop.AutoSize = true;
            this.lblMoveTop.Font = new System.Drawing.Font("Wingdings 3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblMoveTop.ForeColor = System.Drawing.Color.Blue;
            this.lblMoveTop.Location = new System.Drawing.Point(653, 80);
            this.lblMoveTop.Name = "lblMoveTop";
            this.lblMoveTop.Size = new System.Drawing.Size(24, 25);
            this.lblMoveTop.TabIndex = 19;
            this.lblMoveTop.Text = "+";
            this.lblMoveTop.Click += new System.EventHandler(this.lblMoveTop_Click);
            // 
            // lblMoveUp
            // 
            this.lblMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoveUp.AutoSize = true;
            this.lblMoveUp.Font = new System.Drawing.Font("Wingdings 3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblMoveUp.ForeColor = System.Drawing.Color.Blue;
            this.lblMoveUp.Location = new System.Drawing.Point(653, 107);
            this.lblMoveUp.Name = "lblMoveUp";
            this.lblMoveUp.Size = new System.Drawing.Size(24, 25);
            this.lblMoveUp.TabIndex = 20;
            this.lblMoveUp.Text = "#";
            this.lblMoveUp.Click += new System.EventHandler(this.lblMoveUp_Click);
            // 
            // lblMoveDown
            // 
            this.lblMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoveDown.AutoSize = true;
            this.lblMoveDown.Font = new System.Drawing.Font("Wingdings 3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblMoveDown.ForeColor = System.Drawing.Color.Blue;
            this.lblMoveDown.Location = new System.Drawing.Point(653, 134);
            this.lblMoveDown.Name = "lblMoveDown";
            this.lblMoveDown.Size = new System.Drawing.Size(24, 25);
            this.lblMoveDown.TabIndex = 21;
            this.lblMoveDown.Text = "$";
            this.lblMoveDown.Click += new System.EventHandler(this.lblMoveDown_Click);
            // 
            // lblMoveBottom
            // 
            this.lblMoveBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoveBottom.AutoSize = true;
            this.lblMoveBottom.Font = new System.Drawing.Font("Wingdings 3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblMoveBottom.ForeColor = System.Drawing.Color.Blue;
            this.lblMoveBottom.Location = new System.Drawing.Point(653, 161);
            this.lblMoveBottom.Name = "lblMoveBottom";
            this.lblMoveBottom.Size = new System.Drawing.Size(24, 25);
            this.lblMoveBottom.TabIndex = 22;
            this.lblMoveBottom.Text = ",";
            this.lblMoveBottom.Click += new System.EventHandler(this.lblMoveBottom_Click);
            // 
            // txtAnswerText
            // 
            this.txtAnswerText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnswerText.Location = new System.Drawing.Point(12, 229);
            this.txtAnswerText.Name = "txtAnswerText";
            this.txtAnswerText.Size = new System.Drawing.Size(637, 20);
            this.txtAnswerText.TabIndex = 23;
            this.txtAnswerText.Leave += new System.EventHandler(this.txtAnswerText_Leave);
            this.txtAnswerText.Enter += new System.EventHandler(this.txtAnswerText_Enter);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Location = new System.Drawing.Point(9, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(642, 39);
            this.label6.TabIndex = 24;
            this.label6.Text = "Answer Text";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(590, 255);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(61, 23);
            this.cmdSave.TabIndex = 25;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(11, 255);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(61, 23);
            this.cmdDelete.TabIndex = 26;
            this.cmdDelete.Text = "&Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // lnkAddNew
            // 
            this.lnkAddNew.AutoSize = true;
            this.lnkAddNew.Location = new System.Drawing.Point(591, 191);
            this.lnkAddNew.Name = "lnkAddNew";
            this.lnkAddNew.Size = new System.Drawing.Size(58, 13);
            this.lnkAddNew.TabIndex = 27;
            this.lnkAddNew.TabStop = true;
            this.lnkAddNew.Text = "Add new...";
            this.lnkAddNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddNew_LinkClicked);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdClose.Location = new System.Drawing.Point(308, 3);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(61, 23);
            this.cmdClose.TabIndex = 28;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 28);
            this.panel1.TabIndex = 29;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(523, 255);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(61, 23);
            this.cmdCancel.TabIndex = 30;
            this.cmdCancel.Text = "C&ancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmEditMultipleChoiceQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdClose;
            this.ClientSize = new System.Drawing.Size(677, 306);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lnkAddNew);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.txtAnswerText);
            this.Controls.Add(this.lblMoveBottom);
            this.Controls.Add(this.lblMoveDown);
            this.Controls.Add(this.lblMoveUp);
            this.Controls.Add(this.lblMoveTop);
            this.Controls.Add(this.lstAnswerList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblquestionText);
            this.Controls.Add(this.lblActualQuestionText);
            this.Controls.Add(this.label6);
            this.Name = "frmEditMultipleChoiceQuestions";
            this.Text = "Edit Multiple Choice Options";
            this.ctextAnswerBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActualQuestionText;
        private System.Windows.Forms.Label lblquestionText;
        private System.Windows.Forms.ListBox lstAnswerList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMoveTop;
        private System.Windows.Forms.Label lblMoveUp;
        private System.Windows.Forms.Label lblMoveDown;
        private System.Windows.Forms.Label lblMoveBottom;
        private System.Windows.Forms.TextBox txtAnswerText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.LinkLabel lnkAddNew;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip ctextAnswerBox;
        private System.Windows.Forms.ToolStripMenuItem moveTotopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movedownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveTobottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.Button cmdCancel;
    }
}