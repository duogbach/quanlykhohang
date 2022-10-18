namespace QuanLyCuaHangTienLoi
{
    partial class frmTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiem));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLoaiSp = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.txtNhaCungCap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHienThiToanBo = new System.Windows.Forms.Button();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.nudGia = new System.Windows.Forms.NumericUpDown();
            this.btnSuaGiaBan = new System.Windows.Forms.Button();
            this.lblKhongTimThay = new System.Windows.Forms.Label();
            this.lblTimThay = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.nudGiaDen = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudGiaTu = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(481, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "TÌM KIẾM SẢN PHẨM";
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.groupBox1.Controls.Add(this.cboLoaiSp);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dgvProducts);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1281, 334);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục sản phẩm được tìm thấy";
            // 
            // cboLoaiSp
            // 
            this.cboLoaiSp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiSp.DisplayMember = "String";
            this.cboLoaiSp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiSp.ForeColor = System.Drawing.Color.DeepPink;
            this.cboLoaiSp.FormattingEnabled = true;
            this.cboLoaiSp.Items.AddRange(new object[] {
            "Tất cả",
            "Bia",
            "Rượu",
            "Nước giải khát",
            "Đồ dùng cá nhân",
            "Bánh kẹo",
            "Thực phẩm đông lạnh",
            "Rau quả"});
            this.cboLoaiSp.Location = new System.Drawing.Point(460, 24);
            this.cboLoaiSp.Name = "cboLoaiSp";
            this.cboLoaiSp.Size = new System.Drawing.Size(469, 36);
            this.cboLoaiSp.TabIndex = 59;
            this.cboLoaiSp.Text = "Loại sản phẩm ?";
            this.cboLoaiSp.ValueMember = "String";
            this.cboLoaiSp.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSp_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(320, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 28);
            this.label14.TabIndex = 58;
            this.label14.Text = "Loại sản phẩm:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(504, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(372, 28);
            this.label7.TabIndex = 49;
            this.label7.Text = "Kết quả tìm kiếm sẽ được hiển thị ở đây...";
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
            this.ID,
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
            this.dgvProducts.Location = new System.Drawing.Point(6, 59);
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
            this.dgvProducts.Size = new System.Drawing.Size(1269, 269);
            this.dgvProducts.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(67, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhà cung cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(67, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lblSdt.Location = new System.Drawing.Point(67, 125);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(144, 28);
            this.lblSdt.TabIndex = 38;
            this.lblSdt.Text = "Tên sản phẩm:";
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNhaCungCap.Location = new System.Drawing.Point(207, 165);
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Size = new System.Drawing.Size(399, 34);
            this.txtNhaCungCap.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.groupBox2.Controls.Add(this.btnHienThiToanBo);
            this.groupBox2.Controls.Add(this.lblTongSo);
            this.groupBox2.Controls.Add(this.lblGia);
            this.groupBox2.Controls.Add(this.nudGia);
            this.groupBox2.Controls.Add(this.btnSuaGiaBan);
            this.groupBox2.Controls.Add(this.lblKhongTimThay);
            this.groupBox2.Controls.Add(this.lblTimThay);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.nudGiaDen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nudGiaTu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Controls.Add(this.txtMaSP);
            this.groupBox2.Controls.Add(this.txtNhaCungCap);
            this.groupBox2.Controls.Add(this.lblSdt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1281, 290);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm sản phẩm";
            // 
            // btnHienThiToanBo
            // 
            this.btnHienThiToanBo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHienThiToanBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnHienThiToanBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHienThiToanBo.FlatAppearance.BorderSize = 0;
            this.btnHienThiToanBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThiToanBo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiToanBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.btnHienThiToanBo.Image = global::QuanLyCuaHangTienLoi.Properties.Resources.Picture5;
            this.btnHienThiToanBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThiToanBo.Location = new System.Drawing.Point(790, 149);
            this.btnHienThiToanBo.Name = "btnHienThiToanBo";
            this.btnHienThiToanBo.Size = new System.Drawing.Size(257, 42);
            this.btnHienThiToanBo.TabIndex = 55;
            this.btnHienThiToanBo.Text = "Hiển thị toàn bộ sản phẩm";
            this.btnHienThiToanBo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThiToanBo.UseVisualStyleBackColor = false;
            this.btnHienThiToanBo.Click += new System.EventHandler(this.btnHienThiToanBo_Click);
            // 
            // lblTongSo
            // 
            this.lblTongSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.ForeColor = System.Drawing.Color.Tomato;
            this.lblTongSo.Location = new System.Drawing.Point(1107, 120);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(82, 28);
            this.lblTongSo.TabIndex = 54;
            this.lblTongSo.Text = "Tổng số";
            // 
            // lblGia
            // 
            this.lblGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lblGia.Location = new System.Drawing.Point(694, 230);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(46, 28);
            this.lblGia.TabIndex = 53;
            this.lblGia.Text = "Giá:";
            this.lblGia.Visible = false;
            // 
            // nudGia
            // 
            this.nudGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudGia.Location = new System.Drawing.Point(754, 228);
            this.nudGia.Name = "nudGia";
            this.nudGia.Size = new System.Drawing.Size(175, 34);
            this.nudGia.TabIndex = 52;
            this.nudGia.Visible = false;
            // 
            // btnSuaGiaBan
            // 
            this.btnSuaGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaGiaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnSuaGiaBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaGiaBan.FlatAppearance.BorderSize = 0;
            this.btnSuaGiaBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaGiaBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaGiaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.btnSuaGiaBan.Image = global::QuanLyCuaHangTienLoi.Properties.Resources.Picture15;
            this.btnSuaGiaBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaGiaBan.Location = new System.Drawing.Point(1041, 228);
            this.btnSuaGiaBan.Name = "btnSuaGiaBan";
            this.btnSuaGiaBan.Size = new System.Drawing.Size(214, 46);
            this.btnSuaGiaBan.TabIndex = 51;
            this.btnSuaGiaBan.Text = "Điều chỉnh giá bán ";
            this.btnSuaGiaBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaGiaBan.UseVisualStyleBackColor = false;
            this.btnSuaGiaBan.Visible = false;
            // 
            // lblKhongTimThay
            // 
            this.lblKhongTimThay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKhongTimThay.AutoSize = true;
            this.lblKhongTimThay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhongTimThay.ForeColor = System.Drawing.Color.Red;
            this.lblKhongTimThay.Location = new System.Drawing.Point(1106, 80);
            this.lblKhongTimThay.Name = "lblKhongTimThay";
            this.lblKhongTimThay.Size = new System.Drawing.Size(146, 28);
            this.lblKhongTimThay.TabIndex = 50;
            this.lblKhongTimThay.Text = "Không tìm thấy";
            this.lblKhongTimThay.Visible = false;
            // 
            // lblTimThay
            // 
            this.lblTimThay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimThay.AutoSize = true;
            this.lblTimThay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimThay.ForeColor = System.Drawing.Color.Cyan;
            this.lblTimThay.Location = new System.Drawing.Point(1107, 56);
            this.lblTimThay.Name = "lblTimThay";
            this.lblTimThay.Size = new System.Drawing.Size(89, 28);
            this.lblTimThay.TabIndex = 49;
            this.lblTimThay.Text = "Tìm thấy";
            this.lblTimThay.Visible = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(790, 76);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(128, 42);
            this.btnTimKiem.TabIndex = 48;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // nudGiaDen
            // 
            this.nudGiaDen.Location = new System.Drawing.Point(450, 214);
            this.nudGiaDen.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudGiaDen.Name = "nudGiaDen";
            this.nudGiaDen.Size = new System.Drawing.Size(156, 34);
            this.nudGiaDen.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(384, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 28);
            this.label6.TabIndex = 46;
            this.label6.Text = "đến:";
            // 
            // nudGiaTu
            // 
            this.nudGiaTu.Location = new System.Drawing.Point(207, 214);
            this.nudGiaTu.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudGiaTu.Name = "nudGiaTu";
            this.nudGiaTu.Size = new System.Drawing.Size(156, 34);
            this.nudGiaTu.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(67, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 28);
            this.label4.TabIndex = 44;
            this.label4.Text = "Giá bán từ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(101, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(555, 28);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nhập một hoặc một số thông tin vào ô dưới đây để tìm kiếm...";
            // 
            // txtTenSP
            // 
            this.txtTenSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenSP.Location = new System.Drawing.Point(207, 122);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(399, 34);
            this.txtTenSP.TabIndex = 42;
            // 
            // txtMaSP
            // 
            this.txtMaSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaSP.Location = new System.Drawing.Point(207, 79);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(399, 34);
            this.txtMaSP.TabIndex = 41;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã sản phẩm";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 140;
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
            this.ImportPrice.MinimumWidth = 6;
            this.ImportPrice.Name = "ImportPrice";
            this.ImportPrice.ReadOnly = true;
            this.ImportPrice.Width = 170;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "PriceView";
            this.Price.HeaderText = "Giá bán (VND)";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 170;
            // 
            // RemainAmount
            // 
            this.RemainAmount.DataPropertyName = "RemainAmount";
            this.RemainAmount.HeaderText = "Số lượng còn lại";
            this.RemainAmount.MinimumWidth = 6;
            this.RemainAmount.Name = "RemainAmount";
            this.RemainAmount.ReadOnly = true;
            this.RemainAmount.Width = 150;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1305, 697);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTimKiem";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.TextBox txtNhaCungCap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.NumericUpDown nudGiaDen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudGiaTu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblKhongTimThay;
        private System.Windows.Forms.Label lblTimThay;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.NumericUpDown nudGia;
        private System.Windows.Forms.Button btnSuaGiaBan;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Button btnHienThiToanBo;
        private System.Windows.Forms.ComboBox cboLoaiSp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainAmount;
    }
}