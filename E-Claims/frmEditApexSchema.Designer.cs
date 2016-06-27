namespace C_DentalClaimTracker.E_Claims
{
    partial class frmEditApexSchema
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditApexSchema));
            this.lnkOpenFolder = new System.Windows.Forms.LinkLabel();
            this.cmdSave = new System.Windows.Forms.Button();
            this.dgvSchemaData = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bsApexSchema = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchemaData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsApexSchema)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkOpenFolder
            // 
            this.lnkOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkOpenFolder.AutoSize = true;
            this.lnkOpenFolder.Location = new System.Drawing.Point(618, 69);
            this.lnkOpenFolder.Name = "lnkOpenFolder";
            this.lnkOpenFolder.Size = new System.Drawing.Size(74, 13);
            this.lnkOpenFolder.TabIndex = 5;
            this.lnkOpenFolder.TabStop = true;
            this.lnkOpenFolder.Text = "Open Folder...";
            this.lnkOpenFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOpenFolder_LinkClicked);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSave.Location = new System.Drawing.Point(698, 31);
            this.cmdSave.MaximumSize = new System.Drawing.Size(125, 60);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(117, 60);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // dgvSchemaData
            // 
            this.dgvSchemaData.AllowUserToAddRows = false;
            this.dgvSchemaData.AllowUserToDeleteRows = false;
            this.dgvSchemaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchemaData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colLine,
            this.colStartColumn,
            this.colEnd});
            this.dgvSchemaData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchemaData.Location = new System.Drawing.Point(0, 67);
            this.dgvSchemaData.MultiSelect = false;
            this.dgvSchemaData.Name = "dgvSchemaData";
            this.dgvSchemaData.RowHeadersVisible = false;
            this.dgvSchemaData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSchemaData.Size = new System.Drawing.Size(815, 393);
            this.dgvSchemaData.TabIndex = 32;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colLine
            // 
            this.colLine.DataPropertyName = "Line";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.colLine.DefaultCellStyle = dataGridViewCellStyle1;
            this.colLine.HeaderText = "Line";
            this.colLine.Name = "colLine";
            this.colLine.Width = 75;
            // 
            // colStartColumn
            // 
            this.colStartColumn.DataPropertyName = "StartColumn";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.colStartColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.colStartColumn.HeaderText = "Start";
            this.colStartColumn.Name = "colStartColumn";
            this.colStartColumn.Width = 75;
            // 
            // colEnd
            // 
            this.colEnd.DataPropertyName = "EndColumn";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.colEnd.DefaultCellStyle = dataGridViewCellStyle3;
            this.colEnd.HeaderText = "End";
            this.colEnd.Name = "colEnd";
            this.colEnd.Width = 75;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 67);
            this.panel1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(815, 67);
            this.label2.TabIndex = 36;
            this.label2.Text = "Edit Apex Schema for .apexedi files";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmdSave);
            this.panel2.Controls.Add(this.lnkOpenFolder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 91);
            this.panel2.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEditApexSchema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 551);
            this.Controls.Add(this.dgvSchemaData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEditApexSchema";
            this.Text = "Edit Apex Schema";
            this.Load += new System.EventHandler(this.frmEditApexSchema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchemaData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsApexSchema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkOpenFolder;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.DataGridView dgvSchemaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsApexSchema;
    }
}