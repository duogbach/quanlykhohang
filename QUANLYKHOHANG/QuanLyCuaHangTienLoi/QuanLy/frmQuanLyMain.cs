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
    public partial class frmQuanLyMain : Form
    {
        public frmQuanLyMain()
        {
            InitializeComponent();

            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelQLNhapXuatSubMenu.Visible = false;
            panelQLSPSubMenu.Visible = false;
            panelThongKeDoanhThuSubMenu.Visible = false;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmShowDialogQuestion _frmShowDialogQuestion = new frmShowDialogQuestion("Đăng xuất", "Bạn có muốn đăng xuất không?", "Có", "Không");
            var x = _frmShowDialogQuestion.ShowDialog();

            if (x == DialogResult.Yes)
            {
                this.Close();

                frmLogin _frmLogin = new frmLogin();
                _frmLogin.Show();
            }
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyQLNhanVien());

            //
            // To do
            //
            hideSubMenu();
        }

        private void btnQLNhapXuat_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLNhapXuatSubMenu);
        }

        private void btnNhapSp_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyQLNhapSp());

            //
            // To do
            //
            hideSubMenu();
        }

        private void btnXuatSp_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyXuatSp());

            //
            // To do
            //
            hideSubMenu();
        }

        private void btnThongTinCH_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongTinKho());

            //
            // To do
            //
            hideSubMenu();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLSPSubMenu);
        }

        private void btnXemTTSp_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyQLSp());
            //
            // To do
            //
            hideSubMenu();
        }

        private void btnTimKiemSp_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTimKiem());
            //
            // To do
            //
            hideSubMenu();
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThongKeDoanhThuSubMenu);
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            btnXong.Visible = false;
        }

        private void btnXemHoaDonNhapXuat_Click(object sender, EventArgs e)
        {
            openChildForm(new frmXemHoaDonNhapXuat());
            //
            // To do
            //
            hideSubMenu();
        }

        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmXemDoanhThu());
            //
            // To do
            //
            hideSubMenu();
        }
    }
}
