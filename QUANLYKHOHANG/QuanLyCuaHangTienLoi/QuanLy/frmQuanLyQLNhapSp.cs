using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCuaHangTienLoi
{
    public partial class frmQuanLyQLNhapSp : Form
    {
        private KetNoiDB ketNoiDB = new KetNoiDB();
        private string query;
        private string State = "Reset";
        frmShowDialogQuestion _frmShowDialogQuestion;

        public frmQuanLyQLNhapSp()
        {
            InitializeComponent();

            SetControls(State);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadCboLoaiSP()
        {
            query = "Select NameCate from Category";
            DataSet ds = ketNoiDB.GetDataSet(query);
            DataRow dr = ds.Tables[0].NewRow();
            dr["NameCate"] = "Khác";
            ds.Tables[0].Rows.Add(dr);
            cboLoaiSp.DataSource = ds.Tables[0];
            cboLoaiSp.DisplayMember = "name";
            cboLoaiSp.ValueMember = "NameCate";
            cboLoaiSp.SelectedIndex = 0;
        }

        private void cboLoaiSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoaiSp.Text.Equals("Khác"))
            {
                txtLoaiSp.Enabled = true;
                txtLoaiSp.Text = "";
            }
            else
            {
                txtLoaiSp.Enabled = false;
                txtLoaiSp.Text = "";
            }
        }

        public void SetControls(string State)
        {
            switch (State)
            {
                case "Reset":
                    loadCboLoaiSP();

                    txtTenSp.Enabled = false;
                    txtNhaCungCap.Enabled = false;
                    nudSoLuong.Enabled = false;
                    nudGiaNhap.Enabled = false;
                    nudGiaBan.Enabled = false;
                    cboLoaiSp.Enabled = false;
                    cboLoaiSp.SelectedIndex = -1;
                    cboLoaiSp.Text = "Loại sản phẩm ?";

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    btnQuayLai.Enabled = false;

                    txtTenSp.Text = "";
                    txtNhaCungCap.Text = "";
                    nudSoLuong.Value = 0;
                    nudGiaBan.Value = 0;
                    nudGiaNhap.Value = 0;

                    CalculatorPrice();
                    break;

                case "Insert":
                    txtTenSp.Enabled = true;
                    txtNhaCungCap.Enabled = true;
                    nudSoLuong.Enabled = true;
                    nudGiaNhap.Enabled = true;
                    nudGiaBan.Enabled = true;
                    cboLoaiSp.Enabled = true;
                    cboLoaiSp.SelectedIndex = -1;
                    cboLoaiSp.Text = "Loại sản phẩm ?";

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnQuayLai.Enabled = true;

                    txtTenSp.Text = "";
                    txtNhaCungCap.Text = "";
                    nudSoLuong.Value = 0;
                    nudGiaBan.Value = 0;
                    nudGiaNhap.Value = 0;
                    break;

                case "Update":
                    txtTenSp.Enabled = true;
                    txtNhaCungCap.Enabled = true;
                    nudSoLuong.Enabled = true;
                    nudGiaNhap.Enabled = true;
                    nudGiaBan.Enabled = true;
                    cboLoaiSp.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnQuayLai.Enabled = true;
                    break;
            }
        }

        public void CalculatorPrice()
        {
            long price = 0;
            for(int i = 0; i < dgvProduct.RowCount - 1; i++)
            {
                DataGridViewRow selected = dgvProduct.Rows[i];
                price += long.Parse(selected.Cells["ImportPrice"].Value.ToString().Replace(",", "")) * long.Parse(selected.Cells["Amount"].Value.ToString());
                
            }
            lblThanhTien.Text = price.ToString("#,##0");
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            State = "Reset";
            SetControls(State);
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
            if (txtTenSp.Text != "")
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Xoá", "Bạn có muốn xóa sản phẩm " + txtTenSp.Text.Trim() + " trong danh mục không? ", "Có", "Không");
                var x = _frmShowDialogQuestion.ShowDialog();
                if (x == DialogResult.Yes)
                {
                    int RowIndex = dgvProduct.CurrentCell.RowIndex;
                    dgvProduct.Rows.RemoveAt(RowIndex);
                }
            }
            else
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Xoá", "Bạn chưa chọn sản phẩm muốn xóa!", "Thử lại", "");
                _frmShowDialogQuestion.Show();
            }

            State = "Reset";
            SetControls(State);
        }

        private bool checkPrice()
        {
            if (nudGiaBan.Value <= nudGiaNhap.Value)
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Giá bán phải lớn hơn giá nhập! Bạn có chắc chắn xác nhận tiếp tục như vậy không? ", "Có", "Không");
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
                if (txtTenSp.Text.Equals("") || txtNhaCungCap.Equals("") || nudGiaNhap.Value <= 0 || nudGiaBan.Value <= 0 || nudSoLuong.Value <= 0 || cboLoaiSp.SelectedIndex < 0)
                {
                    _frmShowDialogQuestion = new frmShowDialogQuestion("Lỗi", "Yêu cầu nhập đầy đủ thông tin và giá trị chính xác", "Thử lại", "");
                    _frmShowDialogQuestion.Show();
                }
                else
                {
                    if (checkPrice())
                    {
                        dgvProduct.Rows.Add(1);
                        int RowIndex = dgvProduct.Rows.Count - 2;
                        dgvProduct[0, RowIndex].Value = txtTenSp.Text.Trim();
                        dgvProduct[1, RowIndex].Value = txtNhaCungCap.Text.Trim();
                        if(cboLoaiSp.Text.Equals("Khác"))
                            dgvProduct[2, RowIndex].Value = txtLoaiSp.Text;
                        else
                            dgvProduct[2, RowIndex].Value = cboLoaiSp.Text;
                        dgvProduct[3, RowIndex].Value = nudGiaNhap.Value.ToString();
                        dgvProduct[4, RowIndex].Value = nudGiaBan.Value.ToString();
                        dgvProduct[5, RowIndex].Value = nudSoLuong.Value;

                        State = "Reset";
                        SetControls(State);
                    }
                    
                }
            }
            if (State.Equals("Update"))
            {
                if (txtTenSp.Text.Equals("") || txtNhaCungCap.Equals("") || nudGiaNhap.Value <= 0 || nudGiaBan.Value <= 0 || nudSoLuong.Value <= 0 || cboLoaiSp.SelectedIndex < 0)
                {
                    _frmShowDialogQuestion = new frmShowDialogQuestion("Lỗi", "Yêu cầu nhập đầy đủ thông tin và giá trị chính xác", "Thử lại", "");
                    _frmShowDialogQuestion.Show();
                }
                else
                {
                    if (checkPrice())
                    {
                        int RowIndex = dgvProduct.CurrentCell.RowIndex;
                        dgvProduct[0, RowIndex].Value = txtTenSp.Text.Trim();
                        dgvProduct[1, RowIndex].Value = txtNhaCungCap.Text.Trim();
                        dgvProduct[2, RowIndex].Value = cboLoaiSp.Text;
                        dgvProduct[3, RowIndex].Value = nudGiaNhap.Value;
                        dgvProduct[4, RowIndex].Value = nudGiaBan.Value;
                        dgvProduct[5, RowIndex].Value = nudSoLuong.Value;

                        State = "Reset";
                        SetControls(State);
                    }

                }
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;

            if (State.Equals("Reset") && RowIndex >= 0 && RowIndex < dgvProduct.Rows.Count - 1)
            {
                DataGridViewRow selected = dgvProduct.Rows[RowIndex];

                txtTenSp.Text = selected.Cells["NameProduct"].Value.ToString();
                txtNhaCungCap.Text = selected.Cells["Supplier"].Value.ToString();
                for (int i = 0; i < cboLoaiSp.Items.Count; i++)
                {
                    string value = cboLoaiSp.GetItemText(cboLoaiSp.Items[i]);
                    if (selected.Cells["ProductType"].Value.ToString().Equals(value))
                    {
                        cboLoaiSp.SelectedIndex = i;
                        break;
                    }
                }
                nudSoLuong.Value = int.Parse(selected.Cells["Amount"].Value.ToString());
                nudGiaNhap.Value = int.Parse(selected.Cells["ImportPrice"].Value.ToString());
                nudGiaBan.Value = int.Parse(selected.Cells["Price"].Value.ToString());
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            _frmShowDialogQuestion = new frmShowDialogQuestion("Question", "Bạn có chắc chắn nhập các sản phẩm trên?" +
                " và hóa đơn nhập!", "Có", "Không");
            var x = _frmShowDialogQuestion.ShowDialog();
            if (x != DialogResult.Yes) return; 

            string time = Convert.ToDateTime(DateTime.Now).ToString("MM/dd/yyyy HH:mm:ss ");
            query = "INSERT INTO Bill(DateCheckIn, TotalPrices, Type) VALUES('" + time + "', " + int.Parse(lblThanhTien.Text.Replace(",","")) + ", 1)";
            ketNoiDB.ThucThiCauLenh(query);
            query = "SELECT ID FROM Bill WHERE DateCheckIn = '" + time + "' AND TotalPrices = " + int.Parse(lblThanhTien.Text.Replace(",", "")) + " AND Type = 1";
            string idBill = ketNoiDB.GetValue(query);

            for (int i = 0; i < dgvProduct.RowCount - 1; i++)
            {
                DataGridViewRow selected = dgvProduct.Rows[i];
                string tenSp = selected.Cells["NameProduct"].Value.ToString();
                string nhaCungCap = selected.Cells["Supplier"].Value.ToString();
                string loaiSp = selected.Cells["ProductType"].Value.ToString();
                int soLuong = int.Parse(selected.Cells["Amount"].Value.ToString());
                int giaNhap = int.Parse(selected.Cells["ImportPrice"].Value.ToString());
                int giaBan = int.Parse(selected.Cells["Price"].Value.ToString());

                int type = 0;
                string val = ketNoiDB.GetValue("SELECT ID FROM Category WHERE NameCate = N'" + loaiSp + "'");
                if(val != null)
                {
                    type = int.Parse(val);
                }

                if(type == 0)
                {
                    query = "INSERT INTO Category VALUES (N'" + loaiSp + "')";
                    ketNoiDB.ThucThiCauLenh(query);

                    query = "SELECT ID FROM Category WHERE NameCate = N'" + loaiSp + "'";
                    try
                    {
                        val = ketNoiDB.GetValue(query);
                        type = int.Parse(val);
                    }
                    catch(Exception ex)
                    {

                    }
                }

                query = "SELECT * FROM Product WHERE NameProduct = N'" + tenSp + "'";
                if (ketNoiDB.GetValue(query) != null)
                {
                    query = "SELECT ImportPrice FROM Product WHERE NameProduct = N'" + tenSp + "'";

                    if (giaNhap == long.Parse(ketNoiDB.GetValue(query)))
                    {
                        query = "SELECT RemainAmount FROM Product WHERE NameProduct = N'" + tenSp + "'";
                        long remainAmount = long.Parse(ketNoiDB.GetValue(query));
                        query = "UPDATE Product SET RemainAmount = " + (remainAmount + soLuong) + " WHERE NameProduct = N'" + tenSp + "'";

                        ketNoiDB.ThucThiCauLenh(query);
                    }
                    else
                    {

                        query = "INSERT INTO Product(NameProduct, Supplier, CategoryID, ImportPrice, Price, RemainAmount) VALUES(N'" + tenSp + "', N'" +
                        nhaCungCap + "', " + type + ", " + giaNhap + ", " + giaBan + ", " + soLuong + ")";
                        ketNoiDB.ThucThiCauLenh(query);
                    }
                }

                else
                {
                    query = "INSERT INTO Product(NameProduct, Supplier, CategoryID, ImportPrice, Price, RemainAmount) VALUES(N'" + tenSp + "', N'" +
                        nhaCungCap + "', " + type + ", " + giaNhap + ", " + giaBan + ", " + soLuong + ")";
                    ketNoiDB.ThucThiCauLenh(query);
                }

                query = "SELECT ID FROM Product WHERE NameProduct = N'" + tenSp + "'";
                string idProduct = ketNoiDB.GetValue(query);

                query = "INSERT INTO BillInfo(IDBill, IDProduct, Amount) VALUES(" + idBill + ", " + idProduct + ", " + soLuong + ")";
                ketNoiDB.ThucThiCauLenh(query);
            }

            _frmShowDialogQuestion = new frmShowDialogQuestion("Thành công", "Nhập sản phẩm thành công! Đã thêm dữ liệu sản phẩm vào danh mục sản phẩm" +
                " và hóa đơn nhập!", "Đồng ý", "");
            _frmShowDialogQuestion.Show();

            State = "Reset";
            SetControls(State);
            dgvProduct.DataSource = new System.Data.DataSet();
        }

    }
}
