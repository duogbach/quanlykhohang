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
    public partial class frmQuanLyQLSp : Form
    {
        private KetNoiDB ketNoiDB = new KetNoiDB();
        private string query;
        private string State = "Reset";
        frmShowDialogQuestion _frmShowDialogQuestion;

        public frmQuanLyQLSp()
        {
            InitializeComponent();
            loadCboLoaiSP();

            GetData();
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
            if (cboLoaiSp.Text.Equals("Khác"))
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

        public void GetData()
        {
            query = "SELECT * FROM Product LEFT JOIN Category ON Product.CategoryID = Category.ID";
            DataSet ds = ketNoiDB.GetDataSet(query);

            DataColumn MaSP = new DataColumn();
            MaSP.ColumnName = "MaSP";
            ds.Tables[0].Columns.Add(MaSP);

            DataColumn ImportPriceView = new DataColumn();
            ImportPriceView.ColumnName = "ImportPriceView";
            ds.Tables[0].Columns.Add(ImportPriceView);

            DataColumn PriceView = new DataColumn();
            PriceView.ColumnName = "PriceView";
            ds.Tables[0].Columns.Add(PriceView);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["ImportPriceView"] = int.Parse(ds.Tables[0].Rows[i]["ImportPrice"].ToString()).ToString("#,##0");
                ds.Tables[0].Rows[i]["PriceView"] = int.Parse(ds.Tables[0].Rows[i]["Price"].ToString()).ToString("#,##0");
                ds.Tables[0].Rows[i]["MaSP"] = "SP" + ds.Tables[0].Rows[i]["ID"];
            }

            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.DataSource = ds.Tables[0];

            lblTongSo.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi.";
            SetControls(State);
        }

        public void SetControls(string State)
        {
            switch (State)
            {
                case "Reset":
                    txtMaSP.Enabled = false;
                    txtNhaCungCap.Enabled = false;
                    txtTenSP.Enabled = false;
                    cboLoaiSp.Enabled = false;
                    nudGiaBan.Enabled = false;
                    nudGiaNhap.Enabled = false;
                    nudSoLuongConLai.Enabled = false;

                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhiDuLieu.Enabled = false;
                    btnBoQua.Enabled = false;

                    txtMaSP.Text = "";
                    txtNhaCungCap.Text = "";
                    txtTenSP.Text = "";
                    break;
                case "Update":
                    txtMaSP.Enabled = false;
                    txtNhaCungCap.Enabled = true;
                    txtTenSP.Enabled = true;
                    cboLoaiSp.Enabled = true;
                    nudGiaBan.Enabled = true;
                    nudGiaNhap.Enabled = false;
                    nudSoLuongConLai.Enabled = false;

                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhiDuLieu.Enabled = true;
                    btnBoQua.Enabled = true;
                    break;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Equals(""))
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Sửa", "Bạn chưa chọn sản phẩm muốn sửa!", "Thử lại", "");
                _frmShowDialogQuestion.Show();
                return;
            }
            State = "Update";
            SetControls(State);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Equals(""))
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Xóa", "Bạn chưa chọn sản phẩm muốn xóa!", "Thử lại", "");
                _frmShowDialogQuestion.Show();
            }
            else
            {
                frmShowDialogQuestion _frmShowDialogQuestion = new frmShowDialogQuestion("Xóa", "Bạn có muốn xóa sản phẩm " + txtTenSP.Text + " không?", "Có", "Không");
                var x = _frmShowDialogQuestion.ShowDialog();

                if(x == DialogResult.Yes)
                {
                    string[] id = txtMaSP.Text.Split('P');
                    query = "DELETE FROM Product WHERE ID = " + id[1];

                    if (ketNoiDB.ThucThiCauLenh(query))
                    {
                        _frmShowDialogQuestion = new frmShowDialogQuestion("Thành công", "Xóa sản phẩm " + txtTenSP.Text + " thành công!", "Đồng ý", "");
                        _frmShowDialogQuestion.Show();

                        GetData();
                    }
                    else
                    {
                        _frmShowDialogQuestion = new frmShowDialogQuestion("Thất bại", "Có lỗi sảy ra. Vui lòng thử lại!", "Thử lại", "");
                        _frmShowDialogQuestion.Show();
                    }
                }
            }
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

        private void btnGhiDuLieu_Click(object sender, EventArgs e)
        {
            if (State.Equals("Update"))
            { 
                if (txtTenSP.Text != "" && txtNhaCungCap.Text != "" && cboLoaiSp.SelectedIndex >= 0 && nudGiaBan.Value > 0)
                {
                    if (checkPrice())
                    {
                        int type;
                        if (cboLoaiSp.Text.Equals("Khác"))
                        {
                            if(txtLoaiSp.Text.Trim() == "")
                            {
                                _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Bạn chưa nhập loại sản phẩm. Vui lòng thử lại!", "Thử lại", "");
                                _frmShowDialogQuestion.Show();
                                return;
                            }
                            query = "INSERT INTO Category VALUES (N'" + txtLoaiSp.Text.Trim() + "')";
                            ketNoiDB.ThucThiCauLenh(query);

                            query = "SELECT ID FROM Category WHERE NameCate = N'" + txtLoaiSp.Text.Trim() + "'";
                            type = int.Parse(ketNoiDB.GetValue(query));
                        }
                        else
                        {
                            query = "SELECT ID FROM Category WHERE NameCate = N'" + cboLoaiSp.Text.Trim() + "'";
                            type = int.Parse(ketNoiDB.GetValue(query));
                        }

                        string[] id = txtMaSP.Text.Split('P');
                        query = "UPDATE Product SET NameProduct = N'" + txtTenSP.Text.Trim() + "', Price = " + nudGiaBan.Value + ", Supplier = N'" +
                            txtNhaCungCap.Text.Trim() + "', CategoryID = " + type + " WHERE ID = " + id[1];
                        if (ketNoiDB.ThucThiCauLenh(query))
                        {
                            _frmShowDialogQuestion = new frmShowDialogQuestion("Thành công", "Cập nhật dữ liệu thành công", "Tiếp tục", "");
                            _frmShowDialogQuestion.Show();

                            loadCboLoaiSP();
                            GetData();
                            State = "Reset";
                            SetControls(State);
                        }
                        else
                        {
                            _frmShowDialogQuestion = new frmShowDialogQuestion("Lỗi", "Có lỗi sảy ra. Vui lòng thử lại", "Thử lại", "");
                            _frmShowDialogQuestion.Show();
                        }
                    }
                }
                else
                {
                    _frmShowDialogQuestion = new frmShowDialogQuestion("Lỗi", "Yêu cầu nhập đầy đủ. Vui lòng thử lại", "Thử lại", "");
                    _frmShowDialogQuestion.Show();
                }
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            State = "Reset";
            SetControls(State);
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;

            if (State.Equals("Reset") && RowIndex >= 0 && RowIndex < dgvProducts.Rows.Count - 1)
            {
                DataGridViewRow selected = dgvProducts.Rows[RowIndex];

                txtMaSP.Text = selected.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = selected.Cells["NameProduct"].Value.ToString();
                txtNhaCungCap.Text = selected.Cells["Supplier"].Value.ToString();
                for (int i = 0; i < cboLoaiSp.Items.Count; i++)
                {
                    string value = cboLoaiSp.GetItemText(cboLoaiSp.Items[i]);
                    if (selected.Cells["Type"].Value.ToString().Equals(value))
                    {
                        cboLoaiSp.SelectedIndex = i;
                        break;
                    }
                }
                nudSoLuongConLai.Value = int.Parse(selected.Cells["RemainAmount"].Value.ToString());
                nudGiaNhap.Value = int.Parse(selected.Cells["ImportPrice"].Value.ToString().Replace(",",""));
                nudGiaBan.Value = int.Parse(selected.Cells["Price"].Value.ToString().Replace(",", ""));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
