namespace Together_Culture
{
    partial class Reset_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset_Password));
            LinkButton = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            Memberid = new TextBox();
            Ress_Pass = new Label();
            pictureBox1 = new PictureBox();
            LinkSent = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LinkButton
            // 
            LinkButton.Location = new Point(192, 401);
            LinkButton.Name = "LinkButton";
            LinkButton.Size = new Size(94, 29);
            LinkButton.TabIndex = 0;
            LinkButton.Text = "Send Link";
            LinkButton.UseVisualStyleBackColor = true;
            LinkButton.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(139, 371);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Mail";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(261, 371);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(88, 24);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Message";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Memberid
            // 
            Memberid.AccessibleName = "Memberid";
            Memberid.Location = new Point(139, 329);
            Memberid.Name = "Memberid";
            Memberid.PlaceholderText = "Enter Your Member ID";
            Memberid.Size = new Size(210, 27);
            Memberid.TabIndex = 3;
            Memberid.TextChanged += Memberid_TextChanged;
            // 
            // Ress_Pass
            // 
            Ress_Pass.AutoSize = true;
            Ress_Pass.Location = new Point(139, 306);
            Ress_Pass.Name = "Ress_Pass";
            Ress_Pass.Size = new Size(80, 20);
            Ress_Pass.TabIndex = 4;
            Ress_Pass.Text = "MemberID";
            Ress_Pass.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(171, 219);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LinkSent
            // 
            LinkSent.AutoSize = true;
            LinkSent.Location = new Point(139, 454);
            LinkSent.Name = "LinkSent";
            LinkSent.Size = new Size(0, 20);
            LinkSent.TabIndex = 6;
            // 
            // Reset_Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(489, 648);
            Controls.Add(LinkSent);
            Controls.Add(pictureBox1);
            Controls.Add(Ress_Pass);
            Controls.Add(Memberid);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(LinkButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Reset_Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reset_pass";
            Load += Reset_pass_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LinkButton;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox Memberid;
        private Label Ress_Pass;
        private PictureBox pictureBox1;
        private Label LinkSent;
    }
}