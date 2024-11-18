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
            groupBox1 = new GroupBox();
            splitContainer1 = new SplitContainer();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.Location = new Point(140, 188);
            UserName.Name = "UserName";
            UserName.PlaceholderText = "Username";
            UserName.Size = new Size(231, 27);
            UserName.TabIndex = 1;
            UserName.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 252);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(231, 27);
            textBox2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(193, 52, 50);
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1028, 999);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 165);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Username";
            label1.Click += label1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 229);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(210, 299);
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
            Remember.Location = new Point(140, 359);
            Remember.Name = "Remember";
            Remember.Size = new Size(104, 24);
            Remember.TabIndex = 8;
            Remember.Text = "Remember";
            Remember.UseVisualStyleBackColor = true;
            Remember.CheckedChanged += Remember_CheckedChanged;
            // 
            // ForgotPass
            // 
            ForgotPass.AutoSize = true;
            ForgotPass.Location = new Point(246, 359);
            ForgotPass.Name = "ForgotPass";
            ForgotPass.Size = new Size(125, 20);
            ForgotPass.TabIndex = 9;
            ForgotPass.TabStop = true;
            ForgotPass.Text = "Forgot Password?";
            ForgotPass.LinkClicked += ForgotPass_LinkClicked;
            // 
            // RegisterPage
            // 
            RegisterPage.Location = new Point(210, 420);
            RegisterPage.Name = "RegisterPage";
            RegisterPage.Size = new Size(95, 29);
            RegisterPage.TabIndex = 10;
            RegisterPage.Text = "Register";
            RegisterPage.UseVisualStyleBackColor = true;
            RegisterPage.Click += Register_button;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(RegisterPage);
            groupBox1.Controls.Add(UserName);
            groupBox1.Controls.Add(ForgotPass);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Remember);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(LoginButton);
            groupBox1.Location = new Point(42, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 874);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Log";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Tomato;
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2MinSize = 300;
            splitContainer1.Size = new Size(1580, 999);
            splitContainer1.SplitterDistance = 1028;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 386);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 11;
            label3.Click += label3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1580, 999);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            Name = "Login";
            Text = "Login Page";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
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
        private GroupBox groupBox1;
        private SplitContainer splitContainer1;
        private Label label3;
    }
}