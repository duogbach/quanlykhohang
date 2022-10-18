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
    public partial class frmXemDoanhThu : Form
    {
        private KetNoiDB ketNoiDB = new KetNoiDB();
        private string query;
        frmShowDialogQuestion _frmShowDialogQuestion;

        private Random Rand = new Random();
        private Color[] FontColors =
        {
            Color.Red,
            Color.Green,
            Color.Blue,
            Color.Orange,
            Color.Brown,
            Color.Magenta,
            Color.Purple,
            Color.BurlyWood,
            Color.HotPink,
            Color.White,
            Color.Aqua,
            Color.Bisque,
            Color.Chocolate,
            Color.DarkOrange,
            Color.LimeGreen,
            Color.DodgerBlue,
            Color.Tomato,
            Color.BlueViolet,
            Color.Cornsilk
        };

        public frmXemDoanhThu()
        {
            InitializeComponent();

            query = "SELECT * FROM Bill LEFT JOIN Staff ON Bill.IDStaff = Staff.ID";
            GetData(query);

            LoadChart();
        }

        public void LoadChart()
        {
            query = "SELECT IDProduct, SUM(Amount) AS [TongSoLuongBan], SUM(Price * Amount) AS [Tong] FROM BillInfo INNER JOIN Bill " +
                "ON BillInfo.IDBill = Bill.ID WHERE Bill.Type = 0 GROUP BY IDProduct";
            DataSet ds = ketNoiDB.GetDataSet(query);

            DataColumn MaSP = new DataColumn();
            MaSP.ColumnName = "MaSP";
            ds.Tables[0].Columns.Add(MaSP);

            DataColumn Name = new DataColumn();
            Name.ColumnName = "Name";
            ds.Tables[0].Columns.Add(Name);

            DataColumn TongTien = new DataColumn();
            TongTien.ColumnName = "TongTien";
            ds.Tables[0].Columns.Add(TongTien);


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["MaSP"] = "SP" + ds.Tables[0].Rows[i]["IDProduct"];
                ds.Tables[0].Rows[i]["Name"] = ketNoiDB.GetValue("SELECT NameProduct FROM Product WHERE ID = " + ds.Tables[0].Rows[i]["IDProduct"]);
                ds.Tables[0].Rows[i]["TongTien"] = int.Parse(ds.Tables[0].Rows[i]["Tong"].ToString()).ToString("#,##0");


                BieuDo.Series["BieuDo"].Points.Add(int.Parse(ds.Tables[0].Rows[i]["Tong"].ToString()));
                BieuDo.Series["BieuDo"].Points[i].Label = ds.Tables[0].Rows[i]["MaSP"] + "";
                BieuDo.Series["BieuDo"].Points[i].Color = FontColors[Rand.Next(0, FontColors.Length)];
                BieuDo.Series["BieuDo"].Points[i].LegendText = ds.Tables[0].Rows[i]["Name"] + "";
            }

            dgvDoanhSo.AutoGenerateColumns = false;
            dgvDoanhSo.DataSource = ds.Tables[0];


        }

        public void GetData(string query)
        {
            DataSet ds = ketNoiDB.GetDataSet(query);

            DataColumn MaHD = new DataColumn();
            MaHD.ColumnName = "MaHD";
            ds.Tables[0].Columns.Add(MaHD);

            DataColumn Date = new DataColumn();
            Date.ColumnName = "Date";
            ds.Tables[0].Columns.Add(Date);

            DataColumn Time = new DataColumn();
            Time.ColumnName = "Time";
            ds.Tables[0].Columns.Add(Time);

            DataColumn NhanVienTT = new DataColumn();
            NhanVienTT.ColumnName = "NhanVienTT";
            ds.Tables[0].Columns.Add(NhanVienTT);

            DataColumn LoaiGD = new DataColumn();
            LoaiGD.ColumnName = "LoaiGD";
            ds.Tables[0].Columns.Add(LoaiGD);

            DataColumn TotalPricesView = new DataColumn();
            TotalPricesView.ColumnName = "TotalPricesView";
            ds.Tables[0].Columns.Add(TotalPricesView);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["TotalPricesView"] = int.Parse(ds.Tables[0].Rows[i]["TotalPrices"].ToString()).ToString("#,##0");
                ds.Tables[0].Rows[i]["MaHD"] = "HD" + ds.Tables[0].Rows[i]["ID"];
                ds.Tables[0].Rows[i]["Date"] = Convert.ToDateTime(ds.Tables[0].Rows[i]["DateCheckIn"]).ToString("dd/MM/yyyy");
                ds.Tables[0].Rows[i]["Time"] = Convert.ToDateTime(ds.Tables[0].Rows[i]["DateCheckIn"]).ToString("HH:mm:ss");
                ds.Tables[0].Rows[i]["NhanVienTT"] = ds.Tables[0].Rows[i]["Lastname"].ToString() + " " + ds.Tables[0].Rows[i]["Firstname"].ToString();
                if (ds.Tables[0].Rows[i]["NhanVienTT"].ToString() == " ") ds.Tables[0].Rows[i]["NhanVienTT"] = "Quản lý";
                if(ds.Tables[0].Rows[i]["Type"].ToString() == "1")
                {
                    ds.Tables[0].Rows[i]["LoaiGD"] = "Nhập kho";
                }
                else if (ds.Tables[0].Rows[i]["Type"].ToString() == "2")
                {
                    ds.Tables[0].Rows[i]["LoaiGD"] = "Xuất kho";
                }
                else
                {
                    ds.Tables[0].Rows[i]["LoaiGD"] = "Bán hàng";
                }
            }

            dgvBills.AutoGenerateColumns = false;
            dgvBills.DataSource = ds.Tables[0];

            lblTongSo.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi.";
        }

        private void cboLoaiHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiHoaDon.SelectedIndex == 0 && chbThoiGian.Checked) query = "SELECT * FROM Bill LEFT JOIN Staff ON Bill.IDStaff = Staff.ID";
            else if (cboLoaiHoaDon.SelectedIndex == 0 && chbThoiGian.Checked == false) query = "SELECT * FROM Bill LEFT JOIN Staff ON Bill.IDStaff = Staff.ID";
            else query = "SELECT * FROM Bill LEFT JOIN Staff ON Bill.IDStaff = Staff.ID WHERE Bill.Type = " + (cboLoaiHoaDon.SelectedIndex-1);
            if (chbThoiGian.Checked) query += " AND (DateCheckIn BETWEEN '" + Convert.ToDateTime(dtpThoiGianTu.Value).ToString("MM/dd/yyyy") +
                     "' AND '" + Convert.ToDateTime(dtpThoiGianDen.Value).ToString("MM/dd/yyyy") + "')";
            GetData(query);
        }

        private void chbThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            cboLoaiHoaDon_SelectedIndexChanged(sender, e);
        }

        private void dtpThoiGianTu_ValueChanged(object sender, EventArgs e)
        {
            cboLoaiHoaDon_SelectedIndexChanged(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
