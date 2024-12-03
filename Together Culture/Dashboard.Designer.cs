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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            listBox1 = new ListBox();
            SearchMemship = new Button();
            EventButton = new Button();
            listBox2 = new ListBox();
            TagsButton = new Button();
            listBox3 = new ListBox();
            button4 = new Button();
            listBox4 = new ListBox();
            Member = new Label();
            label2 = new Label();
            label3 = new Label();
            appseamem = new Label();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            Logout = new Button();
            AdminProfile = new Button();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(296, 165);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(581, 344);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // SearchMemship
            // 
            SearchMemship.Location = new Point(458, 461);
            SearchMemship.Margin = new Padding(3, 4, 3, 4);
            SearchMemship.Name = "SearchMemship";
            SearchMemship.Size = new Size(259, 39);
            SearchMemship.TabIndex = 1;
            SearchMemship.Text = "Search Memberships";
            SearchMemship.UseVisualStyleBackColor = true;
            SearchMemship.Click += mem_onClick;
            // 
            // EventButton
            // 
            EventButton.Location = new Point(458, 887);
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
            listBox2.Location = new Point(296, 554);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(581, 384);
            listBox2.TabIndex = 2;
            // 
            // TagsButton
            // 
            TagsButton.Location = new Point(1053, 461);
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
            listBox3.Size = new Size(560, 344);
            listBox3.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(1053, 887);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(259, 39);
            button4.TabIndex = 7;
            button4.Text = "Approve Search Member";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.Location = new Point(883, 554);
            listBox4.Margin = new Padding(3, 4, 3, 4);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(581, 384);
            listBox4.TabIndex = 6;
            // 
            // Member
            // 
            Member.AutoSize = true;
            Member.Location = new Point(296, 141);
            Member.Name = "Member";
            Member.Size = new Size(157, 20);
            Member.TabIndex = 8;
            Member.Text = "Membership Overview";
            Member.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 530);
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
            // appseamem
            // 
            appseamem.AutoSize = true;
            appseamem.Location = new Point(883, 530);
            appseamem.Name = "appseamem";
            appseamem.Size = new Size(174, 20);
            appseamem.TabIndex = 11;
            appseamem.Text = "Approve Search Member";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(Logout);
            panel1.Controls.Add(AdminProfile);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1802, 125);
            panel1.TabIndex = 13;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(145, 76);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // Logout
            // 
            Logout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Logout.Location = new Point(1294, 41);
            Logout.Name = "Logout";
            Logout.Size = new Size(173, 47);
            Logout.TabIndex = 17;
            Logout.Text = "Log Out";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // AdminProfile
            // 
            AdminProfile.Location = new Point(1116, 41);
            AdminProfile.Name = "AdminProfile";
            AdminProfile.Size = new Size(173, 47);
            AdminProfile.TabIndex = 16;
            AdminProfile.Text = "Admin Profile";
            AdminProfile.UseVisualStyleBackColor = true;
            AdminProfile.Click += UserProfile_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(EventButton);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(TagsButton);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(SearchMemship);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(appseamem);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(listBox4);
            panel2.Controls.Add(Member);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(listBox3);
            panel2.Controls.Add(listBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1802, 1055);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(883, 554);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(581, 384);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(296, 554);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(581, 384);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(883, 165);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(581, 344);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(296, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(581, 344);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Red;
            ClientSize = new Size(1802, 1055);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button SearchMemship;
        private Button EventButton;
        private ListBox listBox2;
        private Button TagsButton;
        private ListBox listBox3;
        private Button button4;
        private ListBox listBox4;
        private Label Member;
        private Label label2;
        private Label label3;
        private Label appseamem;
        private Panel panel1;
        private Button Logout;
        private Button AdminProfile;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}