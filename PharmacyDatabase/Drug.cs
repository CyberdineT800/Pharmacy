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
    public partial class Drug : Form
    {
        string path = Program.path;
        string query = "";

        int id = 0;
        bool isCellClick = false;

        SqlConnection conn;
        SqlCommand sqlCommand;
        SqlDataAdapter adapter;
        DataTable datatable = new DataTable();

        public Drug()
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
            return typesCombo.Text == "" || typesCombo.Text == " " ||
                   typesCombo.Text == "<turni tanlang>" ||
                   deadlinetxt.Text == "" || deadlinetxt.Text == " " ||
                   firmtxt.Text == "" || firmtxt.Text == " " ||
                   pharmacytxt.Text == "" || pharmacytxt.Text == " " ||
                   nametxt.Text == "" || nametxt.Text == " " ||
                   diseasetxt.Text == "" || diseasetxt.Text == " " ||
                   pricetxt.Text == "" || pricetxt.Text == " ";
        }

        public void ClearFields()
        {
            typesCombo.Text = "<turni tanlang>";
            deadlinetxt.Text = "";
            firmtxt.Text = "";
            pharmacytxt.Text = "";
            nametxt.Text = "";
            diseasetxt.Text = "";
            pricetxt.Text = "";
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check_Fields())
                {
                    MessageBox.Show("Please fill all fields !", "Insert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                conn = new SqlConnection(path);

                query = "INSERT INTO Drug VALUES (@name, @firm, " +
                                                 "@pharmacy, @deadline, " +
                                                 "@type, @disease, @price)";

                sqlCommand = new SqlCommand(query, conn);

                sqlCommand.Parameters.AddWithValue("@name", nametxt.Text);
                sqlCommand.Parameters.AddWithValue("@firm", firmtxt.Text);
                sqlCommand.Parameters.AddWithValue("@pharmacy", pharmacytxt.Text);
                sqlCommand.Parameters.AddWithValue("@deadline", deadlinetxt.Text);
                sqlCommand.Parameters.AddWithValue("@type", typesCombo.Text);
                sqlCommand.Parameters.AddWithValue("@disease", diseasetxt.Text);
                sqlCommand.Parameters.AddWithValue("@price", pricetxt.Text);

                conn.Open();
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Information has been inserted !", "Insert",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();

                View();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (!Check_Fields())
            {
                try
                {
                    DataGridViewRow selectedRow = DatasView.CurrentRow;

                    DialogResult result = MessageBox.Show("Are you sure ? \n The selected row will be deleted",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        conn = new SqlConnection(path);

                        query = "DELETE FROM Drug WHERE Drug_ID = @id";

                        sqlCommand = new SqlCommand(query, conn);
                        sqlCommand.Parameters.AddWithValue("@id", id);

                        conn.Open();
                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("Information has been deleted !", "Delete",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        View();
                        ClearFields();

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields !", "Insert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (!Check_Fields())
            {
                try
                {
                    DataGridViewRow selectedRow = DatasView.CurrentRow;
                    //int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                    conn = new SqlConnection(path);

                    query = "UPDATE Drug SET Name = @name, " +
                                            "Firm = @firm, " +
                                            "Pharmacy = @pharmacy, " +
                                            "Best_before = @deadline, " +
                                            "Type = @type, " +
                                            "Disease= @disease, " +
                                            "Price = @price " +
                                            "WHERE Drug_ID = @id";

                    sqlCommand = new SqlCommand(query, conn);

                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Parameters.AddWithValue("@name", nametxt.Text);
                    sqlCommand.Parameters.AddWithValue("@firm", firmtxt.Text);
                    sqlCommand.Parameters.AddWithValue("@pharmacy", pharmacytxt.Text);
                    sqlCommand.Parameters.AddWithValue("@deadline", deadlinetxt.Text);
                    sqlCommand.Parameters.AddWithValue("@type", typesCombo.Text);
                    sqlCommand.Parameters.AddWithValue("@disease", diseasetxt.Text);
                    sqlCommand.Parameters.AddWithValue("@price", pricetxt.Text);

                    conn.Open();
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Information has been updated !", "Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conn.Close();

                    View();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields !", "Insert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            Hide();
            tables.Show();
        }

        private void Drug_Load(object sender, EventArgs e)
        {
            nametxt.Focus();
            nametxt.FindForm();

            View();
        }

        private void Drug_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tables tables = new Tables();
            Hide();
            tables.Show();
        }

        private void DatasView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isCellClick = true;

            DataGridViewRow selectedRow = DatasView.CurrentRow;

            if (DatasView.CurrentRow.Index == DatasView.Rows.Count - 1)
            {
                ClearFields();
            }
            else
            {
                id = Convert.ToInt32(selectedRow.Cells[0].Value);
                nametxt.Text = selectedRow.Cells[1].Value.ToString();
                firmtxt.Text = selectedRow.Cells[2].Value.ToString();
                pharmacytxt.Text = selectedRow.Cells[3].Value.ToString();
                deadlinetxt.Text = selectedRow.Cells[4].Value.ToString();
                typesCombo.Text = selectedRow.Cells[5].Value.ToString();
                diseasetxt.Text = selectedRow.Cells[6].Value.ToString();
                pricetxt.Text = selectedRow.Cells[7].Value.ToString();
            }

            isCellClick = false;
        }


        private void nametxt_TextChanged(object sender, EventArgs e)
        {
            if (!isCellClick)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(path))
                    {
                        query = "SELECT * FROM Drug WHERE 1=1";
                        List<SqlParameter> parameters = new List<SqlParameter>();

                        if (!string.IsNullOrWhiteSpace(nametxt.Text))
                        {
                            query += " AND Name LIKE @name";
                            parameters.Add(new SqlParameter("@name", "%" + nametxt.Text + "%"));
                        }

                        if (!string.IsNullOrWhiteSpace(firmtxt.Text))
                        {
                            query += " AND Firm LIKE @firm";
                            parameters.Add(new SqlParameter("@firm", "%" + firmtxt.Text + "%"));
                        }

                        if (!string.IsNullOrWhiteSpace(pharmacytxt.Text))
                        {
                            query += " AND Pharmacy LIKE @pharmacy";
                            parameters.Add(new SqlParameter("@pharmacy", "%" + pharmacytxt.Text + "%"));
                        }

                        if (!string.IsNullOrWhiteSpace(deadlinetxt.Text))
                        {
                            query += " AND Best_before LIKE @deadline";
                            parameters.Add(new SqlParameter("@deadline", "%" + deadlinetxt.Text + "%"));
                        }

                        if (!string.IsNullOrWhiteSpace(typesCombo.Text) && typesCombo.Text != "<turni tanlang>")
                        {
                            query += " AND Type LIKE @type";
                            parameters.Add(new SqlParameter("@type", "%" + typesCombo.Text + "%"));
                        }

                        if (!string.IsNullOrWhiteSpace(diseasetxt.Text))
                        {
                            query += " AND Disease LIKE @disease";
                            parameters.Add(new SqlParameter("@disease", "%" + diseasetxt.Text + "%"));
                        }

                        if (!string.IsNullOrWhiteSpace(pricetxt.Text))
                        {
                            query += " AND Price = @price";
                            parameters.Add(new SqlParameter("@price", pricetxt.Text));
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
        }

        private void firmtxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void pharmacytxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void deadlinetxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void typesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void diseasetxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Tables tb = new Tables();
            Hide();
            tb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
            View();
        }
    }
}
