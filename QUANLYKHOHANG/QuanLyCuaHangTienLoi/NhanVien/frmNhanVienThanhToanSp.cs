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
    public partial class frmNhanVienThanhToanSp : Form
    {
        private KetNoiDB ketNoiDB = new KetNoiDB();
        private string query;
        private string State = "Reset";
        frmShowDialogQuestion _frmShowDialogQuestion;

        string idStaff;

        public frmNhanVienThanhToanSp(string username)
        {
            InitializeComponent();

            query = "SELECT ID FROM Staff WHERE Username = '" + username + "'";
            idStaff = ketNoiDB.GetValue(query);

            cboLoaiSp.DropDownHeight = 106;
            cboTenSp.DropDownHeight = 106;
            loadCboLoaiSP();

            query = "Select * from Product";
            loadTenSP(query);
        }

        public void ResetData()
        {
            cboLoaiSp.SelectedIndex = 0;
            cboTenSp.SelectedIndex = 0;
            nudSoLuong.Value = 0;
            nudGia.Value = 0;
            lblTongTien.Text = "...";
        }

        public void loadCboLoaiSP()
        {

            query = "Select NameCate from Category";
            DataSet ds = ketNoiDB.GetDataSet(query);
            DataRow dr = ds.Tables[0].NewRow();
            dr["NameCate"] = "Tất cả";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboLoaiSp.DataSource = ds.Tables[0];
            cboLoaiSp.DisplayMember = "name";
            cboLoaiSp.ValueMember = "NameCate";
            cboLoaiSp.SelectedIndex = 0;
        }

        public void loadTenSP(string query)
        {
            DataSet ds = ketNoiDB.GetDataSet(query);
            cboTenSp.DataSource = ds.Tables[0];
            cboTenSp.DisplayMember = "name";
            cboTenSp.ValueMember = "NameProduct";
            cboTenSp.SelectedIndex = 0;
        }
        private void cboLoaiSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoaiSp.SelectedIndex == 0)
            {
                query = "SELECT * FROM Product";
            }
            else
            {
                int type = int.Parse(ketNoiDB.GetValue("SELECT ID FROM Category WHERE NameCate = N'" + cboLoaiSp.Text + "'"));
                query = "Select * from Product where CategoryID=" + type;
            }
            loadTenSP(query);
        }

        bool check = true;
        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (!check) return;
            query = "SELECT RemainAmount FROM Product WHERE NameProduct = N'" + cboTenSp.Text + "'";
            int amount = int.Parse(ketNoiDB.GetValue(query));
            if(nudSoLuong.Value > 0 && nudSoLuong.Value <= amount)
            {
                query = "SELECT Price FROM Product WHERE NameProduct = N'" + cboTenSp.Text + "'";
                int giaBan = int.Parse(ketNoiDB.GetValue(query));
                nudGia.Value = giaBan;

                lblTongTien.Text = (nudSoLuong.Value * giaBan).ToString("#,##0");
                btnThem.Enabled = true;
            }
            else if(nudSoLuong.Value <= 0)
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Yêu cầu nhập số lượng!", "Thử lại", "");
                _frmShowDialogQuestion.Show();
                btnThem.Enabled = false;
            }
            else
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Số lượng nhập vào vượt quá số lượng trong cửa hàng! (còn lại " + amount + ")", "Thử lại", "");
                _frmShowDialogQuestion.Show();
                btnThem.Enabled = false;
            }
        }

        private void cboTenSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            check = false;
            nudSoLuong.Value = 0;
            nudGia.Value = 0;
            lblTongTien.Text = "...";
            btnThem.Enabled = false;
            check = true;

            // Them gia
            try
            {
                query = "SELECT Price FROM Product WHERE NameProduct = N'" + cboTenSp.Text + "'";
                int giaBan = int.Parse(ketNoiDB.GetValue(query));
                nudGia.Value = giaBan;
            }
            catch(Exception ex)
            {

            }
        }

        public void CalculatorPrice()
        {
            long price = 0;
            for (int i = 0; i < dgvProducts.RowCount - 1; i++)
            {
                DataGridViewRow selected = dgvProducts.Rows[i];
                price += long.Parse(selected.Cells["GiaBan"].Value.ToString().Replace(",", "")) * long.Parse(selected.Cells["SoLuong"].Value.ToString());

            }
            lblThanhTien.Text = price.ToString("#,##0");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string[] id = txtTimKiem.Text.Trim().Split('P');
            if (id.Length < 2)
            {
                lblTimThay.Visible = false;
                lblKhongTimThay.Visible = true;
                return;
            }
            if (id[1] == "")
            {
                lblTimThay.Visible = false;
                lblKhongTimThay.Visible = true;
                return;
            }
            query = "SELECT * FROM Product INNER JOIN Category ON Product.CategoryID = Category.ID WHERE Product.ID = " + id[1];

            if (ketNoiDB.GetValue(query) != null)
            {
                DataSet ds = ketNoiDB.GetDataSet(query);
                lblTimThay.Visible = true;
                lblKhongTimThay.Visible = false;

                cboLoaiSp.Text = ds.Tables[0].Rows[0]["NameCate"].ToString();
                cboTenSp.Text = ds.Tables[0].Rows[0]["NameProduct"].ToString();
                nudGia.Value = int.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
            }
            else
            {
                lblTimThay.Visible = false;
                lblKhongTimThay.Visible = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = false;
            DataGridViewRow selected = dgvProducts.Rows[0];
            string TenSP = cboTenSp.Text;
            int type = int.Parse(ketNoiDB.GetValue("SELECT CategoryID FROM Product WHERE NameProduct = N'" + cboTenSp.Text + "'"));
            string LoaiSP = ketNoiDB.GetValue("SELECT NameCate FROM Category WHERE ID = " + type);
            int GiaBan = int.Parse(nudGia.Value.ToString());
            int SoLuong = int.Parse(nudSoLuong.Value.ToString());

            dgvProducts.Rows.Add(1);
            int RowIndex = dgvProducts.Rows.Count - 2;

            dgvProducts[0, RowIndex].Value = TenSP;
            dgvProducts[1, RowIndex].Value = LoaiSP;
            dgvProducts[2, RowIndex].Value = GiaBan.ToString("#,##0");
            dgvProducts[3, RowIndex].Value = SoLuong;

            _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Thêm thành công!", "Tiếp tục", "");
            _frmShowDialogQuestion.Show();
            CalculatorPrice();
            ResetData();
            check = true;
        }

        private void dgvProducts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvProducts.Rows.Count <= 1)
            {
                btnXoa.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
            }
        }

        private void dgvProducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvProducts.Rows.Count <= 1)
            {
                btnXoa.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int Rowindex = dgvProducts.CurrentCell.RowIndex;
            DataGridViewRow selected = dgvProducts.Rows[Rowindex];

            string tenSp = selected.Cells["TenSp"].Value.ToString();
            if (tenSp != "" && Rowindex >= 0 && Rowindex < dgvProducts.Rows.Count - 1)
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Xoá", "Bạn có muốn xóa sản phẩm " + tenSp + " trong danh mục không? ", "Có", "Không");
                var x = _frmShowDialogQuestion.ShowDialog();
                if (x == DialogResult.Yes)
                {
                    int RowIndex = dgvProducts.CurrentCell.RowIndex;
                    dgvProducts.Rows.RemoveAt(RowIndex);
                    ResetData();
                }
            }
            else
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Xoá", "Bạn chưa chọn sản phẩm muốn xóa!", "Thử lại", "");
                _frmShowDialogQuestion.Show();
            }

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvProducts.Rows.Count <= 1)
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Danh mục hóa đơn trống!", "Thử lại", "");
                _frmShowDialogQuestion.Show();
            }
            else
            {
                if(txtTen.Text.Trim().Equals("") && txtSdt.Text.Trim().Equals(""))
                {
                    _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Vui lòng nhập tên và số điện thoại của khách hàng!", "Thử lại", "");
                    _frmShowDialogQuestion.Show();
                }
                else
                {
                    _frmShowDialogQuestion = new frmShowDialogQuestion("Question", "Bạn có chắc chắn thanh toán các sản phẩm trên " +
                        "và lưu vào hóa đơn mua hàng?", "Có", "Không");
                    var x = _frmShowDialogQuestion.ShowDialog();
                    if (x != DialogResult.Yes) return;

                    query = "INSERT INTO Customer VALUES(N'" + txtTen.Text.Trim() + "', '" + txtSdt.Text.Trim() + "', N'" + txtThongTinThem.Text.Trim() + "')";
                    ketNoiDB.ThucThiCauLenh(query);

                    int idCus = int.Parse(ketNoiDB.GetValue("SELECT TOP 1 ID FROM Customer ORDER BY ID DESC"));

                    string time = Convert.ToDateTime(DateTime.Now).ToString("MM/dd/yyyy HH:mm:ss");
                    query = "INSERT INTO Bill(IDStaff, DateCheckIn, TotalPrices, Type, IDCustomer) VALUES(" + idStaff + ", '" + time + "', " + int.Parse(lblThanhTien.Text.Replace(",", "")) + ", 0, " + idCus + ")";
                    ketNoiDB.ThucThiCauLenh(query);
                    query = "SELECT ID FROM Bill WHERE DateCheckIn = '" + time + "' AND TotalPrices = " + int.Parse(lblThanhTien.Text.Replace(",", "")) + " AND Type = 0";
                    string idBill = ketNoiDB.GetValue(query);

                    for (int i = 0; i < dgvProducts.RowCount - 1; i++)
                    {
                        DataGridViewRow selected = dgvProducts.Rows[i];
                        string TenSp = selected.Cells["TenSp"].Value.ToString();
                        int id = int.Parse(ketNoiDB.GetValue("SELECT ID FROM Product WHERE NameProduct = N'" + TenSp + "'"));
                        int soLuong = int.Parse(selected.Cells["SoLuong"].Value.ToString());
                        int gia = int.Parse(selected.Cells["GiaBan"].Value.ToString().Replace(",", ""));

                        query = "SELECT RemainAmount FROM Product WHERE ID = " + id;
                        int remainAmount = int.Parse(ketNoiDB.GetValue(query));
                        query = "UPDATE Product SET RemainAmount = " + (remainAmount - soLuong) + " WHERE ID = " + id;
                        ketNoiDB.ThucThiCauLenh(query);

                        query = "INSERT INTO BillInfo(IDBill, IDProduct, Amount, Price) VALUES(" + idBill + ", " + id + ", " + soLuong + ", " + gia + ")";
                        ketNoiDB.ThucThiCauLenh(query);
                    }

                    QuanLyCuaHangTienLoi.ExcelUtlity obj = new QuanLyCuaHangTienLoi.ExcelUtlity();
                    obj.WriteDataTableToExcel(dgvProducts, "Person Details", "C:\\Excel\\test.xlsx", "Details", int.Parse(idBill), txtTen.Text, txtSdt.Text, lblThanhTien.Text);

                    _frmShowDialogQuestion = new frmShowDialogQuestion("Thành công", "Thanh toán sản phẩm thành công! Đã thêm dữ liệu vào hóa đơn thanh toán!", "Đồng ý", "");
                    _frmShowDialogQuestion.Show();

                    dgvProducts.DataSource = new DataSet();
                    ResetData();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = new DataTable();
            ResetData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
