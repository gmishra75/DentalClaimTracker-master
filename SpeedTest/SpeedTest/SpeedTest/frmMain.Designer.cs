namespace SpeedTest
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnRunTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nmbNumFiles = new System.Windows.Forms.NumericUpDown();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.testTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copyTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numFilesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbNumFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMain);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 350);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(977, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Previous Test Results (time displayed in ms)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nmbNumFiles);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 406);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 48);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(654, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "This software creates, copies, and deletes temporary files and keeps track of tim" +
    "e while doing so. You can rename or delete the XML file in the root directory to" +
    " clear the Previous Test Results Log.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(873, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 41);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtNotes);
            this.panel3.Controls.Add(this.btnRunTest);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(977, 56);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notes for this test (for example, how many RDP connected)";
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNotes.Location = new System.Drawing.Point(215, 34);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(762, 22);
            this.txtNotes.TabIndex = 1;
            // 
            // btnRunTest
            // 
            this.btnRunTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRunTest.Image = global::SpeedTest.Properties.Resources.star;
            this.btnRunTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunTest.Location = new System.Drawing.Point(0, 0);
            this.btnRunTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnRunTest.Name = "btnRunTest";
            this.btnRunTest.Size = new System.Drawing.Size(215, 56);
            this.btnRunTest.TabIndex = 0;
            this.btnRunTest.Text = " Run Test";
            this.btnRunTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRunTest.UseVisualStyleBackColor = true;
            this.btnRunTest.Click += new System.EventHandler(this.btnRunTest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(661, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of files (1-5000)";
            // 
            // nmbNumFiles
            // 
            this.nmbNumFiles.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SpeedTest.Properties.Settings.Default, "NumFiles", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nmbNumFiles.Location = new System.Drawing.Point(748, 23);
            this.nmbNumFiles.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmbNumFiles.Name = "nmbNumFiles";
            this.nmbNumFiles.Size = new System.Drawing.Size(60, 22);
            this.nmbNumFiles.TabIndex = 3;
            this.nmbNumFiles.Value = global::SpeedTest.Properties.Settings.Default.NumFiles;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testTimeDataGridViewTextBoxColumn,
            this.totalTimeDataGridViewTextBoxColumn,
            this.creationTimeDataGridViewTextBoxColumn,
            this.copyTimeDataGridViewTextBoxColumn,
            this.deleteTimeDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.numFilesDataGridViewTextBoxColumn});
            this.dgvMain.DataSource = this.testResultBindingSource;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 28);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(977, 322);
            this.dgvMain.TabIndex = 1;
            // 
            // testTimeDataGridViewTextBoxColumn
            // 
            this.testTimeDataGridViewTextBoxColumn.DataPropertyName = "testTime";
            this.testTimeDataGridViewTextBoxColumn.HeaderText = "Date / Time";
            this.testTimeDataGridViewTextBoxColumn.Name = "testTimeDataGridViewTextBoxColumn";
            this.testTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.testTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalTimeDataGridViewTextBoxColumn
            // 
            this.totalTimeDataGridViewTextBoxColumn.DataPropertyName = "TotalTime";
            this.totalTimeDataGridViewTextBoxColumn.HeaderText = "Total ";
            this.totalTimeDataGridViewTextBoxColumn.Name = "totalTimeDataGridViewTextBoxColumn";
            this.totalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creationTimeDataGridViewTextBoxColumn
            // 
            this.creationTimeDataGridViewTextBoxColumn.DataPropertyName = "creationTime";
            this.creationTimeDataGridViewTextBoxColumn.HeaderText = "Creation";
            this.creationTimeDataGridViewTextBoxColumn.Name = "creationTimeDataGridViewTextBoxColumn";
            this.creationTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.creationTimeDataGridViewTextBoxColumn.Width = 75;
            // 
            // copyTimeDataGridViewTextBoxColumn
            // 
            this.copyTimeDataGridViewTextBoxColumn.DataPropertyName = "copyTime";
            this.copyTimeDataGridViewTextBoxColumn.HeaderText = "Copy";
            this.copyTimeDataGridViewTextBoxColumn.Name = "copyTimeDataGridViewTextBoxColumn";
            this.copyTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.copyTimeDataGridViewTextBoxColumn.Width = 75;
            // 
            // deleteTimeDataGridViewTextBoxColumn
            // 
            this.deleteTimeDataGridViewTextBoxColumn.DataPropertyName = "deleteTime";
            this.deleteTimeDataGridViewTextBoxColumn.HeaderText = "Delete";
            this.deleteTimeDataGridViewTextBoxColumn.Name = "deleteTimeDataGridViewTextBoxColumn";
            this.deleteTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.deleteTimeDataGridViewTextBoxColumn.Width = 75;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numFilesDataGridViewTextBoxColumn
            // 
            this.numFilesDataGridViewTextBoxColumn.DataPropertyName = "numFiles";
            this.numFilesDataGridViewTextBoxColumn.HeaderText = "# Files";
            this.numFilesDataGridViewTextBoxColumn.Name = "numFilesDataGridViewTextBoxColumn";
            this.numFilesDataGridViewTextBoxColumn.ReadOnly = true;
            this.numFilesDataGridViewTextBoxColumn.Width = 80;
            // 
            // testResultBindingSource
            // 
            this.testResultBindingSource.DataMember = "AllTestResults";
            this.testResultBindingSource.DataSource = typeof(SpeedTest.TestResultCollection);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnRunTest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(977, 454);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Speed Test";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbNumFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnRunTest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmbNumFiles;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.BindingSource testResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copyTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFilesDataGridViewTextBoxColumn;
    }
}

