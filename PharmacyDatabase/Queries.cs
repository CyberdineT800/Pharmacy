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
    public partial class Queries : Form
    {
        public Queries()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchByDrugParam searchByDrugParam = new SearchByDrugParam();
            Hide();
            searchByDrugParam.Show();
        }

        private void Queries_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            Hide();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GeneralQuery gq = new GeneralQuery();
            Hide();
            gq.Show();
        }
    }
}
