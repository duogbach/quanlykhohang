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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        frmShowDialogQuestion _frmShowDialogQuestion;

        private void cboPhanQuyen_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboPhanQuyen.SelectedIndex == 0)
            {
                lblText.Text = "Vui lòng nhập tài khoản admin của bạn...";
            }
            else if (cboPhanQuyen.SelectedIndex == 1)
            {
                lblText.Text = "Vui lòng nhập tài khoản quản lý của bạn...";
            }
            else if (cboPhanQuyen.SelectedIndex == 2)
            {
                lblText.Text = "Vui lòng nhập tài khoản nhân viên của bạn...";
            }
            else
            {
                lblText.Text = "Vui lòng lựa chọn phân quyền.";
            }
        }

        string idSalary;
        public void SalaryHandle()
        {
            KetNoiDB ketNoiDB = new KetNoiDB();
            string time = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            string query = "SELECT ID FROM Staff WHERE Username = '" + txtUsername.Text.Trim() + "'";
            string id = ketNoiDB.GetValue(query);
            query = "INSERT INTO Salary(IDStaff, TimeIn, Status) VALUES(" + id + ", '" + time + "', 0)";
            ketNoiDB.ThucThiCauLenh(query);
            query = "SELECT ID FROM Salary WHERE IDStaff = " + id + " AND TimeIn = '" + time + "'";
            idSalary = ketNoiDB.GetValue(query);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            KetNoiDB ketNoiDB = new KetNoiDB();

            string tk = txtUsername.Text;
            string mk = txtPassword.Text;

            string sql;
            if (cboPhanQuyen.SelectedIndex == 0)
            {
                sql = "SELECT * FROM Account WHERE Username = '" + tk + "' AND Password = '" + mk + "' AND Type = 1";
            }
            else if (cboPhanQuyen.SelectedIndex == 1)
            {
                sql = "SELECT * FROM Account WHERE Username = '" + tk + "' AND Password = '" + mk + "' AND Type = 2";
            }
            else
            {
                sql = "SELECT * FROM Account WHERE Username = '" + tk + "' AND Password = '" + mk + "' AND Type = 3";
            }

            string val = ketNoiDB.GetValue(sql);

            if (val != null)
            {
                if (cboPhanQuyen.SelectedIndex == 0)
                {
                    frmAdminMain _frmAdmiMainn = new frmAdminMain();
                    _frmAdmiMainn.Show();

                    this.Hide();
                }
                else if (cboPhanQuyen.SelectedIndex == 1)
                {
                    frmQuanLyMain _frmQuanLyMain = new frmQuanLyMain();
                    _frmQuanLyMain.Show();

                    this.Hide();
                }
                else
                {
                    SalaryHandle();
                    frmNhanVienMain _frmNhanVienMain = new frmNhanVienMain(txtUsername.Text, 1.ToString());
                    _frmNhanVienMain.Show();

                    this.Hide();
                }
                _frmShowDialogQuestion = new frmShowDialogQuestion("Thành công", "Đăng nhập thành công", "Tiếp tục", "");
                var x = _frmShowDialogQuestion.ShowDialog();
            }
            else
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Thất bại", "Tên tài khoản hoặc mật khẩu không chính xác", "Thử lại", "");
                _frmShowDialogQuestion.Show();
            }
        }

        private void lblQuenPass_Click(object sender, EventArgs e)
        {
            _frmShowDialogQuestion = new frmShowDialogQuestion("Quên mật khẩu", "Bạn vui lòng liên hệ Admin để xác nhận danh tính và lấy lại tài khoản", "Đồng ý", "");
            var x = _frmShowDialogQuestion.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmChangePassword _frmChangePassword = new frmChangePassword();
            _frmChangePassword.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _frmShowDialogQuestion = new frmShowDialogQuestion("Thoát", "Bạn có muốn thoát chương trình không?", "Có", "Không");
            var dr = _frmShowDialogQuestion.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
