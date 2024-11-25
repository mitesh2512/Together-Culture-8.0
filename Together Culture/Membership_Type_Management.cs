using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Together_Culture
{
    public partial class Membership_Type_Management : Form
    {
        public Membership_Type_Management()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Membership_Type_Management_Load(object sender, EventArgs e)
        {
            SqlConnection Membership = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"H:\\My Documents\\Development\\New folder\\Together-Culture-8.0\\Together Culture\\DataBase.mdf\";Integrated Security=True");
            Membership.Open();

            String sqlquery = "SELECT Member_ID, Member_Name, Membership_Type FROM Members";

            SqlDataAdapter sqldata = new SqlDataAdapter(sqlquery,Membership);

            DataTable dt = new DataTable();
            sqldata.Fill(dt);

            String memcount_query = "SELECT COUNT(*) FROM Members";

            SqlCommand memcountdata = new SqlCommand(memcount_query,Membership);
            
            int mem_count = (int)memcountdata.ExecuteScalar();

            label5.Text = $"{mem_count}";

            dataGridView1.DataSource = dt;
            

            




            Membership.Close();
        }
    }
}
