namespace QuanLyCuaHangTienLoi
{
    partial class frmXemDoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbThoiGian = new System.Windows.Forms.CheckBox();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.dtpThoiGianDen = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpThoiGianTu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoaiHoaDon = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDoanhSo = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoLuongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BieuDo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhSo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(550, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "DOANH THU";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.groupBox1.Controls.Add(this.chbThoiGian);
            this.groupBox1.Controls.Add(this.lblTongSo);
            this.groupBox1.Controls.Add(this.dtpThoiGianDen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpThoiGianTu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboLoaiHoaDon);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dgvBills);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1281, 297);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // chbThoiGian
            // 
            this.chbThoiGian.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbThoiGian.AutoSize = true;
            this.chbThoiGian.Location = new System.Drawing.Point(502, 33);
            this.chbThoiGian.Name = "chbThoiGian";
            this.chbThoiGian.Size = new System.Drawing.Size(15, 14);
            this.chbThoiGian.TabIndex = 65;
            this.chbThoiGian.UseVisualStyleBackColor = true;
            this.chbThoiGian.CheckedChanged += new System.EventHandler(this.chbThoiGian_CheckedChanged);
            // 
            // lblTongSo
            // 
            this.lblTongSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.ForeColor = System.Drawing.Color.Tomato;
            this.lblTongSo.Location = new System.Drawing.Point(1111, 30);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(65, 21);
            this.lblTongSo.TabIndex = 64;
            this.lblTongSo.Text = "Tổng số";
            // 
            // dtpThoiGianDen
            // 
            this.dtpThoiGianDen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpThoiGianDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianDen.Location = new System.Drawing.Point(851, 24);
            this.dtpThoiGianDen.Name = "dtpThoiGianDen";
            this.dtpThoiGianDen.Size = new System.Drawing.Size(136, 29);
            this.dtpThoiGianDen.TabIndex = 63;
            this.dtpThoiGianDen.Value = new System.DateTime(2021, 6, 5, 14, 17, 49, 0);
            this.dtpThoiGianDen.ValueChanged += new System.EventHandler(this.dtpThoiGianTu_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(803, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 62;
            this.label3.Text = "đến:";
            // 
            // dtpThoiGianTu
            // 
            this.dtpThoiGianTu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpThoiGianTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianTu.Location = new System.Drawing.Point(642, 24);
            this.dtpThoiGianTu.Name = "dtpThoiGianTu";
            this.dtpThoiGianTu.Size = new System.Drawing.Size(136, 29);
            this.dtpThoiGianTu.TabIndex = 61;
            this.dtpThoiGianTu.Value = new System.DateTime(2021, 6, 5, 14, 17, 49, 0);
            this.dtpThoiGianTu.ValueChanged += new System.EventHandler(this.dtpThoiGianTu_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "Thời gian từ:";
            // 
            // cboLoaiHoaDon
            // 
            this.cboLoaiHoaDon.DisplayMember = "String";
            this.cboLoaiHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiHoaDon.ForeColor = System.Drawing.Color.DeepPink;
            this.cboLoaiHoaDon.FormattingEnabled = true;
            this.cboLoaiHoaDon.Items.AddRange(new object[] {
            "Tất cả",
            "Bán hàng",
            "Nhập kho",
            "Xuất kho"});
            this.cboLoaiHoaDon.Location = new System.Drawing.Point(132, 27);
            this.cboLoaiHoaDon.Name = "cboLoaiHoaDon";
            this.cboLoaiHoaDon.Size = new System.Drawing.Size(186, 29);
            this.cboLoaiHoaDon.TabIndex = 59;
            this.cboLoaiHoaDon.Text = "Tất cả";
            this.cboLoaiHoaDon.ValueMember = "String";
            this.cboLoaiHoaDon.SelectedIndexChanged += new System.EventHandler(this.cboLoaiHoaDon_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(53, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 21);
            this.label14.TabIndex = 58;
            this.label14.Text = "Loại:";
            // 
            // dgvBills
            // 
            this.dgvBills.AllowUserToDeleteRows = false;
            this.dgvBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBills.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.dgvBills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBills.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBills.ColumnHeadersHeight = 36;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.Time,
            this.Date,
            this.TotalPrices,
            this.LoaiGD,
            this.NhanVienTT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBills.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBills.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.dgvBills.Location = new System.Drawing.Point(6, 59);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.ReadOnly = true;
            this.dgvBills.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBills.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBills.RowHeadersWidth = 51;
            this.dgvBills.RowTemplate.Height = 24;
            this.dgvBills.Size = new System.Drawing.Size(1269, 232);
            this.dgvBills.TabIndex = 1;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            this.MaHD.Width = 180;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Thời gian thực hiện giao dịch";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Ngày thực hiện giao dịch";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // TotalPrices
            // 
            this.TotalPrices.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrices.DataPropertyName = "TotalPricesView";
            this.TotalPrices.HeaderText = "Tổng tiền (VND)";
            this.TotalPrices.MinimumWidth = 6;
            this.TotalPrices.Name = "TotalPrices";
            this.TotalPrices.ReadOnly = true;
            // 
            // LoaiGD
            // 
            this.LoaiGD.DataPropertyName = "LoaiGD";
            this.LoaiGD.HeaderText = "Loại giao dịch";
            this.LoaiGD.MinimumWidth = 6;
            this.LoaiGD.Name = "LoaiGD";
            this.LoaiGD.ReadOnly = true;
            this.LoaiGD.Width = 220;
            // 
            // NhanVienTT
            // 
            this.NhanVienTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NhanVienTT.DataPropertyName = "NhanVienTT";
            this.NhanVienTT.HeaderText = "Nhân viên phụ trách";
            this.NhanVienTT.Name = "NhanVienTT";
            this.NhanVienTT.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.groupBox2.Controls.Add(this.dgvDoanhSo);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 329);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê doanh số sản phẩm";
            // 
            // dgvDoanhSo
            // 
            this.dgvDoanhSo.AllowUserToDeleteRows = false;
            this.dgvDoanhSo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoanhSo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.dgvDoanhSo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDoanhSo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoanhSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDoanhSo.ColumnHeadersHeight = 36;
            this.dgvDoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDoanhSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.Name,
            this.TongSoLuongBan,
            this.TongTien});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoanhSo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDoanhSo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.dgvDoanhSo.Location = new System.Drawing.Point(6, 28);
            this.dgvDoanhSo.Name = "dgvDoanhSo";
            this.dgvDoanhSo.ReadOnly = true;
            this.dgvDoanhSo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoanhSo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDoanhSo.RowHeadersWidth = 51;
            this.dgvDoanhSo.RowTemplate.Height = 24;
            this.dgvDoanhSo.Size = new System.Drawing.Size(622, 295);
            this.dgvDoanhSo.TabIndex = 2;
            // 
            // MaSP
            // 
            this.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Tên sản phẩm";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // TongSoLuongBan
            // 
            this.TongSoLuongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongSoLuongBan.DataPropertyName = "TongSoLuongBan";
            this.TongSoLuongBan.HeaderText = "Tổng số lượng đã bán";
            this.TongSoLuongBan.Name = "TongSoLuongBan";
            this.TongSoLuongBan.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng doanh thu (VND)";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.groupBox3.Controls.Add(this.BieuDo);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.groupBox3.Location = new System.Drawing.Point(652, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(641, 329);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Biểu đồ doanh thu sản phẩm theo giá";
            // 
            // BieuDo
            // 
            this.BieuDo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.BieuDo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BieuDo.Legends.Add(legend1);
            this.BieuDo.Location = new System.Drawing.Point(6, 28);
            this.BieuDo.Name = "BieuDo";
            this.BieuDo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.LegendText = "Biểu đồ doanh thu";
            series1.Name = "BieuDo";
            this.BieuDo.Series.Add(series1);
            this.BieuDo.Size = new System.Drawing.Size(629, 295);
            this.BieuDo.TabIndex = 0;
            this.BieuDo.Text = "chart1";
            // 
            // frmXemDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1305, 697);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhSo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BieuDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboLoaiHoaDon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpThoiGianDen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpThoiGianTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.CheckBox chbThoiGian;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienTT;
        private System.Windows.Forms.DataGridView dgvDoanhSo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart BieuDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoLuongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}