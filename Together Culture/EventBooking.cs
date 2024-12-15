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
    public partial class EventBooking : Form
    {
        public EventBooking()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventDetails eventDetails = new EventDetails();
            eventDetails.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EventDetails eventDetails = new EventDetails();
            eventDetails.Show();
            this.Hide();
        }

        private void EventBooking_Load(object sender, EventArgs e)
        {

        }
    }
}
