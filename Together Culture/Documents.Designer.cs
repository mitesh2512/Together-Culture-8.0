namespace Together_Culture
{
    partial class Documents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Documents));
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(69, 54);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(206, 25);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Guidelines and Policies";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 90);
            label1.Name = "label1";
            label1.Size = new Size(521, 15);
            label1.TabIndex = 1;
            label1.Text = "At this Service, we are committed to maintaining a respectful and positive experience for all users.";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 105);
            label2.Name = "label2";
            label2.Size = new Size(581, 15);
            label2.TabIndex = 2;
            label2.Text = "By using our Service, you agree to follow our community guidelines and adhere to our policies. This includes,";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 120);
            label3.Name = "label3";
            label3.Size = new Size(651, 15);
            label3.TabIndex = 3;
            label3.Text = "but is not limited to, treating others with respect, refraining from any form of harassment, hate speech, or illegal activities, ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 135);
            label4.Name = "label4";
            label4.Size = new Size(610, 15);
            label4.TabIndex = 4;
            label4.Text = "and respecting intellectual property rights. You must also comply with all applicable laws while using our platform.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 150);
            label5.Name = "label5";
            label5.Size = new Size(592, 15);
            label5.TabIndex = 5;
            label5.Text = "Any content you upload, share, or interact with on the Service should be appropriate, legal, and non-infringing.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 165);
            label6.Name = "label6";
            label6.Size = new Size(583, 15);
            label6.TabIndex = 6;
            label6.Text = "We reserve the right to remove or disable access to any content or user account that violates these guidelines.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 180);
            label7.Name = "label7";
            label7.Size = new Size(520, 15);
            label7.TabIndex = 7;
            label7.Text = "Repeated violations may result in permanent suspension from the Service. By using our platform, ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 195);
            label8.Name = "label8";
            label8.Size = new Size(407, 15);
            label8.TabIndex = 8;
            label8.Text = "you acknowledge that you have read, understood, and agree to our policies.";
            // 
            // Documents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(857, 460);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Documents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Documents";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}