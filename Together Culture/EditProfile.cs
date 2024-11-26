using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Together_Culture
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Intrest_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Caring");
            comboBox1.Items.Add("Sharing");
            comboBox1.Items.Add("Expreiecning");
            comboBox1.Items.Add("Working");
            comboBox1.Items.Add("Creating");
        

        }
    }
}
