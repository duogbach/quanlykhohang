namespace QuanLyCuaHangTienLoi
{
    partial class frmQLTKNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTKNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCheckSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimThay = new System.Windows.Forms.Label();
            this.lblKhongTimThay = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelAddInfo = new System.Windows.Forms.Panel();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.lblLoi = new System.Windows.Forms.Label();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnGhiDuLieu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.lblErorr = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnWriteData = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblErorrPassword2 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblErorrPassword = new System.Windows.Forms.Label();
            this.lblErorrUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnShowList = new System.Windows.Forms.Button();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panelAddInfo.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(411, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN NHÂN VIÊN";
            // 
            // lblCheckSearch
            // 
            this.lblCheckSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCheckSearch.AutoSize = true;
            this.lblCheckSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckSearch.ForeColor = System.Drawing.Color.Red;
            this.lblCheckSearch.Location = new System.Drawing.Point(481, 63);
            this.lblCheckSearch.Name = "lblCheckSearch";
            this.lblCheckSearch.Size = new System.Drawing.Size(319, 28);
            this.lblCheckSearch.TabIndex = 21;
            this.lblCheckSearch.Text = "Tên tài khoản phải dài hơn 5 ký tự.";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSearch.Location = new System.Drawing.Point(485, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(424, 34);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(60, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tìm kiếm tài khoản theo tên tài khoản (Username):";
            // 
            // lblTimThay
            // 
            this.lblTimThay.AutoSize = true;
            this.lblTimThay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimThay.ForeColor = System.Drawing.Color.Cyan;
            this.lblTimThay.Location = new System.Drawing.Point(74, 63);
            this.lblTimThay.Name = "lblTimThay";
            this.lblTimThay.Size = new System.Drawing.Size(95, 28);
            this.lblTimThay.TabIndex = 19;
            this.lblTimThay.Text = "Tìm thấy!";
            // 
            // lblKhongTimThay
            // 
            this.lblKhongTimThay.AutoSize = true;
            this.lblKhongTimThay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhongTimThay.ForeColor = System.Drawing.Color.Red;
            this.lblKhongTimThay.Location = new System.Drawing.Point(80, 63);
            this.lblKhongTimThay.Name = "lblKhongTimThay";
            this.lblKhongTimThay.Size = new System.Drawing.Size(152, 28);
            this.lblKhongTimThay.TabIndex = 18;
            this.lblKhongTimThay.Text = "Không tìm thấy!";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.splitter1);
            this.groupBox2.Controls.Add(this.panelAddInfo);
            this.groupBox2.Controls.Add(this.lblErorr);
            this.groupBox2.Controls.Add(this.lblSuccess);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnWriteData);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.lblErorrPassword2);
            this.groupBox2.Controls.Add(this.txtPassword2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblErorrPassword);
            this.groupBox2.Controls.Add(this.lblErorrUsername);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1288, 247);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản nhân viên";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(1282, 30);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 214);
            this.splitter1.TabIndex = 21;
            this.splitter1.TabStop = false;
            // 
            // panelAddInfo
            // 
            this.panelAddInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAddInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.panelAddInfo.Controls.Add(this.txtSdt);
            this.panelAddInfo.Controls.Add(this.lblLoi);
            this.panelAddInfo.Controls.Add(this.btnBoQua);
            this.panelAddInfo.Controls.Add(this.btnGhiDuLieu);
            this.panelAddInfo.Controls.Add(this.label6);
            this.panelAddInfo.Controls.Add(this.txtHoTen);
            this.panelAddInfo.Controls.Add(this.txtMaNV);
            this.panelAddInfo.Controls.Add(this.lblSdt);
            this.panelAddInfo.Controls.Add(this.lblMaNV);
            this.panelAddInfo.Controls.Add(this.dtpNgaySinh);
            this.panelAddInfo.Controls.Add(this.label7);
            this.panelAddInfo.Controls.Add(this.label9);
            this.panelAddInfo.Controls.Add(this.panel7);
            this.panelAddInfo.Controls.Add(this.label10);
            this.panelAddInfo.Controls.Add(this.txtQueQuan);
            this.panelAddInfo.Location = new System.Drawing.Point(6, 25);
            this.panelAddInfo.Name = "panelAddInfo";
            this.panelAddInfo.Size = new System.Drawing.Size(1279, 219);
            this.panelAddInfo.TabIndex = 20;
            // 
            // txtSdt
            // 
            this.txtSdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSdt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSdt.Location = new System.Drawing.Point(205, 56);
            this.txtSdt.MaximumSize = new System.Drawing.Size(500, 29);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(464, 34);
            this.txtSdt.TabIndex = 37;
            // 
            // lblLoi
            // 
            this.lblLoi.AutoSize = true;
            this.lblLoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoi.ForeColor = System.Drawing.Color.Red;
            this.lblLoi.Location = new System.Drawing.Point(113, 179);
            this.lblLoi.Name = "lblLoi";
            this.lblLoi.Size = new System.Drawing.Size(123, 28);
            this.lblLoi.TabIndex = 36;
            this.lblLoi.Text = "Có lỗi xảy ra";
            this.lblLoi.Visible = false;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBoQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnBoQua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoQua.FlatAppearance.BorderSize = 0;
            this.btnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.btnBoQua.Location = new System.Drawing.Point(920, 170);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(157, 36);
            this.btnBoQua.TabIndex = 34;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnGhiDuLieu
            // 
            this.btnGhiDuLieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGhiDuLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnGhiDuLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGhiDuLieu.FlatAppearance.BorderSize = 0;
            this.btnGhiDuLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGhiDuLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.btnGhiDuLieu.Location = new System.Drawing.Point(308, 169);
            this.btnGhiDuLieu.Name = "btnGhiDuLieu";
            this.btnGhiDuLieu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGhiDuLieu.Size = new System.Drawing.Size(214, 36);
            this.btnGhiDuLieu.TabIndex = 33;
            this.btnGhiDuLieu.Text = "Ghi dữ liệu";
            this.btnGhiDuLieu.UseVisualStyleBackColor = false;
            this.btnGhiDuLieu.Click += new System.EventHandler(this.btnGhiDuLieu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(78, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtHoTen.Location = new System.Drawing.Point(205, 13);
            this.txtHoTen.MaximumSize = new System.Drawing.Size(500, 29);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(464, 34);
            this.txtHoTen.TabIndex = 22;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtMaNV.Location = new System.Drawing.Point(875, 116);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(281, 34);
            this.txtMaNV.TabIndex = 32;
            this.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lblSdt.Location = new System.Drawing.Point(78, 59);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(138, 28);
            this.lblSdt.TabIndex = 23;
            this.lblSdt.Text = "Số điện thoại:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lblMaNV.Location = new System.Drawing.Point(742, 119);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(141, 28);
            this.lblMaNV.TabIndex = 31;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(875, 13);
            this.dtpNgaySinh.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MaximumSize = new System.Drawing.Size(410, 29);
            this.dtpNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(281, 29);
            this.dtpNgaySinh.TabIndex = 24;
            this.dtpNgaySinh.Value = new System.DateTime(2021, 5, 5, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(742, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 28);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ngày sinh:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(742, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 28);
            this.label9.TabIndex = 26;
            this.label9.Text = "Giới tính:";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.rdoNu);
            this.panel7.Controls.Add(this.rdoNam);
            this.panel7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.Location = new System.Drawing.Point(875, 56);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(234, 39);
            this.panel7.TabIndex = 27;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.rdoNu.Location = new System.Drawing.Point(122, 6);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(60, 32);
            this.rdoNu.TabIndex = 1;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.rdoNam.Location = new System.Drawing.Point(3, 6);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(75, 32);
            this.rdoNam.TabIndex = 0;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(78, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 28);
            this.label10.TabIndex = 28;
            this.label10.Text = "Quê quán";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtQueQuan.Location = new System.Drawing.Point(205, 104);
            this.txtQueQuan.MaximumSize = new System.Drawing.Size(550, 51);
            this.txtQueQuan.Multiline = true;
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(464, 51);
            this.txtQueQuan.TabIndex = 29;
            // 
            // lblErorr
            // 
            this.lblErorr.AutoSize = true;
            this.lblErorr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErorr.ForeColor = System.Drawing.Color.Red;
            this.lblErorr.Location = new System.Drawing.Point(182, 159);
            this.lblErorr.Name = "lblErorr";
            this.lblErorr.Size = new System.Drawing.Size(122, 28);
            this.lblErorr.TabIndex = 19;
            this.lblErorr.Text = "Có lỗi sảy ra";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.ForeColor = System.Drawing.Color.Cyan;
            this.lblSuccess.Location = new System.Drawing.Point(182, 159);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(171, 28);
            this.lblSuccess.TabIndex = 18;
            this.lblSuccess.Text = "Thêm thành công!";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(1068, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 33);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnWriteData
            // 
            this.btnWriteData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWriteData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnWriteData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWriteData.FlatAppearance.BorderSize = 0;
            this.btnWriteData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriteData.Location = new System.Drawing.Point(869, 197);
            this.btnWriteData.Name = "btnWriteData";
            this.btnWriteData.Size = new System.Drawing.Size(167, 33);
            this.btnWriteData.TabIndex = 16;
            this.btnWriteData.Text = "Ghi dữ liệu";
            this.btnWriteData.UseVisualStyleBackColor = false;
            this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(549, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 33);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(363, 198);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 33);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(182, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 33);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblErorrPassword2
            // 
            this.lblErorrPassword2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErorrPassword2.AutoSize = true;
            this.lblErorrPassword2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErorrPassword2.ForeColor = System.Drawing.Color.Red;
            this.lblErorrPassword2.Location = new System.Drawing.Point(846, 115);
            this.lblErorrPassword2.Name = "lblErorrPassword2";
            this.lblErorrPassword2.Size = new System.Drawing.Size(450, 28);
            this.lblErorrPassword2.TabIndex = 12;
            this.lblErorrPassword2.Text = "Mật khẩu nhập lại phải trùng với mật khẩu ở trên!";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.Location = new System.Drawing.Point(340, 108);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(479, 34);
            this.txtPassword2.TabIndex = 11;
            this.txtPassword2.UseSystemPasswordChar = true;
            this.txtPassword2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword2_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 28);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nhập lại mật khẩu:";
            // 
            // lblErorrPassword
            // 
            this.lblErorrPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErorrPassword.AutoSize = true;
            this.lblErorrPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErorrPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErorrPassword.Location = new System.Drawing.Point(846, 76);
            this.lblErorrPassword.Name = "lblErorrPassword";
            this.lblErorrPassword.Size = new System.Drawing.Size(283, 28);
            this.lblErorrPassword.TabIndex = 9;
            this.lblErorrPassword.Text = "Mật khẩu phải dài hơn 5 ký tự!";
            // 
            // lblErorrUsername
            // 
            this.lblErorrUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErorrUsername.AutoSize = true;
            this.lblErorrUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErorrUsername.ForeColor = System.Drawing.Color.Red;
            this.lblErorrUsername.Location = new System.Drawing.Point(846, 43);
            this.lblErorrUsername.Name = "lblErorrUsername";
            this.lblErorrUsername.Size = new System.Drawing.Size(321, 28);
            this.lblErorrUsername.TabIndex = 8;
            this.lblErorrUsername.Text = "Tên tài khoản phải dài hơn 5 ký tự!";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(340, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(479, 34);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(340, 40);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(479, 34);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mật khẩu (Password):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên tài khoản (Username):";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.lblText);
            this.groupBox1.Controls.Add(this.btnShowList);
            this.groupBox1.Controls.Add(this.dgvAccounts);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1288, 261);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tài khoản nhân viên";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(142, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ẩn danh sách ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAnList_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Tomato;
            this.lblInfo.Location = new System.Drawing.Point(136, 212);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(217, 28);
            this.lblInfo.TabIndex = 19;
            this.lblInfo.Text = "Tổng cộng có ? bản ghi";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblText
            // 
            this.lblText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblText.Location = new System.Drawing.Point(653, 153);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(653, 28);
            this.lblText.TabIndex = 18;
            this.lblText.Text = "Vì tính bảo mật nên chưa hiển thị danh sách. Danh sách sẽ hiển thị ở đây";
            // 
            // btnShowList
            // 
            this.btnShowList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnShowList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowList.FlatAppearance.BorderSize = 0;
            this.btnShowList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.btnShowList.Image = global::QuanLyCuaHangTienLoi.Properties.Resources.Picture5;
            this.btnShowList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowList.Location = new System.Drawing.Point(84, 69);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(279, 43);
            this.btnShowList.TabIndex = 18;
            this.btnShowList.Text = "Hiển thị danh sách tài khoản";
            this.btnShowList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.dgvAccounts.Location = new System.Drawing.Point(447, 28);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersWidth = 51;
            this.dgvAccounts.RowTemplate.Height = 26;
            this.dgvAccounts.Size = new System.Drawing.Size(835, 227);
            this.dgvAccounts.TabIndex = 0;
            this.dgvAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellClick);
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tên tài khoản (Username)";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Mật khẩu (Password)";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.lblKhongTimThay);
            this.groupBox3.Controls.Add(this.lblCheckSearch);
            this.groupBox3.Controls.Add(this.lblTimThay);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1288, 103);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(971, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 42);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // frmAdminQLTKNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1305, 697);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdminQLTKNhanVien";
            this.Text = "Form2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelAddInfo.ResumeLayout(false);
            this.panelAddInfo.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCheckSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTimThay;
        private System.Windows.Forms.Label lblKhongTimThay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelAddInfo;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label lblLoi;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnGhiDuLieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label lblErorr;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnWriteData;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblErorrPassword2;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblErorrPassword;
        private System.Windows.Forms.Label lblErorrUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Button btnClose;
    }
}