namespace Together_Culture
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            UserName = new TextBox();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            LoginButton = new Button();
            Remember = new CheckBox();
            ForgotPass = new LinkLabel();
            RegisterPage = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.Location = new Point(1140, 390);
            UserName.Name = "UserName";
            UserName.Size = new Size(231, 27);
            UserName.TabIndex = 1;
            UserName.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1140, 454);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 27);
            textBox2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-14, -32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1080, 1080);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1140, 367);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Username";
            label1.Click += label1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1140, 431);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(1210, 501);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += Login_Button;
            // 
            // Remember
            // 
            Remember.AutoSize = true;
            Remember.Location = new Point(1140, 561);
            Remember.Name = "Remember";
            Remember.Size = new Size(104, 24);
            Remember.TabIndex = 8;
            Remember.Text = "Remember";
            Remember.UseVisualStyleBackColor = true;
            // 
            // ForgotPass
            // 
            ForgotPass.AutoSize = true;
            ForgotPass.Location = new Point(1246, 561);
            ForgotPass.Name = "ForgotPass";
            ForgotPass.Size = new Size(125, 20);
            ForgotPass.TabIndex = 9;
            ForgotPass.TabStop = true;
            ForgotPass.Text = "Forgot Password?";
            // 
            // RegisterPage
            // 
            RegisterPage.Location = new Point(1210, 622);
            RegisterPage.Name = "RegisterPage";
            RegisterPage.Size = new Size(95, 29);
            RegisterPage.TabIndex = 10;
            RegisterPage.Text = "Register";
            RegisterPage.UseVisualStyleBackColor = true;
            RegisterPage.Click += Register_button;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 996);
            Controls.Add(RegisterPage);
            Controls.Add(ForgotPass);
            Controls.Add(Remember);
            Controls.Add(LoginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(UserName);
            Controls.Add(pictureBox3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            Name = "Login";
            Text = "Login Page";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox UserName;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Button LoginButton;
        private CheckBox Remember;
        private LinkLabel ForgotPass;
        private Button RegisterPage;
    }
}