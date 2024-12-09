namespace Together_Culture
{
    partial class Communicate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Communicate));
            listBoxMessages = new ListBox();
            textBoxDocumentContent = new TextBox();
            textBoxMessageInput = new TextBox();
            labelCurrentUser = new ListBox();
            buttonSendMessage = new Button();
            buttonLoadDocuments = new Button();
            SuspendLayout();
            // 
            // listBoxMessages
            // 
            listBoxMessages.FormattingEnabled = true;
            listBoxMessages.Location = new Point(6, 12);
            listBoxMessages.Name = "listBoxMessages";
            listBoxMessages.Size = new Size(249, 144);
            listBoxMessages.TabIndex = 0;
           // listBoxMessages.SelectedIndexChanged += listBoxDocuments_SelectedIndexChanged;
            // 
            // textBoxDocumentContent
            // 
            textBoxDocumentContent.Location = new Point(6, 176);
            textBoxDocumentContent.Multiline = true;
            textBoxDocumentContent.Name = "textBoxDocumentContent";
            textBoxDocumentContent.ReadOnly = true;
            textBoxDocumentContent.Size = new Size(249, 34);
            textBoxDocumentContent.TabIndex = 1;
            // 
            // textBoxMessageInput
            // 
            textBoxMessageInput.Location = new Point(425, 12);
            textBoxMessageInput.Multiline = true;
            textBoxMessageInput.Name = "textBoxMessageInput";
            textBoxMessageInput.Size = new Size(249, 144);
            textBoxMessageInput.TabIndex = 2;
            // 
            // labelCurrentUser
            // 
            labelCurrentUser.FormattingEnabled = true;
            labelCurrentUser.Location = new Point(244, 264);
            labelCurrentUser.Name = "labelCurrentUser";
            labelCurrentUser.Size = new Size(188, 44);
            labelCurrentUser.TabIndex = 3;
            // 
            // buttonSendMessage
            // 
            buttonSendMessage.Location = new Point(694, 50);
            buttonSendMessage.Name = "buttonSendMessage";
            buttonSendMessage.Size = new Size(94, 29);
            buttonSendMessage.TabIndex = 4;
            buttonSendMessage.Text = "Send";
            buttonSendMessage.UseVisualStyleBackColor = true;
            buttonSendMessage.Click += buttonSendMessage_Click;
            // 
            // buttonLoadDocuments
            // 
            buttonLoadDocuments.Location = new Point(285, 50);
            buttonLoadDocuments.Name = "buttonLoadDocuments";
            buttonLoadDocuments.Size = new Size(94, 29);
            buttonLoadDocuments.TabIndex = 5;
            buttonLoadDocuments.Text = "Upload";
            buttonLoadDocuments.UseVisualStyleBackColor = true;
            buttonLoadDocuments.Click += buttonLoadDocuments_Click;
            // 
            // Communicate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLoadDocuments);
            Controls.Add(buttonSendMessage);
            Controls.Add(labelCurrentUser);
            Controls.Add(textBoxMessageInput);
            Controls.Add(textBoxDocumentContent);
            Controls.Add(listBoxMessages);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Communicate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Communicate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxMessages;
        private TextBox textBoxDocumentContent;
        private TextBox textBoxMessageInput;
        private ListBox labelCurrentUser;
        private Button buttonSendMessage;
        private Button buttonLoadDocuments;
    }
}