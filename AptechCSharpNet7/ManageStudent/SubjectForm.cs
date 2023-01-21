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
    
    public partial class SubjectForm : Form
    {
        public SubjectForm()
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

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            using (var ef = new ManageStudentEntities())
            {
                bindingSource1.DataSource = ef.tblSubjects.Where(subs => subs.status == "yes").Select( sub => new
                {
                    sub.subjectId, sub.subjectName, sub.semeter, sub.status
                }).ToList();

                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;

                txtSubjId.DataBindings.Add("Text", bindingSource1, "subjectId", true, DataSourceUpdateMode.OnPropertyChanged);
                txtSubjName.DataBindings.Add("Text", bindingSource1, "subjectName", true, DataSourceUpdateMode.OnPropertyChanged);
                txtSem.DataBindings.Add("Text", bindingSource1, "semeter", true, DataSourceUpdateMode.OnPropertyChanged);
                txtSta.DataBindings.Add("Text", bindingSource1, "status", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            using (var ef = new ManageStudentEntities())
            {
                MessageBox.Show("Are you Sure?", "info", MessageBoxButtons.OKCancel);
                var subj = new tblSubject();
                txtSubjId.Clear();
                subj.subjectName = txtSubjName.Text;
                subj.semeter = Convert.ToInt32(txtSem.Text);
                subj.status = txtSta.Text;

                ef.tblSubjects.Add(subj);
                ef.SaveChanges();

                bindingSource1.DataSource = ef.tblSubjects.Where(subs => subs.status == "yes").Select(sub => new
                {
                    sub.subjectId,
                    sub.subjectName,
                    sub.semeter,
                    sub.status
                }).ToList();
                MessageBox.Show("Added", "info", MessageBoxButtons.OK);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var ef =new ManageStudentEntities())
            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show("Are you Sure?", "info", MessageBoxButtons.OKCancel);
                var findID = Convert.ToInt32(txtSubjId.Text);
                var obj = ef.tblSubjects.FirstOrDefault(subj => subj.subjectId == findID);
                if (obj != null)
                {
                    obj.subjectName = txtSubjName.Text;
                    obj.semeter = Convert.ToInt32(txtSem.Text);
                    obj.status = txtSta.Text;
                }
                ef.SaveChanges();
                bindingSource1.DataSource = ef.tblSubjects.Where(subs => subs.status == "yes").Select(sub => new
                {
                    sub.subjectId,
                    sub.subjectName,
                    sub.semeter,
                    sub.status
                }).ToList();
                MessageBox.Show("Updated", "info", MessageBoxButtons.OK);

            }
        }
    }
}
