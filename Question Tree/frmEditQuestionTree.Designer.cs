namespace C_DentalClaimTracker
{
    partial class frmEditQuestionTree
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Base");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditQuestionTree));
            this.trvDisplay = new System.Windows.Forms.TreeView();
            this.mnuTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.imgCallIcons = new System.Windows.Forms.ImageList(this.components);
            this.pnlDetailsPanel = new System.Windows.Forms.Panel();
            this.pnlSaveCancel = new System.Windows.Forms.Panel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.txtQuestionText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlTreeText = new System.Windows.Forms.Panel();
            this.txtTreeText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlForkOptions = new System.Windows.Forms.Panel();
            this.lblRequiredAnswer = new System.Windows.Forms.Label();
            this.cmbRequiredAnswer = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlCategoryRestrictions = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lnkInsuranceCompanyList = new System.Windows.Forms.LinkLabel();
            this.pnlClassification2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nmbDefaultRevisitDate = new System.Windows.Forms.NumericUpDown();
            this.cmbRevisitDateOptions = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlClassificationOptions = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatusDropdown = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radFork = new System.Windows.Forms.RadioButton();
            this.radCallClassification = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlType = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbQuestionType = new System.Windows.Forms.ComboBox();
            this.lnkEditMultipleChoiceOptions = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuestionDetails = new System.Windows.Forms.Label();
            this.pnlOptionsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdCut = new System.Windows.Forms.Button();
            this.cmdPaste = new System.Windows.Forms.Button();
            this.cmdAddNew = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdMoveDown = new System.Windows.Forms.Button();
            this.cmdMoveUp = new System.Windows.Forms.Button();
            this.ttipMain = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.mnuTreeView.SuspendLayout();
            this.pnlDetailsPanel.SuspendLayout();
            this.pnlSaveCancel.SuspendLayout();
            this.pnlQuestion.SuspendLayout();
            this.pnlTreeText.SuspendLayout();
            this.pnlForkOptions.SuspendLayout();
            this.pnlCategoryRestrictions.SuspendLayout();
            this.pnlClassification2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDefaultRevisitDate)).BeginInit();
            this.pnlClassificationOptions.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlType.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlOptionsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvDisplay
            // 
            this.trvDisplay.AllowDrop = true;
            this.trvDisplay.ContextMenuStrip = this.mnuTreeView;
            this.trvDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvDisplay.FullRowSelect = true;
            this.trvDisplay.HideSelection = false;
            this.trvDisplay.ImageIndex = 0;
            this.trvDisplay.ImageList = this.imgCallIcons;
            this.trvDisplay.Location = new System.Drawing.Point(98, 41);
            this.trvDisplay.Name = "trvDisplay";
            treeNode1.Name = "nodBase";
            treeNode1.Text = "Base";
            this.trvDisplay.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.trvDisplay.SelectedImageIndex = 0;
            this.trvDisplay.Size = new System.Drawing.Size(375, 446);
            this.trvDisplay.TabIndex = 0;
            this.trvDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trvDisplay_MouseUp);
            this.trvDisplay.DragDrop += new System.Windows.Forms.DragEventHandler(this.trvDisplay_DragDrop);
            this.trvDisplay.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDisplay_AfterSelect);
            this.trvDisplay.DragEnter += new System.Windows.Forms.DragEventHandler(this.trvDisplay_DragEnter);
            this.trvDisplay.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDisplay_BeforeSelect);
            this.trvDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trvDisplay_KeyDown);
            this.trvDisplay.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.trvDisplay_ItemDrag);
            // 
            // mnuTreeView
            // 
            this.mnuTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMoveUp,
            this.mnuMoveDown,
            this.toolStripMenuItem1,
            this.mnuCut,
            this.mnuPaste,
            this.toolStripMenuItem2,
            this.mnuAddNew,
            this.mnuDelete});
            this.mnuTreeView.Name = "mnuTreeView";
            this.mnuTreeView.Size = new System.Drawing.Size(138, 148);
            // 
            // mnuMoveUp
            // 
            this.mnuMoveUp.Name = "mnuMoveUp";
            this.mnuMoveUp.Size = new System.Drawing.Size(137, 22);
            this.mnuMoveUp.Text = "Move &up";
            this.mnuMoveUp.Click += new System.EventHandler(this.cmdMoveUp_Click);
            // 
            // mnuMoveDown
            // 
            this.mnuMoveDown.Name = "mnuMoveDown";
            this.mnuMoveDown.Size = new System.Drawing.Size(137, 22);
            this.mnuMoveDown.Text = "Move &down";
            this.mnuMoveDown.Click += new System.EventHandler(this.cmdMoveDown_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 6);
            // 
            // mnuCut
            // 
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.Size = new System.Drawing.Size(137, 22);
            this.mnuCut.Text = "&Cut";
            this.mnuCut.Click += new System.EventHandler(this.cmdCut_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Enabled = false;
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Size = new System.Drawing.Size(137, 22);
            this.mnuPaste.Text = "&Paste";
            this.mnuPaste.Click += new System.EventHandler(this.cmdPaste_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(134, 6);
            // 
            // mnuAddNew
            // 
            this.mnuAddNew.Name = "mnuAddNew";
            this.mnuAddNew.Size = new System.Drawing.Size(137, 22);
            this.mnuAddNew.Text = "&Add New";
            this.mnuAddNew.Click += new System.EventHandler(this.cmdAddNew_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(137, 22);
            this.mnuDelete.Text = "&Delete";
            this.mnuDelete.Click += new System.EventHandler(this.cmdDelete_Click);
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
            // pnlDetailsPanel
            // 
            this.pnlDetailsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetailsPanel.Controls.Add(this.pnlSaveCancel);
            this.pnlDetailsPanel.Controls.Add(this.pnlQuestion);
            this.pnlDetailsPanel.Controls.Add(this.pnlTreeText);
            this.pnlDetailsPanel.Controls.Add(this.pnlForkOptions);
            this.pnlDetailsPanel.Controls.Add(this.pnlCategoryRestrictions);
            this.pnlDetailsPanel.Controls.Add(this.pnlClassification2);
            this.pnlDetailsPanel.Controls.Add(this.pnlClassificationOptions);
            this.pnlDetailsPanel.Controls.Add(this.panel3);
            this.pnlDetailsPanel.Controls.Add(this.pnlType);
            this.pnlDetailsPanel.Controls.Add(this.panel1);
            this.pnlDetailsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDetailsPanel.Enabled = false;
            this.pnlDetailsPanel.Location = new System.Drawing.Point(473, 0);
            this.pnlDetailsPanel.Name = "pnlDetailsPanel";
            this.pnlDetailsPanel.Size = new System.Drawing.Size(594, 487);
            this.pnlDetailsPanel.TabIndex = 1;
            // 
            // pnlSaveCancel
            // 
            this.pnlSaveCancel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSaveCancel.Controls.Add(this.cmdCancel);
            this.pnlSaveCancel.Controls.Add(this.cmdSave);
            this.pnlSaveCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSaveCancel.Location = new System.Drawing.Point(0, 427);
            this.pnlSaveCancel.Name = "pnlSaveCancel";
            this.pnlSaveCancel.Size = new System.Drawing.Size(592, 53);
            this.pnlSaveCancel.TabIndex = 14;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.Location = new System.Drawing.Point(387, 26);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(71, 23);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Image = global::C_DentalClaimTracker.Properties.Resources.accept;
            this.cmdSave.Location = new System.Drawing.Point(464, 4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(121, 45);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "&Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuestion.Controls.Add(this.txtQuestionText);
            this.pnlQuestion.Controls.Add(this.label11);
            this.pnlQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuestion.Location = new System.Drawing.Point(0, 349);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(592, 78);
            this.pnlQuestion.TabIndex = 24;
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuestionText.Location = new System.Drawing.Point(104, 0);
            this.txtQuestionText.Multiline = true;
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.Size = new System.Drawing.Size(486, 76);
            this.txtQuestionText.TabIndex = 3;
            this.txtQuestionText.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 76);
            this.label11.TabIndex = 7;
            this.label11.Text = "Question Text";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTreeText
            // 
            this.pnlTreeText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTreeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTreeText.Controls.Add(this.txtTreeText);
            this.pnlTreeText.Controls.Add(this.label10);
            this.pnlTreeText.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTreeText.Location = new System.Drawing.Point(0, 305);
            this.pnlTreeText.Name = "pnlTreeText";
            this.pnlTreeText.Size = new System.Drawing.Size(592, 44);
            this.pnlTreeText.TabIndex = 23;
            // 
            // txtTreeText
            // 
            this.txtTreeText.Location = new System.Drawing.Point(109, 12);
            this.txtTreeText.Name = "txtTreeText";
            this.txtTreeText.Size = new System.Drawing.Size(253, 20);
            this.txtTreeText.TabIndex = 8;
            this.txtTreeText.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 42);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tree Text";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlForkOptions
            // 
            this.pnlForkOptions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlForkOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForkOptions.Controls.Add(this.lblRequiredAnswer);
            this.pnlForkOptions.Controls.Add(this.cmbRequiredAnswer);
            this.pnlForkOptions.Controls.Add(this.label9);
            this.pnlForkOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForkOptions.Location = new System.Drawing.Point(0, 261);
            this.pnlForkOptions.Name = "pnlForkOptions";
            this.pnlForkOptions.Size = new System.Drawing.Size(592, 44);
            this.pnlForkOptions.TabIndex = 22;
            // 
            // lblRequiredAnswer
            // 
            this.lblRequiredAnswer.Location = new System.Drawing.Point(138, 15);
            this.lblRequiredAnswer.Name = "lblRequiredAnswer";
            this.lblRequiredAnswer.Size = new System.Drawing.Size(77, 16);
            this.lblRequiredAnswer.TabIndex = 7;
            this.lblRequiredAnswer.Text = "Req\'d Answer";
            // 
            // cmbRequiredAnswer
            // 
            this.cmbRequiredAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequiredAnswer.FormattingEnabled = true;
            this.cmbRequiredAnswer.Location = new System.Drawing.Point(221, 11);
            this.cmbRequiredAnswer.Name = "cmbRequiredAnswer";
            this.cmbRequiredAnswer.Size = new System.Drawing.Size(262, 21);
            this.cmbRequiredAnswer.TabIndex = 4;
            this.cmbRequiredAnswer.SelectedIndexChanged += new System.EventHandler(this.DataChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(132, 42);
            this.label9.TabIndex = 7;
            this.label9.Text = "Forked Parent Options";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCategoryRestrictions
            // 
            this.pnlCategoryRestrictions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCategoryRestrictions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategoryRestrictions.Controls.Add(this.label14);
            this.pnlCategoryRestrictions.Controls.Add(this.lnkInsuranceCompanyList);
            this.pnlCategoryRestrictions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategoryRestrictions.Location = new System.Drawing.Point(0, 217);
            this.pnlCategoryRestrictions.Name = "pnlCategoryRestrictions";
            this.pnlCategoryRestrictions.Size = new System.Drawing.Size(592, 44);
            this.pnlCategoryRestrictions.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label14.Size = new System.Drawing.Size(132, 42);
            this.label14.TabIndex = 7;
            this.label14.Text = "Restrictions";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnkInsuranceCompanyList
            // 
            this.lnkInsuranceCompanyList.AutoSize = true;
            this.lnkInsuranceCompanyList.Location = new System.Drawing.Point(138, 15);
            this.lnkInsuranceCompanyList.Name = "lnkInsuranceCompanyList";
            this.lnkInsuranceCompanyList.Size = new System.Drawing.Size(210, 13);
            this.lnkInsuranceCompanyList.TabIndex = 18;
            this.lnkInsuranceCompanyList.TabStop = true;
            this.lnkInsuranceCompanyList.Text = "Only use with this Insurance Company list...";
            this.ttipMain.SetToolTip(this.lnkInsuranceCompanyList, "This can be used to restrict a call classification so it only shows for certain i" +
                    "nsurance providers. It is used primarily to set up easy input into automated sys" +
                    "tems.");
            this.lnkInsuranceCompanyList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkInsuranceCompanyList_LinkClicked);
            // 
            // pnlClassification2
            // 
            this.pnlClassification2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlClassification2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClassification2.Controls.Add(this.label1);
            this.pnlClassification2.Controls.Add(this.nmbDefaultRevisitDate);
            this.pnlClassification2.Controls.Add(this.cmbRevisitDateOptions);
            this.pnlClassification2.Controls.Add(this.label12);
            this.pnlClassification2.Controls.Add(this.label4);
            this.pnlClassification2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClassification2.Location = new System.Drawing.Point(0, 173);
            this.pnlClassification2.Name = "pnlClassification2";
            this.pnlClassification2.Size = new System.Drawing.Size(592, 44);
            this.pnlClassification2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(490, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "days";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nmbDefaultRevisitDate
            // 
            this.nmbDefaultRevisitDate.Location = new System.Drawing.Point(435, 11);
            this.nmbDefaultRevisitDate.Name = "nmbDefaultRevisitDate";
            this.nmbDefaultRevisitDate.Size = new System.Drawing.Size(49, 20);
            this.nmbDefaultRevisitDate.TabIndex = 16;
            this.ttipMain.SetToolTip(this.nmbDefaultRevisitDate, "Set the default revisit date for a claim if this classification is chosen");
            this.nmbDefaultRevisitDate.ValueChanged += new System.EventHandler(this.nmbDefaultRevisitDate_ValueChanged);
            // 
            // cmbRevisitDateOptions
            // 
            this.cmbRevisitDateOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRevisitDateOptions.FormattingEnabled = true;
            this.cmbRevisitDateOptions.Items.AddRange(new object[] {
            "Fixed revisit",
            "User sets revisit (with default)",
            "Do not change",
            "Unspecified"});
            this.cmbRevisitDateOptions.Location = new System.Drawing.Point(215, 10);
            this.cmbRevisitDateOptions.Name = "cmbRevisitDateOptions";
            this.cmbRevisitDateOptions.Size = new System.Drawing.Size(211, 21);
            this.cmbRevisitDateOptions.TabIndex = 19;
            this.ttipMain.SetToolTip(this.cmbRevisitDateOptions, "Select the default status for a claim if this classification is chosen");
            this.cmbRevisitDateOptions.SelectedIndexChanged += new System.EventHandler(this.cmbRevisitDateOptions_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 42);
            this.label12.TabIndex = 7;
            this.label12.Text = "Revisit Date";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(138, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Revisit Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlClassificationOptions
            // 
            this.pnlClassificationOptions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlClassificationOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClassificationOptions.Controls.Add(this.label8);
            this.pnlClassificationOptions.Controls.Add(this.label3);
            this.pnlClassificationOptions.Controls.Add(this.cmbStatusDropdown);
            this.pnlClassificationOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClassificationOptions.Location = new System.Drawing.Point(0, 129);
            this.pnlClassificationOptions.Name = "pnlClassificationOptions";
            this.pnlClassificationOptions.Size = new System.Drawing.Size(592, 44);
            this.pnlClassificationOptions.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(132, 42);
            this.label8.TabIndex = 7;
            this.label8.Text = "Linked Status";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(138, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Linked Status";
            // 
            // cmbStatusDropdown
            // 
            this.cmbStatusDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusDropdown.FormattingEnabled = true;
            this.cmbStatusDropdown.Location = new System.Drawing.Point(215, 12);
            this.cmbStatusDropdown.Name = "cmbStatusDropdown";
            this.cmbStatusDropdown.Size = new System.Drawing.Size(211, 21);
            this.cmbStatusDropdown.TabIndex = 13;
            this.ttipMain.SetToolTip(this.cmbStatusDropdown, "Select the default status for a claim if this classification is chosen");
            this.cmbStatusDropdown.SelectedIndexChanged += new System.EventHandler(this.cmbStatusDropdown_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radFork);
            this.panel3.Controls.Add(this.radCallClassification);
            this.panel3.Controls.Add(this.radStandard);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(592, 44);
            this.panel3.TabIndex = 20;
            // 
            // radFork
            // 
            this.radFork.AutoSize = true;
            this.radFork.Location = new System.Drawing.Point(293, 13);
            this.radFork.Name = "radFork";
            this.radFork.Size = new System.Drawing.Size(46, 17);
            this.radFork.TabIndex = 15;
            this.radFork.TabStop = true;
            this.radFork.Text = "Fork";
            this.radFork.UseVisualStyleBackColor = true;
            this.radFork.CheckedChanged += new System.EventHandler(this.chkIsClassification_CheckedChanged);
            // 
            // radCallClassification
            // 
            this.radCallClassification.AutoSize = true;
            this.radCallClassification.Location = new System.Drawing.Point(183, 13);
            this.radCallClassification.Name = "radCallClassification";
            this.radCallClassification.Size = new System.Drawing.Size(106, 17);
            this.radCallClassification.TabIndex = 14;
            this.radCallClassification.Text = "Call Classification";
            this.radCallClassification.UseVisualStyleBackColor = true;
            this.radCallClassification.CheckedChanged += new System.EventHandler(this.chkIsClassification_CheckedChanged);
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Checked = true;
            this.radStandard.Location = new System.Drawing.Point(109, 13);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(68, 17);
            this.radStandard.TabIndex = 13;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            this.radStandard.CheckedChanged += new System.EventHandler(this.chkIsClassification_CheckedChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 42);
            this.label5.TabIndex = 7;
            this.label5.Text = "Extended Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlType
            // 
            this.pnlType.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlType.Controls.Add(this.label7);
            this.pnlType.Controls.Add(this.cmbQuestionType);
            this.pnlType.Controls.Add(this.lnkEditMultipleChoiceOptions);
            this.pnlType.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlType.Location = new System.Drawing.Point(0, 41);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(592, 44);
            this.pnlType.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 42);
            this.label7.TabIndex = 7;
            this.label7.Text = "Type";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbQuestionType
            // 
            this.cmbQuestionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestionType.FormattingEnabled = true;
            this.cmbQuestionType.Location = new System.Drawing.Point(110, 10);
            this.cmbQuestionType.Name = "cmbQuestionType";
            this.cmbQuestionType.Size = new System.Drawing.Size(180, 21);
            this.cmbQuestionType.TabIndex = 0;
            this.cmbQuestionType.SelectedIndexChanged += new System.EventHandler(this.cmbQuestionType_SelectedIndexChanged);
            // 
            // lnkEditMultipleChoiceOptions
            // 
            this.lnkEditMultipleChoiceOptions.AutoSize = true;
            this.lnkEditMultipleChoiceOptions.Location = new System.Drawing.Point(296, 15);
            this.lnkEditMultipleChoiceOptions.Name = "lnkEditMultipleChoiceOptions";
            this.lnkEditMultipleChoiceOptions.Size = new System.Drawing.Size(139, 13);
            this.lnkEditMultipleChoiceOptions.TabIndex = 5;
            this.lnkEditMultipleChoiceOptions.TabStop = true;
            this.lnkEditMultipleChoiceOptions.Text = "Edit Multiple Choice Options";
            this.lnkEditMultipleChoiceOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditMultipleChoiceOptions_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblQuestionDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 41);
            this.panel1.TabIndex = 26;
            // 
            // lblQuestionDetails
            // 
            this.lblQuestionDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestionDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionDetails.ForeColor = System.Drawing.Color.White;
            this.lblQuestionDetails.Location = new System.Drawing.Point(0, 0);
            this.lblQuestionDetails.Name = "lblQuestionDetails";
            this.lblQuestionDetails.Size = new System.Drawing.Size(590, 39);
            this.lblQuestionDetails.TabIndex = 0;
            this.lblQuestionDetails.Text = "Question Details";
            this.lblQuestionDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOptionsPanel
            // 
            this.pnlOptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptionsPanel.Controls.Add(this.label2);
            this.pnlOptionsPanel.Controls.Add(this.cmdCut);
            this.pnlOptionsPanel.Controls.Add(this.cmdPaste);
            this.pnlOptionsPanel.Controls.Add(this.cmdAddNew);
            this.pnlOptionsPanel.Controls.Add(this.cmdDelete);
            this.pnlOptionsPanel.Controls.Add(this.cmdMoveDown);
            this.pnlOptionsPanel.Controls.Add(this.cmdMoveUp);
            this.pnlOptionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOptionsPanel.Location = new System.Drawing.Point(0, 41);
            this.pnlOptionsPanel.Name = "pnlOptionsPanel";
            this.pnlOptionsPanel.Size = new System.Drawing.Size(98, 446);
            this.pnlOptionsPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Options";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdCut
            // 
            this.cmdCut.Enabled = false;
            this.cmdCut.Image = global::C_DentalClaimTracker.Properties.Resources.cut;
            this.cmdCut.Location = new System.Drawing.Point(3, 142);
            this.cmdCut.Name = "cmdCut";
            this.cmdCut.Size = new System.Drawing.Size(87, 51);
            this.cmdCut.TabIndex = 5;
            this.cmdCut.Text = "&Cut";
            this.cmdCut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttipMain.SetToolTip(this.cmdCut, "Places the current item in the clipboard so that it can be pasted later.\r\n\r\nHotke" +
                    "y: Ctrl + X");
            this.cmdCut.UseVisualStyleBackColor = true;
            this.cmdCut.Click += new System.EventHandler(this.cmdCut_Click);
            // 
            // cmdPaste
            // 
            this.cmdPaste.Enabled = false;
            this.cmdPaste.Image = global::C_DentalClaimTracker.Properties.Resources.paste_plain;
            this.cmdPaste.Location = new System.Drawing.Point(3, 198);
            this.cmdPaste.Name = "cmdPaste";
            this.cmdPaste.Size = new System.Drawing.Size(87, 51);
            this.cmdPaste.TabIndex = 4;
            this.cmdPaste.Text = "&Paste";
            this.cmdPaste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttipMain.SetToolTip(this.cmdPaste, "Take the item in the clipboard and pastes it in the selected location.\r\n\r\nHotkey:" +
                    " Ctrl + V");
            this.cmdPaste.UseVisualStyleBackColor = true;
            this.cmdPaste.Click += new System.EventHandler(this.cmdPaste_Click);
            // 
            // cmdAddNew
            // 
            this.cmdAddNew.Image = global::C_DentalClaimTracker.Properties.Resources.comment_add;
            this.cmdAddNew.Location = new System.Drawing.Point(3, 312);
            this.cmdAddNew.Name = "cmdAddNew";
            this.cmdAddNew.Size = new System.Drawing.Size(87, 51);
            this.cmdAddNew.TabIndex = 3;
            this.cmdAddNew.Text = "&Add New";
            this.cmdAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttipMain.SetToolTip(this.cmdAddNew, "Adds a new item in the selected location.\r\n\r\nHotkey: +");
            this.cmdAddNew.UseVisualStyleBackColor = true;
            this.cmdAddNew.Click += new System.EventHandler(this.cmdAddNew_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Enabled = false;
            this.cmdDelete.ForeColor = System.Drawing.Color.Maroon;
            this.cmdDelete.Image = global::C_DentalClaimTracker.Properties.Resources.comment_delete;
            this.cmdDelete.Location = new System.Drawing.Point(3, 369);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(87, 51);
            this.cmdDelete.TabIndex = 2;
            this.cmdDelete.Text = "&Delete";
            this.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttipMain.SetToolTip(this.cmdDelete, "Removes the selected item. Requires confirmation.\r\n\r\nHotkey: Delete");
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdMoveDown
            // 
            this.cmdMoveDown.Enabled = false;
            this.cmdMoveDown.Image = global::C_DentalClaimTracker.Properties.Resources.arrow_down1;
            this.cmdMoveDown.Location = new System.Drawing.Point(3, 88);
            this.cmdMoveDown.Name = "cmdMoveDown";
            this.cmdMoveDown.Size = new System.Drawing.Size(87, 51);
            this.cmdMoveDown.TabIndex = 1;
            this.cmdMoveDown.Text = "Move Down";
            this.cmdMoveDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdMoveDown.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttipMain.SetToolTip(this.cmdMoveDown, "Move the current item down within the current category.\r\n\r\nHotkey: Ctrl + DOWN");
            this.cmdMoveDown.UseVisualStyleBackColor = true;
            this.cmdMoveDown.Click += new System.EventHandler(this.cmdMoveDown_Click);
            // 
            // cmdMoveUp
            // 
            this.cmdMoveUp.Enabled = false;
            this.cmdMoveUp.Image = global::C_DentalClaimTracker.Properties.Resources.arrow_up1;
            this.cmdMoveUp.Location = new System.Drawing.Point(3, 31);
            this.cmdMoveUp.Name = "cmdMoveUp";
            this.cmdMoveUp.Size = new System.Drawing.Size(87, 51);
            this.cmdMoveUp.TabIndex = 0;
            this.cmdMoveUp.Text = "Move Up";
            this.cmdMoveUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdMoveUp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttipMain.SetToolTip(this.cmdMoveUp, "Move the current item up within the current category.\r\n\r\nHotkey: Ctrl + UP");
            this.cmdMoveUp.UseVisualStyleBackColor = true;
            this.cmdMoveUp.Click += new System.EventHandler(this.cmdMoveUp_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmdClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 31);
            this.panel2.TabIndex = 14;
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Location = new System.Drawing.Point(494, 2);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(78, 23);
            this.cmdClose.TabIndex = 11;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.trvDisplay);
            this.panel4.Controls.Add(this.pnlOptionsPanel);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(473, 487);
            this.panel4.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SteelBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(473, 41);
            this.label6.TabIndex = 16;
            this.label6.Text = "Question Tree Layout";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEditQuestionTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 518);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlDetailsPanel);
            this.Controls.Add(this.panel2);
            this.Name = "frmEditQuestionTree";
            this.Text = "Edit Question Tree";
            this.Load += new System.EventHandler(this.frmEditQuestionTree_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditQuestionTree_FormClosing);
            this.mnuTreeView.ResumeLayout(false);
            this.pnlDetailsPanel.ResumeLayout(false);
            this.pnlSaveCancel.ResumeLayout(false);
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            this.pnlTreeText.ResumeLayout(false);
            this.pnlTreeText.PerformLayout();
            this.pnlForkOptions.ResumeLayout(false);
            this.pnlCategoryRestrictions.ResumeLayout(false);
            this.pnlCategoryRestrictions.PerformLayout();
            this.pnlClassification2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmbDefaultRevisitDate)).EndInit();
            this.pnlClassificationOptions.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlType.ResumeLayout(false);
            this.pnlType.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlOptionsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvDisplay;
        private System.Windows.Forms.ImageList imgCallIcons;
        private System.Windows.Forms.Panel pnlDetailsPanel;
        private System.Windows.Forms.ComboBox cmbQuestionType;
        private System.Windows.Forms.TextBox txtQuestionText;
        private System.Windows.Forms.ComboBox cmbRequiredAnswer;
        private System.Windows.Forms.Label lblRequiredAnswer;
        private System.Windows.Forms.LinkLabel lnkEditMultipleChoiceOptions;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Panel pnlOptionsPanel;
        private System.Windows.Forms.Button cmdMoveDown;
        private System.Windows.Forms.Button cmdMoveUp;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdAddNew;
        private System.Windows.Forms.ContextMenuStrip mnuTreeView;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveUp;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveDown;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuAddNew;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.Button cmdCut;
        private System.Windows.Forms.Button cmdPaste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip ttipMain;
        private System.Windows.Forms.Panel pnlSaveCancel;
        private System.Windows.Forms.ComboBox cmbStatusDropdown;
        private System.Windows.Forms.NumericUpDown nmbDefaultRevisitDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.LinkLabel lnkInsuranceCompanyList;
        private System.Windows.Forms.Panel pnlType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlClassification2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlTreeText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlForkOptions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlClassificationOptions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radCallClassification;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton radFork;
        private System.Windows.Forms.TextBox txtTreeText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuestionDetails;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRevisitDateOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCategoryRestrictions;
        private System.Windows.Forms.Label label14;
    }
}