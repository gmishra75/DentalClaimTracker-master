namespace C_DentalClaimTracker.Appointment_Auditing
{
    partial class frmAppointmentAudits
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointmentAudits));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.chkGroupSimilar = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbUserList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDuration = new System.Windows.Forms.ComboBox();
            this.lnkImport = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblDentalNewPatients = new System.Windows.Forms.Label();
            this.lblDentalAverageDays = new System.Windows.Forms.Label();
            this.lblDentalTotal = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblHygieneNewPatients = new System.Windows.Forms.Label();
            this.lblHygieneAverageDays = new System.Windows.Forms.Label();
            this.lblHygieneTotal = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDeleted = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.lblBroken = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblTotalChanges = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblTotalPatients = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabpIndividual = new System.Windows.Forms.TabPage();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.colChangeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChanges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblChangedAppointments = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ttipMain = new System.Windows.Forms.ToolTip(this.components);
            this.panel11 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblOtherAverageDays = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblOtherNewPatients = new System.Windows.Forms.Label();
            this.lblOtherTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabpIndividual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(152)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.cmdSearch);
            this.panel1.Controls.Add(this.chkGroupSimilar);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 54);
            this.panel1.TabIndex = 0;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdSearch.Image = global::AppointmentAuditor.Properties.Resources.arrow_rotate_clockwise;
            this.cmdSearch.Location = new System.Drawing.Point(424, 0);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(136, 54);
            this.cmdSearch.TabIndex = 18;
            this.cmdSearch.Text = "&Search";
            this.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // chkGroupSimilar
            // 
            this.chkGroupSimilar.AutoSize = true;
            this.chkGroupSimilar.Checked = true;
            this.chkGroupSimilar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGroupSimilar.Location = new System.Drawing.Point(915, 30);
            this.chkGroupSimilar.Name = "chkGroupSimilar";
            this.chkGroupSimilar.Size = new System.Drawing.Size(165, 20);
            this.chkGroupSimilar.TabIndex = 19;
            this.chkGroupSimilar.Text = "Group Similar Changes";
            this.ttipMain.SetToolTip(this.chkGroupSimilar, "Some changes to patients will change every appointment for that Patient. Checking" +
        " this box shows these as just one change.");
            this.chkGroupSimilar.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.dtpStartDate);
            this.panel6.Controls.Add(this.cmbUserList);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.cmbDuration);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(424, 54);
            this.panel6.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "days";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(7, 26);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(145, 22);
            this.dtpStartDate.TabIndex = 0;
            // 
            // cmbUserList
            // 
            this.cmbUserList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserList.FormattingEnabled = true;
            this.cmbUserList.Location = new System.Drawing.Point(299, 24);
            this.cmbUserList.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUserList.Name = "cmbUserList";
            this.cmbUserList.Size = new System.Drawing.Size(115, 24);
            this.cmbUserList.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duration";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "User";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDuration
            // 
            this.cmbDuration.FormattingEnabled = true;
            this.cmbDuration.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDuration.Location = new System.Drawing.Point(160, 24);
            this.cmbDuration.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDuration.Name = "cmbDuration";
            this.cmbDuration.Size = new System.Drawing.Size(91, 24);
            this.cmbDuration.TabIndex = 3;
            // 
            // lnkImport
            // 
            this.lnkImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(111)))));
            this.lnkImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkImport.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.lnkImport.Location = new System.Drawing.Point(0, 0);
            this.lnkImport.Name = "lnkImport";
            this.lnkImport.Size = new System.Drawing.Size(77, 35);
            this.lnkImport.TabIndex = 19;
            this.lnkImport.TabStop = true;
            this.lnkImport.Text = "Import...";
            this.lnkImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkImport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkImport_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Controls.Add(this.lblChangedAppointments);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1083, 469);
            this.panel3.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabpIndividual);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 434);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel9);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1075, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Group Statistics";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(225, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(261, 395);
            this.panel9.TabIndex = 19;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label15);
            this.panel10.Controls.Add(this.label17);
            this.panel10.Controls.Add(this.lblDentalAverageDays);
            this.panel10.Controls.Add(this.label28);
            this.panel10.Controls.Add(this.label18);
            this.panel10.Controls.Add(this.lblDentalNewPatients);
            this.panel10.Controls.Add(this.lblDentalTotal);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 133);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(259, 132);
            this.panel10.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(259, 28);
            this.label15.TabIndex = 17;
            this.label15.Text = "Dental";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(3, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(182, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "New Patients";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(182, 20);
            this.label18.TabIndex = 1;
            this.label18.Text = "Total";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDentalNewPatients
            // 
            this.lblDentalNewPatients.BackColor = System.Drawing.Color.White;
            this.lblDentalNewPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDentalNewPatients.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDentalNewPatients.Location = new System.Drawing.Point(191, 71);
            this.lblDentalNewPatients.Name = "lblDentalNewPatients";
            this.lblDentalNewPatients.Size = new System.Drawing.Size(47, 20);
            this.lblDentalNewPatients.TabIndex = 4;
            this.lblDentalNewPatients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDentalAverageDays
            // 
            this.lblDentalAverageDays.BackColor = System.Drawing.Color.White;
            this.lblDentalAverageDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDentalAverageDays.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDentalAverageDays.Location = new System.Drawing.Point(191, 38);
            this.lblDentalAverageDays.Name = "lblDentalAverageDays";
            this.lblDentalAverageDays.Size = new System.Drawing.Size(47, 20);
            this.lblDentalAverageDays.TabIndex = 12;
            this.lblDentalAverageDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDentalTotal
            // 
            this.lblDentalTotal.BackColor = System.Drawing.Color.White;
            this.lblDentalTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDentalTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDentalTotal.Location = new System.Drawing.Point(191, 104);
            this.lblDentalTotal.Name = "lblDentalTotal";
            this.lblDentalTotal.Size = new System.Drawing.Size(47, 20);
            this.lblDentalTotal.TabIndex = 5;
            this.lblDentalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(3, 26);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(182, 45);
            this.label28.TabIndex = 8;
            this.label28.Text = "Average days between creation and scheduled date";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.label32);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.lblHygieneAverageDays);
            this.panel8.Controls.Add(this.lblHygieneNewPatients);
            this.panel8.Controls.Add(this.lblHygieneTotal);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(259, 133);
            this.panel8.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(259, 28);
            this.label13.TabIndex = 17;
            this.label13.Text = "Hygiene";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(3, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "New Patients";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Total";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHygieneNewPatients
            // 
            this.lblHygieneNewPatients.BackColor = System.Drawing.Color.White;
            this.lblHygieneNewPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHygieneNewPatients.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHygieneNewPatients.Location = new System.Drawing.Point(191, 72);
            this.lblHygieneNewPatients.Name = "lblHygieneNewPatients";
            this.lblHygieneNewPatients.Size = new System.Drawing.Size(47, 20);
            this.lblHygieneNewPatients.TabIndex = 4;
            this.lblHygieneNewPatients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHygieneAverageDays
            // 
            this.lblHygieneAverageDays.BackColor = System.Drawing.Color.White;
            this.lblHygieneAverageDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHygieneAverageDays.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHygieneAverageDays.Location = new System.Drawing.Point(191, 39);
            this.lblHygieneAverageDays.Name = "lblHygieneAverageDays";
            this.lblHygieneAverageDays.Size = new System.Drawing.Size(47, 20);
            this.lblHygieneAverageDays.TabIndex = 12;
            this.lblHygieneAverageDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHygieneTotal
            // 
            this.lblHygieneTotal.BackColor = System.Drawing.Color.White;
            this.lblHygieneTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHygieneTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHygieneTotal.Location = new System.Drawing.Point(191, 105);
            this.lblHygieneTotal.Name = "lblHygieneTotal";
            this.lblHygieneTotal.Size = new System.Drawing.Size(47, 20);
            this.lblHygieneTotal.TabIndex = 5;
            this.lblHygieneTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(3, 27);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(182, 45);
            this.label32.TabIndex = 8;
            this.label32.Text = "Average days between creation and scheduled date";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.lblOther);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.lblStatus);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.lblTime);
            this.panel7.Controls.Add(this.lblDeleted);
            this.panel7.Controls.Add(this.lblCreated);
            this.panel7.Controls.Add(this.lblBroken);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.lblTotalChanges);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.lblTotalPatients);
            this.panel7.Controls.Add(this.label22);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(222, 395);
            this.panel7.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 28);
            this.label11.TabIndex = 17;
            this.label11.Text = "General";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Deleted";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOther
            // 
            this.lblOther.BackColor = System.Drawing.Color.White;
            this.lblOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOther.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.Location = new System.Drawing.Point(161, 204);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(47, 20);
            this.lblOther.TabIndex = 16;
            this.lblOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Broken";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Other Changes";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(161, 171);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 20);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total Patients Changed";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(161, 138);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 20);
            this.lblTime.TabIndex = 13;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeleted
            // 
            this.lblDeleted.BackColor = System.Drawing.Color.White;
            this.lblDeleted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeleted.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleted.Location = new System.Drawing.Point(161, 39);
            this.lblDeleted.Name = "lblDeleted";
            this.lblDeleted.Size = new System.Drawing.Size(47, 20);
            this.lblDeleted.TabIndex = 4;
            this.lblDeleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreated
            // 
            this.lblCreated.BackColor = System.Drawing.Color.White;
            this.lblCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCreated.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreated.Location = new System.Drawing.Point(161, 105);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(47, 20);
            this.lblCreated.TabIndex = 12;
            this.lblCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBroken
            // 
            this.lblBroken.BackColor = System.Drawing.Color.White;
            this.lblBroken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBroken.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroken.Location = new System.Drawing.Point(161, 72);
            this.lblBroken.Name = "lblBroken";
            this.lblBroken.Size = new System.Drawing.Size(47, 20);
            this.lblBroken.TabIndex = 5;
            this.lblBroken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(3, 171);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 20);
            this.label20.TabIndex = 10;
            this.label20.Text = "Status";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalChanges
            // 
            this.lblTotalChanges.BackColor = System.Drawing.Color.White;
            this.lblTotalChanges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalChanges.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalChanges.Location = new System.Drawing.Point(161, 275);
            this.lblTotalChanges.Name = "lblTotalChanges";
            this.lblTotalChanges.Size = new System.Drawing.Size(47, 20);
            this.lblTotalChanges.TabIndex = 6;
            this.lblTotalChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(3, 138);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(152, 20);
            this.label21.TabIndex = 9;
            this.label21.Text = "Time / Operatory";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPatients
            // 
            this.lblTotalPatients.BackColor = System.Drawing.Color.White;
            this.lblTotalPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPatients.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPatients.Location = new System.Drawing.Point(161, 236);
            this.lblTotalPatients.Name = "lblTotalPatients";
            this.lblTotalPatients.Size = new System.Drawing.Size(47, 20);
            this.lblTotalPatients.TabIndex = 7;
            this.lblTotalPatients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(3, 105);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(152, 20);
            this.label22.TabIndex = 8;
            this.label22.Text = "Created Appointments";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabpIndividual
            // 
            this.tabpIndividual.Controls.Add(this.dgvAppointments);
            this.tabpIndividual.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpIndividual.Location = new System.Drawing.Point(4, 29);
            this.tabpIndividual.Name = "tabpIndividual";
            this.tabpIndividual.Padding = new System.Windows.Forms.Padding(3);
            this.tabpIndividual.Size = new System.Drawing.Size(1075, 401);
            this.tabpIndividual.TabIndex = 1;
            this.tabpIndividual.Text = "Individual Statistics";
            this.tabpIndividual.UseVisualStyleBackColor = true;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChangeDate,
            this.colUser,
            this.colPatientName,
            this.colApptDate,
            this.colAction,
            this.colApptID,
            this.colChanges});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointments.EnableHeadersVisualStyles = false;
            this.dgvAppointments.Location = new System.Drawing.Point(3, 3);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(1069, 395);
            this.dgvAppointments.TabIndex = 0;
            // 
            // colChangeDate
            // 
            this.colChangeDate.HeaderText = "Changed";
            this.colChangeDate.Name = "colChangeDate";
            this.colChangeDate.ReadOnly = true;
            this.colChangeDate.Width = 110;
            // 
            // colUser
            // 
            this.colUser.HeaderText = "User";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            // 
            // colPatientName
            // 
            this.colPatientName.HeaderText = "Patient";
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.ReadOnly = true;
            this.colPatientName.Width = 120;
            // 
            // colApptDate
            // 
            this.colApptDate.HeaderText = "Appt Date";
            this.colApptDate.Name = "colApptDate";
            this.colApptDate.ReadOnly = true;
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.Width = 120;
            // 
            // colApptID
            // 
            this.colApptID.HeaderText = "Appt ID";
            this.colApptID.Name = "colApptID";
            this.colApptID.ReadOnly = true;
            // 
            // colChanges
            // 
            this.colChanges.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colChanges.HeaderText = "Change Details";
            this.colChanges.Name = "colChanges";
            this.colChanges.ReadOnly = true;
            // 
            // lblChangedAppointments
            // 
            this.lblChangedAppointments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChangedAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChangedAppointments.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblChangedAppointments.Location = new System.Drawing.Point(0, 0);
            this.lblChangedAppointments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangedAppointments.Name = "lblChangedAppointments";
            this.lblChangedAppointments.Size = new System.Drawing.Size(1083, 35);
            this.lblChangedAppointments.TabIndex = 6;
            this.lblChangedAppointments.Text = "Changed Appointments";
            this.lblChangedAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(111)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 560);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1083, 35);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(170)))), ((int)(((byte)(118)))));
            this.panel5.Controls.Add(this.lnkImport);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(77, 35);
            this.panel5.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(131)))), ((int)(((byte)(81)))));
            this.label7.Location = new System.Drawing.Point(424, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Color Scheme Saver";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(992, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 37);
            this.panel2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(111)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1083, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Appointment Auditor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label19);
            this.panel11.Controls.Add(this.label23);
            this.panel11.Controls.Add(this.lblOtherAverageDays);
            this.panel11.Controls.Add(this.label25);
            this.panel11.Controls.Add(this.label26);
            this.panel11.Controls.Add(this.lblOtherNewPatients);
            this.panel11.Controls.Add(this.lblOtherTotal);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 265);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(259, 132);
            this.panel11.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(259, 28);
            this.label19.TabIndex = 17;
            this.label19.Text = "Other";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(3, 71);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(182, 20);
            this.label23.TabIndex = 0;
            this.label23.Text = "New Patients";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOtherAverageDays
            // 
            this.lblOtherAverageDays.BackColor = System.Drawing.Color.White;
            this.lblOtherAverageDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOtherAverageDays.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherAverageDays.Location = new System.Drawing.Point(191, 38);
            this.lblOtherAverageDays.Name = "lblOtherAverageDays";
            this.lblOtherAverageDays.Size = new System.Drawing.Size(47, 20);
            this.lblOtherAverageDays.TabIndex = 12;
            this.lblOtherAverageDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(3, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(182, 45);
            this.label25.TabIndex = 8;
            this.label25.Text = "Average days between creation and scheduled date";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 104);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(182, 20);
            this.label26.TabIndex = 1;
            this.label26.Text = "Total";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOtherNewPatients
            // 
            this.lblOtherNewPatients.BackColor = System.Drawing.Color.White;
            this.lblOtherNewPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOtherNewPatients.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherNewPatients.Location = new System.Drawing.Point(191, 71);
            this.lblOtherNewPatients.Name = "lblOtherNewPatients";
            this.lblOtherNewPatients.Size = new System.Drawing.Size(47, 20);
            this.lblOtherNewPatients.TabIndex = 4;
            this.lblOtherNewPatients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOtherTotal
            // 
            this.lblOtherTotal.BackColor = System.Drawing.Color.White;
            this.lblOtherTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOtherTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherTotal.Location = new System.Drawing.Point(191, 104);
            this.lblOtherTotal.Name = "lblOtherTotal";
            this.lblOtherTotal.Size = new System.Drawing.Size(47, 20);
            this.lblOtherTotal.TabIndex = 5;
            this.lblOtherTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAppointmentAudits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(231)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1083, 595);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAppointmentAudits";
            this.Text = "Appointment Auditor";
            this.Load += new System.EventHandler(this.frmAppointmentAudits_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tabpIndividual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cmbDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUserList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label lblChangedAppointments;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChangeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChanges;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lnkImport;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chkGroupSimilar;
        private System.Windows.Forms.ToolTip ttipMain;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabpIndividual;
        private System.Windows.Forms.Label lblTotalPatients;
        private System.Windows.Forms.Label lblTotalChanges;
        private System.Windows.Forms.Label lblBroken;
        private System.Windows.Forms.Label lblDeleted;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblDentalNewPatients;
        private System.Windows.Forms.Label lblDentalAverageDays;
        private System.Windows.Forms.Label lblDentalTotal;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblHygieneNewPatients;
        private System.Windows.Forms.Label lblHygieneAverageDays;
        private System.Windows.Forms.Label lblHygieneTotal;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblOtherAverageDays;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblOtherNewPatients;
        private System.Windows.Forms.Label lblOtherTotal;
    }
}