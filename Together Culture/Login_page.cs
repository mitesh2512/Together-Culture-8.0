using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Together_Culture
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void ForgotPassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset_Password startform = new Reset_Password();
            startform.Show();
        }

        private void RegisterPageButton_Click(object sender, EventArgs e)
        {
            Register startform = new Register();
            startform.Show();
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
          Globals globals = new Globals();
            globals.global_var();
            string connectionString = globals.Conn_string; 

             
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // SQL query to check email, password and retrieve role
                    string query = "SELECT Role FROM Together WHERE email = @Email AND password = @Password";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", UserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", PasswordTxtbox.Text.Trim());

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();

                        if (role == "Admin")
                        {
                            Dashboard adminPage = new Dashboard();
                            adminPage.Show();
                        }
                        else if (role == "Member")
                        {
                            Dashboard_user memberPage = new Dashboard_user();
                            memberPage.Show();
                        }

                        this.Hide(); // Close login form
                    }
                    else
                    {
                        Message.Text = "Invalid email or password. Please try again.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Message_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Login_page_Load(object sender, EventArgs e)
        {
        }

        private void Login_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}