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
    public partial class frmQuanLyQLNhanVien : Form
    {
        private KetNoiDB ketNoiDB = new KetNoiDB();
        private string query;
        private string State = "Reset";

        public static string username = string.Empty;
        public static string password = string.Empty;
        public frmQuanLyQLNhanVien()
        {
            InitializeComponent();

            GetData();
        }

        public void GetData()
        {
            query = "SELECT * FROM Staff";
            DataSet ds = ketNoiDB.GetDataSet(query);

            DataColumn colViewGioiTinh = new DataColumn();
            colViewGioiTinh.ColumnName = "View_GioiTinh";
            ds.Tables[0].Columns.Add(colViewGioiTinh);

            DataColumn colMaNV = new DataColumn();
            colMaNV.ColumnName = "MaNV";
            ds.Tables[0].Columns.Add(colMaNV);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["Gender"].ToString().Trim().Equals("1"))
                {
                    ds.Tables[0].Rows[i]["View_GioiTinh"] = "Nam";
                }
                else
                {
                    ds.Tables[0].Rows[i]["View_GioiTinh"] = "Nữ";
                }

                ds.Tables[0].Rows[i]["MaNV"] = "NV" + ds.Tables[0].Rows[i]["ID"].ToString();

            }

            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.DataSource = ds.Tables[0];

            lblTongSo.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi.";
            SetControls(State);
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;

            if (RowIndex >= 0 && RowIndex < dgvStaff.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = dgvStaff.Rows[RowIndex];
                txtHoTen.Text = selectedRow.Cells["colHo"].Value.ToString().Trim() + " "
                    + selectedRow.Cells["colTen"].Value.ToString().Trim();
                dtpNgaySinh.Value = Convert.ToDateTime(selectedRow.Cells["colNgaySinh"].Value);
                txtSdt.Text = selectedRow.Cells["colSdt"].Value.ToString().Trim();
                txtQueQuan.Text = selectedRow.Cells["colQueQuan"].Value.ToString().Trim();
                txtMaNV.Text = selectedRow.Cells["MaNV"].Value.ToString().Trim();

                if (selectedRow.Cells["View_GioiTinh"].Value.ToString().Equals("Nam"))
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }
            }
        }

        public void SetControls(string State)
        {

            switch (State)
            {
                case "Reset":
                    dgvStaff.Enabled = true;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhiDuLieu.Enabled = false;
                    btnBoQua.Enabled = false;

                    txtQueQuan.Enabled = false;
                    txtHoTen.Enabled = false;
                    txtSdt.Enabled = false;

                    rdoNam.Checked = true;
                    rdoNam.Enabled = false;
                    rdoNu.Enabled = false;
                    dtpNgaySinh.Enabled = false;

                    lblLoi.Visible = false;
                    lblTrangThai.Visible = false;

                    break;

                case "Insert":
                    dgvStaff.Enabled = false;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhiDuLieu.Enabled = true;
                    btnBoQua.Enabled = true;

                    txtQueQuan.Enabled = true;
                    txtHoTen.Enabled = true;
                    txtSdt.Enabled = true;

                    rdoNam.Checked = true;
                    rdoNam.Enabled = true;
                    rdoNu.Enabled = true;
                    dtpNgaySinh.Enabled = true;

                    txtHoTen.Text = "";
                    txtQueQuan.Text = "";
                    dtpNgaySinh.Value = DateTime.Now;
                    txtSdt.Text = "";
                    txtMaNV.Text = "";

                    break;

                case "Update":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhiDuLieu.Enabled = true;
                    btnBoQua.Enabled = true;

                    txtQueQuan.Enabled = true;
                    txtHoTen.Enabled = true;
                    txtSdt.Enabled = true;

                    rdoNam.Checked = true;
                    rdoNam.Enabled = true;
                    rdoNu.Enabled = true;
                    dtpNgaySinh.Enabled = true;

                    break;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            State = "Reset";
            SetControls(State);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Equals(""))
            {
                lblLoi.Text = "Bạn chưa chọn nhân viên muốn xóa.";
                lblLoi.Visible = true;
                return;
            }
            frmShowDialogQuestion _frmShowDialogQuestion = new frmShowDialogQuestion("Xóa", "Bạn có muốn xóa nhân viên " + txtMaNV.Text + " không?", "Có", "Không");
            var x = _frmShowDialogQuestion.ShowDialog();
            if (x == DialogResult.Yes)
            {
                string[] id = txtMaNV.Text.Split('V');
                query = "DELETE FROM Account WHERE Username = ( SELECT Username FROM Staff WHERE ID = '" + id[1] + "')";

                if (ketNoiDB.ThucThiCauLenh(query))
                {
                    query = "DELETE FROM Staff WHERE ID='" + id[1] + "'";
                    if (ketNoiDB.ThucThiCauLenh(query))
                    {
                        lblTrangThai.Text = "Xóa dữ liệu thành công!";
                        lblTrangThai.Visible = true;

                        lblLoi.Visible = false;
                    }
                    else
                    {
                        lblLoi.Text = "Xóa thất bại";
                        lblLoi.Visible = true;

                        lblTrangThai.Visible = false;
                    }
                }
                else
                {
                    lblLoi.Text = "Xóa thất bại";
                    lblLoi.Visible = true;

                    lblTrangThai.Visible = false;
                }
                GetData();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            State = "Insert";
            SetControls(State);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Equals(""))
            {
                lblLoi.Text = "Bạn chưa chọn nhân viên muốn sửa.";
                lblLoi.Visible = true;

                lblTrangThai.Visible = false;
                return;
            }
            State = "Update";
            SetControls(State);
        }

        private void btnGhiDuLieu_Click(object sender, EventArgs e)
        {
            if (State.Equals("Insert"))
            {
                if (txtHoTen.Text.Equals("") && txtQueQuan.Text.Equals("") && txtSdt.Text.Trim().Equals(""))
                {
                    lblLoi.Text = "Vui lòng nhập đầy đủ thông tin.";
                    lblLoi.Visible = true;

                    lblTrangThai.Visible = false;
                }
                else
                {
                    lblLoi.Text = "";
                    frmInput2 input = new frmInput2();
                    input.ShowDialog();

                    if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                    {
                        string[] name = txtHoTen.Text.Split(' ');
                        string firstName = name[name.Length - 1];
                        string lastName = "";
                        for (int i = 0; i < name.Length - 1; i++)
                        {
                            lastName += name[i] + " ";
                        }

                        int GioiTinh = -1;
                        if (rdoNam.Checked)
                        {
                            GioiTinh = 1;
                        }
                        else
                        {
                            GioiTinh = 0;
                        }

                        query = "INSERT INTO Account VALUES('" + username + "', '" + password + "', '3')";
                        if (ketNoiDB.ThucThiCauLenh(query))
                        {
                            query = "INSERT INTO Staff(Username, Firstname, Lastname, Birthday, Gender, HomeTown, Phone) VALUES('" +
                            username + "', '" + firstName.Trim() + "', '" + lastName.Trim() + "', '"
                            + Convert.ToDateTime(dtpNgaySinh.Value).ToString("MM/dd/yyyy") + "', " + GioiTinh + ", '"
                            + txtQueQuan.Text.Trim() + "', '" + txtSdt.Text.Trim() + "')";

                            
                            if (ketNoiDB.ThucThiCauLenh(query))
                            {
                                GetData();
                                State = "Reset";
                                SetControls(State);
                                lblTrangThai.Text = "Thêm nhân viên thành công!";
                                lblTrangThai.Visible = true;

                                lblLoi.Visible = false;
                            }
                            else
                            {
                                lblLoi.Text = "Có lỗi sảy ra, vui lòng thử lại!";
                                lblLoi.Visible = true;

                                lblTrangThai.Visible = false;
                            }
                        }
                        else
                        {
                            lblLoi.Text = "Tên tài khoản đã được sử dụng, Vui lòng dùng tên tài khoản khác.";
                            lblLoi.Visible = true;

                            lblTrangThai.Visible = false;
                        }
                        return;

                    }
                }
            }

            if (State.Equals("Update"))
            {
                if (txtHoTen.Text.Equals("") && txtQueQuan.Text.Equals("") && txtSdt.Text.Trim().Equals(""))
                {
                    lblLoi.Text = "Vui lòng nhập đầy đủ thông tin.";
                    lblLoi.Visible = true;

                    lblTrangThai.Visible = false;
                }
                else
                {
                    lblLoi.Text = "";
                    string[] name = txtHoTen.Text.Split(' ');
                    string firstName = name[name.Length - 1];
                    string lastName = "";
                    string[] id = txtMaNV.Text.Split('V');
                    for (int i = 0; i < name.Length - 1; i++)
                    {
                        lastName += name[i] + " ";
                    }

                    int GioiTinh = -1;
                    if (rdoNam.Checked)
                    {
                        GioiTinh = 1;
                    }
                    else
                    {
                        GioiTinh = 0;
                    }

                    query = "UPDATE Staff SET Firstname = N'" + firstName + "', Lastname = N'" + lastName + "', Gender = '"
                        + GioiTinh + "', HomeTown = N'" + txtQueQuan.Text + "', Birthday = '"
                        + Convert.ToDateTime(dtpNgaySinh.Value).ToString("MM/dd/yyyy") + "', Phone = '" + txtSdt.Text.Trim() + "' WHERE ID = '" + id[1] + "'";

                    if (ketNoiDB.ThucThiCauLenh(query))
                    {
                        GetData();
                        State = "Reset";
                        SetControls(State);
                        lblTrangThai.Text = "Sửa nhân viên thành công!";
                        lblTrangThai.Visible = true;

                        lblLoi.Visible = false;
                    }
                    else
                    {
                        lblLoi.Text = "Có lỗi sảy ra, vui lòng thử lại!";
                        lblLoi.Visible = true;

                        lblTrangThai.Visible = false;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
