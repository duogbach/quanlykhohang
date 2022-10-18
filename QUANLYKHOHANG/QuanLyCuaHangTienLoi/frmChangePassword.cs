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
    public partial class frmChangePassword : Form
    {
        frmShowDialogQuestion _frmShowDialogQuestion;
        KetNoiDB ketNoiDB = new KetNoiDB();
        string query;

        public frmChangePassword()
        {
            InitializeComponent();

            InitUI();
        }

        public void InitUI()
        {
            lblErrorPassword.Visible = false;
            lblErrorPassword2.Visible = false;

            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPasswordNew.Text = "";
            txtPassword2.Text = "";
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPasswordNew.Text.Trim().Length < 6)
            {
                lblErrorPassword.Visible = true;
            }
            else
            {
                lblErrorPassword.Visible = false;
            }
        }

        private void txtPassword2_KeyUp(object sender, KeyEventArgs e)
        {
            if (!txtPassword2.Text.Equals(txtPasswordNew.Text))
            {
                lblErrorPassword2.Visible = true;
            }
            else
            {
                lblErrorPassword2.Visible = false;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM Account WHERE Username = '" + txtUsername.Text.Trim() + "' AND Password = '" + txtPassword.Text +
                "'" ;
            if (ketNoiDB.GetValue(query) != null)
            {
                if (txtUsername.Text.Trim().Length < 6)
                {
                    _frmShowDialogQuestion = new frmShowDialogQuestion("Lỗi", "Tên tài khoản mới phải dài hơn 5 ký tự", "Thử lại", "");
                    _frmShowDialogQuestion.ShowDialog();
                    return;
                }
                else if (txtPasswordNew.Text.Length < 6)
                {
                    _frmShowDialogQuestion = new frmShowDialogQuestion("Lỗi", "Mật khẩu mới phải dài hơn 5 ký tự", "Thử lại", "");
                    _frmShowDialogQuestion.ShowDialog();
                    return;
                }
                else if (!txtPassword2.Text.Equals(txtPasswordNew.Text))
                {
                    _frmShowDialogQuestion = new frmShowDialogQuestion("Lỗi", "Mật khẩu nhập lại khác mật khẩu nhập mới đã nhập trước đó!", "Thử lại", "");
                    _frmShowDialogQuestion.ShowDialog();
                    return;
                }

                if ( lblErrorPassword.Visible || lblErrorPassword2.Visible)  
                {
                    _frmShowDialogQuestion = new frmShowDialogQuestion("Lỗi", "Bạn nhập ký tự không hợp lệ. Vui lòng nhập lại!", "Thử lại", "");
                    _frmShowDialogQuestion.ShowDialog();
                }
                else
                {
                    query = "UPDATE Account SET Password = '" + txtPasswordNew.Text
                        + "' WHERE Username = '" + txtUsername.Text.Trim() + "'";

                    if (ketNoiDB.ThucThiCauLenh(query))
                    {
                        _frmShowDialogQuestion = new frmShowDialogQuestion("Thành công", "Thay đổi mật khẩu thành công!", "Quay lại trang", "Ở lại");
                        var dr = _frmShowDialogQuestion.ShowDialog();

                        if(dr == DialogResult.Yes)
                        {
                            this.Close();
                        }

                        InitUI();
                    }
                    else
                    {
                        _frmShowDialogQuestion = new frmShowDialogQuestion("Lỗi", "Có lỗi sảy ra. Vui lòng thử lại!", "Thử lại", "");
                        _frmShowDialogQuestion.ShowDialog();
                    }
                }
            }
            else
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Lỗi", "Bạn nhập sai tài khoản hoặc mật khẩu", "Thử lại", "");
                _frmShowDialogQuestion.ShowDialog();

                InitUI();
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
