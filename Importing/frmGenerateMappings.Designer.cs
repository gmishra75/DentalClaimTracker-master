namespace C_DentalClaimTracker
{
    partial class frmGenerateMappings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerateMappings));
            this.dgvColumns = new System.Windows.Forms.DataGridView();
            this.colTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFound = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colData_Mapping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMappingGeneratorItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvColumns
            // 
            this.dgvColumns.AllowUserToAddRows = false;
            this.dgvColumns.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvColumns.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTableName,
            this.colFieldName,
            this.colDataType,
            this.colFound,
            this.colAdd,
            this.colData_Mapping,
            this.colMappingGeneratorItem});
            this.dgvColumns.Location = new System.Drawing.Point(12, 12);
            this.dgvColumns.MultiSelect = false;
            this.dgvColumns.Name = "dgvColumns";
            this.dgvColumns.RowHeadersVisible = false;
            this.dgvColumns.Size = new System.Drawing.Size(574, 150);
            this.dgvColumns.TabIndex = 0;
            // 
            // colTableName
            // 
            this.colTableName.DataPropertyName = "table_Name";
            this.colTableName.HeaderText = "Table Name";
            this.colTableName.Name = "colTableName";
            this.colTableName.ReadOnly = true;
            // 
            // colFieldName
            // 
            this.colFieldName.DataPropertyName = "field_Name";
            this.colFieldName.HeaderText = "Field Name";
            this.colFieldName.Name = "colFieldName";
            this.colFieldName.ReadOnly = true;
            this.colFieldName.Width = 125;
            // 
            // colDataType
            // 
            this.colDataType.DataPropertyName = "field_Type";
            this.colDataType.HeaderText = "Data Type";
            this.colDataType.Name = "colDataType";
            this.colDataType.ReadOnly = true;
            // 
            // colFound
            // 
            this.colFound.DataPropertyName = "Exists";
            this.colFound.HeaderText = "Exists";
            this.colFound.Name = "colFound";
            this.colFound.ReadOnly = true;
            this.colFound.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colFound.Width = 70;
            // 
            // colAdd
            // 
            this.colAdd.DataPropertyName = "Map_Field";
            this.colAdd.HeaderText = "Map Field";
            this.colAdd.Name = "colAdd";
            this.colAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAdd.Width = 80;
            // 
            // colData_Mapping
            // 
            this.colData_Mapping.DataPropertyName = "ExistingMapping";
            this.colData_Mapping.HeaderText = "DataMapping";
            this.colData_Mapping.Name = "colData_Mapping";
            this.colData_Mapping.Visible = false;
            // 
            // colMappingGeneratorItem
            // 
            this.colMappingGeneratorItem.DataPropertyName = "thisObject";
            this.colMappingGeneratorItem.HeaderText = "MappingGenerator";
            this.colMappingGeneratorItem.Name = "colMappingGeneratorItem";
            this.colMappingGeneratorItem.Visible = false;
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGenerate.Location = new System.Drawing.Point(514, 168);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(72, 27);
            this.cmdGenerate.TabIndex = 1;
            this.cmdGenerate.Text = "&Generate";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // frmGenerateMappings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 203);
            this.Controls.Add(this.cmdGenerate);
            this.Controls.Add(this.dgvColumns);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGenerateMappings";
            this.Text = "Generate Mappings";
            this.Load += new System.EventHandler(this.frmGenerateMappings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColumns;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFound;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData_Mapping;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMappingGeneratorItem;
    }
}