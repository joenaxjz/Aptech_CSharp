using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // load form event
        private async void Form1_Load(object sender, EventArgs e)
        {
            // khai báo local
            using (var ef = new WFC2109I2Entities())
            {
                // lấy hết trong bảng
                //dataGridView1.DataSource = ef.students.ToList();

                // lấy cột chỉ định trong bảng
                //dataGridView1.DataSource = ef.students.Select(stu => new
                //{
                //    stu.Id, stu.LastName, stu.Gender
                //}).ToList();

                //binding Source
                bindingSource1.DataSource = ef.students.ToList();
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;


                txtId.DataBindings.Add("Text", bindingSource1, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
                txtFirstName.DataBindings.Add("Text", bindingSource1, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged);
                txtLastName.DataBindings.Add("Text", bindingSource1, "LastName", true, DataSourceUpdateMode.OnPropertyChanged);
                chkGender.DataBindings.Add("Checked", bindingSource1, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);
                dtpDoB.DataBindings.Add("Value", bindingSource1, "DoB", true, DataSourceUpdateMode.OnPropertyChanged);

            }    


        }

        private void chkGender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var ef = new WFC2109I2Entities())
            {
                var Findid = Convert.ToInt32(txtId.Text);
                // tìm id trùng với id trong database
                var obj = await ef.students.FirstOrDefaultAsync(stu => stu.Id == Findid);
                if(obj!= null)
                {
                    obj.FirstName = txtFirstName.Text;
                    obj.LastName  = txtLastName.Text;
                    obj.Gender    = chkGender.Checked;
                    obj.DoB       = dtpDoB.Value;
                }
                await ef.SaveChangesAsync();
                bindingSource1.DataSource = await ef.students.ToListAsync();
                MessageBox.Show("Updated", "info", MessageBoxButtons.OK);
                // async => dùng bên trên method
                // await => dung bên trong method
            }
            }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            using (var ef = new WFC2109I2Entities())
            {
                var stu = new student();
                stu.FirstName = txtFirstName.Text;
                stu.LastName = txtLastName.Text;
                stu.Gender = chkGender.Checked;
                stu.DoB = dtpDoB.Value;

                ef.students.Add(stu);

                await ef.SaveChangesAsync();

                bindingSource1.DataSource = await ef.students.ToListAsync();
                MessageBox.Show("Inserted", "info", MessageBoxButtons.OK);
            }
            }

        private async void btnDel_Click(object sender, EventArgs e)
        {
            using (var ef = new WFC2109I2Entities())
            {
                var findId = Convert.ToInt32(txtId.Text);
                //foreach (var stu in ef.students)
                //{
                //    if(stu.Id == findId)
                //    {
                //        ef.students.Remove(stu);
                //    }
                //}
                ef.students.Remove(ef.students.FirstOrDefault(stu => stu.Id == findId));
                await ef.SaveChangesAsync();
                bindingSource1.DataSource = await ef.students.ToListAsync();
                MessageBox.Show("Deleted", "info", MessageBoxButtons.OK);
            }
            }
    }
}
