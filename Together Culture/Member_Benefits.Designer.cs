namespace Together_Culture
{
    partial class Member_Benefits
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
            unusedbene = new Label();
            dataGridView2 = new DataGridView();
            Used = new DataGridViewButtonColumn();
            dataGridView1 = new DataGridView();
            usedbene = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // unusedbene
            // 
            unusedbene.AutoSize = true;
            unusedbene.Location = new Point(857, 199);
            unusedbene.Name = "unusedbene";
            unusedbene.Size = new Size(115, 20);
            unusedbene.TabIndex = 31;
            unusedbene.Text = "Unused Benefits";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Used });
            dataGridView2.Location = new Point(633, 235);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(501, 188);
            dataGridView2.TabIndex = 30;
            // 
            // Used
            // 
            Used.HeaderText = "Used Benefits";
            Used.MinimumWidth = 6;
            Used.Name = "Used";
            Used.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 235);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(499, 188);
            dataGridView1.TabIndex = 29;
            // 
            // usedbene
            // 
            usedbene.AutoSize = true;
            usedbene.ForeColor = SystemColors.Control;
            usedbene.Location = new Point(222, 199);
            usedbene.Name = "usedbene";
            usedbene.Size = new Size(99, 20);
            usedbene.TabIndex = 27;
            usedbene.Text = "Used Benefits";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(538, 115);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 26;
            label1.Text = "Member Benefits";
            // 
            // Member_Benefits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1176, 658);
            Controls.Add(unusedbene);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(usedbene);
            Controls.Add(label1);
            Name = "Member_Benefits";
            Text = "Member_Benefits";
            Load += Member_Benefits_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label unusedbene;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label usedbene;
        private Label label1;
        private DataGridViewButtonColumn Used;
    }
}