using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStudent
{
    public partial class TotForm : Form
    {
        public TotForm()
        {
            InitializeComponent();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            MainPageForm mainPage = new MainPageForm();
            this.Hide();
            mainPage.ShowDialog();
            this.Close();
        }

        private void TotForm_Load(object sender, EventArgs e)
        {
            using(var ef = new ManageStudentEntities())
            {
                bindingSource1.DataSource= ef.tblTots.Where(tots => tots.status == "yes").Select( tots => new
                {
                    tots.totId, tots.totName, tots.status
                }).ToList();
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;

                txtTotId.DataBindings.Add("Text", bindingSource1, "totId", true, DataSourceUpdateMode.OnPropertyChanged);
                txtTotName.DataBindings.Add("Text", bindingSource1, "totName", true, DataSourceUpdateMode.OnPropertyChanged);
                txtSta.DataBindings.Add("Text", bindingSource1, "status", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            using (var ef = new ManageStudentEntities())
            {
                MessageBox.Show("Are you Sure?", "info", MessageBoxButtons.OKCancel);
                var tot = new tblTot();
                txtTotId.Clear();
                tot.totName = txtTotName.Text;
                tot.status = txtSta.Text;

                ef.tblTots.Add(tot);
                ef.SaveChanges();

                bindingSource1.DataSource = ef.tblTots.Where(tots => tots.status == "yes").Select(tots => new
                {
                    tots.totId,
                    tots.totName,
                    tots.status
                }).ToList();
                MessageBox.Show("Added", "info", MessageBoxButtons.OK);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var ef = new ManageStudentEntities())
            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show("Are you Sure?", "info", MessageBoxButtons.OKCancel);
                var findID = Convert.ToInt32(txtTotId.Text);
                var obj = ef.tblTots.FirstOrDefault(tots => tots.totId == findID);
                if (obj != null)
                {
                    obj.totName = txtTotName.Text;
                    obj.status = txtSta.Text;
                }
                ef.SaveChanges();
                bindingSource1.DataSource = ef.tblTots.Where(tots => tots.status == "yes").Select(tots => new
                {
                    tots.totId,
                    tots.totName,
                    tots.status
                }).ToList();
                MessageBox.Show("Updated", "info", MessageBoxButtons.OK);

            }
        }
    }
}
