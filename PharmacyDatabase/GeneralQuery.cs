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
    public partial class GeneralQuery : Form
    {
        string path = Program.path;
        string query = "";

        public void View()
        {
            using (SqlConnection conn = new SqlConnection(path))
            {
                string query = "SELECT Drug.Drug_ID, Drug.Name, Drug.Firm, " +
                               "Firm.Country, Firm.FirmPhone, Drug.Pharmacy, " +
                               "Pharmacy.Address, Pharmacy.Phone, " +
                               "Drug.Best_Before, DrugType.Type, " +
                               "Disease1.Name AS DiseaseName, Disease1.Character, " +
                               "Drug.Price, DrugType.Year FROM Drug " +
                               "JOIN DrugType ON Drug.Type = DrugType.Type " +
                               "JOIN Disease1 ON Drug.Disease = Disease1.Name " +
                               "JOIN Firm ON Drug.Firm = Firm.Name " +
                               "JOIN Pharmacy ON Drug.Pharmacy = Pharmacy.Name";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    DatasView.DataSource = datatable;
                }
            }
        }

        public void ClearFields()
        {
            nametxt.Text = "";
            typesCombo.Text = "<turni tanlang>";
            deadline1txt.Text = "";
            hintCombo1.Text = "";
            deadline2txt.Text = "";
            hintCombo2.Text = "";
            price1txt.Text = "";
            hintComboPrice1.Text = "";
            price2txt.Text = "";
            hintComboPrice2.Text = "";
            logicCombo.Text = "";
            logicComboPrice.Text = "";
            charactertxt.Text = "";
            phonetxt.Text = "";
            countrytxt.Text = "";
            pharmacytxt.Text = "";
            addresstxt.Text = "";
            firmphonetxt.Text = "";
            diseasetxt.Text = "";
            firmtxt.Text = "";
        }

        public GeneralQuery()
        {
            InitializeComponent();
        }

        private void GeneralQuery_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Queries queries = new Queries();
            Hide();
            queries.Show();
        }

        private void GeneralQuery_Load(object sender, EventArgs e)
        {
            nametxt.Focus();
            nametxt.FindForm();

            View();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
            View();
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(path))
                {
                    query = "SELECT Drug.Drug_ID, Drug.Name, Drug.Firm, " +
                               "Firm.Country, Firm.FirmPhone, Drug.Pharmacy, " +
                               "Pharmacy.Address, Pharmacy.Phone," +
                               "Drug.Best_Before, DrugType.Type, " +
                               "Disease1.Name AS DiseaseName, Disease1.Character, " +
                               "Drug.Price, DrugType.Year FROM Drug " +
                               "JOIN DrugType ON Drug.Type = DrugType.Type " +
                               "JOIN Disease1 ON Drug.Disease = Disease1.Name " +
                               "JOIN Firm ON Drug.Firm = Firm.Name " +
                               "JOIN Pharmacy ON Drug.Pharmacy = Pharmacy.Name " +
                               "WHERE 1=1";

                    List<SqlParameter> parameters = new List<SqlParameter>();

                    if (!string.IsNullOrWhiteSpace(nametxt.Text))
                    {
                        query += " AND Drug.Name LIKE @name";
                        parameters.Add(new SqlParameter("@name", nametxt.Text + "%"));
                    }

                    if (!string.IsNullOrWhiteSpace(typesCombo.Text) &&
                        typesCombo.Text != "<turni tanlang>")
                    {
                        query += " AND Drug.Type LIKE @type";
                        parameters.Add(new SqlParameter("@type", typesCombo.Text + "%"));
                    }

                    if (!string.IsNullOrWhiteSpace(deadline1txt.Text) &&
                        string.IsNullOrWhiteSpace(hintCombo1.Text))
                    {
                        query += " AND Drug.Best_before LIKE @deadline1";
                        parameters.Add(new SqlParameter("@deadline1", deadline1txt.Text + "%"));
                    }
                    else if (!string.IsNullOrWhiteSpace(deadline1txt.Text) &&
                             !string.IsNullOrWhiteSpace(hintCombo1.Text))
                    {
                        string s = hintCombo1.Text;
                        parameters.Add(new SqlParameter("@deadline1", deadline1txt.Text));

                        query += s == ">" ? " AND Drug.Best_before < @deadline1" :
                                 s == ">=" ? " AND Drug.Best_before <= @deadline1" :
                                 s == "=" ? " AND Drug.Best_before = @deadline1" :
                                 s == "<=" ? " AND Drug.Best_before >= @deadline1" :
                                 " AND Drug.Best_before > @deadline1";
                    }

                    if (!string.IsNullOrWhiteSpace(logicCombo.Text))
                    {
                        query += " " + logicCombo.Text.Trim();

                        if (!string.IsNullOrWhiteSpace(deadline2txt.Text) &&
                        string.IsNullOrWhiteSpace(hintCombo2.Text))
                        {
                            query += " Drug.Best_before LIKE @deadline2";
                            parameters.Add(new SqlParameter("@deadline2", deadline2txt.Text + "%"));
                        }
                        else if (!string.IsNullOrWhiteSpace(deadline2txt.Text) &&
                                 !string.IsNullOrWhiteSpace(hintCombo2.Text))
                        {
                            string s = hintCombo2.Text;
                            parameters.Add(new SqlParameter("@deadline2", deadline2txt.Text));

                            query += s == ">" ? " Drug.Best_before > @deadline2" :
                                     s == ">=" ? " Drug.Best_before >= @deadline2" :
                                     s == "=" ? " Drug.Best_before = @deadline2" :
                                     s == "<=" ? " Drug.Best_before <= @deadline2" :
                                     " Drug.Best_before < @deadline2";
                        }
                    }

                    ///
                    if (!string.IsNullOrWhiteSpace(price1txt.Text) &&
                        string.IsNullOrWhiteSpace(hintComboPrice1.Text))
                    {
                        query += " AND Drug.Price LIKE @price1";
                        parameters.Add(new SqlParameter("@price1", price1txt.Text + "%"));
                    }
                    else if (!string.IsNullOrWhiteSpace(price1txt.Text) &&
                             !string.IsNullOrWhiteSpace(hintComboPrice1.Text))
                    {
                        string s = hintComboPrice1.Text;
                        parameters.Add(new SqlParameter("@price1", price1txt.Text));

                        query += s == ">" ? " AND Drug.Price < @price1" :
                                 s == ">=" ? " AND Drug.Price <= @price1" :
                                 s == "=" ? " AND Drug.Price = @price1" :
                                 s == "<=" ? " AND Drug.Price >= @price1" :
                                 " AND Drug.Price > @price1";
                    }

                    if (!string.IsNullOrWhiteSpace(logicComboPrice.Text))
                    {
                        query += " " + logicComboPrice.Text.Trim();

                        if (!string.IsNullOrWhiteSpace(price2txt.Text) &&
                        string.IsNullOrWhiteSpace(hintComboPrice2.Text))
                        {
                            query += " Drug.Price LIKE @price2";
                            parameters.Add(new SqlParameter("@price2", price2txt.Text + "%"));
                        }
                        else if (!string.IsNullOrWhiteSpace(price2txt.Text) &&
                                 !string.IsNullOrWhiteSpace(hintComboPrice2.Text))
                        {
                            string s = hintComboPrice2.Text;
                            parameters.Add(new SqlParameter("@price2", price2txt.Text));

                            query += s == ">" ? " Drug.Price > @price2" :
                                     s == ">=" ? " Drug.Price >= @price2" :
                                     s == "=" ? " Drug.Price = @price2" :
                                     s == "<=" ? " Drug.Price <= @price2" :
                                     " Drug.Price < @price2";
                        }
                    }

                    ///
                    if (!string.IsNullOrWhiteSpace(year1txt.Text) &&
                        string.IsNullOrWhiteSpace(hintCombo3.Text))
                    {
                        query += " AND DrugType.Year LIKE @year1";
                        parameters.Add(new SqlParameter("@year1", year1txt.Text + "%"));
                    }
                    else if (!string.IsNullOrWhiteSpace(year1txt.Text) &&
                             !string.IsNullOrWhiteSpace(hintCombo3.Text))
                    {
                        string s = hintCombo3.Text;
                        parameters.Add(new SqlParameter("@year1", year1txt.Text));

                        query += s == ">" ? " AND DrugType.Year < @year1" :
                                 s == ">=" ? " AND DrugType.Year <= @year1" :
                                 s == "=" ? " AND DrugType.Year = @year1" :
                                 s == "<=" ? " AND DrugType.Year >= @year1" :
                                 " AND DrugType.Year > @year1";
                    }

                    if (!string.IsNullOrWhiteSpace(logicCombo3.Text))
                    {
                        query += " " + logicCombo3.Text.Trim();

                        if (!string.IsNullOrWhiteSpace(year2txt.Text) &&
                        string.IsNullOrWhiteSpace(hintCombo4.Text))
                        {
                            query += " DrugType.Year LIKE @year2";
                            parameters.Add(new SqlParameter("@year2", year2txt.Text + "%"));
                        }
                        else if (!string.IsNullOrWhiteSpace(year2txt.Text) &&
                                 !string.IsNullOrWhiteSpace(hintCombo4.Text))
                        {
                            string s = hintCombo4.Text;
                            parameters.Add(new SqlParameter("@year2", year2txt.Text));

                            query += s == ">" ? " DrugType.Year > @year2" :
                                     s == ">=" ? " DrugType.Year >= @year2" :
                                     s == "=" ? " DrugType.Year = @year2" :
                                     s == "<=" ? " DrugType.Year <= @year2" :
                                     " DrugType.Year < @year2";
                        }
                    }

                    //
                    if (!string.IsNullOrWhiteSpace(diseasetxt.Text))
                    {
                        query += " AND Disease1.Name LIKE @disease";
                        parameters.Add(new SqlParameter("@disease", diseasetxt.Text + "%"));
                    }

                    if (!string.IsNullOrWhiteSpace(charactertxt.Text))
                    {
                        query += " AND Disease1.Character LIKE @character";
                        parameters.Add(new SqlParameter("@character", charactertxt.Text + "%"));
                    }

                    if (!string.IsNullOrWhiteSpace(phonetxt.Text))
                    {
                        query += " AND Pharmacy.Phone LIKE @phone";
                        parameters.Add(new SqlParameter("@phone", "%" + phonetxt.Text + "%"));
                    }

                    if (!string.IsNullOrWhiteSpace(addresstxt.Text))
                    {
                        query += " AND Pharmacy.Address LIKE @address";
                        parameters.Add(new SqlParameter("@address", addresstxt.Text + "%"));
                    }

                    if (!string.IsNullOrWhiteSpace(pharmacytxt.Text))
                    {
                        query += " AND Pharmacy.Name LIKE @pharmacy";
                        parameters.Add(new SqlParameter("@pharmacy", pharmacytxt.Text + "%"));
                    }

                    if (!string.IsNullOrWhiteSpace(firmtxt.Text))
                    {
                        query += " AND Firm.Name LIKE @firm";
                        parameters.Add(new SqlParameter("@firm", firmtxt.Text + "%"));
                    }

                    if (!string.IsNullOrWhiteSpace(countrytxt.Text))
                    {
                        query += " AND Firm.Name LIKE @country";
                        parameters.Add(new SqlParameter("@country", countrytxt.Text + "%"));
                    }

                    if (!string.IsNullOrWhiteSpace(firmphonetxt.Text))
                    {
                        query += " AND Firm.Phone LIKE @firmphone";
                        parameters.Add(new SqlParameter("@firmphone", "%" + firmphonetxt.Text + "%"));
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

        private void typesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void price1txt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void hintComboPrice1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void logicComboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void hintComboPrice2_SelectedIndexChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void price2txt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void deadline1txt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void hintCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void logicCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void hintCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void deadline2txt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void charactertxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void phonetxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void diseasetxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void firmtxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void countrytxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void firmphonetxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void pharmacytxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void addresstxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void year1txt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void hintCombo3_SelectedIndexChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void logicCombo3_SelectedIndexChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void hintCombo4_SelectedIndexChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void year2txt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }
    }
}
