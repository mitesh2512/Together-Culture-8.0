namespace Together_Culture
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            registerButton = new Button();
            LoginPage = new Button();
            RegisterLable = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(208, 282);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(208, 343);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(488, 282);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(206, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(488, 343);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(206, 27);
            textBox6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(208, 194);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 6;
            label1.Text = "Full Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(208, 259);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 7;
            label2.Text = "Mobile Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(208, 319);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(488, 194);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 9;
            label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(488, 259);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 10;
            label5.Text = "Email Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Red;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(488, 319);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 11;
            label6.Text = "Confirm Password";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(488, 215);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // registerButton
            // 
            registerButton.ForeColor = Color.Navy;
            registerButton.Location = new Point(321, 417);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(94, 29);
            registerButton.TabIndex = 13;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // LoginPage
            // 
            LoginPage.BackColor = Color.Transparent;
            LoginPage.ForeColor = Color.Black;
            LoginPage.Location = new Point(488, 415);
            LoginPage.Margin = new Padding(3, 4, 3, 4);
            LoginPage.Name = "LoginPage";
            LoginPage.Size = new Size(86, 31);
            LoginPage.TabIndex = 14;
            LoginPage.Text = "Login";
            LoginPage.UseVisualStyleBackColor = false;
            LoginPage.Click += LoginPage_Click;
            // 
            // RegisterLable
            // 
            RegisterLable.AutoSize = true;
            RegisterLable.ForeColor = Color.Black;
            RegisterLable.Location = new Point(423, 482);
            RegisterLable.Name = "RegisterLable";
            RegisterLable.Size = new Size(0, 20);
            RegisterLable.TabIndex = 15;
            RegisterLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(375, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Red;
            ClientSize = new Size(946, 614);
            Controls.Add(pictureBox1);
            Controls.Add(RegisterLable);
            Controls.Add(LoginPage);
            Controls.Add(registerButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            ForeColor = Color.Red;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Together-Culture";
            FormClosing += Register_FormClosing;
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Button registerButton;
        private Button LoginPage;
        private Label RegisterLable;
        private PictureBox pictureBox1;
    }
}