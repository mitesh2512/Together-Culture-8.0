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

        private void AdminProfile_Click(object sender, EventArgs e)
        {

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
    }
}
