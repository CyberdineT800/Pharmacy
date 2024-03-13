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
    public partial class Pharmacy : Form
    {
        string path = Program.path;
        string query = "";

        int id = 0;
        bool isCellClick = false;

        SqlConnection conn;
        SqlCommand sqlCommand;
        SqlDataAdapter adapter;
        DataTable datatable = new DataTable();

        public Pharmacy()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            Hide();
            tables.Show();
        }

        public void View()
        {
            conn = new SqlConnection(path);
            query = "SELECT * FROM Pharmacy";

            adapter = new SqlDataAdapter(query, conn);

            datatable.Clear();
            adapter.Fill(datatable);
            DatasView.DataSource = datatable;
        }

        public bool Check_Fields()
        {
            return nametxt.Text == "" || nametxt.Text == " " ||
                   addresstxt.Text == "" || addresstxt.Text == " " ||
                   phonetxt.Text == "" || phonetxt.Text == " ";
        }

        public void ClearFields()
        {
            nametxt.Text = "";
            addresstxt.Text = "";
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

                query = "INSERT INTO Pharmacy VALUES(@name, @address, @phone)";

                sqlCommand = new SqlCommand(query, conn);

                sqlCommand.Parameters.AddWithValue("@name", nametxt.Text);
                sqlCommand.Parameters.AddWithValue("@address", addresstxt.Text);
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

                        query = "DELETE FROM Pharmacy WHERE Pharmacy_ID = @id";

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

                    query = "UPDATE Pharmacy SET Name = @name, " +
                                            "Address = @address, " +
                                            "Phone = @phone " +
                                            "WHERE Pharmacy_ID = @id";

                    sqlCommand = new SqlCommand(query, conn);

                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Parameters.AddWithValue("@name", nametxt.Text);
                    sqlCommand.Parameters.AddWithValue("@address", addresstxt.Text);
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

        private void Pharmacy_FormClosing(object sender, FormClosingEventArgs e)
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
                addresstxt.Text = selectedRow.Cells[2].Value.ToString();
                phonetxt.Text = selectedRow.Cells[3].Value.ToString();
            }

            isCellClick = false;
        }

        private void Pharmacy_Load(object sender, EventArgs e)
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
                        query = "SELECT * FROM Pharmacy WHERE 1=1";
                        List<SqlParameter> parameters = new List<SqlParameter>();

                        if (!string.IsNullOrWhiteSpace(nametxt.Text))
                        {
                            query += " AND Name LIKE @name";
                            parameters.Add(new SqlParameter("@name", "%" + nametxt.Text + "%"));
                        }

                        if (!string.IsNullOrWhiteSpace(addresstxt.Text))
                        {
                            query += " AND Address LIKE @address";
                            parameters.Add(new SqlParameter("@address", "%" + addresstxt.Text + "%"));
                        }

                        if (!string.IsNullOrWhiteSpace(phonetxt.Text))
                        {
                            query += " AND Phone LIKE @phone";
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

        private void addresstxt_TextChanged(object sender, EventArgs e)
        {
            nametxt_TextChanged(sender, e);
        }

        private void phonetxt_TextChanged(object sender, EventArgs e)
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
