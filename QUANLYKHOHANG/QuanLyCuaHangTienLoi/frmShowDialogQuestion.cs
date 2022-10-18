using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTienLoi
{
    public partial class frmShowDialogQuestion : Form
    {
        public frmShowDialogQuestion(string title, string question, string btnYes, string btnNo)
        {
            InitializeComponent();

            this.Text = title;
            txtQuestion.Text = question;
            btnCo.Text = btnYes;
            btnKhong.Text = btnNo;

            if(btnYes.Equals(""))
            {
                btnCo.Visible = false;
            }
            if (btnNo.Equals(""))
            {
                btnKhong.Visible = false;
            }
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
