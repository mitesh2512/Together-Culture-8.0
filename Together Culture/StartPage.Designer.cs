namespace Together_Culture
{
    partial class StartPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            StartButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StartButton.AutoSize = false; // AutoSize should be false to control the button size manually
            StartButton.BackColor = Color.FromArgb(45, 45, 48); // A sleek dark background color
            StartButton.FlatAppearance.BorderSize = 0; // No border for a cleaner look
            StartButton.FlatStyle = FlatStyle.Flat; // Flat style for a modern look
            StartButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0); // Using Segoe UI for a modern font
            StartButton.ForeColor = Color.White; // White text for good contrast
            StartButton.Location = new Point(317, 410);
            StartButton.Margin = new Padding(5);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(320, 50); // Adjusted size for better proportion
            StartButton.TabIndex = 0;
            StartButton.Text = "START";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += button1_Click;

            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(StartButton, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(937, 519);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Red;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(937, 519);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            ForeColor = Color.Transparent;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "StartPage";
            Text = "Toghether-Culture";
            WindowState = FormWindowState.Maximized;
            Load += StartPage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button StartButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
