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
    public partial class frmXemHoaDonNhapXuat : Form
    {
        private KetNoiDB ketNoiDB = new KetNoiDB();
        private string query;

        public frmXemHoaDonNhapXuat()
        {
            InitializeComponent();

            query = "SELECT * FROM Bill WHERE Type = 1 OR Type = 2";
            GetData(query);
        }

        public void GetData(string query)
        {
            DataSet ds = ketNoiDB.GetDataSet(query);

            DataColumn MaHD = new DataColumn();
            MaHD.ColumnName = "MaHD";
            ds.Tables[0].Columns.Add(MaHD);

            DataColumn LoaiGD = new DataColumn();
            LoaiGD.ColumnName = "LoaiGD";
            ds.Tables[0].Columns.Add(LoaiGD);

            DataColumn Date = new DataColumn();
            Date.ColumnName = "Date";
            ds.Tables[0].Columns.Add(Date);

            DataColumn Time = new DataColumn();
            Time.ColumnName = "Time";
            ds.Tables[0].Columns.Add(Time);

            DataColumn TotalPricesView = new DataColumn();
            TotalPricesView.ColumnName = "TotalPricesView";
            ds.Tables[0].Columns.Add(TotalPricesView);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["TotalPricesView"] = int.Parse(ds.Tables[0].Rows[i]["TotalPrices"].ToString()).ToString("#,##0");
                ds.Tables[0].Rows[i]["MaHD"] = "HD" + ds.Tables[0].Rows[i]["ID"];
                ds.Tables[0].Rows[i]["Date"] = Convert.ToDateTime(ds.Tables[0].Rows[i]["DateCheckIn"]).ToString("dd/MM/yyyy");
                ds.Tables[0].Rows[i]["Time"] = Convert.ToDateTime(ds.Tables[0].Rows[i]["DateCheckIn"]).ToString("HH:mm:ss");

                if (ds.Tables[0].Rows[i]["Type"].ToString().Equals("1"))
                {
                    ds.Tables[0].Rows[i]["LoaiGD"] = "Nhập";
                }
                else
                {
                    ds.Tables[0].Rows[i]["LoaiGD"] = "Xuất";
                }
            }

            dgvBills.AutoGenerateColumns = false;
            dgvBills.DataSource = ds.Tables[0];

            lblTongSo.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi.";
        }

        private void cboLoaiHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiHoaDon.SelectedIndex == 0) query = "SELECT * FROM Bill WHERE (Type = 1 OR Type = 2)";
            else query = "SELECT * FROM Bill WHERE Type = " + cboLoaiHoaDon.SelectedIndex;
            if (chbThoiGian.Checked) query += " AND (DateCheckIn BETWEEN '" + Convert.ToDateTime(dtpThoiGianTu.Value).ToString("MM/dd/yyyy") +
                     "' AND '" + Convert.ToDateTime(dtpThoiGianDen.Value).ToString("MM/dd/yyyy") + "')";
            GetData(query);
        }

        private void dtpThoiGianTu_ValueChanged(object sender, EventArgs e)
        {
            cboLoaiHoaDon_SelectedIndexChanged(sender, e);
        }

        private void chbThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            cboLoaiHoaDon_SelectedIndexChanged(sender, e);
        }

        private void dtpThoiGianDen_ValueChanged(object sender, EventArgs e)
        {
            cboLoaiHoaDon_SelectedIndexChanged(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;

            if (RowIndex >= 0 && RowIndex < dgvBills.Rows.Count - 1)
            {
                string MaHD = dgvBills.Rows[RowIndex].Cells["MaHD"].Value.ToString();
                string LoaiGD = dgvBills.Rows[RowIndex].Cells["LoaiGD"].Value.ToString();
                lblMaHD.Text = MaHD;
                lblLoaiGD.Text = LoaiGD;

                string[] id = MaHD.Split('D');
                query = "SELECT * FROM BillInfo INNER JOIN Product ON BillInfo.IDProduct = Product.ID WHERE BillInfo.IDBill = " + id[1];

                DataSet ds = ketNoiDB.GetDataSet(query);

                DataColumn MaSP = new DataColumn();
                MaSP.ColumnName = "MaSP";
                ds.Tables[0].Columns.Add(MaSP);

                DataColumn ImportPriceView = new DataColumn();
                ImportPriceView.ColumnName = "ImportPriceView";
                ds.Tables[0].Columns.Add(ImportPriceView);

                DataColumn ExportPriceView = new DataColumn();
                ExportPriceView.ColumnName = "ExportPriceView";
                ds.Tables[0].Columns.Add(ExportPriceView);

                DataColumn NameCate = new DataColumn();
                NameCate.ColumnName = "NameCate";
                ds.Tables[0].Columns.Add(NameCate);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ds.Tables[0].Rows[i]["ImportPriceView"] = int.Parse(ds.Tables[0].Rows[i]["ImportPrice"].ToString()).ToString("#,##0");
                    try
                    {
                        ds.Tables[0].Rows[i]["ExportPriceView"] = int.Parse(ds.Tables[0].Rows[i]["ExportPrice"].ToString()).ToString("#,##0");
                    }
                    catch(Exception ex)
                    {

                    }
                    ds.Tables[0].Rows[i]["MaSP"] = "SP" + ds.Tables[0].Rows[i]["IDProduct"];

                    ds.Tables[0].Rows[i]["NameCate"] = ketNoiDB.GetValue("SELECT NameCate FROM Category WHERE ID = " + ds.Tables[0].Rows[i]["CategoryID"]);
                }

                dgvBillInfo.AutoGenerateColumns = false;
                dgvBillInfo.DataSource = ds.Tables[0];
            }
            
        }
    }
}
