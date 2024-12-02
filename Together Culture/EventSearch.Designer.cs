
namespace Together_Culture
{
    partial class EventSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventSearch));
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11F);
            dateTimePicker1.Location = new Point(176, 215);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(198, 32);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 11F);
            dateTimePicker2.Location = new Point(176, 287);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(198, 32);
            dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(34, 133);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 2;
            label1.Text = "Event Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(34, 215);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 3;
            label2.Text = "Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(42, 290);
            label3.Name = "label3";
            label3.Size = new Size(91, 28);
            label3.TabIndex = 4;
            label3.Text = "End Date";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(53, 419);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(115, 45);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(247, 419);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(115, 45);
            button2.TabIndex = 6;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DimGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(411, 73);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(489, 412);
            dataGridView1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(73, 36);
            label4.Name = "label4";
            label4.Size = new Size(264, 30);
            label4.TabIndex = 9;
            label4.Text = "Event Attendance Analysis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(621, 49);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 11;
            label5.Text = "SEARCH RESULTS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(464, 529);
            label6.Name = "label6";
            label6.Size = new Size(128, 23);
            label6.TabIndex = 12;
            label6.Text = "Total Attendees";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(643, 527);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 30);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 27);
            textBox2.TabIndex = 14;
            // 
            // EventSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(914, 600);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "EventSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Event Search";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}