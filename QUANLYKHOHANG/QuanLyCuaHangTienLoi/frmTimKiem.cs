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
    public partial class frmTimKiem : Form
    {
        private KetNoiDB ketNoiDB = new KetNoiDB();
        private string query;
        frmShowDialogQuestion _frmShowDialogQuestion;

        public frmTimKiem()
        {
            InitializeComponent();
            loadCboLoaiSP();

            query = "SELECT * FROM Product LEFT JOIN Category ON Product.CategoryID = Category.ID";
            GetData(query);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GetData(string query)
        {
            DataSet ds = ketNoiDB.GetDataSet(query);

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
            }

            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.DataSource = ds.Tables[0];

            lblTongSo.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi.";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string MaSP = txtMaSP.Text;
            string TenSP = txtTenSP.Text;
            string NhaCungCap = txtNhaCungCap.Text;
            int GiaTu = int.Parse(nudGiaTu.Value.ToString());
            int GiaDen = int.Parse(nudGiaDen.Value.ToString());

            if(MaSP.Equals("") && TenSP.Equals("") && NhaCungCap.Equals("") && GiaDen == 0)
            {
                _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Yêu cầu nhập một hoặc vài thông tin tìm kiếm!", "Thử lại", "");
                _frmShowDialogQuestion.Show();
            }
            else
            {
                if(GiaTu > GiaDen)
                {
                    _frmShowDialogQuestion = new frmShowDialogQuestion("Thông báo", "Giá bán từ phải nhỏ hơn hoặc bằng giá nhập!", "Thử lại", "");
                    _frmShowDialogQuestion.Show();
                    return;
                }
                else
                {
                    bool check = true;
                    query = "SELECT * FROM Product LEFT JOIN Category ON Product.CategoryID = Category.ID WHERE ";

                    if(MaSP != "")
                    {
                        query += "ID = " + MaSP;
                        check = false;
                    }

                    if(TenSP != "")
                    {
                        if(!check) query += " AND NameProduct = N'%" + TenSP + "%'";
                        else query += " NameProduct LIKE N'%" + TenSP + "%'";
                        check = false;
                    }

                    if(NhaCungCap != "")
                    {
                        if (!check) query += " AND Supplier = N'%" + NhaCungCap + "%'";
                        else query += " Supplier LIKE N'%" + NhaCungCap + "%'";
                        check = false;
                    }

                    if(GiaDen > 0)
                    {
                        if (!check) query += " AND ( Price BETWEEN " + GiaTu + " AND " + GiaDen + " )";
                        else query += " ( Price BETWEEN " + GiaTu + " AND " + GiaDen + " )";
                    }

                    if (ketNoiDB.GetValue(query) != null)
                    {
                        lblTimThay.Visible = true;
                        lblKhongTimThay.Visible = false;

                        GetData(query);
                    }
                    else
                    {
                        lblTimThay.Visible = false;
                        lblKhongTimThay.Visible = true;
                    }
                }
            }
        }

        private void btnHienThiToanBo_Click(object sender, EventArgs e)
        {
            lblTimThay.Visible = false;
            lblKhongTimThay.Visible = false;
            query = "SELECT * FROM Product LEFT JOIN Category ON Product.CategoryID = Category.ID";
            GetData(query);
        }

        private void cboLoaiSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoaiSp.SelectedIndex > 0 && cboLoaiSp.SelectedIndex < cboLoaiSp.Items.Count)
            {
                query = "SELECT * FROM Product LEFT JOIN Category ON Product.CategoryID = Category.ID WHERE NameCate = N'" + cboLoaiSp.Text + "'";
                GetData(query);
            }
            else
            {
                query = "SELECT * FROM Product LEFT JOIN Category ON Product.CategoryID = Category.ID";
                GetData(query);
            }
        }
    }
}
