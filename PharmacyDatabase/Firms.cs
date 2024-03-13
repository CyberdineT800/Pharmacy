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
    public partial class Firms : Form
    {
        string path = Program.path;
        string query = "";

        int id = 0;
        bool isCellClick = false;

        SqlConnection conn;
        SqlCommand sqlCommand;
        SqlDataAdapter adapter;
        DataTable datatable = new DataTable();

        public Firms()
        {
            InitializeComponent();
        }

        public void View()
        {
            conn = new SqlConnection(path);
            query = "SELECT * FROM Firm";

            adapter = new SqlDataAdapter(query, conn);

            datatable.Clear();
            adapter.Fill(datatable);
            DatasView.DataSource = datatable;
        }

        public bool Check_Fields()
        {
            return nametxt.Text == "" || nametxt.Text == " " ||
                   countrytxt.Text == "" || countrytxt.Text == " " ||
                   phonetxt.Text == "" || phonetxt.Text == " ";
        }

        public void ClearFields()
        {
            nametxt.Text = "";
            countrytxt.Text = "";
            phonetxt.Text = "";
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

                query = "INSERT INTO Firm VALUES(@name, @country, @phone)";

                sqlCommand = new SqlCommand(query, conn);

                sqlCommand.Parameters.AddWithValue("@name", nametxt.Text);
                sqlCommand.Parameters.AddWithValue("@country", countrytxt.Text);
                sqlCommand.Parameters.AddWithValue("@phone", phonetxt.Text);

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

                        query = "DELETE FROM Firm WHERE firm_ID = @id";

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

                    query = "UPDATE Firm SET Name = @name, " +
                                            "Country = @country, " +
                                            "FirmPhone = @phone " +
                                            "WHERE Firm_ID = @id";

                    sqlCommand = new SqlCommand(query, conn);

                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Parameters.AddWithValue("@name", nametxt.Text);
                    sqlCommand.Parameters.AddWithValue("@country", countrytxt.Text);
                    sqlCommand.Parameters.AddWithValue("@phone", phonetxt.Text);

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
            Tables tb = new Tables();
            Hide();
            tb.Show();
        }

        private void Firms_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tables tb = new Tables();
            Hide();
            tb.Show();
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
                countrytxt.Text = selectedRow.Cells[2].Value.ToString();
                phonetxt.Text = selectedRow.Cells[3].Value.ToString();
            }

            isCellClick = false;
        }

        private void Firms_Load(object sender, EventArgs e)
        {
            View();
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
            if (!isCellClick)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(path))
                    {
                        query = "SELECT * FROM Firm WHERE 1=1";
                        List<SqlParameter> parameters = new List<SqlParameter>();

                        if (!string.IsNullOrWhiteSpace(nametxt.Text))
                        {
                            query += " AND Name LIKE @name";
                            parameters.Add(new SqlParameter("@name", "%" + nametxt.Text + "%"));
                        }

                        if (!string.IsNullOrWhiteSpace(countrytxt.Text))
                        {
                            query += " AND Country LIKE @country";
                            parameters.Add(new SqlParameter("@country", "%" + countrytxt.Text + "%"));
                        }

                        if (!string.IsNullOrWhiteSpace(phonetxt.Text))
                        {
                            query += " AND FirmPhone LIKE @phone";
                            parameters.Add(new SqlParameter("@phone", "%" + phonetxt.Text + "%"));
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

        private void countrytxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void phonetxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
            View();
        }
    }
}
