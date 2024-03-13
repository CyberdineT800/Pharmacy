using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyDatabase
{
    public partial class SearchByDrugParam : Form
    {
        string path = Program.path;
        string query = "";

        SqlConnection conn;
        SqlCommand sqlCommand;
        SqlDataAdapter adapter;
        DataTable datatable = new DataTable();

        public SearchByDrugParam()
        {
            InitializeComponent();
        }

        public void View()
        {
            conn = new SqlConnection(path);
            query = "SELECT * FROM Drug";

            adapter = new SqlDataAdapter(query, conn);

            datatable.Clear();
            adapter.Fill(datatable);
            DatasView.DataSource = datatable;
        }

        public bool Check_Fields()
        {
            return typesCombo.Text.Trim() == "" ||
                   typesCombo.Text == "<turni tanlang>" ||
                   deadline1txt.Text.Trim() == "" ||
                   deadline2txt.Text.Trim() == "" ||
                   logicCombo.Text.Trim() == "" ||
                   hintCombo1.Text.Trim() == "" ||
                   hintCombo2.Text.Trim() == "" ||
                   nametxt.Text == "" ||
                   price1txt.Text == "" ||
                   price2txt.Text == "" ||
                   hintComboPrice1.Text == "" ||
                   hintComboPrice2.Text == "" ||
                   logicComboPrice.Text == "";
        }

        public void ClearFields()
        {
            typesCombo.Text = "<turni tanlang>";
            deadline1txt.Text = "";
            deadline2txt.Text = "";
            logicCombo.Text = "";
            hintCombo1.Text = "";
            hintCombo2.Text = "";
            nametxt.Text = "";
            price1txt.Text = "";
            price2txt.Text = "";
            hintComboPrice1.Text = "";
            hintComboPrice2.Text = "";
            logicComboPrice.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Queries tb = new Queries();
            Hide();
            tb.Show();
        }

        private void SearchByDrugType_Load(object sender, EventArgs e)
        {
            View();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
            View();
        }

        private void typesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(path))
                {
                    query = "SELECT * FROM Drug WHERE 1=1";
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    if (!string.IsNullOrWhiteSpace(nametxt.Text))
                    {
                        query += "AND Name LIKE @name";
                        parameters.Add(new SqlParameter("@name", "%" + nametxt.Text + "%"));
                    }

                    if (!string.IsNullOrWhiteSpace(typesCombo.Text) &&
                        typesCombo.Text != "<turni tanlang>")
                    {
                        query += " AND Type LIKE @type";
                        parameters.Add(new SqlParameter("@type", "%" + typesCombo.Text + "%"));
                    }

                    if (!string.IsNullOrWhiteSpace(deadline1txt.Text) &&
                        string.IsNullOrWhiteSpace(hintCombo1.Text))
                    {
                        query += " AND Best_before LIKE @deadline1";
                        parameters.Add(new SqlParameter("@deadline1", "%" + deadline1txt.Text + "%"));
                    }
                    else if (!string.IsNullOrWhiteSpace(deadline1txt.Text) &&
                             !string.IsNullOrWhiteSpace(hintCombo1.Text))
                    {
                        string s = hintCombo1.Text;
                        parameters.Add(new SqlParameter("@deadline1", deadline1txt.Text));

                        query += s == ">" ? " AND Best_before < @deadline1" :
                                 s == ">=" ? " AND Best_before <= @deadline1" :
                                 s == "=" ? " AND Best_before = @deadline1" :
                                 s == "<=" ? " AND Best_before >= @deadline1" :
                                 "AND Best_before > @deadline1";
                    }

                    if (!string.IsNullOrWhiteSpace(logicCombo.Text))
                    {
                        query += " " + logicCombo.Text.Trim();

                        if (!string.IsNullOrWhiteSpace(deadline2txt.Text) &&
                        string.IsNullOrWhiteSpace(hintCombo2.Text))
                        {
                            query += " Best_before LIKE @deadline2";
                            parameters.Add(new SqlParameter("@deadline2", "%" + deadline2txt.Text + "%"));
                        }
                        else if (!string.IsNullOrWhiteSpace(deadline2txt.Text) &&
                                 !string.IsNullOrWhiteSpace(hintCombo2.Text))
                        {
                            string s = hintCombo2.Text;
                            parameters.Add(new SqlParameter("@deadline2", deadline2txt.Text));

                            query += s == ">" ? " Best_before > @deadline2" :
                                     s == ">=" ? " Best_before >= @deadline2" :
                                     s == "=" ? " Best_before = @deadline2" :
                                     s == "<=" ? " Best_before <= @deadline2" :
                                     " Best_before < @deadline2";
                        }
                    }

                    ///
                    if (!string.IsNullOrWhiteSpace(price1txt.Text) &&
                        string.IsNullOrWhiteSpace(hintComboPrice1.Text))
                    {
                        query += " AND Price LIKE @price1";
                        parameters.Add(new SqlParameter("@price1", "%" + price1txt.Text + "%"));
                    }
                    else if (!string.IsNullOrWhiteSpace(price1txt.Text) &&
                             !string.IsNullOrWhiteSpace(hintComboPrice1.Text))
                    {
                        string s = hintComboPrice1.Text;
                        parameters.Add(new SqlParameter("@price1", price1txt.Text));

                        query += s == ">" ? " AND Price < @price1" :
                                 s == ">=" ? " AND Price <= @price1" :
                                 s == "=" ? " AND Price = @price1" :
                                 s == "<=" ? " AND Price >= @price1" :
                                 "AND Price > @price1";
                    }

                    if (!string.IsNullOrWhiteSpace(logicComboPrice.Text))
                    {
                        query += " " + logicComboPrice.Text.Trim();

                        if (!string.IsNullOrWhiteSpace(price2txt.Text) &&
                        string.IsNullOrWhiteSpace(hintComboPrice2.Text))
                        {
                            query += " Price LIKE @price2";
                            parameters.Add(new SqlParameter("@price2", "%" + price2txt.Text + "%"));
                        }
                        else if (!string.IsNullOrWhiteSpace(price2txt.Text) &&
                                 !string.IsNullOrWhiteSpace(hintComboPrice2.Text))
                        {
                            string s = hintComboPrice2.Text;
                            parameters.Add(new SqlParameter("@price2", price2txt.Text));

                            query += s == ">" ? " Price > @price2" :
                                     s == ">=" ? " Price >= @price2" :
                                     s == "=" ? " Price = @price2" :
                                     s == "<=" ? " Price <= @price2" :
                                     " Price < @price2";
                        }
                    }

                    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    {
                        sqlCommand.Parameters.AddRange(parameters.ToArray());

                        using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                        {
                            DataTable datatable = new DataTable();
                            adapter.Fill(datatable);
                            DatasView.DataSource = datatable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deadline1txt_TextChanged(object sender, EventArgs e)
        {
            typesCombo_SelectedIndexChanged(sender, e);
        }

        private void hintCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            typesCombo_SelectedIndexChanged(sender, e);
        }

        private void logicCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hintCombo2.Text.Trim() == "" &&
                deadline2txt.Text.Trim() == "")
            {
                hintCombo2.SelectedIndex = 3;
                deadline2txt.Text = "0";
            }

            typesCombo_SelectedIndexChanged(sender, e);
        }

        private void hintCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            typesCombo_SelectedIndexChanged(sender, e);
        }

        private void deadline2txt_TextChanged(object sender, EventArgs e)
        {
            typesCombo_SelectedIndexChanged(sender, e);
        }

        private void SearchByDrugType_FormClosing(object sender, FormClosingEventArgs e)
        {
            Queries queries = new Queries();
            Hide();
            queries.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            typesCombo_SelectedIndexChanged(sender, e);
        }

        private void logicComboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hintComboPrice2.Text.Trim() == "" &&
                price2txt.Text.Trim() == "")
            {
                hintComboPrice2.SelectedIndex = 3;
                price2txt.Text = "0";
            }

            typesCombo_SelectedIndexChanged(sender, e);
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
            typesCombo_SelectedIndexChanged(sender, e);
        }

        private void hintComboPrice1_SelectedIndexChanged(object sender, EventArgs e)
        {
            typesCombo_SelectedIndexChanged(sender, e);
        }

        private void hintComboPrice2_SelectedIndexChanged(object sender, EventArgs e)
        {
            typesCombo_SelectedIndexChanged(sender, e);
        }

        private void price2txt_TextChanged(object sender, EventArgs e)
        {
            typesCombo_SelectedIndexChanged(sender, e);
        }
    }
}
