namespace QuanLyCuaHangTienLoi
{
    partial class frmQLTKQuanLy
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblPasswordQuanLy = new System.Windows.Forms.Label();
            this.lblUsernameQuanLy = new System.Windows.Forms.Label();
            this.btnDoiMatKhauQL = new System.Windows.Forms.Button();
            this.btnAnQL = new System.Windows.Forms.Button();
            this.btnHienThiQL = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(344, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(707, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN QUẢN LÝ KHO";
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
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.panel8);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.groupBox4.Location = new System.Drawing.Point(12, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1281, 630);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin tài khoản người quản lý kho";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.lblPasswordQuanLy);
            this.panel8.Controls.Add(this.lblUsernameQuanLy);
            this.panel8.Controls.Add(this.btnDoiMatKhauQL);
            this.panel8.Controls.Add(this.btnAnQL);
            this.panel8.Controls.Add(this.btnHienThiQL);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.label12);
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.panel8.Location = new System.Drawing.Point(3, 22);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1272, 602);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel9.BackgroundImage = global::QuanLyCuaHangTienLoi.Properties.Resources.icon_quanly1;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Location = new System.Drawing.Point(474, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(306, 277);
            this.panel9.TabIndex = 50;
            // 
            // lblPasswordQuanLy
            // 
            this.lblPasswordQuanLy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPasswordQuanLy.AutoSize = true;
            this.lblPasswordQuanLy.Location = new System.Drawing.Point(718, 336);
            this.lblPasswordQuanLy.Name = "lblPasswordQuanLy";
            this.lblPasswordQuanLy.Size = new System.Drawing.Size(60, 28);
            this.lblPasswordQuanLy.TabIndex = 53;
            this.lblPasswordQuanLy.Text = "******";
            // 
            // lblUsernameQuanLy
            // 
            this.lblUsernameQuanLy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsernameQuanLy.AutoSize = true;
            this.lblUsernameQuanLy.Location = new System.Drawing.Point(718, 300);
            this.lblUsernameQuanLy.Name = "lblUsernameQuanLy";
            this.lblUsernameQuanLy.Size = new System.Drawing.Size(60, 28);
            this.lblUsernameQuanLy.TabIndex = 52;
            this.lblUsernameQuanLy.Text = "******";
            // 
            // btnDoiMatKhauQL
            // 
            this.btnDoiMatKhauQL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDoiMatKhauQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnDoiMatKhauQL.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhauQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhauQL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhauQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.btnDoiMatKhauQL.Location = new System.Drawing.Point(567, 521);
            this.btnDoiMatKhauQL.Name = "btnDoiMatKhauQL";
            this.btnDoiMatKhauQL.Size = new System.Drawing.Size(126, 40);
            this.btnDoiMatKhauQL.TabIndex = 49;
            this.btnDoiMatKhauQL.Text = "Đổi mật khẩu";
            this.btnDoiMatKhauQL.UseVisualStyleBackColor = false;
            this.btnDoiMatKhauQL.Click += new System.EventHandler(this.btnDoiMatKhauQL_Click);
            // 
            // btnAnQL
            // 
            this.btnAnQL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnAnQL.FlatAppearance.BorderSize = 0;
            this.btnAnQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnQL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.btnAnQL.Image = global::QuanLyCuaHangTienLoi.Properties.Resources.Picture6;
            this.btnAnQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnQL.Location = new System.Drawing.Point(763, 428);
            this.btnAnQL.Name = "btnAnQL";
            this.btnAnQL.Size = new System.Drawing.Size(240, 53);
            this.btnAnQL.TabIndex = 48;
            this.btnAnQL.Text = "Ẩn tài khoản mật khẩu  ";
            this.btnAnQL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnQL.UseVisualStyleBackColor = false;
            this.btnAnQL.Click += new System.EventHandler(this.btnAnQL_Click);
            // 
            // btnHienThiQL
            // 
            this.btnHienThiQL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHienThiQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnHienThiQL.FlatAppearance.BorderSize = 0;
            this.btnHienThiQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThiQL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.btnHienThiQL.Image = global::QuanLyCuaHangTienLoi.Properties.Resources.Picture5;
            this.btnHienThiQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThiQL.Location = new System.Drawing.Point(236, 428);
            this.btnHienThiQL.Name = "btnHienThiQL";
            this.btnHienThiQL.Size = new System.Drawing.Size(268, 53);
            this.btnHienThiQL.TabIndex = 47;
            this.btnHienThiQL.Text = "Hiển thị tài khoản mật khẩu  ";
            this.btnHienThiQL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThiQL.UseVisualStyleBackColor = false;
            this.btnHienThiQL.Click += new System.EventHandler(this.btnHienThiQL_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(480, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 28);
            this.label11.TabIndex = 46;
            this.label11.Text = "Mật khẩu (Password):";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(480, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 28);
            this.label12.TabIndex = 45;
            this.label12.Text = "Tên tài khoản (Username):";
            // 
            // frmQLTKQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1305, 697);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQLTKQuanLy";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblPasswordQuanLy;
        private System.Windows.Forms.Label lblUsernameQuanLy;
        private System.Windows.Forms.Button btnDoiMatKhauQL;
        private System.Windows.Forms.Button btnAnQL;
        private System.Windows.Forms.Button btnHienThiQL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClose;
    }
}