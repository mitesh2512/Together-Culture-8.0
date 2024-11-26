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
            // Establish SQL connection
            SqlConnection Membership = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"H:\\My Documents\\Development\\New folder\\Together-Culture-8.0\\Together Culture\\DataBase.mdf\";Integrated Security=True");
            Membership.Open();

            // Query to load all members
            String sqlquery = "SELECT Member_ID, Member_Name, MembershipType FROM Members";

            // Load all members into DataGridView
            SqlDataAdapter sqldata = new SqlDataAdapter(sqlquery, Membership);
            DataTable dt = new DataTable();
            sqldata.Fill(dt);
            dataGridView1.DataSource = dt;

            // Query to count all members
            String memcount_query = "SELECT COUNT(*) FROM Members";
            SqlCommand memcountdata = new SqlCommand(memcount_query, Membership);
            int mem_count = (int)memcountdata.ExecuteScalar();

            // Set the total member count in label5
            label5.Text = $"Total Members: {mem_count}";

            // Populate ComboBox with membership types
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Community Member");
            comboBox1.Items.Add("Key Access Member");
            comboBox1.Items.Add("Creative Workspace Member");
            comboBox1.SelectedIndex = -1; // Default to no selection

            Membership.Close();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1) // Ensure a valid selection
            {
                string selectedType = comboBox1.SelectedItem.ToString();

                // SQL query to filter members by selected membership type
                string filterQuery = @"
            SELECT 
                Member_ID, 
                Member_Name, 
                MembershipType 
            FROM 
                Members 
            WHERE 
                MembershipType = @MembershipType";

                // SQL query to count members in the selected type
                string countQuery = @"
            SELECT 
                COUNT(*) 
            FROM 
                Members 
            WHERE 
                Membership_Type = @MembershipType";

                // Establish connection and execute queries
                SqlConnection Membership = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"H:\\My Documents\\Development\\New folder\\Together-Culture-8.0\\Together Culture\\DataBase.mdf\";Integrated Security=True");
                Membership.Open();

                // Filter data for DataGridView
                SqlCommand filterCommand = new SqlCommand(filterQuery, Membership);
                filterCommand.Parameters.AddWithValue("@MembershipType", selectedType);
                SqlDataAdapter adapter = new SqlDataAdapter(filterCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Get count of members for the selected type
                SqlCommand countCommand = new SqlCommand(countQuery, Membership);
                countCommand.Parameters.AddWithValue("@MembershipType", selectedType);
                int memberCount = (int)countCommand.ExecuteScalar();

                // Display member count in label5
                label5.Text = $"Members in {selectedType}: {memberCount}";

                Membership.Close();
            }
            else
            {
                // Reset DataGridView and label5 if no selection is made
                LoadAllMembers();
                label5.Text = "Member Count: N/A";
            }
        }

        private void LoadAllMembers()
        {
            // Load all members into the DataGridView
            SqlConnection Membership = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"H:\\My Documents\\Development\\New folder\\Together-Culture-8.0\\Together Culture\\DataBase.mdf\";Integrated Security=True");
            Membership.Open();

            String sqlquery = "SELECT Member_ID, Member_Name, MembershipType FROM Members";
            SqlDataAdapter sqldata = new SqlDataAdapter(sqlquery, Membership);
            DataTable dt = new DataTable();
            sqldata.Fill(dt);

            dataGridView1.DataSource = dt;

            Membership.Close();
        }
    }
}
