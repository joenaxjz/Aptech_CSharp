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

namespace ManageStudent
{
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DepartmentForm departmentForm = new DepartmentForm();
            this.Hide();
            departmentForm.ShowDialog();
            this.Close();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            StudentForm stuForm = new StudentForm();
            this.Hide();
            stuForm.ShowDialog();
            this.Close();
        }

        private void btnCou_Click(object sender, EventArgs e)
        {
            CourseForm couForm = new CourseForm();
            this.Hide();
            couForm.ShowDialog();
            this.Close();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            ExamForm examForm = new ExamForm();
            this.Hide();
            examForm.ShowDialog();
            this.Close();
        }

        private void btnStu_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            this.Hide();
            studentForm.ShowDialog();
            this.Close();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            this.Hide();
            subjectForm.ShowDialog();
            this.Close();
        }

        private void btnTot_Click(object sender, EventArgs e)
        {
            TotForm totForm = new TotForm();
            this.Hide();
            totForm.ShowDialog();
            this.Close();
        }
    }
}
