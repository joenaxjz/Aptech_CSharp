using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App3
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=LAPTOP-FDR7M9C3;Initial Catalog=ManageStudent;Integrated Security=True";
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable table = new DataTable();

        void load_data()
        {
            cmd = con.CreateCommand();
            // dùng câu truy vấn
            cmd.CommandText = "select stuId, stuName, stuGender, stuAddress, stuPhone, stuEmail, stuDoB, status from tblStudent";
            adap.SelectCommand = cmd;
            table.Clear();
            adap.Fill(table);
            dataGridView1.DataSource = table;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            load_data();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i;
            //i = dataGridView1.CurrentRow.Index;
            //txtStuId.Text = dataGridView1[i].Cells[0].Value.ToString();
            //txtStuName.Text = dataGridView1[i].Cells[1].Value.ToString();
        }

    }
}
