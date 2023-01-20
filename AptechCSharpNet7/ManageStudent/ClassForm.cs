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
    public partial class ClassForm : Form
    {
        public ClassForm()
        {
            InitializeComponent();
        }

        private void btnBackToMainPage_Click_1(object sender, EventArgs e)
        {
            MainPageForm mainPage = new MainPageForm();
            this.Hide();
            mainPage.ShowDialog();
            this.Close();
        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            using (var ef = new ManageStudentEntities())
            {
                bindingSource1.DataSource = ef.tblClasses.Where(cou => cou.status == "yes").Select(cls => new
                {
                    cls.classId,
                    cls.className,
                    cls.deptId,
                    cls.totId,
                    cls.couId,
                    cls.status
                }).ToList();
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;

                txtClassId.DataBindings.Add("Text", bindingSource1, "classId", true, DataSourceUpdateMode.OnPropertyChanged);
                txtClassName.DataBindings.Add("Text", bindingSource1, "className", true, DataSourceUpdateMode.OnPropertyChanged);
                txtDeptId.DataBindings.Add("Text", bindingSource1, "deptId", true, DataSourceUpdateMode.OnPropertyChanged);
                txtTotId.DataBindings.Add("Text", bindingSource1, "totId", true, DataSourceUpdateMode.OnPropertyChanged);
                txtCouId.DataBindings.Add("Text", bindingSource1, "couId", true, DataSourceUpdateMode.OnPropertyChanged);
                txtSta.DataBindings.Add("Text", bindingSource1, "status", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using ( var ef = new ManageStudentEntities())
            {
                MessageBox.Show("Are you Sure?", "info", MessageBoxButtons.OKCancel);
                var findIdClass = txtClassId.Text;
                var obj = ef.tblClasses.FirstOrDefault(cls => cls.classId== findIdClass);
                if (obj != null)
                {
                    obj.className = txtClassName.Text;
                    obj.deptId = txtDeptId.Text;
                    obj.totId = Convert.ToInt32(txtTotId.Text);
                    obj.couId = txtCouId.Text;
                    obj.status = txtSta.Text;
                }
                ef.SaveChanges();
                bindingSource1.DataSource = ef.tblClasses.Where(cls => cls.status == "yes").Select(cls => new
                {
                    cls.classId,
                    cls.className,
                    cls.deptId,
                    cls.totId,
                    cls.couId,
                    cls.status
                }).ToList();
                MessageBox.Show("Updated", "info", MessageBoxButtons.OK);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var ef = new ManageStudentEntities())
            {
                MessageBox.Show("Are you Sure?", "info", MessageBoxButtons.OKCancel);
                var cls = new tblClass();
                cls.classId = txtClassId.Text;
                cls.className = txtClassName.Text;
                cls.deptId= txtDeptId.Text;
                cls.totId = Convert.ToInt32(txtTotId.Text);
                cls.couId= txtCouId.Text;
                cls.status = txtSta.Text;

                ef.tblClasses.Add(cls);
                ef.SaveChanges();

                bindingSource1.DataSource = ef.tblClasses.Where(clss => clss.status == "yes").Select(clss => new
                {
                    clss.classId,
                    clss.className,
                    clss.deptId,
                    clss.totId,
                    clss.couId,
                    clss.status
                }).ToList();
              MessageBox.Show("Added", "info", MessageBoxButtons.OK);

            }

        }
    }
}
