namespace Together_Culture
{
    partial class Login_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_page));
            pictureBox1 = new PictureBox();
            PasswordTxtbox = new TextBox();
            RegisterPageButton = new Button();
            UserName = new TextBox();
            ForgotPassLink = new LinkLabel();
            UserLable = new Label();
            Remember = new CheckBox();
            Passwordlabel = new Label();
            LoginButton = new Button();
            Message = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(691, 532);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PasswordTxtbox
            // 
            PasswordTxtbox.Location = new Point(860, 242);
            PasswordTxtbox.Margin = new Padding(3, 2, 3, 2);
            PasswordTxtbox.Name = "PasswordTxtbox";
            PasswordTxtbox.PasswordChar = '*';
            PasswordTxtbox.PlaceholderText = "Password";
            PasswordTxtbox.Size = new Size(203, 23);
            PasswordTxtbox.TabIndex = 12;
            PasswordTxtbox.Tag = "";
            // 
            // RegisterPageButton
            // 
            RegisterPageButton.Location = new Point(921, 368);
            RegisterPageButton.Margin = new Padding(3, 2, 3, 2);
            RegisterPageButton.Name = "RegisterPageButton";
            RegisterPageButton.Size = new Size(83, 22);
            RegisterPageButton.TabIndex = 18;
            RegisterPageButton.Text = "Register";
            RegisterPageButton.UseVisualStyleBackColor = true;
            RegisterPageButton.Click += RegisterPageButton_Click;
            // 
            // UserName
            // 
            UserName.Location = new Point(860, 194);
            UserName.Margin = new Padding(3, 2, 3, 2);
            UserName.Name = "UserName";
            UserName.PlaceholderText = "Username";
            UserName.Size = new Size(203, 23);
            UserName.TabIndex = 11;
            // 
            // ForgotPassLink
            // 
            ForgotPassLink.AutoSize = true;
            ForgotPassLink.Location = new Point(953, 322);
            ForgotPassLink.Name = "ForgotPassLink";
            ForgotPassLink.Size = new Size(100, 15);
            ForgotPassLink.TabIndex = 17;
            ForgotPassLink.TabStop = true;
            ForgotPassLink.Text = "Forgot Password?";
            ForgotPassLink.LinkClicked += ForgotPassLink_LinkClicked;
            // 
            // UserLable
            // 
            UserLable.AutoSize = true;
            UserLable.Location = new Point(860, 177);
            UserLable.Name = "UserLable";
            UserLable.Size = new Size(60, 15);
            UserLable.TabIndex = 13;
            UserLable.Text = "Username";
            // 
            // Remember
            // 
            Remember.AutoSize = true;
            Remember.Location = new Point(860, 322);
            Remember.Margin = new Padding(3, 2, 3, 2);
            Remember.Name = "Remember";
            Remember.Size = new Size(84, 19);
            Remember.TabIndex = 16;
            Remember.Text = "Remember";
            Remember.UseVisualStyleBackColor = true;
            // 
            // Passwordlabel
            // 
            Passwordlabel.AutoSize = true;
            Passwordlabel.Location = new Point(860, 225);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(57, 15);
            Passwordlabel.TabIndex = 14;
            Passwordlabel.Text = "Password";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(921, 278);
            LoginButton.Margin = new Padding(3, 2, 3, 2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(82, 22);
            LoginButton.TabIndex = 15;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Location = new Point(938, 343);
            Message.Name = "Message";
            Message.Size = new Size(0, 15);
            Message.TabIndex = 19;
            Message.Click += Message_Click;
            // 
            // Login_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1218, 536);
            Controls.Add(Message);
            Controls.Add(PasswordTxtbox);
            Controls.Add(RegisterPageButton);
            Controls.Add(UserName);
            Controls.Add(ForgotPassLink);
            Controls.Add(UserLable);
            Controls.Add(Remember);
            Controls.Add(Passwordlabel);
            Controls.Add(LoginButton);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login_page";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login_page";
            WindowState = FormWindowState.Maximized;
            Load += Login_page_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox PasswordTxtbox;
        private Button RegisterPageButton;
        private TextBox UserName;
        private LinkLabel ForgotPassLink;
        private Label UserLable;
        private CheckBox Remember;
        private Label Passwordlabel;
        private Button LoginButton;
        private Label Message;
    }
}