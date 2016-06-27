namespace C_DentalClaimTracker.Messaging
{
    partial class frmMessagingCenter
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Attention Required");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("In Process Messages");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("All Messages");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Sent Messages");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessagingCenter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvNavigation = new System.Windows.Forms.TreeView();
            this.imglstTreeView = new System.Windows.Forms.ImageList(this.components);
            this.spltMessageReading = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMessageList = new System.Windows.Forms.DataGridView();
            this.btnSendReceive = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnReplyTop = new System.Windows.Forms.Button();
            this.btnReturnTop = new System.Windows.Forms.Button();
            this.btnResolvingTop = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.colSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.colMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.spltMessageReading.Panel1.SuspendLayout();
            this.spltMessageReading.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessageList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 30);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvNavigation);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.spltMessageReading);
            this.splitContainer1.Size = new System.Drawing.Size(944, 598);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 1;
            // 
            // trvNavigation
            // 
            this.trvNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.trvNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvNavigation.ImageIndex = 0;
            this.trvNavigation.ImageList = this.imglstTreeView;
            this.trvNavigation.Location = new System.Drawing.Point(0, 0);
            this.trvNavigation.Name = "trvNavigation";
            treeNode1.Name = "nodAttention";
            treeNode1.Text = "Attention Required";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "nodInProcess";
            treeNode2.Text = "In Process Messages";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "nodAllMessages";
            treeNode3.Text = "All Messages";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "nodSent";
            treeNode4.Text = "Sent Messages";
            this.trvNavigation.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.trvNavigation.SelectedImageIndex = 0;
            this.trvNavigation.ShowPlusMinus = false;
            this.trvNavigation.ShowRootLines = false;
            this.trvNavigation.Size = new System.Drawing.Size(203, 80);
            this.trvNavigation.TabIndex = 0;
            // 
            // imglstTreeView
            // 
            this.imglstTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstTreeView.ImageStream")));
            this.imglstTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstTreeView.Images.SetKeyName(0, "page_white_star.png");
            this.imglstTreeView.Images.SetKeyName(1, "page_white_wrench.png");
            this.imglstTreeView.Images.SetKeyName(2, "page_white_stack.png");
            this.imglstTreeView.Images.SetKeyName(3, "page_white_put.png");
            // 
            // spltMessageReading
            // 
            this.spltMessageReading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltMessageReading.Location = new System.Drawing.Point(0, 0);
            this.spltMessageReading.Name = "spltMessageReading";
            // 
            // spltMessageReading.Panel1
            // 
            this.spltMessageReading.Panel1.Controls.Add(this.dgvMessageList);
            this.spltMessageReading.Size = new System.Drawing.Size(737, 598);
            this.spltMessageReading.SplitterDistance = 234;
            this.spltMessageReading.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCreateNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 30);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSendReceive);
            this.panel3.Controls.Add(this.btnComplete);
            this.panel3.Controls.Add(this.btnResolvingTop);
            this.panel3.Controls.Add(this.btnReturnTop);
            this.panel3.Controls.Add(this.btnReplyTop);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(206, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 30);
            this.panel3.TabIndex = 5;
            // 
            // dgvMessageList
            // 
            this.dgvMessageList.AllowUserToAddRows = false;
            this.dgvMessageList.AllowUserToDeleteRows = false;
            this.dgvMessageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessageList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSender,
            this.colDate,
            this.colStatus,
            this.colMessage});
            this.dgvMessageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMessageList.Location = new System.Drawing.Point(0, 0);
            this.dgvMessageList.Name = "dgvMessageList";
            this.dgvMessageList.ReadOnly = true;
            this.dgvMessageList.RowHeadersVisible = false;
            this.dgvMessageList.Size = new System.Drawing.Size(234, 598);
            this.dgvMessageList.TabIndex = 0;
            // 
            // btnSendReceive
            // 
            this.btnSendReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendReceive.Image = global::C_DentalClaimTracker.Properties.Resources.arrow_refresh;
            this.btnSendReceive.Location = new System.Drawing.Point(619, 3);
            this.btnSendReceive.Name = "btnSendReceive";
            this.btnSendReceive.Size = new System.Drawing.Size(114, 23);
            this.btnSendReceive.TabIndex = 5;
            this.btnSendReceive.Text = "&Send/Receive";
            this.btnSendReceive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSendReceive.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            this.btnComplete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnComplete.Image = global::C_DentalClaimTracker.Properties.Resources.accept1;
            this.btnComplete.Location = new System.Drawing.Point(276, 0);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(92, 28);
            this.btnComplete.TabIndex = 4;
            this.btnComplete.Text = "&Complete";
            this.btnComplete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // btnReplyTop
            // 
            this.btnReplyTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReplyTop.Image = global::C_DentalClaimTracker.Properties.Resources.bullet_go;
            this.btnReplyTop.Location = new System.Drawing.Point(0, 0);
            this.btnReplyTop.Name = "btnReplyTop";
            this.btnReplyTop.Size = new System.Drawing.Size(92, 28);
            this.btnReplyTop.TabIndex = 1;
            this.btnReplyTop.Text = "&Reply";
            this.btnReplyTop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReplyTop.UseVisualStyleBackColor = true;
            // 
            // btnReturnTop
            // 
            this.btnReturnTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReturnTop.Image = global::C_DentalClaimTracker.Properties.Resources.arrow_rotate_clockwise3;
            this.btnReturnTop.Location = new System.Drawing.Point(92, 0);
            this.btnReturnTop.Name = "btnReturnTop";
            this.btnReturnTop.Size = new System.Drawing.Size(92, 28);
            this.btnReturnTop.TabIndex = 2;
            this.btnReturnTop.Text = "Re&turn";
            this.btnReturnTop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturnTop.UseVisualStyleBackColor = true;
            // 
            // btnResolvingTop
            // 
            this.btnResolvingTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnResolvingTop.Image = global::C_DentalClaimTracker.Properties.Resources.page_white_code_red1;
            this.btnResolvingTop.Location = new System.Drawing.Point(184, 0);
            this.btnResolvingTop.Name = "btnResolvingTop";
            this.btnResolvingTop.Size = new System.Drawing.Size(92, 28);
            this.btnResolvingTop.TabIndex = 3;
            this.btnResolvingTop.Text = "Resol&ving";
            this.btnResolvingTop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResolvingTop.UseVisualStyleBackColor = true;
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Image = global::C_DentalClaimTracker.Properties.Resources.add;
            this.btnCreateNew.Location = new System.Drawing.Point(3, 3);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(92, 23);
            this.btnCreateNew.TabIndex = 0;
            this.btnCreateNew.Text = "Create New";
            this.btnCreateNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateNew.UseVisualStyleBackColor = true;
            // 
            // colSender
            // 
            this.colSender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSender.HeaderText = "Sender";
            this.colSender.Name = "colSender";
            this.colSender.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 85;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "ST";
            this.colStatus.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colStatus.ToolTipText = "Status";
            this.colStatus.Width = 30;
            // 
            // colMessage
            // 
            this.colMessage.HeaderText = "MessageObject";
            this.colMessage.Name = "colMessage";
            this.colMessage.ReadOnly = true;
            this.colMessage.Visible = false;
            // 
            // frmMessagingCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 628);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMessagingCenter";
            this.Text = "Messaging Center";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.spltMessageReading.Panel1.ResumeLayout(false);
            this.spltMessageReading.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessageList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvNavigation;
        private System.Windows.Forms.ImageList imglstTreeView;
        private System.Windows.Forms.SplitContainer spltMessageReading;
        private System.Windows.Forms.Button btnResolvingTop;
        private System.Windows.Forms.Button btnReturnTop;
        private System.Windows.Forms.Button btnReplyTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.DataGridView dgvMessageList;
        private System.Windows.Forms.Button btnSendReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewImageColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessage;
    }
}