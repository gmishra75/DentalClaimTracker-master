namespace C_DentalClaimTracker
{
    partial class CallManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallManager));
            this.pnlNotes = new System.Windows.Forms.Panel();
            this.splCallManager = new System.Windows.Forms.Splitter();
            this.pnlCall = new System.Windows.Forms.Panel();
            this.tvwCall = new System.Windows.Forms.TreeView();
            this.imgCallIcons = new System.Windows.Forms.ImageList(this.components);
            this.pnlDataEntry = new System.Windows.Forms.Panel();
            this.cmdClearAnswer = new System.Windows.Forms.Button();
            this.pnlChoiceLargeText = new System.Windows.Forms.Panel();
            this.txtLarge = new System.Windows.Forms.TextBox();
            this.pnlChoiceDate = new System.Windows.Forms.Panel();
            this.pnlChoiceYesNo = new System.Windows.Forms.Panel();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.pnlChoiceNumeric = new System.Windows.Forms.Panel();
            this.numNumber = new System.Windows.Forms.NumericUpDown();
            this.pnlChoiceNormalText = new System.Windows.Forms.Panel();
            this.txtNormal = new System.Windows.Forms.TextBox();
            this.pnlChoiceSmallText = new System.Windows.Forms.Panel();
            this.txtSmall = new System.Windows.Forms.TextBox();
            this.pnlChoiceCategory = new System.Windows.Forms.Panel();
            this.pnlChoiceMultiple = new System.Windows.Forms.Panel();
            this.cmbMultipleChoice = new System.Windows.Forms.ComboBox();
            this.lblDataDescription = new System.Windows.Forms.Label();
            this.tmrOnHold = new System.Windows.Forms.Timer(this.components);
            this.pnlCallControls = new System.Windows.Forms.Panel();
            this.btnHoldCall = new System.Windows.Forms.Button();
            this.btnLogCall = new System.Windows.Forms.Button();
            this.ctlDate = new C_DentalClaimTracker.ctlDateEntry();
            this.notesGrid = new C_DentalClaimTracker.NotesGrid();
            this.pnlNotes.SuspendLayout();
            this.pnlCall.SuspendLayout();
            this.pnlDataEntry.SuspendLayout();
            this.pnlChoiceLargeText.SuspendLayout();
            this.pnlChoiceDate.SuspendLayout();
            this.pnlChoiceYesNo.SuspendLayout();
            this.pnlChoiceNumeric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            this.pnlChoiceNormalText.SuspendLayout();
            this.pnlChoiceSmallText.SuspendLayout();
            this.pnlChoiceMultiple.SuspendLayout();
            this.pnlCallControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNotes
            // 
            this.pnlNotes.Controls.Add(this.notesGrid);
            this.pnlNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNotes.Location = new System.Drawing.Point(0, 0);
            this.pnlNotes.Name = "pnlNotes";
            this.pnlNotes.Size = new System.Drawing.Size(686, 142);
            this.pnlNotes.TabIndex = 0;
            // 
            // splCallManager
            // 
            this.splCallManager.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splCallManager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splCallManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.splCallManager.Location = new System.Drawing.Point(0, 142);
            this.splCallManager.MinExtra = 50;
            this.splCallManager.Name = "splCallManager";
            this.splCallManager.Size = new System.Drawing.Size(686, 10);
            this.splCallManager.TabIndex = 1;
            this.splCallManager.TabStop = false;
            // 
            // pnlCall
            // 
            this.pnlCall.Controls.Add(this.tvwCall);
            this.pnlCall.Controls.Add(this.pnlDataEntry);
            this.pnlCall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCall.Location = new System.Drawing.Point(0, 152);
            this.pnlCall.Name = "pnlCall";
            this.pnlCall.Size = new System.Drawing.Size(686, 367);
            this.pnlCall.TabIndex = 2;
            // 
            // tvwCall
            // 
            this.tvwCall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwCall.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.tvwCall.HideSelection = false;
            this.tvwCall.ImageIndex = 0;
            this.tvwCall.ImageList = this.imgCallIcons;
            this.tvwCall.Location = new System.Drawing.Point(0, 0);
            this.tvwCall.Name = "tvwCall";
            this.tvwCall.SelectedImageIndex = 0;
            this.tvwCall.Size = new System.Drawing.Size(686, 242);
            this.tvwCall.TabIndex = 1;
            this.tvwCall.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tvwCall_AfterCollapse);
            this.tvwCall.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.tvwCall_DrawNode);
            this.tvwCall.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwCall_AfterSelect);
            this.tvwCall.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwCall_BeforeSelect);
            // 
            // imgCallIcons
            // 
            this.imgCallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCallIcons.ImageStream")));
            this.imgCallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCallIcons.Images.SetKeyName(0, "Comments.ico");
            this.imgCallIcons.Images.SetKeyName(1, "Folder.png");
            this.imgCallIcons.Images.SetKeyName(2, "Folder-Ok.png");
            this.imgCallIcons.Images.SetKeyName(3, "Note.png");
            this.imgCallIcons.Images.SetKeyName(4, "Note-Ok.png");
            this.imgCallIcons.Images.SetKeyName(5, "Comments-edit.png");
            // 
            // pnlDataEntry
            // 
            this.pnlDataEntry.Controls.Add(this.cmdClearAnswer);
            this.pnlDataEntry.Controls.Add(this.pnlChoiceLargeText);
            this.pnlDataEntry.Controls.Add(this.pnlChoiceDate);
            this.pnlDataEntry.Controls.Add(this.pnlChoiceYesNo);
            this.pnlDataEntry.Controls.Add(this.pnlChoiceNumeric);
            this.pnlDataEntry.Controls.Add(this.pnlChoiceNormalText);
            this.pnlDataEntry.Controls.Add(this.pnlChoiceSmallText);
            this.pnlDataEntry.Controls.Add(this.pnlChoiceCategory);
            this.pnlDataEntry.Controls.Add(this.pnlChoiceMultiple);
            this.pnlDataEntry.Controls.Add(this.lblDataDescription);
            this.pnlDataEntry.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDataEntry.Location = new System.Drawing.Point(0, 242);
            this.pnlDataEntry.Name = "pnlDataEntry";
            this.pnlDataEntry.Size = new System.Drawing.Size(686, 125);
            this.pnlDataEntry.TabIndex = 2;
            this.pnlDataEntry.Visible = false;
            // 
            // cmdClearAnswer
            // 
            this.cmdClearAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClearAnswer.Location = new System.Drawing.Point(609, 1);
            this.cmdClearAnswer.Name = "cmdClearAnswer";
            this.cmdClearAnswer.Size = new System.Drawing.Size(70, 27);
            this.cmdClearAnswer.TabIndex = 9;
            this.cmdClearAnswer.Text = "Clear";
            this.cmdClearAnswer.UseVisualStyleBackColor = true;
            this.cmdClearAnswer.Visible = false;
            this.cmdClearAnswer.Click += new System.EventHandler(this.cmdClearAnswer_Click);
            // 
            // pnlChoiceLargeText
            // 
            this.pnlChoiceLargeText.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceLargeText.Controls.Add(this.txtLarge);
            this.pnlChoiceLargeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceLargeText.Location = new System.Drawing.Point(0, 29);
            this.pnlChoiceLargeText.Name = "pnlChoiceLargeText";
            this.pnlChoiceLargeText.Size = new System.Drawing.Size(686, 96);
            this.pnlChoiceLargeText.TabIndex = 6;
            this.pnlChoiceLargeText.Visible = false;
            // 
            // txtLarge
            // 
            this.txtLarge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLarge.Location = new System.Drawing.Point(9, 5);
            this.txtLarge.Multiline = true;
            this.txtLarge.Name = "txtLarge";
            this.txtLarge.ReadOnly = true;
            this.txtLarge.Size = new System.Drawing.Size(670, 82);
            this.txtLarge.TabIndex = 1;
            this.txtLarge.TextChanged += new System.EventHandler(this.txtLarge_TextChanged);
            // 
            // pnlChoiceDate
            // 
            this.pnlChoiceDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceDate.Controls.Add(this.ctlDate);
            this.pnlChoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceDate.Location = new System.Drawing.Point(0, 29);
            this.pnlChoiceDate.Name = "pnlChoiceDate";
            this.pnlChoiceDate.Size = new System.Drawing.Size(686, 96);
            this.pnlChoiceDate.TabIndex = 7;
            this.pnlChoiceDate.Visible = false;
            // 
            // pnlChoiceYesNo
            // 
            this.pnlChoiceYesNo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceYesNo.Controls.Add(this.radNo);
            this.pnlChoiceYesNo.Controls.Add(this.radYes);
            this.pnlChoiceYesNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceYesNo.Location = new System.Drawing.Point(0, 29);
            this.pnlChoiceYesNo.Name = "pnlChoiceYesNo";
            this.pnlChoiceYesNo.Size = new System.Drawing.Size(686, 96);
            this.pnlChoiceYesNo.TabIndex = 2;
            this.pnlChoiceYesNo.Visible = false;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Enabled = false;
            this.radNo.Location = new System.Drawing.Point(9, 31);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(39, 17);
            this.radNo.TabIndex = 1;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            this.radNo.CheckedChanged += new System.EventHandler(this.radNo_CheckedChanged);
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Enabled = false;
            this.radYes.Location = new System.Drawing.Point(9, 8);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(43, 17);
            this.radYes.TabIndex = 0;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            this.radYes.CheckedChanged += new System.EventHandler(this.radYes_CheckedChanged);
            // 
            // pnlChoiceNumeric
            // 
            this.pnlChoiceNumeric.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceNumeric.Controls.Add(this.numNumber);
            this.pnlChoiceNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceNumeric.Location = new System.Drawing.Point(0, 29);
            this.pnlChoiceNumeric.Name = "pnlChoiceNumeric";
            this.pnlChoiceNumeric.Size = new System.Drawing.Size(686, 96);
            this.pnlChoiceNumeric.TabIndex = 8;
            this.pnlChoiceNumeric.Visible = false;
            // 
            // numNumber
            // 
            this.numNumber.Location = new System.Drawing.Point(9, 8);
            this.numNumber.Name = "numNumber";
            this.numNumber.ReadOnly = true;
            this.numNumber.Size = new System.Drawing.Size(77, 20);
            this.numNumber.TabIndex = 0;
            this.numNumber.ValueChanged += new System.EventHandler(this.numNumber_ValueChanged);
            // 
            // pnlChoiceNormalText
            // 
            this.pnlChoiceNormalText.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceNormalText.Controls.Add(this.txtNormal);
            this.pnlChoiceNormalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceNormalText.Location = new System.Drawing.Point(0, 29);
            this.pnlChoiceNormalText.Name = "pnlChoiceNormalText";
            this.pnlChoiceNormalText.Size = new System.Drawing.Size(686, 96);
            this.pnlChoiceNormalText.TabIndex = 4;
            this.pnlChoiceNormalText.Visible = false;
            // 
            // txtNormal
            // 
            this.txtNormal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNormal.Location = new System.Drawing.Point(9, 8);
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.ReadOnly = true;
            this.txtNormal.Size = new System.Drawing.Size(670, 20);
            this.txtNormal.TabIndex = 0;
            this.txtNormal.TextChanged += new System.EventHandler(this.txtNormal_TextChanged);
            // 
            // pnlChoiceSmallText
            // 
            this.pnlChoiceSmallText.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceSmallText.Controls.Add(this.txtSmall);
            this.pnlChoiceSmallText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceSmallText.Location = new System.Drawing.Point(0, 29);
            this.pnlChoiceSmallText.Name = "pnlChoiceSmallText";
            this.pnlChoiceSmallText.Size = new System.Drawing.Size(686, 96);
            this.pnlChoiceSmallText.TabIndex = 5;
            this.pnlChoiceSmallText.Visible = false;
            // 
            // txtSmall
            // 
            this.txtSmall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSmall.Location = new System.Drawing.Point(9, 8);
            this.txtSmall.Name = "txtSmall";
            this.txtSmall.ReadOnly = true;
            this.txtSmall.Size = new System.Drawing.Size(670, 20);
            this.txtSmall.TabIndex = 1;
            this.txtSmall.TextChanged += new System.EventHandler(this.txtSmall_TextChanged);
            // 
            // pnlChoiceCategory
            // 
            this.pnlChoiceCategory.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceCategory.Location = new System.Drawing.Point(0, 29);
            this.pnlChoiceCategory.Name = "pnlChoiceCategory";
            this.pnlChoiceCategory.Size = new System.Drawing.Size(686, 96);
            this.pnlChoiceCategory.TabIndex = 1;
            this.pnlChoiceCategory.Visible = false;
            // 
            // pnlChoiceMultiple
            // 
            this.pnlChoiceMultiple.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceMultiple.Controls.Add(this.cmbMultipleChoice);
            this.pnlChoiceMultiple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceMultiple.Location = new System.Drawing.Point(0, 29);
            this.pnlChoiceMultiple.Name = "pnlChoiceMultiple";
            this.pnlChoiceMultiple.Size = new System.Drawing.Size(686, 96);
            this.pnlChoiceMultiple.TabIndex = 3;
            this.pnlChoiceMultiple.Visible = false;
            // 
            // cmbMultipleChoice
            // 
            this.cmbMultipleChoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMultipleChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMultipleChoice.Enabled = false;
            this.cmbMultipleChoice.FormattingEnabled = true;
            this.cmbMultipleChoice.Location = new System.Drawing.Point(9, 9);
            this.cmbMultipleChoice.Name = "cmbMultipleChoice";
            this.cmbMultipleChoice.Size = new System.Drawing.Size(670, 21);
            this.cmbMultipleChoice.TabIndex = 8;
            this.cmbMultipleChoice.SelectedIndexChanged += new System.EventHandler(this.cmbMultipleChoice_SelectedIndexChanged);
            // 
            // lblDataDescription
            // 
            this.lblDataDescription.BackColor = System.Drawing.Color.SteelBlue;
            this.lblDataDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDataDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDescription.ForeColor = System.Drawing.Color.White;
            this.lblDataDescription.Location = new System.Drawing.Point(0, 0);
            this.lblDataDescription.Name = "lblDataDescription";
            this.lblDataDescription.Size = new System.Drawing.Size(686, 29);
            this.lblDataDescription.TabIndex = 0;
            this.lblDataDescription.Text = "Browse the call tree above";
            this.lblDataDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrOnHold
            // 
            this.tmrOnHold.Interval = 1000;
            this.tmrOnHold.Tick += new System.EventHandler(this.tmrOnHold_Tick);
            // 
            // pnlCallControls
            // 
            this.pnlCallControls.Controls.Add(this.btnHoldCall);
            this.pnlCallControls.Controls.Add(this.btnLogCall);
            this.pnlCallControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCallControls.Location = new System.Drawing.Point(0, 519);
            this.pnlCallControls.Name = "pnlCallControls";
            this.pnlCallControls.Size = new System.Drawing.Size(686, 33);
            this.pnlCallControls.TabIndex = 3;
            this.pnlCallControls.Resize += new System.EventHandler(this.pnlCallControls_Resize);
            // 
            // btnHoldCall
            // 
            this.btnHoldCall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHoldCall.Enabled = false;
            this.btnHoldCall.Location = new System.Drawing.Point(609, 3);
            this.btnHoldCall.Name = "btnHoldCall";
            this.btnHoldCall.Size = new System.Drawing.Size(70, 27);
            this.btnHoldCall.TabIndex = 1;
            this.btnHoldCall.Text = "Hold Call";
            this.btnHoldCall.UseVisualStyleBackColor = true;
            this.btnHoldCall.Click += new System.EventHandler(this.btnHoldCall_Click);
            // 
            // btnLogCall
            // 
            this.btnLogCall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogCall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogCall.ImageIndex = 1;
            this.btnLogCall.Location = new System.Drawing.Point(7, 3);
            this.btnLogCall.Name = "btnLogCall";
            this.btnLogCall.Size = new System.Drawing.Size(87, 27);
            this.btnLogCall.TabIndex = 0;
            this.btnLogCall.Text = "Log Call";
            this.btnLogCall.UseVisualStyleBackColor = true;
            this.btnLogCall.Click += new System.EventHandler(this.btnLogCall_Click);
            // 
            // ctlDate
            // 
            this.ctlDate.CurrentDate = null;
            this.ctlDate.DateSelectionVisible = true;
            this.ctlDate.DateValue = null;
            this.ctlDate.Enabled = false;
            this.ctlDate.Location = new System.Drawing.Point(9, 7);
            this.ctlDate.Name = "ctlDate";
            this.ctlDate.Size = new System.Drawing.Size(168, 21);
            this.ctlDate.TabIndex = 0;
            this.ctlDate.ValueChanged += new System.EventHandler(this.ctlDate_ValueChanged);
            // 
            // notesGrid
            // 
            this.notesGrid.CurrentCall = null;
            this.notesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesGrid.Location = new System.Drawing.Point(0, 0);
            this.notesGrid.Mode = C_DentalClaimTracker.NotesGrid.NotesGridMode.GridView;
            this.notesGrid.Name = "notesGrid";
            this.notesGrid.Size = new System.Drawing.Size(686, 142);
            this.notesGrid.TabIndex = 0;
            this.notesGrid.NewNotes += new System.EventHandler(this.notesGrid_NewNotes);
            // 
            // CallManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCall);
            this.Controls.Add(this.pnlCallControls);
            this.Controls.Add(this.splCallManager);
            this.Controls.Add(this.pnlNotes);
            this.Name = "CallManager";
            this.Size = new System.Drawing.Size(686, 552);
            this.pnlNotes.ResumeLayout(false);
            this.pnlCall.ResumeLayout(false);
            this.pnlDataEntry.ResumeLayout(false);
            this.pnlChoiceLargeText.ResumeLayout(false);
            this.pnlChoiceLargeText.PerformLayout();
            this.pnlChoiceDate.ResumeLayout(false);
            this.pnlChoiceYesNo.ResumeLayout(false);
            this.pnlChoiceYesNo.PerformLayout();
            this.pnlChoiceNumeric.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            this.pnlChoiceNormalText.ResumeLayout(false);
            this.pnlChoiceNormalText.PerformLayout();
            this.pnlChoiceSmallText.ResumeLayout(false);
            this.pnlChoiceSmallText.PerformLayout();
            this.pnlChoiceMultiple.ResumeLayout(false);
            this.pnlCallControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNotes;
        private System.Windows.Forms.Splitter splCallManager;
        private System.Windows.Forms.Panel pnlCall;
        private System.Windows.Forms.TreeView tvwCall;
        private System.Windows.Forms.Timer tmrOnHold;
        private System.Windows.Forms.Panel pnlCallControls;
        private System.Windows.Forms.Button btnHoldCall;
        private System.Windows.Forms.Button btnLogCall;
        private System.Windows.Forms.Panel pnlDataEntry;
        private System.Windows.Forms.Panel pnlChoiceCategory;
        private System.Windows.Forms.ImageList imgCallIcons;
        private System.Windows.Forms.Panel pnlChoiceYesNo;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.Panel pnlChoiceSmallText;
        private System.Windows.Forms.Panel pnlChoiceNormalText;
        private System.Windows.Forms.TextBox txtNormal;
        private System.Windows.Forms.Panel pnlChoiceMultiple;
        private System.Windows.Forms.Panel pnlChoiceNumeric;
        private System.Windows.Forms.NumericUpDown numNumber;
        private System.Windows.Forms.Panel pnlChoiceDate;
        private System.Windows.Forms.Panel pnlChoiceLargeText;
        private System.Windows.Forms.TextBox txtLarge;
        private System.Windows.Forms.TextBox txtSmall;
        private NotesGrid notesGrid;
        private System.Windows.Forms.Label lblDataDescription;
        private System.Windows.Forms.ComboBox cmbMultipleChoice;
        private ctlDateEntry ctlDate;
        private System.Windows.Forms.Button cmdClearAnswer;


    }
}
