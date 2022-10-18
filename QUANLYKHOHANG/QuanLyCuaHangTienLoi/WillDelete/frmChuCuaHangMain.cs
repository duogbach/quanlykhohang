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
    public partial class frmChuCuaHangMain : Form
    {
        public frmChuCuaHangMain()
        {
            InitializeComponent();

            hideSubMenu();
        }

        private void hideSubMenu()
        {
            //panelQLTKSubMenu.Visible = false;
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

        private void btnThongTinCH_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongTinKho(true));

            //
            // To do
            //
            hideSubMenu();
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

        private void btnXong_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            btnXong.Visible = false;
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            openChildForm(new frmXemDoanhThu());

            //
            // To do
            //
            hideSubMenu();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThanhToanLuong());

            //
            // To do
            //
            hideSubMenu();
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
