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
    public partial class frmAdminMain : Form
    {
        public frmAdminMain()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelQLTKSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            btnXong.Visible = true;
        }


        private void btnQLTK_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLTKSubMenu);
        }
        private void btnQLTKNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLTKNhanVien());
            hideSubMenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmShowDialogQuestion _frmShowDialogQuestion = new frmShowDialogQuestion("Đăng xuất", "Bạn có muốn đăng xuất không?", "Có", "Không");
            var x = _frmShowDialogQuestion.ShowDialog();

            if(x == DialogResult.Yes)
            {
                this.Close();

                frmLogin _frmLogin = new frmLogin();
                _frmLogin.Show();
            }
        }

        private void btnQLTKChuCuaHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLTKAdmin());
            hideSubMenu();
        }

        private void btnQLTKQuanLy_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLTKQuanLy());
            hideSubMenu();
        }

        private void btnThongTinCH_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongTinKho());
            hideSubMenu();
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            btnXong.Visible = false;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmXemDoanhThu());
            hideSubMenu();
        }

        private void btnAdminQLTK_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLTKAdmin());
            hideSubMenu();
        }

        private void btnThanhToanLuong_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThanhToanLuong());
            hideSubMenu();
        }
    }
}
