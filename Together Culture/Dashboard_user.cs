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
    public partial class Dashboard_user : Form
    {
        public Dashboard_user()
        {
            InitializeComponent();
        }

        private void UserProfile_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile();
            userProfile.Show();

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

        private void MemBen_Click(object sender, EventArgs e)
        {
            int memberId = 1;
            Member_Benefits member_Benefits = new Member_Benefits(memberId);
            member_Benefits.Show();
        }

        private void ViewandBookContent_Click(object sender, EventArgs e)
        {
            UserBooking content = new UserBooking();
            content.Show();
        }

        private void DigitalConnectionsBoard_Click(object sender, EventArgs e)
        {
            ConnectionBoard connectionBoard = new ConnectionBoard();
            connectionBoard.Show();

        }

        private void Information_Click(object sender, EventArgs e)
        {
            ContriInfo contriInfo = new ContriInfo();
            contriInfo.Show();
        }

        private void Event_Click(object sender, EventArgs e)
        {
           EventBooking eventBooking = new EventBooking();
            eventBooking.Show();
        }

        private void Activity_Click(object sender, EventArgs e)
        {
            UserActivity activity = new UserActivity();
            activity.Show();
        }

        private void Communicate_Click(object sender, EventArgs e)
        {
            Communicate communicate = new Communicate();
            communicate.Show();
        }

        private void Documents_Click(object sender, EventArgs e)
        {
            Documents documents = new Documents();
            documents.Show();
        }

        private void Dashboard_user_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
