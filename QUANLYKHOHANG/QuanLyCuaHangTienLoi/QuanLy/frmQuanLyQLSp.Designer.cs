namespace QuanLyCuaHangTienLoi
{
    partial class frmQuanLyQLSp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.txtLoaiSp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudSoLuongConLai = new System.Windows.Forms.NumericUpDown();
            this.nudGiaBan = new System.Windows.Forms.NumericUpDown();
            this.nudGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.cboLoaiSp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnGhiDuLieu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongConLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(497, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 47);
            this.panel1.TabIndex = 24;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.LightGray;
            this.btnClose.Image = global::QuanLyCuaHangTienLoi.Properties.Resources.Picture14;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 47);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.groupBox2.Controls.Add(this.lblTongSo);
            this.groupBox2.Controls.Add(this.txtLoaiSp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nudSoLuongConLai);
            this.groupBox2.Controls.Add(this.nudGiaBan);
            this.groupBox2.Controls.Add(this.nudGiaNhap);
            this.groupBox2.Controls.Add(this.cboLoaiSp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNhaCungCap);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Controls.Add(this.lblSdt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaSP);
            this.groupBox2.Controls.Add(this.lblMaNV);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnBoQua);
            this.groupBox2.Controls.Add(this.btnGhiDuLieu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1281, 298);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm chi tiết";
            // 
            // lblTongSo
            // 
            this.lblTongSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.ForeColor = System.Drawing.Color.Tomato;
            this.lblTongSo.Location = new System.Drawing.Point(913, 268);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(65, 21);
            this.lblTongSo.TabIndex = 1;
            this.lblTongSo.Text = "Tổng số";
            // 
            // txtLoaiSp
            // 
            this.txtLoaiSp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoaiSp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiSp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLoaiSp.Location = new System.Drawing.Point(933, 82);
            this.txtLoaiSp.Name = "txtLoaiSp";
            this.txtLoaiSp.Size = new System.Drawing.Size(284, 29);
            this.txtLoaiSp.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(797, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 21);
            this.label7.TabIndex = 52;
            this.label7.Text = "Khác:";
            // 
            // nudSoLuongConLai
            // 
            this.nudSoLuongConLai.Location = new System.Drawing.Point(235, 170);
            this.nudSoLuongConLai.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSoLuongConLai.Name = "nudSoLuongConLai";
            this.nudSoLuongConLai.Size = new System.Drawing.Size(340, 29);
            this.nudSoLuongConLai.TabIndex = 45;
            // 
            // nudGiaBan
            // 
            this.nudGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudGiaBan.Location = new System.Drawing.Point(933, 170);
            this.nudGiaBan.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudGiaBan.Name = "nudGiaBan";
            this.nudGiaBan.Size = new System.Drawing.Size(284, 29);
            this.nudGiaBan.TabIndex = 44;
            // 
            // nudGiaNhap
            // 
            this.nudGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudGiaNhap.Location = new System.Drawing.Point(933, 126);
            this.nudGiaNhap.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudGiaNhap.Name = "nudGiaNhap";
            this.nudGiaNhap.Size = new System.Drawing.Size(284, 29);
            this.nudGiaNhap.TabIndex = 43;
            // 
            // cboLoaiSp
            // 
            this.cboLoaiSp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiSp.FormattingEnabled = true;
            this.cboLoaiSp.Items.AddRange(new object[] {
            "Bia",
            "Rượu",
            "Nước giải khát",
            "Đồ dùng cá nhân",
            "Bánh kẹo",
            "Thực phẩm đông lạnh",
            "Rau quả"});
            this.cboLoaiSp.Location = new System.Drawing.Point(933, 39);
            this.cboLoaiSp.Name = "cboLoaiSp";
            this.cboLoaiSp.Size = new System.Drawing.Size(284, 29);
            this.cboLoaiSp.TabIndex = 42;
            this.cboLoaiSp.Text = "Loại sản phẩm ?";
            this.cboLoaiSp.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSp_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(797, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 41;
            this.label6.Text = "Loại sản phẩm:";
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNhaCungCap.Location = new System.Drawing.Point(235, 125);
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Size = new System.Drawing.Size(340, 29);
            this.txtNhaCungCap.TabIndex = 40;
            // 
            // txtTenSP
            // 
            this.txtTenSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenSP.Location = new System.Drawing.Point(235, 82);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(340, 29);
            this.txtTenSP.TabIndex = 39;
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lblSdt.Location = new System.Drawing.Point(54, 85);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(112, 21);
            this.lblSdt.TabIndex = 38;
            this.lblSdt.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(54, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(235, 39);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(340, 29);
            this.txtMaSP.TabIndex = 3;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lblMaNV.Location = new System.Drawing.Point(54, 172);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(131, 21);
            this.lblMaNV.TabIndex = 19;
            this.lblMaNV.Text = "Số lượng còn lại:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(797, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá nhập:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(797, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá bán:";
            // 
            // btnBoQua
            // 
            this.btnBoQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBoQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.btnBoQua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoQua.FlatAppearance.BorderSize = 0;
            this.btnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.btnBoQua.Location = new System.Drawing.Point(1012, 229);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(157, 36);
            this.btnBoQua.TabIndex = 16;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnGhiDuLieu
            // 
            this.btnGhiDuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGhiDuLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.btnGhiDuLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGhiDuLieu.FlatAppearance.BorderSize = 0;
            this.btnGhiDuLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGhiDuLieu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiDuLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.btnGhiDuLieu.Location = new System.Drawing.Point(735, 229);
            this.btnGhiDuLieu.Name = "btnGhiDuLieu";
            this.btnGhiDuLieu.Size = new System.Drawing.Size(214, 36);
            this.btnGhiDuLieu.TabIndex = 15;
            this.btnGhiDuLieu.Text = "Ghi dữ liệu";
            this.btnGhiDuLieu.UseVisualStyleBackColor = false;
            this.btnGhiDuLieu.Click += new System.EventHandler(this.btnGhiDuLieu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(54, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhà cung cấp:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.btnXoa.Location = new System.Drawing.Point(343, 229);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 36);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.btnSua.Location = new System.Drawing.Point(160, 229);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 36);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.groupBox1.Controls.Add(this.dgvProducts);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1281, 326);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục sản phẩm";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProducts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeight = 36;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.NameProduct,
            this.Supplier,
            this.Type,
            this.ImportPrice,
            this.Price,
            this.RemainAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.dgvProducts.Location = new System.Drawing.Point(6, 29);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1269, 291);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 140;
            // 
            // NameProduct
            // 
            this.NameProduct.DataPropertyName = "NameProduct";
            this.NameProduct.HeaderText = "Tên sản phẩm";
            this.NameProduct.MinimumWidth = 6;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            this.NameProduct.Width = 200;
            // 
            // Supplier
            // 
            this.Supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.HeaderText = "Nhà cung cấp";
            this.Supplier.MinimumWidth = 6;
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "NameCate";
            this.Type.HeaderText = "Loại sản phẩm";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 220;
            // 
            // ImportPrice
            // 
            this.ImportPrice.DataPropertyName = "ImportPriceView";
            this.ImportPrice.HeaderText = "Giá nhập (VND)";
            this.ImportPrice.Name = "ImportPrice";
            this.ImportPrice.ReadOnly = true;
            this.ImportPrice.Width = 170;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "PriceView";
            this.Price.HeaderText = "Giá bán (VND)";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 170;
            // 
            // RemainAmount
            // 
            this.RemainAmount.DataPropertyName = "RemainAmount";
            this.RemainAmount.HeaderText = "Số lượng còn lại";
            this.RemainAmount.Name = "RemainAmount";
            this.RemainAmount.ReadOnly = true;
            this.RemainAmount.Width = 150;
            // 
            // frmQuanLyQLSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1305, 697);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuanLyQLSp";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongConLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnGhiDuLieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown nudSoLuongConLai;
        private System.Windows.Forms.NumericUpDown nudGiaBan;
        private System.Windows.Forms.NumericUpDown nudGiaNhap;
        private System.Windows.Forms.ComboBox cboLoaiSp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainAmount;
        private System.Windows.Forms.TextBox txtLoaiSp;
        private System.Windows.Forms.Label label7;
    }
}