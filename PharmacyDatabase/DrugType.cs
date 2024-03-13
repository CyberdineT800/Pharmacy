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
    public partial class DrugType : Form
    {
        string path = Program.path;
        string query = "";

        int id = 0;
        bool isCellClick = false;

        SqlConnection conn;
        SqlCommand sqlCommand;
        SqlDataAdapter adapter;
        DataTable datatable = new DataTable();

        public DrugType()
        {
            InitializeComponent();
        }

        private void DrugType_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tables tables = new Tables();
            Hide();
            tables.Show();
        }

        public void View()
        {
            conn = new SqlConnection(path);
            query = "SELECT * FROM DrugType";

            adapter = new SqlDataAdapter(query, conn);

            datatable.Clear();
            adapter.Fill(datatable);
            DatasView.DataSource = datatable;
        }

        public bool Check_Fields()
        {
            return typesCombo.Text == "" || typesCombo.Text == " " || typesCombo.Text == "<turni tanlang>" ||
                   deadlinetxt.Text == "" || deadlinetxt.Text == " ";
        }

        public void ClearFields()
        {
            typesCombo.Text = "<turni tanlang>";
            deadlinetxt.Text = "";
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

                query = "INSERT INTO DrugType VALUES(@type, @deadline, @year)";

                sqlCommand = new SqlCommand(query, conn);

                sqlCommand.Parameters.AddWithValue("@type", typesCombo.Text);
                sqlCommand.Parameters.AddWithValue("@deadline", deadlinetxt.Text);
                sqlCommand.Parameters.AddWithValue("@year", yeartxt.Text);

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

        private void DrugType_Load(object sender, EventArgs e)
        {
            View();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            Hide();
            tables.Show();
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

                        query = "DELETE FROM DrugType WHERE Type_ID = @id";

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
                typesCombo.Text = selectedRow.Cells[1].Value.ToString();
                deadlinetxt.Text = selectedRow.Cells[2].Value.ToString();
            }

            isCellClick = false;
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

                    query = "UPDATE DrugType SET Type = @type, " +
                                            "Best_Before = @deadline, " +
                                            "Year = @year " +
                                            "WHERE Type_ID = @id";

                    sqlCommand = new SqlCommand(query, conn);

                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Parameters.AddWithValue("@type", typesCombo.Text);
                    sqlCommand.Parameters.AddWithValue("@deadline", deadlinetxt.Text);
                    sqlCommand.Parameters.AddWithValue("@year", yeartxt.Text);

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

        private void typesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isCellClick)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(path))
                    {
                        query = "SELECT * FROM DrugType WHERE 1=1";
                        List<SqlParameter> parameters = new List<SqlParameter>();

                        if (!string.IsNullOrWhiteSpace(typesCombo.Text) &&
                            typesCombo.Text != "<turni tanlang>")
                        {
                            query += " AND Type LIKE @type";
                            parameters.Add(new SqlParameter("@type", "%" + typesCombo.Text + "%"));
                        }

                        if (!string.IsNullOrWhiteSpace(deadlinetxt.Text))
                        {
                            query += " AND Best_before LIKE @deadline";
                            parameters.Add(new SqlParameter("@deadline", "%" + deadlinetxt.Text + "%"));
                        }

                        if (!string.IsNullOrWhiteSpace(yeartxt.Text))
                        {
                            query += " AND Year LIKE @year";
                            parameters.Add(new SqlParameter("@year", "%" + yeartxt.Text + "%"));
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

        private void deadlinetxt_TextChanged(object sender, EventArgs e)
        {
            typesCombo_SelectedIndexChanged(sender, e);
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
