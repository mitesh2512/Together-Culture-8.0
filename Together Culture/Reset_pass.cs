using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Together_Culture
{
    public partial class Reset_Password : Form
    {
        public Reset_Password()
        {
            InitializeComponent();
        }

        private void Reset_pass_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the text from the TextBox
            string url = Memberid.Text; // Ensure your TextBox name is correct (e.g., `textBox1`)

            // Check which RadioButton is selected
            string selectedOption = null;
            if (radioButton1.Checked)
            {
                selectedOption = "Mail";
            }
            else if (radioButton2.Checked)
            {
                selectedOption = "Message";
            }

            // Validate URL and option selection
            if (string.IsNullOrWhiteSpace(null))
            {
                MessageBox.Show("Please enter a valid MemberID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedOption == null)
            {
                MessageBox.Show("Please select an option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show confirmation in the label
            LinkSent.Text = $"Link has been sent to {selectedOption}.";
            LinkSent.Visible = true;

          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Optional: Perform any specific action when RadioButton1 is selected
                Console.WriteLine("Mail selected.");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                // Optional: Perform any specific action when RadioButton2 is selected
                Console.WriteLine("Message selected.");
            }
        }
    }
}
