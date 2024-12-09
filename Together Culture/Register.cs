using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Together_Culture
{
    public partial class Register : Form
    {
        public string connStr = "";
        public Register()
        {
            InitializeComponent();
            PopulateMembershipTypeComboBox();
            PopulateInterestComboBox();
            Globals globals = new Globals();
            globals.global_var();
            connStr = globals.Conn_string;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void LoginPage_Click(object sender, EventArgs e)
        {
            Login_page login_Page = new Login_page();
            login_Page.Show();
            this.Hide();
        }

        

        private void PopulateMembershipTypeComboBox()
        {
            MembershipTypeBox.Items.Clear();
            MembershipTypeBox.Items.Add("Community Member");
            MembershipTypeBox.Items.Add("Key Access Member");
            MembershipTypeBox.Items.Add("Creative Workspace Member");
            MembershipTypeBox.SelectedIndex = -1; // Default to no selection
        }

        private void PopulateInterestComboBox()
        {
            InterestBox.Items.Clear();
            InterestBox.Items.Add("Caring");
            InterestBox.Items.Add("Sharing");
            InterestBox.Items.Add("Working");
            InterestBox.Items.Add("Experiencing");
            InterestBox.Items.Add("Creating");
            InterestBox.SelectedIndex = -1; // Default to no selection
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string connectionString = connStr;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Members (FullName, DateOfBirth, MobileNumber, EmailAddress, Password, MembershipType, Interest) VALUES (@FullName, @DateOfBirth, @MobileNumber, @EmailAddress, @Password, @MembershipType, @Interest)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Map form fields to query parameters
                        cmd.Parameters.AddWithValue("@FullName", FullName.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth.Value);
                        cmd.Parameters.AddWithValue("@MobileNumber", MobileNumber.Text);
                        cmd.Parameters.AddWithValue("@EmailAddress", EmailAddress.Text);
                        cmd.Parameters.AddWithValue("@Password", Password.Text);
                        cmd.Parameters.AddWithValue("@MembershipType", MembershipTypeBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Interest", InterestBox.SelectedItem.ToString());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful!");
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.");
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("A database error occurred: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void MembershipTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can handle any additional logic here if needed
        }

        private void InterestBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can handle any additional logic here if needed
        }


    }
}

