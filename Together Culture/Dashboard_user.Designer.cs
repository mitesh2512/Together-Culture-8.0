namespace Together_Culture
{
    partial class Dashboard_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_user));
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            Logout = new Button();
            UserProfile = new Button();
            pictureBox1 = new PictureBox();
            MemBen = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(Logout);
            panel1.Controls.Add(UserProfile);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1788, 125);
            panel1.TabIndex = 14;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 29);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(145, 76);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
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
            // UserProfile
            // 
            UserProfile.Location = new Point(1449, 41);
            UserProfile.Name = "UserProfile";
            UserProfile.Size = new Size(173, 47);
            UserProfile.TabIndex = 16;
            UserProfile.Text = "User Profile";
            UserProfile.UseVisualStyleBackColor = true;
            UserProfile.Click += AdminProfile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(146, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(444, 316);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // MemBen
            // 
            MemBen.Location = new Point(303, 490);
            MemBen.Name = "MemBen";
            MemBen.Size = new Size(152, 29);
            MemBen.TabIndex = 16;
            MemBen.Text = "Member Benefits";
            MemBen.UseVisualStyleBackColor = true;
            MemBen.Click += MemBen_Click;
            // 
            // Dashboard_user
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1788, 790);
            Controls.Add(MemBen);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard_user";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox5;
        private Button Logout;
        private Button UserProfile;
        private PictureBox pictureBox1;
        private Button MemBen;
    }
}