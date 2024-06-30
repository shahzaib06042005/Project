namespace projectDashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void buttonpersonaldetails_Click_1(object sender, EventArgs e)
        {
            form_2 form2 = new form_2();
            form2.Show();


        }

        private void buttonschedule_Click(object sender, EventArgs e)
        {
            form3 form_3 = new form3();
            form_3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

