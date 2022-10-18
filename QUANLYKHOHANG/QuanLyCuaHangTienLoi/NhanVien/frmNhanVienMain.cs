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
    public partial class frmNhanVienMain : Form
    {
        private string username, idSalary;
        string query;
        string State = "Reset";
        KetNoiDB ketNoiDB = new KetNoiDB();

        public frmNhanVienMain(string username, string idSalary)
        {
            InitializeComponent();
            hideSubMenu();

            this.username = username;
            this.idSalary = idSalary;

            GetNameStaffs();
        }

        private void GetNameStaffs()
        {
            query = "SELECT Firstname FROM Staff WHERE Username = '" + username + "'";
            string firstname = ketNoiDB.GetValue(query);
            query = "SELECT Lastname FROM Staff WHERE Username = '" + username + "'";
            string lastname = ketNoiDB.GetValue(query);

            lblTenNhanVien.Text = lastname + " " + firstname;
        }


        private void hideSubMenu()
        {
            panelTTSPSubMenu.Visible = false;
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

        private void btnThanhToanSp_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTTSPSubMenu);
        }

        public void SalaryHandle()
        {
            query = "UPDATE Salary SET TimeOut = '" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "'"
                + " WHERE ID = " + idSalary;
            ketNoiDB.ThucThiCauLenh(query);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmShowDialogQuestion _frmShowDialogQuestion = new frmShowDialogQuestion("Đăng xuất", "Bạn có muốn đăng xuất không?", "Có", "Không");
            var x = _frmShowDialogQuestion.ShowDialog();

            if (x == DialogResult.Yes)
            {
                SalaryHandle();

                this.Close();

                frmLogin _frmLogin = new frmLogin();
                _frmLogin.Show();
            }
        }

        private void btnThongTinCH_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongTinKho());

            //
            // To do
            //
            hideSubMenu();
        }

        private void btnXemTTSp_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTimKiem());

            //
            // To do
            //
            hideSubMenu();
        }

        private void btnQLTKNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVienThanhToanSp(username));

            //
            // To do
            //
            hideSubMenu();
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            btnXong.Visible = false;
        }

        private void btnXemHoaDonThanhToan_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVienXemHDTT());

            //
            // To do
            //
            hideSubMenu();
        }
    }
}
