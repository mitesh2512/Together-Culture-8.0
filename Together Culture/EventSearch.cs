using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Together_Culture
{
    public partial class EventSearch : Form
    {
        public string connStr = "";
        public EventSearch()
        {
            InitializeComponent();
            Globals globals = new Globals();
            globals.global_var();
            connStr = globals.Conn_string;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string eventName = textBox2.Text.Trim(); // Get event name from TextBox
            DateTime startDate = dateTimePicker1.Value;     // Get start date
            DateTime endDate = dateTimePicker2.Value;         // Get end date

            // Validate date range
            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be later than end date.", "Invalid Date Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SQL query to search for events and count total guests
            string query = @"
                SELECT E.Event_Name, E.Event_Date, COUNT(EA.Member_ID) AS TotalGuests
                FROM Events E
                LEFT JOIN EventAttendance EA ON E.Event_ID = EA.Event_ID
                WHERE E.Event_Date BETWEEN @Start_Date AND @End_Date
                AND (@Event_Name IS NULL OR E.Event_Name LIKE '%' + @Event_Name + '%')
                GROUP BY E.Event_Name, E.Event_Date;
            ";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Start_Date", startDate);
                    cmd.Parameters.AddWithValue("@End_Date", endDate);
                    cmd.Parameters.AddWithValue("@Event_Name",
                        string.IsNullOrWhiteSpace(eventName) ? DBNull.Value : eventName);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind data to the DataGridView
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;

            // Reset the DateTimePicker controls to today's date
            dateTimePicker1.Value = DateTime.Now.Date;
            dateTimePicker2.Value = DateTime.Now.Date;

            // Clear the DataGridView
            dataGridView1.DataSource = null;

            // Optionally reload all events (unfiltered)
            LoadAllEvents();
        }




        private void LoadAllEvents()
        {
            string query = @"
                SELECT E.Event_Name, E.Event_Date, COUNT(EA.Member_ID) AS TotalGuests
                FROM Events E
                LEFT JOIN EventAttendance EA ON E.Event_ID = EA.Event_ID
                GROUP BY E.Event_Name, E.Event_Date;
            ";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind data to the DataGridView
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Form Load Event to initialize data
        private void EventSearchForm_Load(object sender, EventArgs e)
        {
            // Optionally load all events when the form loads
            LoadAllEvents();
        }

        private void EventSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
