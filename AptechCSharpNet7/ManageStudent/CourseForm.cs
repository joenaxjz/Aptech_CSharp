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
    public partial class CourseForm : Form
    {
        public CourseForm()
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

        private void CourseForm_Load(object sender, EventArgs e)
        {
            using (var ef = new ManageStudentEntities())
            {
                bindingSource1.DataSource = ef.tblCourses.Where(cou => cou.status == "yes").Select(cou => new
                {
                    cou.couId, cou.couName, cou.couSemeter, cou.status
                }).ToList();
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;

                txtCouId.DataBindings.Add("Text", bindingSource1, "couId", true, DataSourceUpdateMode.OnPropertyChanged);
                txtCouName.DataBindings.Add("Text", bindingSource1, "couName", true, DataSourceUpdateMode.OnPropertyChanged);
                txtCouSem.DataBindings.Add("Text", bindingSource1, "couSemeter", true, DataSourceUpdateMode.OnPropertyChanged);
                txtSta.DataBindings.Add("Text", bindingSource1, "status",true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void btnUpdateCou_Click(object sender, EventArgs e)
        {
            using ( var ef = new ManageStudentEntities())
            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show("Are you Sure?", "info", MessageBoxButtons.OKCancel);
                var findCouId = txtCouId.Text;
                var obj = ef.tblCourses.FirstOrDefault(cou => cou.couId== findCouId);
                if (obj != null)
                {
                    obj.couName = txtCouName.Text;
                    obj.couSemeter = Convert.ToInt32(txtCouSem.Text);
                    obj.status = txtSta.Text;
                }
                ef.SaveChanges();
                bindingSource1.DataSource = ef.tblCourses.Where(cou => cou.status == "yes").Select(cous => new
                {
                    cous.couId,
                    cous.couName,
                    cous.couSemeter,
                    cous.status
                }).ToList();
                MessageBox.Show("Updated", "info", MessageBoxButtons.OK);
            }
        }

        private void btnAddCou_Click(object sender, EventArgs e)
        {
            using (var ef = new ManageStudentEntities())
            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show("Are you Sure?", "info", MessageBoxButtons.OKCancel);
                var cou = new tblCourse();
                cou.couId = txtCouId.Text;
                cou.couName = txtCouName.Text;
                cou.couSemeter = Convert.ToInt32(txtCouSem.Text);
                cou.status = txtSta.Text;

                ef.tblCourses.Add(cou);
                ef.SaveChanges();

                bindingSource1.DataSource = ef.tblCourses.Where(cous => cou.status == "yes").Select(cous => new
                {
                    cous.couId,
                    cous.couName,
                    cous.couSemeter,
                    cous.status
                }).ToList();
                MessageBox.Show("Added", "info", MessageBoxButtons.OK);
            }
        }
    }
}
