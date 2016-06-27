namespace C_DentalClaimTracker
{
    partial class NotesGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.dgvcNoteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcOperatorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcUpdatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsNotes = new System.Windows.Forms.BindingSource(this.components);
            this.pnlNotesControls = new System.Windows.Forms.Panel();
            this.pnlGridControls = new System.Windows.Forms.Panel();
            this.lblAddNote = new System.Windows.Forms.Label();
            this.lblRemoveNote = new System.Windows.Forms.Label();
            this.lblEditNote = new System.Windows.Forms.Label();
            this.pnlEditorControls = new System.Windows.Forms.Panel();
            this.btnQuickText4 = new System.Windows.Forms.Button();
            this.btnQuickText3 = new System.Windows.Forms.Button();
            this.btnQuickText2 = new System.Windows.Forms.Button();
            this.btnQuickText1 = new System.Windows.Forms.Button();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.btnCancelNote = new System.Windows.Forms.Button();
            this.pnlNotesMain = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.ttipMain = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotes)).BeginInit();
            this.pnlNotesControls.SuspendLayout();
            this.pnlGridControls.SuspendLayout();
            this.pnlEditorControls.SuspendLayout();
            this.pnlNotesMain.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNotes
            // 
            this.dgvNotes.AllowUserToAddRows = false;
            this.dgvNotes.AllowUserToDeleteRows = false;
            this.dgvNotes.AutoGenerateColumns = false;
            this.dgvNotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNotes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.ColumnHeadersVisible = false;
            this.dgvNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcNoteId,
            this.dgvcCallId,
            this.dgvcOperatorId,
            this.dgvcCreatedOn,
            this.dgvcUpdatedOn,
            this.dgvcNote});
            this.dgvNotes.DataSource = this.bsNotes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotes.Location = new System.Drawing.Point(0, 0);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.ReadOnly = true;
            this.dgvNotes.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotes.Size = new System.Drawing.Size(494, 366);
            this.dgvNotes.TabIndex = 5;
            this.dgvNotes.SelectionChanged += new System.EventHandler(this.dgvNotes_SelectionChanged);
            this.dgvNotes.Enter += new System.EventHandler(this.dgvNotes_Enter);
            this.dgvNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvNotes_KeyDown);
            this.dgvNotes.Leave += new System.EventHandler(this.dgvNotes_Leave);
            // 
            // dgvcNoteId
            // 
            this.dgvcNoteId.DataPropertyName = "NoteId";
            this.dgvcNoteId.HeaderText = "NoteId";
            this.dgvcNoteId.Name = "dgvcNoteId";
            this.dgvcNoteId.ReadOnly = true;
            this.dgvcNoteId.Visible = false;
            // 
            // dgvcCallId
            // 
            this.dgvcCallId.DataPropertyName = "CallId";
            this.dgvcCallId.HeaderText = "CallId";
            this.dgvcCallId.Name = "dgvcCallId";
            this.dgvcCallId.ReadOnly = true;
            this.dgvcCallId.Visible = false;
            // 
            // dgvcOperatorId
            // 
            this.dgvcOperatorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvcOperatorId.DataPropertyName = "operatorId";
            this.dgvcOperatorId.HeaderText = "operatorId";
            this.dgvcOperatorId.Name = "dgvcOperatorId";
            this.dgvcOperatorId.ReadOnly = true;
            this.dgvcOperatorId.Visible = false;
            // 
            // dgvcCreatedOn
            // 
            this.dgvcCreatedOn.DataPropertyName = "created_on";
            this.dgvcCreatedOn.HeaderText = "created_on";
            this.dgvcCreatedOn.Name = "dgvcCreatedOn";
            this.dgvcCreatedOn.ReadOnly = true;
            this.dgvcCreatedOn.Visible = false;
            // 
            // dgvcUpdatedOn
            // 
            this.dgvcUpdatedOn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcUpdatedOn.DataPropertyName = "updated_on";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvcUpdatedOn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcUpdatedOn.HeaderText = "updated_on";
            this.dgvcUpdatedOn.Name = "dgvcUpdatedOn";
            this.dgvcUpdatedOn.ReadOnly = true;
            this.dgvcUpdatedOn.Visible = false;
            // 
            // dgvcNote
            // 
            this.dgvcNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcNote.DataPropertyName = "Note";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcNote.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcNote.HeaderText = "Note";
            this.dgvcNote.MaxInputLength = 255;
            this.dgvcNote.Name = "dgvcNote";
            this.dgvcNote.ReadOnly = true;
            // 
            // bsNotes
            // 
            this.bsNotes.DataSource = typeof(C_DentalClaimTracker.notes);
            // 
            // pnlNotesControls
            // 
            this.pnlNotesControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNotesControls.Controls.Add(this.pnlGridControls);
            this.pnlNotesControls.Controls.Add(this.pnlEditorControls);
            this.pnlNotesControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNotesControls.Location = new System.Drawing.Point(0, 336);
            this.pnlNotesControls.Name = "pnlNotesControls";
            this.pnlNotesControls.Size = new System.Drawing.Size(496, 32);
            this.pnlNotesControls.TabIndex = 9;
            // 
            // pnlGridControls
            // 
            this.pnlGridControls.Controls.Add(this.lblAddNote);
            this.pnlGridControls.Controls.Add(this.lblRemoveNote);
            this.pnlGridControls.Controls.Add(this.lblEditNote);
            this.pnlGridControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridControls.Location = new System.Drawing.Point(0, 0);
            this.pnlGridControls.Name = "pnlGridControls";
            this.pnlGridControls.Size = new System.Drawing.Size(492, 28);
            this.pnlGridControls.TabIndex = 10;
            // 
            // lblAddNote
            // 
            this.lblAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAddNote.AutoSize = true;
            this.lblAddNote.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAddNote.Location = new System.Drawing.Point(3, 7);
            this.lblAddNote.Name = "lblAddNote";
            this.lblAddNote.Size = new System.Drawing.Size(38, 13);
            this.lblAddNote.TabIndex = 9;
            this.lblAddNote.Text = "&New...";
            this.lblAddNote.Click += new System.EventHandler(this.lblAddNote_Click);
            // 
            // lblRemoveNote
            // 
            this.lblRemoveNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRemoveNote.AutoSize = true;
            this.lblRemoveNote.Enabled = false;
            this.lblRemoveNote.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRemoveNote.Location = new System.Drawing.Point(91, 7);
            this.lblRemoveNote.Name = "lblRemoveNote";
            this.lblRemoveNote.Size = new System.Drawing.Size(38, 13);
            this.lblRemoveNote.TabIndex = 11;
            this.lblRemoveNote.Text = "Delete";
            this.lblRemoveNote.Click += new System.EventHandler(this.lblRemoveNote_Click);
            // 
            // lblEditNote
            // 
            this.lblEditNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEditNote.AutoSize = true;
            this.lblEditNote.Enabled = false;
            this.lblEditNote.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEditNote.Location = new System.Drawing.Point(47, 7);
            this.lblEditNote.Name = "lblEditNote";
            this.lblEditNote.Size = new System.Drawing.Size(34, 13);
            this.lblEditNote.TabIndex = 10;
            this.lblEditNote.Text = "&Edit...";
            this.lblEditNote.Click += new System.EventHandler(this.lblEditNote_Click);
            // 
            // pnlEditorControls
            // 
            this.pnlEditorControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlEditorControls.Controls.Add(this.btnQuickText4);
            this.pnlEditorControls.Controls.Add(this.btnQuickText3);
            this.pnlEditorControls.Controls.Add(this.btnQuickText2);
            this.pnlEditorControls.Controls.Add(this.btnQuickText1);
            this.pnlEditorControls.Controls.Add(this.btnSaveNote);
            this.pnlEditorControls.Controls.Add(this.btnCancelNote);
            this.pnlEditorControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditorControls.Location = new System.Drawing.Point(0, 0);
            this.pnlEditorControls.Name = "pnlEditorControls";
            this.pnlEditorControls.Size = new System.Drawing.Size(492, 28);
            this.pnlEditorControls.TabIndex = 10;
            // 
            // btnQuickText4
            // 
            this.btnQuickText4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuickText4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuickText4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickText4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickText4.Location = new System.Drawing.Point(219, 2);
            this.btnQuickText4.Name = "btnQuickText4";
            this.btnQuickText4.Size = new System.Drawing.Size(65, 23);
            this.btnQuickText4.TabIndex = 14;
            this.btnQuickText4.Text = "4";
            this.btnQuickText4.UseVisualStyleBackColor = false;
            this.btnQuickText4.Visible = false;
            this.btnQuickText4.Click += new System.EventHandler(this.QuickText_Click);
            // 
            // btnQuickText3
            // 
            this.btnQuickText3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuickText3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuickText3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickText3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickText3.Location = new System.Drawing.Point(148, 2);
            this.btnQuickText3.Name = "btnQuickText3";
            this.btnQuickText3.Size = new System.Drawing.Size(65, 23);
            this.btnQuickText3.TabIndex = 13;
            this.btnQuickText3.Text = "3";
            this.btnQuickText3.UseVisualStyleBackColor = false;
            this.btnQuickText3.Visible = false;
            this.btnQuickText3.Click += new System.EventHandler(this.QuickText_Click);
            // 
            // btnQuickText2
            // 
            this.btnQuickText2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuickText2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuickText2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickText2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickText2.Location = new System.Drawing.Point(77, 2);
            this.btnQuickText2.Name = "btnQuickText2";
            this.btnQuickText2.Size = new System.Drawing.Size(65, 23);
            this.btnQuickText2.TabIndex = 12;
            this.btnQuickText2.Text = "2";
            this.btnQuickText2.UseVisualStyleBackColor = false;
            this.btnQuickText2.Visible = false;
            this.btnQuickText2.Click += new System.EventHandler(this.QuickText_Click);
            // 
            // btnQuickText1
            // 
            this.btnQuickText1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuickText1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuickText1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickText1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickText1.Location = new System.Drawing.Point(6, 2);
            this.btnQuickText1.Name = "btnQuickText1";
            this.btnQuickText1.Size = new System.Drawing.Size(65, 23);
            this.btnQuickText1.TabIndex = 11;
            this.btnQuickText1.Text = "1";
            this.btnQuickText1.UseVisualStyleBackColor = false;
            this.btnQuickText1.Visible = false;
            this.btnQuickText1.Click += new System.EventHandler(this.QuickText_Click);
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNote.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNote.Location = new System.Drawing.Point(353, 3);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(65, 23);
            this.btnSaveNote.TabIndex = 0;
            this.btnSaveNote.Text = "Save";
            this.btnSaveNote.UseVisualStyleBackColor = false;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // btnCancelNote
            // 
            this.btnCancelNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancelNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelNote.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNote.Location = new System.Drawing.Point(424, 3);
            this.btnCancelNote.Name = "btnCancelNote";
            this.btnCancelNote.Size = new System.Drawing.Size(65, 23);
            this.btnCancelNote.TabIndex = 1;
            this.btnCancelNote.Text = "Cancel";
            this.btnCancelNote.UseVisualStyleBackColor = false;
            this.btnCancelNote.Click += new System.EventHandler(this.btnCancelNote_Click);
            // 
            // pnlNotesMain
            // 
            this.pnlNotesMain.Controls.Add(this.pnlGrid);
            this.pnlNotesMain.Controls.Add(this.pnlEditor);
            this.pnlNotesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotesMain.Location = new System.Drawing.Point(0, 0);
            this.pnlNotesMain.Name = "pnlNotesMain";
            this.pnlNotesMain.Size = new System.Drawing.Size(496, 368);
            this.pnlNotesMain.TabIndex = 10;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrid.Controls.Add(this.dgvNotes);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(496, 368);
            this.pnlGrid.TabIndex = 11;
            // 
            // pnlEditor
            // 
            this.pnlEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditor.Controls.Add(this.rtbNote);
            this.pnlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditor.Location = new System.Drawing.Point(0, 0);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(496, 368);
            this.pnlEditor.TabIndex = 11;
            // 
            // rtbNote
            // 
            this.rtbNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rtbNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNote.Location = new System.Drawing.Point(0, 0);
            this.rtbNote.MaxLength = 999;
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(494, 366);
            this.rtbNote.TabIndex = 5;
            this.rtbNote.Text = "";
            // 
            // NotesGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlNotesControls);
            this.Controls.Add(this.pnlNotesMain);
            this.Name = "NotesGrid";
            this.Size = new System.Drawing.Size(496, 368);
            this.Load += new System.EventHandler(this.NotesGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotes)).EndInit();
            this.pnlNotesControls.ResumeLayout(false);
            this.pnlGridControls.ResumeLayout(false);
            this.pnlGridControls.PerformLayout();
            this.pnlEditorControls.ResumeLayout(false);
            this.pnlNotesMain.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.Panel pnlNotesControls;
        private System.Windows.Forms.Panel pnlGridControls;
        private System.Windows.Forms.Label lblAddNote;
        private System.Windows.Forms.Label lblRemoveNote;
        private System.Windows.Forms.Label lblEditNote;
        private System.Windows.Forms.Panel pnlEditorControls;
        private System.Windows.Forms.Button btnSaveNote;
        private System.Windows.Forms.Button btnCancelNote;
        private System.Windows.Forms.Panel pnlNotesMain;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.BindingSource bsNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNoteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcOperatorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCreatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcUpdatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNote;
        private System.Windows.Forms.Button btnQuickText4;
        private System.Windows.Forms.Button btnQuickText3;
        private System.Windows.Forms.Button btnQuickText2;
        private System.Windows.Forms.Button btnQuickText1;
        private System.Windows.Forms.ToolTip ttipMain;
    }
}
