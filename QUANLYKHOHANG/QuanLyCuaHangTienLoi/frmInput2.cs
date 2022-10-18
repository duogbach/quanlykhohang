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
    public partial class frmInput2 : Form
    {
        public frmInput2()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim().Length > 5 && txtPassword.Text.Trim().Length > 5 && txtPassword.Text.Trim().Equals(txtPassword2.Text.Trim()))
            {
                frmQuanLyQLNhanVien.username = txtUsername.Text;
                frmQuanLyQLNhanVien.password = txtPassword.Text;

                this.Close();
            }
            else
            {
                if(txtPassword.Text.Trim().Equals("") && txtPassword.Text.Trim().Equals(txtPassword2.Text.Trim()))
                {
                    lblLoi.Text = "Nhập lại mật khẩu không trùng khớp";
                }
                else
                {
                    lblLoi.Text = "Tên tài khoản hoặc mật khẩu phải dài hơn 5 ký tự";
                }
                lblLoi.Visible = true;
            }
        }
    }
}
