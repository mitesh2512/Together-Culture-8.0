namespace Together_Culture
{
    partial class EventBooking
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 0;
            label1.Text = "Notification || Recomendation";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(210, 94);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(210, 163);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Go";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(210, 230);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Go";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(210, 292);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "Go";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 104);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 5;
            label2.Text = "Rock Concert";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 234);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 6;
            label3.Text = "Football Match";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 172);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 7;
            label4.Text = "Art WorkShop";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 301);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 8;
            label5.Text = "jazz Night";
            // 
            // EventBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "EventBooking";
            Text = "EventBooking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}