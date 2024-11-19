namespace Together_Culture
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }
              
        private void StartPage_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login startform = new Login();
            startform.Show();
            this.Hide();
        }
    }
}
