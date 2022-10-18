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
    public partial class frmThongTinKho : Form
    {
        KetNoiDB ketNoiDB = new KetNoiDB();
        string query;

        public frmThongTinKho()
        {
            InitializeComponent();

            GetStoreInfo();
        }

        public frmThongTinKho(bool isVisible)
        {
            InitializeComponent();

            setUI();
            GetStoreInfo();
            btnSuaTT.Visible = isVisible;
        }


        public void setUI()
        {
            lblTenCH.ReadOnly = true;
            lblDiaChi.ReadOnly = true;
            lblSdt.ReadOnly = true;
            lblTenCCH.ReadOnly = true;
            txtTitle.ReadOnly = true;

            lblTenCH.BackColor = Color.FromArgb(64, 72, 104);
            lblDiaChi.BackColor = Color.FromArgb(64, 72, 104);
            lblSdt.BackColor = Color.FromArgb(64, 72, 104);
            lblTenCCH.BackColor = Color.FromArgb(64, 72, 104);
            txtTitle.BackColor = Color.FromArgb(64, 72, 104);
        }

        public void GetStoreInfo()
        {
            query = "SELECT * FROM StoreInfo";
            DataSet ds = ketNoiDB.GetDataSet(query);

            lblTenCH.Text = ds.Tables[0].Rows[0]["StoreName"].ToString();
            lblDiaChi.Text = ds.Tables[0].Rows[0]["Address"].ToString();
            lblSdt.Text = ds.Tables[0].Rows[0]["Phone"].ToString();
            txtTitle.Text = ds.Tables[0].Rows[0]["Title"].ToString();
            lblTenCCH.Text = ds.Tables[0].Rows[0]["OwnerStoreName"].ToString();

            query = "SELECT COUNT(Username) FROM Account WHERE Type = 3";
            lblTongNV.Text = ketNoiDB.GetValue(query);
            query = "SELECT COUNT(Username) FROM Account WHERE Type = 2";
            lblTongQL.Text = ketNoiDB.GetValue(query);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            lblTenCH.ReadOnly = false;
            lblDiaChi.ReadOnly = false;
            lblSdt.ReadOnly = false;
            lblTenCCH.ReadOnly = false;
            txtTitle.ReadOnly = false;

            lblTenCH.BackColor = Color.FromArgb(242, 17, 112);
            lblDiaChi.BackColor = Color.FromArgb(242, 17, 112);
            lblSdt.BackColor = Color.FromArgb(242, 17, 112);
            lblTenCCH.BackColor = Color.FromArgb(242, 17, 112);
            txtTitle.BackColor = Color.FromArgb(242, 17, 112);

            btnSuaTT.Visible = false;
            btnXacNhan.Visible = true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            setUI();

            btnXacNhan.Visible = false;
            btnSuaTT.Visible = true;

            query = "UPDATE StoreInfo SET StoreName=N'" + lblTenCH.Text.Trim() + "', Address=N'" + lblDiaChi.Text.Trim() +
                "', Phone='" + lblSdt.Text.Trim() + "', Title=N'" + txtTitle.Text.Trim() + "', OwnerStoreName=N'" + lblTenCCH.Text.Trim() + "'";

            if (ketNoiDB.ThucThiCauLenh(query))
            {
                frmShowDialogQuestion _frmShowDialogQuestion = new frmShowDialogQuestion("Thành công", "Cập nhật thông tin cửa hàng thành công!", "Đồng ý", "");
                _frmShowDialogQuestion.Show();
            }
            else
            {
                frmShowDialogQuestion _frmShowDialogQuestion = new frmShowDialogQuestion("Thất bại", "Có lỗi sảy ra. Vui lòng thử lại!", "Thử lại", "");
                _frmShowDialogQuestion.Show();
            }
        }
    }
}
