using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App11
{
    public partial class App1 : Form
    {
        public App1()
        {
            InitializeComponent();
        }

        private void BtnClickMe_Click(object sender, EventArgs e)
        {
           var rs =  MessageBox.Show("Xin chào","Đây là Caption",MessageBoxButtons.OKCancel,MessageBoxIcon.Hand);
            if (rs == DialogResult.OK)
            {
                MessageBox.Show("xin chào lần 2");
            }
            else
            {
                MessageBox.Show("Tạm biệt <3");
            }

        }
    }
}
