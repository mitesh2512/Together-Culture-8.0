namespace Together_Culture
{
    partial class EditProfile
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
            treeView2 = new TreeView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            treeView1 = new TreeView();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            textBox4 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // treeView2
            // 
            treeView2.Location = new Point(69, 525);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(603, 34);
            treeView2.TabIndex = 34;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(68, 428);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(605, 34);
            treeView1.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 486);
            label7.Name = "label7";
            label7.Size = new Size(13, 20);
            label7.TabIndex = 32;
            label7.Text = " ";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 392);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 31;
            label6.Text = "Interest";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 320);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 30;
            label5.Text = "Contact Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 241);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 29;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 158);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 28;
            label3.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(68, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(604, 27);
            textBox2.TabIndex = 27;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(69, 343);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(604, 27);
            textBox5.TabIndex = 26;
            // 
            // button2
            // 
            button2.Location = new Point(343, 595);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 25;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(68, 264);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(604, 27);
            textBox4.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 56);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 23;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 56);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 22;
            label1.Text = "First Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(412, 93);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 27);
            textBox3.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 27);
            textBox1.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(234, 595);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 19;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 755);
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
            Name = "EditProfile";
            Text = "EditProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TreeView treeView1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox5;
        private Button button2;
        private TextBox textBox4;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox1;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
    }
}