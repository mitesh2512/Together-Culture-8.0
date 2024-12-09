using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Together_Culture
{
    public partial class ApproveandSearchMem : Form
    {
        public string connStr = "";
        public ApproveandSearchMem()
        {
            InitializeComponent();
            Globals globals = new Globals();
            globals.global_var();
            connStr = globals.Conn_string;
        }

        // Form Load Event
        private void ApproveandSearchMem_Load(object sender, EventArgs e)
        {
            // Initialize or load data if needed
        }

        // Search Members Button Click Event
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearchMember.Text.Trim();

            // SQL query to fetch members based on name or email
            string query = @"
                SELECT 
                    Member_ID, 
                    FullName, 
                    DateOfBirth,
                    MembershipType,
                    EmailAddress,
                    MobileNumber,   
                    Interest,
                    CASE WHEN IsApproved = 1 THEN 'Approved' ELSE 'Pending' END AS Status
                FROM Members
                WHERE 
                    FullName LIKE '%' + @SearchQuery + '%' 
                    OR EmailAddress LIKE '%' + @SearchQuery + '%';
            ";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SearchQuery", searchQuery);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind data to DataGridView
                    dataGridViewMembers.DataSource = dt;
                    dataGridViewMembers.Columns["Member_ID"].Visible = false; // Hide Member_ID

                    // Add checkbox column for approvals
                    AddApproveColumn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add Checkbox Column for Approving Members
        private void AddApproveColumn()
        {
            // Prevent duplicate checkbox columns
            if (!dataGridViewMembers.Columns.Contains("Approve"))
            {
                DataGridViewCheckBoxColumn approveColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Approve",
                    HeaderText = "Approve",
                    Width = 50,
                    TrueValue = true,
                    FalseValue = false
                };

                dataGridViewMembers.Columns.Add(approveColumn);
            }
        }

        // Save Changes Button Click Event
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            bool updated = false;

            foreach (DataGridViewRow row in dataGridViewMembers.Rows)
            {
                // Ensure the "Approve" column exists and has a valid value
                if (row.Cells["Approve"] != null && row.Cells["Approve"].Value != null &&
                    Convert.ToBoolean(row.Cells["Approve"].Value) == true)
                {
                    int memberId = Convert.ToInt32(row.Cells["Member_ID"].Value);

                    // SQL query to update the IsApproved status
                    string query = "UPDATE Members SET IsApproved = 1 WHERE Member_ID = @Member_ID";

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connStr))
                        {
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@Member_ID", memberId);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            updated = true; // Track if any rows were updated
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while approving member ID {memberId}: {ex.Message}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (updated)
            {
                MessageBox.Show("Selected members have been approved.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView to show updated statuses
                btnSearchMember.PerformClick();
            }
            else
            {
                MessageBox.Show("No members were selected for approval.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}