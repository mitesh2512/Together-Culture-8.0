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
            pictureBox1.Location = new Point(5, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(790, 709);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PasswordTxtbox
            // 
            PasswordTxtbox.Location = new Point(983, 323);
            PasswordTxtbox.Name = "PasswordTxtbox";
            PasswordTxtbox.PasswordChar = '*';
            PasswordTxtbox.PlaceholderText = "Password";
            PasswordTxtbox.Size = new Size(231, 27);
            PasswordTxtbox.TabIndex = 12;
            PasswordTxtbox.Tag = "";
            // 
            // RegisterPageButton
            // 
            RegisterPageButton.Location = new Point(1053, 491);
            RegisterPageButton.Name = "RegisterPageButton";
            RegisterPageButton.Size = new Size(95, 29);
            RegisterPageButton.TabIndex = 18;
            RegisterPageButton.Text = "Register";
            RegisterPageButton.UseVisualStyleBackColor = true;
            RegisterPageButton.Click += RegisterPageButton_Click;
            // 
            // UserName
            // 
            UserName.Location = new Point(983, 259);
            UserName.Name = "UserName";
            UserName.PlaceholderText = "Username";
            UserName.Size = new Size(231, 27);
            UserName.TabIndex = 11;
            // 
            // ForgotPassLink
            // 
            ForgotPassLink.AutoSize = true;
            ForgotPassLink.Location = new Point(1089, 430);
            ForgotPassLink.Name = "ForgotPassLink";
            ForgotPassLink.Size = new Size(125, 20);
            ForgotPassLink.TabIndex = 17;
            ForgotPassLink.TabStop = true;
            ForgotPassLink.Text = "Forgot Password?";
            ForgotPassLink.LinkClicked += ForgotPassLink_LinkClicked;
            // 
            // UserLable
            // 
            UserLable.AutoSize = true;
            UserLable.Location = new Point(983, 236);
            UserLable.Name = "UserLable";
            UserLable.Size = new Size(75, 20);
            UserLable.TabIndex = 13;
            UserLable.Text = "Username";
            // 
            // Remember
            // 
            Remember.AutoSize = true;
            Remember.Location = new Point(983, 430);
            Remember.Name = "Remember";
            Remember.Size = new Size(104, 24);
            Remember.TabIndex = 16;
            Remember.Text = "Remember";
            Remember.UseVisualStyleBackColor = true;
            // 
            // Passwordlabel
            // 
            Passwordlabel.AutoSize = true;
            Passwordlabel.Location = new Point(983, 300);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(70, 20);
            Passwordlabel.TabIndex = 14;
            Passwordlabel.Text = "Password";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(1053, 370);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 15;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Location = new Point(1072, 457);
            Message.Name = "Message";
            Message.Size = new Size(0, 20);
            Message.TabIndex = 19;
            Message.Click += Message_Click;
            // 
            // Login_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1392, 715);
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
            Name = "Login_page";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login_page";
            WindowState = FormWindowState.Maximized;
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