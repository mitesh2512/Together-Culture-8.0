namespace Together_Culture
{
    partial class ApproveandSearchMem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproveandSearchMem));
            txtSearchMember = new TextBox();
            SearchMem = new Label();
            btnSearchMember = new Button();
            dataGridViewMembers = new DataGridView();
            Approve = new DataGridViewCheckBoxColumn();
            btnSaveChanges = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembers).BeginInit();
            SuspendLayout();
            // 
            // txtSearchMember
            // 
            txtSearchMember.Location = new Point(306, 202);
            txtSearchMember.Name = "txtSearchMember";
            txtSearchMember.Size = new Size(181, 27);
            txtSearchMember.TabIndex = 0;
            // 
            // SearchMem
            // 
            SearchMem.AutoSize = true;
            SearchMem.Location = new Point(187, 209);
            SearchMem.Name = "SearchMem";
            SearchMem.Size = new Size(113, 20);
            SearchMem.TabIndex = 1;
            SearchMem.Text = "Search Member";
            // 
            // btnSearchMember
            // 
            btnSearchMember.Location = new Point(197, 507);
            btnSearchMember.Name = "btnSearchMember";
            btnSearchMember.Size = new Size(138, 29);
            btnSearchMember.TabIndex = 2;
            btnSearchMember.Text = "Search Member";
            btnSearchMember.UseVisualStyleBackColor = true;
            btnSearchMember.Click += btnSearchMember_Click;
            // 
            // dataGridViewMembers
            // 
            dataGridViewMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMembers.Columns.AddRange(new DataGridViewColumn[] { Approve });
            dataGridViewMembers.Location = new Point(187, 246);
            dataGridViewMembers.Name = "dataGridViewMembers";
            dataGridViewMembers.RowHeadersWidth = 51;
            dataGridViewMembers.Size = new Size(682, 235);
            dataGridViewMembers.TabIndex = 3;
            // 
            // Approve
            // 
            Approve.HeaderText = "Approve";
            Approve.MinimumWidth = 6;
            Approve.Name = "Approve";
            Approve.Width = 125;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(341, 507);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(156, 29);
            btnSaveChanges.TabIndex = 4;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // ApproveandSearchMem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1056, 739);
            Controls.Add(btnSaveChanges);
            Controls.Add(dataGridViewMembers);
            Controls.Add(btnSearchMember);
            Controls.Add(SearchMem);
            Controls.Add(txtSearchMember);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ApproveandSearchMem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApproveandSearchMem";
            Load += ApproveandSearchMem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchMember;
        private Label SearchMem;
        private Button btnSearchMember;
        private DataGridView dataGridViewMembers;
        private Button btnSaveChanges;
        private DataGridViewCheckBoxColumn Approve;
        // private CheckBox AddapproveColumn;
    }
}