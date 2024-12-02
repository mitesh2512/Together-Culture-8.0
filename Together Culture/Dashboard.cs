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
                this.Hide();


            }
        }

        private void UserProfile_Click(object sender, EventArgs e)
        {
            Admin_Profile admin_Profile = new Admin_Profile();
            admin_Profile.Show();
            
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the application
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EventSearch eventSearch = new EventSearch();
            eventSearch.Show();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void TagsButton_Click(object sender, EventArgs e)
        {
            Tags tags = new Tags();
            tags.Show();
            
        }
    }
}
