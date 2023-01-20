using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStudent
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
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

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            using (var ef = new ManageStudentEntities())
            {
                bindingSource1.DataSource = ef.tblDepts.Where(dept => dept.status == "yes").Select(dept => new
                {
                    dept.deptId, dept.deptName, dept.deptPhone, dept.deptAddress, dept.status
                }).ToList();
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;

                txtDeptId.DataBindings.Add("Text", bindingSource1, "deptId", true, DataSourceUpdateMode.OnPropertyChanged);
                txtDeptName.DataBindings.Add("Text", bindingSource1, "deptName", true, DataSourceUpdateMode.OnPropertyChanged);
                txtDeptAdrs.DataBindings.Add("Text", bindingSource1, "deptAddress", true, DataSourceUpdateMode.OnPropertyChanged);
                txtDeptNum.DataBindings.Add("Text", bindingSource1, "deptPhone", true, DataSourceUpdateMode.OnPropertyChanged);
                txtSta.DataBindings.Add("Text", bindingSource1, "status", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            using (var ef = new ManageStudentEntities())
            {
                MessageBox.Show("Are you sure?", "info", MessageBoxButtons.OKCancel);
                var findId = txtDeptId.Text;
                var obj = ef.tblDepts.FirstOrDefault(dept => dept.deptId == findId);
                if (obj != null)
                {
                    obj.deptName = txtDeptName.Text;
                    obj.deptAddress = txtDeptAdrs.Text;
                    obj.status = txtSta.Text;
                    obj.deptPhone = txtDeptNum.Text;
                    if (new Regex("^[0-9]+$").IsMatch(obj.deptPhone))
                    {
                        ef.SaveChanges();
                        bindingSource1.DataSource = ef.tblDepts.Where(dept => dept.status == "yes").Select(dept => new
                        {
                            dept.deptId,
                            dept.deptName,
                            dept.deptPhone,
                            dept.deptAddress,
                            dept.status
                        }).ToList();
                        MessageBox.Show("Updated", "info", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Some text box is null, plese type the value inside");
                }
                }
            
        }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                using ( var ef = new ManageStudentEntities())
            {
                MessageBox.Show("Are you Sure?", "info", MessageBoxButtons.OKCancel);
                
                var dept = new tblDept();
                dept.deptId = txtDeptId.Text;
                dept.deptName = txtDeptName.Text;
                dept.deptAddress = txtDeptAdrs.Text;
                dept.deptPhone = txtDeptNum.Text;
                dept.status = txtSta.Text;
                if (dept.deptId != "" && dept.deptName != "" && dept.deptAddress != "" && dept.deptPhone != "" && dept.status != "")
                {
                    ef.tblDepts.Add(dept);
                    ef.SaveChanges();
                    bindingSource1.DataSource = ef.tblDepts.Where(depts => dept.status == "yes").Select(depts => new
                    {
                        depts.deptId,
                        depts.deptName,
                        depts.deptPhone,
                        depts.deptAddress,
                        depts.status
                    }).ToList();
                    MessageBox.Show("Added", "info", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Some text box has value is null, please enter all of value","info", MessageBoxButtons.OK);
                }
            }
            }
        }
    } 
