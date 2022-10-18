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
    public partial class frmQLTKQuanLy : Form
    {
        KetNoiDB ketNoiDB = new KetNoiDB();
        string query;
        frmShowDialogQuestion _frmShowDialogQuestion;
        public frmQLTKQuanLy()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHienThiQL_Click(object sender, EventArgs e)
        {
            query = "SELECT Username FROM Account WHERE Type = 2";
            string username = ketNoiDB.GetValue(query);
            query = "SELECT Password FROM Account WHERE Type = 2";
            string password = ketNoiDB.GetValue(query);

            if (username == null || password == null)
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Lỗi", "Có lỗi xảy ra. Vui lòng thử lại sau!", "Thử lại", "");
                _frmShowDialogQuestion.Show();
                return;
            }

            lblUsernameQuanLy.Text = username;
            lblPasswordQuanLy.Text = password;
        }

        private void btnAnQL_Click(object sender, EventArgs e)
        {
            lblUsernameQuanLy.Text = "******";
            lblPasswordQuanLy.Text = "******";
        }

        private void btnDoiMatKhauQL_Click(object sender, EventArgs e)
        {
            frmChangePassword _frmChangePassword = new frmChangePassword();
            _frmChangePassword.Show();
        }
    }
}
