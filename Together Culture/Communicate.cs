using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Together_Culture
{
    public partial class Communicate : Form
    {
        private List<string> documents;
        private List<string> messages;
        private string currentUser;
        public Communicate()
        {
            InitializeComponent();
            documents = new List<string>();
            messages = new List<string>();
            currentUser = "User 1"; // Example user
            labelCurrentUser.Text = $"Logged in as: {currentUser}";
        }

        private void Communicate_Load(object sender, EventArgs e)
        {
            LoadDocuments();
        }
        private void LoadDocuments()
        {
            // Load some sample documents
            documents.Add("Document 1: Movie Tickets Guidelines");
            documents.Add("Document 2: Meeting Minutes");
            documents.Add("Document 3: Event Schedule");

            // Populate the ListBox with document titles
            listBoxMessages.DataSource = null;
            listBoxMessages.DataSource = documents;
        }

        private ListBox GetListBoxMessages()
        {
            return listBoxMessages;
        }

        private void listBoxDocuments_SelectedIndexChanged(object sender, EventArgs e, ListBox listBoxMessages)
        {
            // Display the selected document content
            //string selectedDocument = listBoxMessages.SelectedItem.ToString();
            string? selectedDocument = listBoxMessages.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedDocument)) // Check if the selected document is not null or empty
            {
                Communicate communicator = new Communicate();
                string content = communicator.GetDocumentContent(selectedDocument);
                // Do something with the content, e.g., display it in a TextBox
                textBoxDocumentContent.Text = GetDocumentContent(selectedDocument);
            }
            else
            {
                MessageBox.Show("Please select a document.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private string GetDocumentContent(string documentTitle)
        {
            // Simulate document content based on title
            switch (documentTitle)
            {
                case "Document 1: Movie Tickets Guidelines":
                    return "These are the Movie Tickets guidelines...";
                case "Document 2: Meeting Minutes":
                    return "Minutes from the last meeting...";
                case "Document 3: Event Schedule":
                    return "Upcoming events include...";
                default:
                    return "No content available.";
            }
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            string message = textBoxMessageInput.Text.Trim();
            if (!string.IsNullOrWhiteSpace(message))
            {
                string formattedMessage = $"{currentUser}: {message}";
                messages.Add(formattedMessage);
                listBoxMessages.Items.Add(formattedMessage);
                textBoxMessageInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a message before sending.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonLoadDocuments_Click(object sender, EventArgs e)
        {
            LoadDocuments();
        }
    }

}

