namespace FlightTicketApplication
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Login Button Clicked
        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage(); 
            loginPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.Show();
            this.Hide();
        }
    }
}