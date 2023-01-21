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
    public partial class ExamForm : Form
    {
        public ExamForm()
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

        private void ExamForm_Load(object sender, EventArgs e)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            using (var ef = new ManageStudentEntities())
            {
                bindingSource1.DataSource = ef.tblExams.Where(ex => ex.status == "yes").Select(ex => new
                {
                    ex.stuId,
                    ex.subjectId,
                    ex.examName,
                    ex.mark1st,
                    ex.mark2nd,
                    ex.status
                }).ToList();
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;

                txtSubId.DataBindings.Add("Text", bindingSource1, "subjectId", true, DataSourceUpdateMode.OnPropertyChanged);
                txtStuId.DataBindings.Add("Text", bindingSource1, "stuId", true, DataSourceUpdateMode.OnPropertyChanged);
                txtExName.DataBindings.Add("Text", bindingSource1, "examName", true, DataSourceUpdateMode.OnPropertyChanged);
                txtMark1.DataBindings.Add("Text", bindingSource1, "mark1st", true, DataSourceUpdateMode.OnPropertyChanged);
                txtMark2.DataBindings.Add("Text", bindingSource1, "mark2nd", true, DataSourceUpdateMode.OnPropertyChanged);
                txtSta.DataBindings.Add("Text", bindingSource1, "status", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            using(var ef = new ManageStudentEntities()){
                var ex = new tblExam();
                ex.subjectId = Convert.ToInt32(txtSubId.Text);
                ex.stuId = txtStuId.Text;
                ex.examName = txtExName.Text;
                ex.mark1st = Convert.ToInt32(txtMark1.Text);
                ex.mark2nd = Convert.ToInt32(txtMark2.Text);
                ex.status = txtSta.Text;

                ef.tblExams.Add(ex);
                ef.SaveChanges();

                bindingSource1.DataSource = ef.tblExams.Where(exam => ex.status == "yes").Select(exam => new
                {
                    exam.stuId,
                    exam.subjectId,
                    exam.examName,
                    exam.mark1st,
                    exam.mark2nd,
                    exam.status
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
                var findSubId = Convert.ToInt32(txtSubId.Text);
                var findStuId = txtStuId.Text;
                var obj = ef.tblExams.FirstOrDefault(exam => exam.stuId == findStuId &&  exam.subjectId == findSubId);
                if (obj != null)
                {
                    obj.subjectId = Convert.ToInt32(txtSubId.Text);
                    obj.stuId = txtStuId.Text;
                    obj.examName = txtExName.Text;
                    obj.mark1st = Convert.ToInt32(txtMark1.Text);
                    obj.mark2nd = Convert.ToInt32(txtMark2.Text);
                    obj.status = txtSta.Text;
                }
                ef.SaveChanges();
                bindingSource1.DataSource = ef.tblExams.Where(exam => exam.status == "yes").Select(exam => new
                {
                    exam.stuId,
                    exam.subjectId,
                    exam.examName,
                    exam.mark1st,
                    exam.mark2nd,
                    exam.status
                }).ToList();
                MessageBox.Show("Updated", "info", MessageBoxButtons.OK);
            }
        }
    }
}
