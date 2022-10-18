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
    public partial class frmThanhToanLuong : Form
    {
        KetNoiDB ketNoiDB = new KetNoiDB();
        string query;
        frmShowDialogQuestion _frmShowDialogQuestion;
        string StaffIdSelected = "";

        public frmThanhToanLuong()
        {
            InitializeComponent();

            reload();
        }

        public void GetDataLogin()
        {
            query = "SELECT * FROM Salary LEFT JOIN Staff ON Salary.IDStaff = Staff.ID ORDER BY TimeIn DESC";
            DataSet ds = ketNoiDB.GetDataSet(query);

            DataColumn colMaDangNhap = new DataColumn();
            colMaDangNhap.ColumnName = "MaDangNhap";
            ds.Tables[0].Columns.Add(colMaDangNhap);

            DataColumn colMaNV = new DataColumn();
            colMaNV.ColumnName = "MaNhanVien";
            ds.Tables[0].Columns.Add(colMaNV);

            DataColumn colTenNV = new DataColumn();
            colTenNV.ColumnName = "Name";
            ds.Tables[0].Columns.Add(colTenNV);

            DataColumn colTimeIn = new DataColumn();
            colTimeIn.ColumnName = "TimeInView";
            ds.Tables[0].Columns.Add(colTimeIn);

            DataColumn colTimeOut = new DataColumn();
            colTimeOut.ColumnName = "TimeOutView";
            ds.Tables[0].Columns.Add(colTimeOut);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["MaDangNhap"] = "DN" + ds.Tables[0].Rows[i]["ID"];
                ds.Tables[0].Rows[i]["MaNhanVien"] = ds.Tables[0].Rows[i]["IDStaff"];
                ds.Tables[0].Rows[i]["Name"] = ds.Tables[0].Rows[i]["Lastname"] + " " + ds.Tables[0].Rows[i]["Firstname"].ToString();

                ds.Tables[0].Rows[i]["TimeInView"] = Convert.ToDateTime(ds.Tables[0].Rows[i]["TimeIn"]).ToString("HH:mm:ss dd/MM/yyyy");
                try
                {
                    ds.Tables[0].Rows[i]["TimeOutView"] = Convert.ToDateTime(ds.Tables[0].Rows[i]["TimeOut"]).ToString("HH:mm:ss dd/MM/yyyy");
                }
                catch (Exception ex)
                {

                }
            }

            dgvDangNhap.AutoGenerateColumns = false;
            dgvDangNhap.DataSource = ds.Tables[0];
        }

        public void GetDataSalary()
        {
            query = "select nv.ID, nv.Firstname, nv.Lastname, l.Status, sum(DATEDIFF(MINUTE, TimeIn, TimeOut)) * 700 as 'Salary' " +
                "from Salary l, Staff nv " +
                "where l.IDStaff = nv.ID " +
                "group by nv.ID, nv.Username, nv.Firstname, nv.Lastname, l.Status";
            DataSet ds = ketNoiDB.GetDataSet(query);

            DataColumn colTenNV = new DataColumn();
            colTenNV.ColumnName = "TenNV";
            ds.Tables[0].Columns.Add(colTenNV);

            DataColumn colTrangThai = new DataColumn();
            colTrangThai.ColumnName = "TrangThai";
            ds.Tables[0].Columns.Add(colTrangThai);

            DataColumn colLuong = new DataColumn();
            colLuong.ColumnName = "Luong";
            ds.Tables[0].Columns.Add(colLuong);

            DataColumn colTotalTime = new DataColumn();
            colTotalTime.ColumnName = "TotalTime";
            ds.Tables[0].Columns.Add(colTotalTime);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string idStaff = ds.Tables[0].Rows[i]["ID"].ToString();
                ds.Tables[0].Rows[i]["TenNV"] = ds.Tables[0].Rows[i]["Lastname"] + " " + ds.Tables[0].Rows[i]["Firstname"].ToString();
                ds.Tables[0].Rows[i]["Luong"] = ds.Tables[0].Rows[i]["Salary"].ToString() + " VND";
                ds.Tables[0].Rows[i]["TrangThai"] = ds.Tables[0].Rows[i]["Status"].ToString() == "0" ? "Chưa thanh toán" : "Đã thanh toán";
                if (cboLocTheo.SelectedIndex == 0)
                {
                    query = "SELECT convert(varchar(8), dateadd(second, SUM(DATEDIFF(SECOND, TimeIn, TimeOut)), 0),  108) FROM Salary WHERE IDStaff = " + idStaff;
                }
                else if (cboLocTheo.SelectedIndex == 1)
                {
                    query = "SELECT convert(varchar(8), dateadd(second, SUM(DATEDIFF(SECOND, TimeIn, TimeOut)), 0),  108) FROM Salary WHERE IDStaff = " + idStaff + " AND Status = 0";
                }
                else if (cboLocTheo.SelectedIndex == 2)
                {
                    query = "SELECT convert(varchar(8), dateadd(second, SUM(DATEDIFF(SECOND, TimeIn, TimeOut)), 0),  108) FROM Salary WHERE IDStaff = " + idStaff + " AND Status = 1";
                }
                else
                {
                    string timeFrom = Convert.ToDateTime(dtpThoiGianTu.Value).ToString("MM/dd/yyyy HH:mm:ss");
                    string timeTo = Convert.ToDateTime(dtpThoiGianDen.Value).ToString("MM/dd/yyyy HH:mm:ss");
                    query = "SELECT convert(varchar(8), dateadd(second, SUM(DATEDIFF(SECOND, TimeIn, TimeOut)), 0),  108) FROM Salary WHERE IDStaff = " + idStaff + " AND TimeIn BETWEEN '" 
                        + timeFrom + "' AND '" + timeTo + "'";
                }
                string totalTime = ketNoiDB.GetValue(query);
                if (totalTime == "") totalTime = "00:00:00";
                ds.Tables[0].Rows[i]["TotalTime"] = totalTime.ToString();
            }

            dgvChiTiet.AutoGenerateColumns = false;
            dgvChiTiet.DataSource = ds.Tables[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboLocTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataSalary();
            if(cboLocTheo.SelectedIndex == 3)
            {
                dtpThoiGianDen.Enabled = true;
                dtpThoiGianTu.Enabled = true;
            }
            else
            {
                dtpThoiGianDen.Enabled = false;
                dtpThoiGianTu.Enabled = false;
            }
        }

        private void dtpThoiGianDen_ValueChanged(object sender, EventArgs e)
        {
            GetDataSalary();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            if (StaffIdSelected != null)
            {
                query = "UPDATE Salary SET Status = 1 WHERE IDStaff = '" + StaffIdSelected + "'";

                _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Xác nhận đã trả lương cho nhân viên này?", "OK", "Hủy");
                var dr = _frmShowDialogQuestion.ShowDialog();
                if (dr == DialogResult.Yes)
                    {
                        if (ketNoiDB.ThucThiCauLenh(query))
                        {
                            reload();
                        }
                    }
                }
            else
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Bạn cần chọn ít nhất một nhân viên!", "OK", null);
                _frmShowDialogQuestion.ShowDialog();
            }
        }

        public void reload()
        {
            GetDataLogin();

            dtpThoiGianDen.Enabled = false;
            dtpThoiGianTu.Enabled = false;
            cboLocTheo.SelectedIndex = 0;
            GetDataSalary();
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvChiTiet.Rows[e.RowIndex];
            StaffIdSelected = Convert.ToString(row.Cells["ID"].Value);
        }
    }
}
