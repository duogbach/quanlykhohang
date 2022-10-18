namespace QuanLyCuaHangTienLoi
{
    partial class frmThanhToanLuong
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpThoiGianDen = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpThoiGianTu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLocTheo = new System.Windows.Forms.ComboBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDangNhap = new System.Windows.Forms.DataGridView();
            this.MaDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOutView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(492, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "THANH TOÁN LƯƠNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 47);
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
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Controls.Add(this.dgvChiTiet);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.groupBox4.Location = new System.Drawing.Point(12, 341);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1330, 291);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách chi tiết từng nhân viên";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.dtpThoiGianDen);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpThoiGianTu);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cboLocTheo);
            this.panel2.Location = new System.Drawing.Point(6, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1318, 52);
            this.panel2.TabIndex = 22;
            // 
            // dtpThoiGianDen
            // 
            this.dtpThoiGianDen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpThoiGianDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianDen.Location = new System.Drawing.Point(955, 9);
            this.dtpThoiGianDen.Name = "dtpThoiGianDen";
            this.dtpThoiGianDen.Size = new System.Drawing.Size(144, 34);
            this.dtpThoiGianDen.TabIndex = 67;
            this.dtpThoiGianDen.Value = new System.DateTime(2021, 6, 5, 14, 17, 49, 0);
            this.dtpThoiGianDen.ValueChanged += new System.EventHandler(this.dtpThoiGianDen_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(907, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 28);
            this.label3.TabIndex = 66;
            this.label3.Text = "đến:";
            // 
            // dtpThoiGianTu
            // 
            this.dtpThoiGianTu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpThoiGianTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianTu.Location = new System.Drawing.Point(746, 9);
            this.dtpThoiGianTu.Name = "dtpThoiGianTu";
            this.dtpThoiGianTu.Size = new System.Drawing.Size(136, 34);
            this.dtpThoiGianTu.TabIndex = 65;
            this.dtpThoiGianTu.Value = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
            this.dtpThoiGianTu.ValueChanged += new System.EventHandler(this.dtpThoiGianDen_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(627, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 28);
            this.label4.TabIndex = 64;
            this.label4.Text = "Thời gian từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lọc theo:";
            // 
            // cboLocTheo
            // 
            this.cboLocTheo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.cboLocTheo.FormattingEnabled = true;
            this.cboLocTheo.Items.AddRange(new object[] {
            "Từ trước đến nay",
            "Chưa thanh toán lương",
            "Đã thanh toán lương",
            "Lọc theo ngày"});
            this.cboLocTheo.Location = new System.Drawing.Point(261, 12);
            this.cboLocTheo.Name = "cboLocTheo";
            this.cboLocTheo.Size = new System.Drawing.Size(212, 36);
            this.cboLocTheo.TabIndex = 0;
            this.cboLocTheo.SelectedIndexChanged += new System.EventHandler(this.cboLocTheo_SelectedIndexChanged);
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenNV,
            this.TotalTime,
            this.Luong,
            this.TrangThai});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTiet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.dgvChiTiet.Location = new System.Drawing.Point(6, 96);
            this.dgvChiTiet.Name = "dgvChiTiet";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTiet.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 24;
            this.dgvChiTiet.Size = new System.Drawing.Size(1318, 189);
            this.dgvChiTiet.TabIndex = 20;
            this.dgvChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.groupBox3.Controls.Add(this.dgvDangNhap);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1330, 280);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết thông tin nhân viên đăng nhập hệ thống";
            // 
            // dgvDangNhap
            // 
            this.dgvDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDangNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDangNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.dgvDangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDangNhap,
            this.MaNhanVien,
            this.name,
            this.TimeIn,
            this.TimeOutView});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDangNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDangNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.dgvDangNhap.Location = new System.Drawing.Point(6, 28);
            this.dgvDangNhap.Name = "dgvDangNhap";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDangNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDangNhap.RowHeadersWidth = 51;
            this.dgvDangNhap.RowTemplate.Height = 24;
            this.dgvDangNhap.Size = new System.Drawing.Size(1318, 239);
            this.dgvDangNhap.TabIndex = 21;
            // 
            // MaDangNhap
            // 
            this.MaDangNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDangNhap.DataPropertyName = "MaDangNhap";
            this.MaDangNhap.FillWeight = 30F;
            this.MaDangNhap.HeaderText = "Mã đăng nhập";
            this.MaDangNhap.MinimumWidth = 6;
            this.MaDangNhap.Name = "MaDangNhap";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.FillWeight = 45.60066F;
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "Name";
            this.name.FillWeight = 45.60066F;
            this.name.HeaderText = "Tên nhân viên";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // TimeIn
            // 
            this.TimeIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeIn.DataPropertyName = "TimeInView";
            this.TimeIn.FillWeight = 45.60066F;
            this.TimeIn.HeaderText = "Thời gian đăng nhập";
            this.TimeIn.MinimumWidth = 6;
            this.TimeIn.Name = "TimeIn";
            // 
            // TimeOutView
            // 
            this.TimeOutView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeOutView.DataPropertyName = "TimeOutView";
            this.TimeOutView.FillWeight = 45.60066F;
            this.TimeOutView.HeaderText = "Thời gian đăng xuất";
            this.TimeOutView.MinimumWidth = 6;
            this.TimeOutView.Name = "TimeOutView";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.btnThanhToan.FlatAppearance.BorderSize = 2;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.btnThanhToan.Location = new System.Drawing.Point(1125, 638);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(211, 50);
            this.btnThanhToan.TabIndex = 27;
            this.btnThanhToan.Text = "Đã thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã nhân viên";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            // 
            // TotalTime
            // 
            this.TotalTime.DataPropertyName = "TotalTime";
            this.TotalTime.HeaderText = "Tổng thời gian làm việc";
            this.TotalTime.MinimumWidth = 6;
            this.TotalTime.Name = "TotalTime";
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương thực nhận";
            this.Luong.MinimumWidth = 6;
            this.Luong.Name = "Luong";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // frmThanhToanLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1354, 697);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThanhToanLuong";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOutView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLocTheo;
        private System.Windows.Forms.DateTimePicker dtpThoiGianDen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpThoiGianTu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}