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
            panel1 = new Panel();
            button7 = new Button();
            Logout = new Button();
            button5 = new Button();
            button8 = new Button();
            UserProfile = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(522, 349);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(137, 204);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(543, 510);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += mem_onClick;
            // 
            // button2
            // 
            button2.Location = new Point(765, 510);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(743, 349);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(137, 204);
            listBox2.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(952, 510);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(930, 349);
            listBox3.Margin = new Padding(3, 4, 3, 4);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(137, 204);
            listBox3.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(1135, 510);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.Location = new Point(1114, 349);
            listBox4.Margin = new Padding(3, 4, 3, 4);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(137, 204);
            listBox4.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(522, 325);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 8;
            label1.Text = "Member Overview";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(750, 325);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 9;
            label2.Text = "Event Overview";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(935, 325);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 10;
            label3.Text = "Top Tags and Trends";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1114, 325);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 11;
            label4.Text = "Engagement Insights";
            // 
            // panel1
            // 
            panel1.Controls.Add(button7);
            panel1.Controls.Add(Logout);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(UserProfile);
            panel1.Controls.Add(button6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1823, 125);
            panel1.TabIndex = 13;
            // 
            // button7
            // 
            button7.Location = new Point(1091, 41);
            button7.Name = "button7";
            button7.Size = new Size(173, 47);
            button7.TabIndex = 14;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            Logout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Logout.Location = new Point(1628, 41);
            Logout.Name = "Logout";
            Logout.Size = new Size(173, 47);
            Logout.TabIndex = 17;
            Logout.Text = "Log Out";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 41);
            button5.Name = "button5";
            button5.Size = new Size(173, 47);
            button5.TabIndex = 13;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(1270, 41);
            button8.Name = "button8";
            button8.Size = new Size(173, 47);
            button8.TabIndex = 15;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // UserProfile
            // 
            UserProfile.Location = new Point(1449, 41);
            UserProfile.Name = "UserProfile";
            UserProfile.Size = new Size(173, 47);
            UserProfile.TabIndex = 16;
            UserProfile.Text = "User Profile";
            UserProfile.UseVisualStyleBackColor = true;
            UserProfile.Click += UserProfile_Click;
            // 
            // button6
            // 
            button6.Location = new Point(909, 41);
            button6.Name = "button6";
            button6.Size = new Size(173, 47);
            button6.TabIndex = 13;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1823, 901);
            Controls.Add(panel1);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            FormClosing += Dashboard_FormClosing;
            panel1.ResumeLayout(false);
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
        private Panel panel1;
        private Button button7;
        private Button Logout;
        private Button button5;
        private Button button8;
        private Button UserProfile;
        private Button button6;
    }
}