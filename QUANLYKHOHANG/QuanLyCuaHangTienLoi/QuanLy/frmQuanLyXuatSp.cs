using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCuaHangTienLoi
{
    public partial class frmQuanLyXuatSp : Form
    {
        private KetNoiDB ketNoiDB = new KetNoiDB();
        private string query;
        private string State = "Reset";
        frmShowDialogQuestion _frmShowDialogQuestion;
        private DataGridViewRow selectedRow;

        public frmQuanLyXuatSp()
        {
            InitializeComponent();
            SetControls(State);
            reload();
        }

        public void reload()
        {
            lblThanhTien.Text = CalculatorPrice().ToString("0,###");
        }

        public long CalculatorPrice()
        {
            long price = 0;
            for (int i = 0; i < dgvProducts.RowCount - 1; i++)
            {
                DataGridViewRow selected = dgvProducts.Rows[i];
                price += long.Parse(selected.Cells["Price"].Value.ToString().Replace(",","")) * long.Parse(selected.Cells["Amount"].Value.ToString());

            }
            return price;
        }

        public void SetControls(string State)
        {
            switch (State)
            {
                case "Reset":
                    txtTimKiem.Enabled = false;
                    btnTimKiem.Enabled = false;
                    nudSoLuong.Enabled = false;
                    nudGiaXuat.Enabled = false;

                    lblTimThay.Visible = false;
                    lblKhongTimThay.Visible = false;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    btnQuayLai.Enabled = false;
                    btnTimKiem.Enabled = true;

                    txtTimKiem.Text = "";
                    nudSoLuong.Value = 0;
                    nudGiaXuat.Value = 0;

                    dgvProduct.DataSource = null;
                    break;
                case "Insert":
                    txtTimKiem.Enabled = true;
                    btnTimKiem.Enabled = true;
                    nudSoLuong.Enabled = true;
                    nudGiaXuat.Enabled = true;

                    lblTimThay.Visible = false;
                    lblKhongTimThay.Visible = false;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnQuayLai.Enabled = true;
                    btnTimKiem.Enabled = true;

                    txtTimKiem.Text = "";
                    nudSoLuong.Value = 0;
                    nudGiaXuat.Value = 0;

                    dgvProduct.DataSource = null;
                    break;
                case "Update":
                    txtTimKiem.Enabled = true;
                    btnTimKiem.Enabled = false;
                    nudSoLuong.Enabled = true;
                    nudGiaXuat.Enabled = true;

                    lblTimThay.Visible = false;
                    lblKhongTimThay.Visible = false;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnQuayLai.Enabled = true;
                    btnTimKiem.Enabled = false;
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            State = "Insert";
            SetControls(State);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            State = "Update";
            SetControls(State);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int Rowindex = dgvProducts.CurrentCell.RowIndex;
            DataGridViewRow selected = dgvProducts.Rows[Rowindex];

            string tenSp = selected.Cells["NameProduct"].Value.ToString();
            if (tenSp != ""  && Rowindex >= 0 && Rowindex < dgvProducts.Rows.Count - 1)
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Xoá", "Bạn có muốn xóa sản phẩm " + tenSp + " trong danh mục không? ", "Có", "Không");
                var x = _frmShowDialogQuestion.ShowDialog();
                if (x == DialogResult.Yes)
                {
                    int RowIndex = dgvProducts.CurrentCell.RowIndex;
                    dgvProducts.Rows.RemoveAt(RowIndex);
                }
            }
            else
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Xoá", "Bạn chưa chọn sản phẩm muốn xóa!", "Thử lại", "");
                _frmShowDialogQuestion.Show();
            }

            State = "Reset";
            SetControls(State);
            reload();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if(keyword == "")
            {
                lblTimThay.Visible = false;
                lblKhongTimThay.Visible = true;
                dgvProduct.DataSource = null;
                return;
            }
            query = "SELECT * FROM Product INNER JOIN Category ON Product.CategoryID = Category.ID " +
                "WHERE Product.NameProduct like N'%" + keyword + "%'";

            if (ketNoiDB.GetValue(query) != null)
            {
                DataSet ds = ketNoiDB.GetDataSet(query);
                lblTimThay.Visible = true;
                lblKhongTimThay.Visible = false;

                DataColumn LoaiSP = new DataColumn();
                LoaiSP.ColumnName = "LoaiSP";
                ds.Tables[0].Columns.Add(LoaiSP);

                for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ds.Tables[0].Rows[i]["LoaiSP"] = ketNoiDB.GetValue("SELECT NameCate FROM Category WHERE ID = " + ds.Tables[0].Rows[i]["CategoryID"]);
                }
                dgvProduct.AutoGenerateColumns = false;
                dgvProduct.DataSource = ds.Tables[0];
            }
            else
            {
                lblTimThay.Visible = false;
                lblKhongTimThay.Visible = true;
                dgvProduct.DataSource = null;
            }
        }

        private bool checkPrice(int giaNhap, int giaXuat)
        {
            //int giaNhap = int.Parse(dgvProduct.Rows[0].Cells["GiaNhap"].Value.ToString());
            //int giaNhap = int.Parse(dgvProduct.Rows[0].Cells["GiaNhap"].Value.ToString());
            //int giaXuat = int.Parse(nudGiaXuat.Value.ToString());
            if (giaXuat <= giaNhap)
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Giá xuất phải lớn hơn giá nhập! Bạn có chắc chắn xác nhận tiếp tục như vậy không? ", "Có", "Không");
                var x = _frmShowDialogQuestion.ShowDialog();
                if (x == DialogResult.Yes)
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
            return false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (State.Equals("Insert"))
            {
                int soLuong = int.Parse(nudSoLuong.Value.ToString());
                int giaXuat = int.Parse(nudGiaXuat.Value.ToString());

                if (selectedRow != null)
                {
                    DataGridViewRow selected = selectedRow;
                    string MaSP = selected.Cells["MaSP"].Value.ToString();
                    string TenSP = selected.Cells["TenSP"].Value.ToString();
                    string NhaCungCap = selected.Cells["NhaCungCap"].Value.ToString();
                    string LoaiSP = selected.Cells["LoaiSP"].Value.ToString();
                    int SoLuongConLai = int.Parse(selected.Cells["SoLuongConLai"].Value.ToString());
                    string GiaXuat = nudGiaXuat.Value.ToString();
                    string SoLuong = nudSoLuong.Value.ToString();

                    if (lblTimThay.Visible && soLuong > 0 && giaXuat > 0)
                    {
                        if (SoLuongConLai < soLuong)
                        {
                            _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Trong kho chỉ còn " + SoLuongConLai + " số lượng. Vui lòng giảm số lượng và thử lại!", "Thử lại", "");
                            _frmShowDialogQuestion.Show();
                            return;
                        }
                        if (checkPrice(int.Parse(selected.Cells["GiaNhap"].Value.ToString()), int.Parse(GiaXuat)))
                        {
                            dgvProducts.Rows.Add(1);
                            int RowIndex = dgvProducts.Rows.Count - 2;
                            dgvProducts[0, RowIndex].Value = MaSP;
                            dgvProducts[1, RowIndex].Value = TenSP;
                            dgvProducts[2, RowIndex].Value = NhaCungCap;
                            dgvProducts[3, RowIndex].Value = LoaiSP;
                            dgvProducts[4, RowIndex].Value = int.Parse(GiaXuat).ToString();
                            dgvProducts[5, RowIndex].Value = SoLuong;

                            State = "Reset";
                            reload();
                        }
                    }
                    else
                    {
                        _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Yêu cầu nhập đầy đủ thông tin!", "Thử lại", "");
                        _frmShowDialogQuestion.Show();
                    }
                }
                else
                {
                    _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Chọn ít nhất 1 sản phẩm!", "Thử lại", "");
                    _frmShowDialogQuestion.Show();
                }
            }
            if (State.Equals("Update"))
            {
                int soLuong = int.Parse(nudSoLuong.Value.ToString());
                int giaXuat = int.Parse(nudGiaXuat.Value.ToString());

                if (selectedRow != null)
                {
                    DataGridViewRow selected = dgvProduct.Rows[0];
                    int SoLuongConLai = int.Parse(selected.Cells["SoLuongConLai"].Value.ToString());

                    if (soLuong > 0 && giaXuat > 0)
                    {
                        if (SoLuongConLai < soLuong)
                        {
                            _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Trong kho chỉ còn " + SoLuongConLai + " số lượng. Vui lòng giảm số lượng và thử lại!", "Thử lại", "");
                            _frmShowDialogQuestion.Show();
                            return;
                        }
                        if (checkPrice(int.Parse(selected.Cells["GiaNhap"].Value.ToString()), giaXuat))
                        {
                            int RowIndex = dgvProducts.CurrentCell.RowIndex;
                            dgvProducts[4, RowIndex].Value = giaXuat;
                            dgvProducts[5, RowIndex].Value = soLuong;

                            State = "Reset";
                            reload();
                        }
                    }
                    else
                    {
                        _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Yêu cầu nhập đầy đủ thông tin!", "Thử lại", "");
                        _frmShowDialogQuestion.Show();
                    }
                }
                else
                {
                    _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Chọn ít nhất 1 sản phẩm!", "Thử lại", "");
                    _frmShowDialogQuestion.Show();
                }
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;

            if (RowIndex >= 0 && RowIndex < dgvProducts.Rows.Count - 1)
            {
                if (selectedRow != null)
                {
                    DataGridViewRow selected = dgvProducts.Rows[RowIndex];

                    string MaSP = selected.Cells["ID"].Value.ToString();
                    int SoLuong = int.Parse(selected.Cells["Amount"].Value.ToString());
                    int GiaXuat = int.Parse(selected.Cells["Price"].Value.ToString());

                    nudSoLuong.Value = SoLuong;
                    nudGiaXuat.Value = GiaXuat;

                    string id = MaSP.Trim();
                    query = "SELECT * FROM Product " +
                        "WHERE ID = '" + id + "'";

                    DataSet ds = ketNoiDB.GetDataSet(query);
                    lblTimThay.Visible = true;
                    lblKhongTimThay.Visible = false;

                    dgvProduct.AutoGenerateColumns = false;
                    dgvProduct.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            _frmShowDialogQuestion = new frmShowDialogQuestion("Question", "Bạn có chắc chắn xuất các sản phẩm trên" +
                " và lưu vào hóa đơn xuất?", "Có", "Không");
            var x = _frmShowDialogQuestion.ShowDialog();
            if (x != DialogResult.Yes) return;
            else
            {
                if (CalculatorPrice() == 0)
                {
                    _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Không có dữ liệu để xuất", "OK", "Quay lại");
                    _frmShowDialogQuestion.ShowDialog();
                }
                else
                {
                    string time = Convert.ToDateTime(DateTime.Now).ToString("MM/dd/yyyy HH:mm:ss");
                    query = "INSERT INTO Bill(DateCheckIn, TotalPrices, Type) VALUES('" + time + "', " + int.Parse(lblThanhTien.Text.Replace(",", "")) + ", 2)";
                    ketNoiDB.ThucThiCauLenh(query);
                    query = "SELECT ID FROM Bill WHERE DateCheckIn = '" + time + "' AND TotalPrices = " + int.Parse(lblThanhTien.Text.Replace(",", "")) + " AND Type = 2";
                    string idBill = ketNoiDB.GetValue(query);

                    for (int i = 0; i < dgvProducts.RowCount - 1; i++)
                    {
                        DataGridViewRow selected = dgvProducts.Rows[i];
                        string MaSP = selected.Cells["ID"].Value.ToString();
                        int soLuong = int.Parse(selected.Cells["Amount"].Value.ToString());
                        int giaXuat = int.Parse(selected.Cells["Price"].Value.ToString().Replace(",", ""));

                        query = "SELECT RemainAmount FROM Product WHERE ID = " + MaSP;
                        int remainAmount = int.Parse(ketNoiDB.GetValue(query));
                        query = "UPDATE Product SET RemainAmount = " + (remainAmount - soLuong) + " WHERE ID = " + MaSP;
                        ketNoiDB.ThucThiCauLenh(query);

                        query = "INSERT INTO BillInfo(IDBill, IDProduct, Amount, ExportPrice) VALUES(" + idBill + ", " + MaSP + ", " + soLuong + ", " + giaXuat + ")";
                        ketNoiDB.ThucThiCauLenh(query);
                    }

                    _frmShowDialogQuestion = new frmShowDialogQuestion("Thành công", "Xuất sản phẩm thành công! Đã thêm dữ liệu vào hóa đơn xuất" +
                        " và hóa đơn nhập!", "Đồng ý", "");
                    _frmShowDialogQuestion.Show();

                    State = "Reset";
                    SetControls(State);
                    dgvProduct.DataSource = null;
                    dgvProducts.DataSource = new DataSet();
                    reload();
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            State = "Reset";
            SetControls(State);
            reload();
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

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (RowIndex >= 0 && RowIndex < dgvProduct.Rows.Count - 1)
            {
                selectedRow = dgvProduct.Rows[RowIndex];
            }
        }
    }
}
