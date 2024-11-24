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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Button(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\MitesH\\source\\repos\\mitesh2512\\Together-Culture-8.0\\Together Culture\\DataBase.mdf\";Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "SELECT COUNT(*) FROM Together WHERE email=@Email AND password=@Password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", UserName.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                Remember.Text = "Success";
                Dashboard Dash = new Dashboard();
                Dash.Show();
                this.Close();
            }
            else
            {
                label3.Text = "Failed Successfully";
            }




        }

        private void Register_button(object sender, EventArgs e)
        {
            Register startform = new Register();
            startform.Show();
            this.Hide();
        }

        private void Remember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset_pass startform = new Reset_pass();
            startform.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
