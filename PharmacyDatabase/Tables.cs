using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyDatabase
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }

        private void Tables_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrugType drugType = new DrugType();
            Hide();
            drugType.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Drug drug = new Drug();
            Hide();
            drug.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Hide();
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pharmacy ph = new Pharmacy();
            Hide();
            ph.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Firms f = new Firms();
            Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Disease d = new Disease();
            Hide();
            d.Show();
        }
    }
}
