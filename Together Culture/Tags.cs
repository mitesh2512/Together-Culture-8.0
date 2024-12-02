using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Together_Culture
{
    public partial class Tags : Form
    {


        public Tags()
        {
            InitializeComponent();
        }

        private void onIndex_change(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                String selectedText = this.comboBox3.Text;

                LoadMembersByTag(selectedText);
            }
        }

        private void LoadMembersByTag(string tagName)
        {
            // Load members associated with the selected tag
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\adit\\mitesh2512\\Together-Culture-8.0\\Together Culture\\DataBase.mdf\";Integrated Security=True");

            conn.Open();

            string query = @"
                SELECT m.Member_ID, m.Member_Name 
                FROM Members m
                INNER JOIN Member_Tags mt ON m.Member_ID = mt.Member_ID
                INNER JOIN Tags t ON mt.Tag_ID = t.Tag_ID
                WHERE t.Tag_Name = @Tag_Name";

            
            SqlCommand adaptercmd = new SqlCommand(query, conn);
            adaptercmd.Parameters.AddWithValue("@Tag_Name", tagName);
            
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(adaptercmd);

            adapter.Fill(dt);
            

            dataGridView1.DataSource = dt; // Display members in a DataGridView

        }




        private void AssignTag_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both a member and a tag.");
                return;
            }

            string selectedMember = comboBox1.SelectedValue.ToString();
            string selectedTag = comboBox2.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\adit\\mitesh2512\\Together-Culture-8.0\\Together Culture\\DataBase.mdf\";Integrated Security=True"))
            {
                conn.Open();

                // Check if the tag is already assigned to the member
                string checkQuery = @"
                    SELECT COUNT(*) 
                    FROM Member_Tags 
                    WHERE Member_ID = @Member_ID AND Tag_ID = @Tag_ID";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Member_ID", selectedMember);
                checkCmd.Parameters.AddWithValue("@Tag_ID", selectedTag);

                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("This tag is already assigned to the selected member.");
                    return;
                }

                // Assign the tag
                string assignQuery = "INSERT INTO Member_Tags (Member_ID, Tag_ID) VALUES (@Member_ID, @Tag_ID)";
                using (SqlCommand assignCmd = new SqlCommand(assignQuery, conn))
                {
                    assignCmd.Parameters.AddWithValue("@Member_ID", selectedMember);
                    assignCmd.Parameters.AddWithValue("@Tag_ID", selectedTag);

                    assignCmd.ExecuteNonQuery();
                    MessageBox.Show("Tag assigned successfully!");
                }

                LoadAssignedTags(); // Refresh the assigned tags list
            }
        }

        private void Load_Members()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\adit\\mitesh2512\\Together-Culture-8.0\\Together Culture\\DataBase.mdf\";Integrated Security=True"))
            {
                conn.Open();

                string query = "SELECT Member_ID, Member_Name FROM Members";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Member_Name";
                comboBox1.ValueMember = "Member_ID";

                comboBox1.SelectedIndex = -1; // No selection by default
            }
        }

        private void LoadTags()
        {
            // Load all tags into the ComboBox
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\adit\\mitesh2512\\Together-Culture-8.0\\Together Culture\\DataBase.mdf\";Integrated Security=True"))
            {
                conn.Open();

                string query = "SELECT Tag_ID, Tag_Name FROM Tags";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "Tag_Name";
                comboBox2.ValueMember = "Tag_ID";

                comboBox2.SelectedIndex = -1; // No selection by default

                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "Tag_Name";
                comboBox3.ValueMember = "Tag_ID";

                comboBox3.SelectedIndex = -1; // No selection by default
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add a new tag to the database
            string tagName = textBox1.Text;

            if (string.IsNullOrEmpty(tagName))
            {
                MessageBox.Show("Tag name cannot be empty.");
                return;
            }

            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\adit\\mitesh2512\\Together-Culture-8.0\\Together Culture\\DataBase.mdf\";Integrated Security=True"))
            {
                conn.Open();

                string query = "INSERT INTO Tags (Tag_Name) VALUES (@Tag_Name)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Tag_Name", tagName);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tag added successfully!");
                }

                LoadTags(); // Refresh the tag list
            }
        }

        private void LoadAssignedTags()
        {
            // Load all members with their assigned tags into the DataGridView
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\adit\\mitesh2512\\Together-Culture-8.0\\Together Culture\\DataBase.mdf\";Integrated Security=True"))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        m.Member_Name, 
                        t.Tag_Name 
                    FROM 
                        Member_Tags mt
                    INNER JOIN Members m ON mt.Member_ID = m.Member_ID
                    INNER JOIN Tags t ON mt.Tag_ID = t.Tag_ID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt; // Display assigned tags
                
                
               
            }
        }

        private void Tags_Load(object sender, EventArgs e)
        {
            Load_Members();
            LoadTags();
            //comboBox3.SelectedIndex = 0;
        }
    }

}
