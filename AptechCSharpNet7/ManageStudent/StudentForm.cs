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
    public partial class StudentForm : Form
    {
        public StudentForm()
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

        private void StudentForm_Load(object sender, EventArgs e)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            using (var ef = new ManageStudentEntities())
            {
                bindingSource1.DataSource = ef.tblStudents.Where(stu => stu.status == "yes").Select(stu => new
                {
                    stu.stuId,
                    stu.stuName,
                    stu.stuGender,
                    stu.stuAddress,
                    stu.stuPhone,
                    stu.stuEmail,
                    stu.stuDoB,
                    stu.status
                }).ToList();
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;

                txtStuId.DataBindings.Add("Text", bindingSource1, "stuId", true, DataSourceUpdateMode.OnPropertyChanged);
                txtStuName.DataBindings.Add("Text", bindingSource1, "stuName", true, DataSourceUpdateMode.OnPropertyChanged);
                txtStuGender.DataBindings.Add("Text", bindingSource1, "stuGender", true, DataSourceUpdateMode.OnPropertyChanged);
                txtStuAdrs.DataBindings.Add("Text", bindingSource1, "stuAddress", true, DataSourceUpdateMode.OnPropertyChanged);
                txtStuPhone.DataBindings.Add("Text", bindingSource1, "stuPhone", true, DataSourceUpdateMode.OnPropertyChanged);
                txtEmail.DataBindings.Add("Text", bindingSource1, "stuEmail", true, DataSourceUpdateMode.OnPropertyChanged);
                dtpDoB.DataBindings.Add("Value", bindingSource1, "stuDoB", true, DataSourceUpdateMode.OnPropertyChanged);
                txtSta.DataBindings.Add("Text", bindingSource1, "status", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using ( var ef = new ManageStudentEntities())
            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show("Are you Sure?", "info", MessageBoxButtons.OKCancel);
                var stu = new tblStudent();
                stu.stuId = txtStuId.Text;
                stu.stuPass = txtPass.Text;
                stu.stuName = txtStuName.Text;
                stu.stuAddress = txtStuAdrs.Text;
                stu.stuGender = txtStuGender.Text;
                stu.stuPhone= txtStuPhone.Text;
                stu.stuEmail = txtEmail.Text;
                stu.stuDoB = dtpDoB.Value;
                stu.status = txtSta.Text;
                ef.tblStudents.Add(stu);
                ef.SaveChanges();
                bindingSource1.DataSource = ef.tblStudents.Where(stus => stu.status == "yes").Select(stus => new
                {
                    stus.stuId,
                    stus.stuName,
                    stus.stuGender,
                    stus.stuAddress,
                    stus.stuPhone,
                    stus.stuEmail,
                    stus.stuDoB,
                    stus.status
                }).ToList();
                MessageBox.Show("Added", "info", MessageBoxButtons.OK);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var ef = new ManageStudentEntities()) {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show("Are you Sure?", "info", MessageBoxButtons.OKCancel);
                var findId = txtStuId.Text;
                var obj = ef.tblStudents.FirstOrDefault(stu => stu.stuId == findId);
                if (obj != null)
                {
                    obj.stuId = txtStuId.Text;
                    obj.stuPass = txtPass.Text;
                    obj.stuName = txtStuName.Text;
                    obj.stuAddress = txtStuAdrs.Text;
                    obj.stuGender = txtStuGender.Text;
                    obj.stuPhone = txtStuPhone.Text;
                    obj.stuEmail = txtEmail.Text;
                    obj.stuDoB = dtpDoB.Value;
                    obj.status = txtSta.Text;
                }
                ef.SaveChanges();
                bindingSource1.DataSource = ef.tblStudents.Where(stus => stus.status == "yes").Select(stus => new
                {
                    stus.stuId,
                    stus.stuName,
                    stus.stuGender,
                    stus.stuAddress,
                    stus.stuPhone,
                    stus.stuEmail,
                    stus.stuDoB,
                    stus.status
                }).ToList();
                MessageBox.Show("Updated", "info", MessageBoxButtons.OK);
            } }
    }
}
