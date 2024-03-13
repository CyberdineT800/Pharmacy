namespace PharmacyDatabase
{
    public partial class Entering : Form
    {
        public Entering()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Hide();
            main.Show();
        }
    }
}