namespace Together_Culture
{
    partial class Tags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tags));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            button3 = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(64, 132);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 0;
            label1.Text = "New Tag :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(525, 109);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 1;
            label2.Text = "Search Members :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(48, 321);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 2;
            label3.Text = "Assign Tag :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(321, 31);
            label4.Name = "label4";
            label4.Size = new Size(273, 28);
            label4.TabIndex = 3;
            label4.Text = "Tag Management and Insights";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(160, 132);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 32);
            textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(160, 312);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 33);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Member Dropdown";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 11F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(160, 373);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(201, 33);
            comboBox2.TabIndex = 6;
            comboBox2.Text = "Tag Dropdown";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 11F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(699, 100);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(177, 33);
            comboBox3.TabIndex = 7;
            comboBox3.Text = "Tag Dropdown";
            comboBox3.SelectedIndexChanged += onIndex_change;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(137, 203);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(130, 45);
            button1.TabIndex = 8;
            button1.Text = "Create Tag";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(137, 452);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(130, 45);
            button3.TabIndex = 10;
            button3.Text = "Assign Tag";
            button3.UseVisualStyleBackColor = true;
            button3.Click += AssignTag_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(624, 178);
            label5.Name = "label5";
            label5.Size = new Size(119, 23);
            label5.TabIndex = 11;
            label5.Text = "Search Results";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(525, 218);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 12;
            // 
            // Tags
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Tags";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tags";
            Load += Tags_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button1;
        private Button button3;
        private Label label5;
        private DataGridView dataGridView1;
    }
}