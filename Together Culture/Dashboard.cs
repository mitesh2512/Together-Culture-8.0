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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mem_onClick(object sender, EventArgs e)
        {
            Membership_Type_Management membership_Type_Management = new Membership_Type_Management();
            membership_Type_Management.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Redirect to the login form
                Login_page login_Page = new Login_page(); // Replace with the actual name of your login form
                login_Page.Show();

                // Close the current form
                this.Close();
            }
        }

        private void UserProfile_Click(object sender, EventArgs e)
        {
            UserProfile UserProfile = new UserProfile();
            UserProfile.Show();
            this.Hide();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Optional: Display a confirmation dialog before closing
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?",
                                                  "Exit Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                // Cancel the close action
                e.Cancel = true;
            }
            else
            {
                // Close the application
                Application.Exit();
            }
        }
    }
}
