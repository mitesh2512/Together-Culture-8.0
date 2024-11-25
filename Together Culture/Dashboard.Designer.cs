namespace Together_Culture
{
    partial class Dashboard
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            listBox2 = new ListBox();
            button3 = new Button();
            listBox3 = new ListBox();
            button4 = new Button();
            listBox4 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(88, 107);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 154);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(107, 228);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += mem_onClick;
            // 
            // button2
            // 
            button2.Location = new Point(301, 228);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(282, 107);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 154);
            listBox2.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(465, 228);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(445, 107);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 154);
            listBox3.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(625, 228);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(606, 107);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(120, 154);
            listBox4.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 89);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 8;
            label1.Text = "Member Overview";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 89);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 9;
            label2.Text = "Event Overview";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(450, 89);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 10;
            label3.Text = "Top Tags and Trends";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(606, 89);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 11;
            label4.Text = "Engagement Insights";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(listBox4);
            Controls.Add(button3);
            Controls.Add(listBox3);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private ListBox listBox2;
        private Button button3;
        private ListBox listBox3;
        private Button button4;
        private ListBox listBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}