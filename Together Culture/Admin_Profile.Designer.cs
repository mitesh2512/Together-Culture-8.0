namespace Together_Culture
{
    partial class Admin_Profile
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
            PictureBox pictureBox1;
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(371, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(96, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(487, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(96, 266);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(365, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(486, 266);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(97, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(96, 339);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(487, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(96, 105);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(64, 23);
            textBox7.TabIndex = 6;
            textBox7.Text = "First Name";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(371, 105);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(90, 23);
            textBox8.TabIndex = 7;
            textBox8.Text = "Last Name";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(96, 169);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 8;
            textBox9.Text = "Email Address";
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(96, 237);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 9;
            textBox10.Text = "Address";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(486, 237);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 10;
            textBox11.Text = "Postcode";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(96, 310);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 23);
            textBox12.TabIndex = 11;
            textBox12.Text = "Contact number";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(656, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 104);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(302, 395);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 13;
            button1.Text = "Edit Profile";
            button1.UseVisualStyleBackColor = true;
            // 
            // Admin_Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Admin_Profile";
            Text = "Admin Profile";
            Load += Admin_Profile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private PictureBox pictureBox1;
        private Button button1;
    }
}