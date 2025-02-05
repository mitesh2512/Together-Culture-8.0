﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Together_Culture
{
    public partial class Member_Benefits : Form
    {
        public string connStr = "";
        public int MemberID { get; set; } // Member ID passed from the login process

        public Member_Benefits(int memberId)
        {
            InitializeComponent();
            MemberID = memberId;  // Store the MemberID
            Globals globals = new Globals();
            globals.global_var();
            connStr = globals.Conn_string;
        }

        private void Member_Benefits_Load(object sender, EventArgs e)
        {
            if (MemberID == 0)
            {
                MessageBox.Show("Member ID is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoadMemberBenefits();  // Load the benefits after confirming MemberID
            }
        }

        // Load both used and unused benefits for the member
        private void LoadMemberBenefits()
        {
            string query = @"
                SELECT b.Benefit_ID, b.Benefit_Name, b.Benefit_Description, mb.Status
                FROM Benefits b
                JOIN MemberBenefits mb ON b.Benefit_ID = mb.Benefit_ID
                WHERE mb.Member_ID = @MemberID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MemberID", MemberID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the result to the DataGridView
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["Benefit_ID"].Visible = false; // Hide Benefit_ID column
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button to use selected benefits
        private void btnUseBenefit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int benefitID = Convert.ToInt32(row.Cells["Benefit_ID"].Value);
                MarkBenefitAsUsed(benefitID);
            }

            // Reload the benefits after updating
            LoadMemberBenefits();
        }

        // Update the benefit status to 'Used'
        private void MarkBenefitAsUsed(int benefitID)
        {
            string query = @"
                UPDATE MemberBenefits
                SET Status = 'Used', DateUsed = GETDATE()
                WHERE Member_ID = @MemberID AND Benefit_ID = @BenefitID AND Status = 'Unused'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MemberID", MemberID);
                    cmd.Parameters.AddWithValue("@BenefitID", benefitID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Benefit has been used successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Benefit_Name")
            {
                int benefitID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Benefit_ID"].Value);
                MarkBenefitAsUsed(benefitID);

                // Reload the benefits after updating
                LoadMemberBenefits();
            }
        }
    }
}
