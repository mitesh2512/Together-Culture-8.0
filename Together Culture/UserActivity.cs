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
    public partial class UserActivity : Form
    {
        private static readonly string[] staticItems = { "Sunday Movie Day", "London Theater", "Muscial Events", "London NewYear Celebration", "31st party" };

        public UserActivity()
        {
            InitializeComponent();
            LoadStaticItems();
        }
        private void LoadStaticItems()
        {
            // Clear existing items if needed
            listBox1.Items.Clear();

            // Add static items to the ListBox
            listBox1.Items.AddRange(staticItems);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
