using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            this.Hide();
        }

        private void RegisterPageButton_Click(object sender, EventArgs e)
        {
            Register startform = new Register();
            startform.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\MitesH\\source\\repos\\mitesh2512\\NEW\\Together-Culture-8.0\\Together Culture\\DataBase.mdf\";Integrated Security=True");
            con.Open();
            string query = "SELECT COUNT(*) FROM Together WHERE email=@Email AND password=@Password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", UserName.Text);
            cmd.Parameters.AddWithValue("@password", PasswordTxtbox.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                Dashboard Dash = new Dashboard();
                Dash.Show();
                this.Close();
            }
            else
            {
                Message.Text = "Failed Successfully";
            }

           
        }
        private void Message_Click(object sender, EventArgs e)
        { 
        
        
        
        }
    }
}
