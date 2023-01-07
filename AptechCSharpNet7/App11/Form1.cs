using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ado.net
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adap = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["aptechcsharp"].ConnectionString;
            cmd.Connection = con;
            // câu select * from Student là table[0], select Id, LastName from Student table[1]
            cmd.CommandText = "select * from Student; select Id, LastName from Student";
            cmd.CommandType = CommandType.Text;
            adap.SelectCommand = cmd;
            ds.Tables.Clear();

            adap.Fill(ds);
            bindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            txtId.DataBindings.Add("Text", bindingSource1, "Id");

            txtFirstName.DataBindings.Add("Text", bindingSource1, "FirstName");

            txtLastName.DataBindings.Add("Text", bindingSource1, "LastName");

            ChkGender.DataBindings.Add("Checked", bindingSource1, "Gender");

            DoB.DataBindings.Add("Value", bindingSource1, "DoB");
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            // ds.Tables[0].DefaultView = select * from
            // RowFilter = where FirstName like {%kytu%}
            ds.Tables[1].DefaultView.RowFilter = $"FirstName like '%{toolStripTextBox1.Text}%'";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "updateStu";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName",txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@Gender", ChkGender.Checked);
            cmd.Parameters.AddWithValue("@DoB", DoB.Value);
            cmd.Parameters.AddWithValue("@Id", txtId.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                cmd.Parameters.Clear();
            }
            txtId.DataBindings.Clear();

            txtFirstName.DataBindings.Clear();

            txtLastName.DataBindings.Clear();

            ChkGender.DataBindings.Clear();

            DoB.DataBindings.Clear();
            LoadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "delStu";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", txtId.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                cmd.Parameters.Clear();
            }
            txtId.DataBindings.Clear();

            txtFirstName.DataBindings.Clear();

            txtLastName.DataBindings.Clear();

            ChkGender.DataBindings.Clear();

            DoB.DataBindings.Clear();
            LoadData();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // xóa kí tự nhập sẵn trong textbox
            txtId.DataBindings.Clear();

            txtFirstName.DataBindings.Clear();

            txtLastName.DataBindings.Clear();

            ChkGender.DataBindings.Clear();

            DoB.DataBindings.Clear();

            // thực hiện lên insert vào bảng
            cmd.CommandText = "addStu";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@Gender", ChkGender.Checked);
            cmd.Parameters.AddWithValue("@DoB", DoB.Value);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                cmd.Parameters.Clear();
            }

            LoadData();
        }
    }
}
