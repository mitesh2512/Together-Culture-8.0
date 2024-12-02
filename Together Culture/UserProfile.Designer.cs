namespace Together_Culture
{
    partial class UserProfile
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            treeView1 = new TreeView();
            treeView2 = new TreeView();
            button3 = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.Location = new Point(206, 596);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(403, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 27);
            textBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 57);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 6;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 57);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 7;
            label2.Text = "Last Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(59, 265);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(604, 27);
            textBox4.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(321, 596);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(60, 344);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(604, 27);
            textBox5.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(59, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(604, 27);
            textBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 159);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 242);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 13;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 321);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 14;
            label5.Text = "Contact Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 393);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 15;
            label6.Text = "Interest";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 487);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 16;
            label7.Text = "Membership";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(59, 429);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(605, 34);
            treeView1.TabIndex = 17;
            // 
            // treeView2
            // 
            treeView2.Location = new Point(60, 526);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(603, 34);
            treeView2.TabIndex = 18;
            // 
            // button3
            // 
            button3.Location = new Point(436, 596);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 19;
            button3.Text = "Edit Profile";
            button3.UseVisualStyleBackColor = true;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(748, 671);
            Controls.Add(button3);
            Controls.Add(treeView2);
            Controls.Add(treeView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private TextBox textBox4;
        private Button button2;
        private TextBox textBox5;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TreeView treeView1;
        private TreeView treeView2;
        private Button button3;
    }
}