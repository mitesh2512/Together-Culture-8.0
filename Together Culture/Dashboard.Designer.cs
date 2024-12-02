﻿namespace Together_Culture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            listBox1 = new ListBox();
            SearchMem = new Button();
            EventButton = new Button();
            listBox2 = new ListBox();
            TagsButton = new Button();
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
            AdminProfile = new Button();
            button6 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(296, 165);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(310, 184);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // SearchMem
            // 
            SearchMem.Location = new Point(321, 292);
            SearchMem.Margin = new Padding(3, 4, 3, 4);
            SearchMem.Name = "SearchMem";
            SearchMem.Size = new Size(259, 39);
            SearchMem.TabIndex = 1;
            SearchMem.Text = "Search Member";
            SearchMem.UseVisualStyleBackColor = true;
            SearchMem.Click += mem_onClick;
            // 
            // EventButton
            // 
            EventButton.Location = new Point(321, 611);
            EventButton.Margin = new Padding(3, 4, 3, 4);
            EventButton.Name = "EventButton";
            EventButton.Size = new Size(259, 39);
            EventButton.TabIndex = 3;
            EventButton.Text = "Event Search";
            EventButton.UseVisualStyleBackColor = true;
            EventButton.Click += button2_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(296, 476);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(310, 184);
            listBox2.TabIndex = 2;
            // 
            // TagsButton
            // 
            TagsButton.Location = new Point(909, 292);
            TagsButton.Margin = new Padding(3, 4, 3, 4);
            TagsButton.Name = "TagsButton";
            TagsButton.Size = new Size(259, 39);
            TagsButton.TabIndex = 5;
            TagsButton.Text = "Tags and Trends";
            TagsButton.UseVisualStyleBackColor = true;
            TagsButton.Click += TagsButton_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(883, 165);
            listBox3.Margin = new Padding(3, 4, 3, 4);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(310, 184);
            listBox3.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(909, 611);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(259, 39);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.Location = new Point(883, 476);
            listBox4.Margin = new Padding(3, 4, 3, 4);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(310, 184);
            listBox4.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 141);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 8;
            label1.Text = "Member Overview";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 452);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 9;
            label2.Text = "Event Overview";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(883, 141);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 10;
            label3.Text = "Top Tags and Trends";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(883, 452);
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
            panel1.Controls.Add(AdminProfile);
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
            Logout.Location = new Point(1627, 41);
            Logout.Name = "Logout";
            Logout.Size = new Size(173, 47);
            Logout.TabIndex = 17;
            Logout.Text = "Log Out";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // button5
            // 
            button5.Location = new Point(11, 41);
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
            // AdminProfile
            // 
            AdminProfile.Location = new Point(1449, 41);
            AdminProfile.Name = "AdminProfile";
            AdminProfile.Size = new Size(173, 47);
            AdminProfile.TabIndex = 16;
            AdminProfile.Text = "Admin Profile";
            AdminProfile.UseVisualStyleBackColor = true;
            AdminProfile.Click += UserProfile_Click;
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
            // panel2
            // 
            panel2.Controls.Add(EventButton);
            panel2.Controls.Add(SearchMem);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(listBox4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(TagsButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(listBox3);
            panel2.Controls.Add(listBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1823, 901);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1823, 901);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            FormClosing += Dashboard_FormClosing;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button SearchMem;
        private Button EventButton;
        private ListBox listBox2;
        private Button TagsButton;
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
        private Button AdminProfile;
        private Button button6;
        private Panel panel2;
    }
}