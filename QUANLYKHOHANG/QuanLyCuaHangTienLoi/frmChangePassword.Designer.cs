
namespace QuanLyCuaHangTienLoi
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorPassword2 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.txtPasswordNew = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.btnQuayLai.FlatAppearance.BorderSize = 0;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(696, 345);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(134, 40);
            this.btnQuayLai.TabIndex = 77;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(346, 345);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(134, 40);
            this.btnXacNhan.TabIndex = 76;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.Location = new System.Drawing.Point(259, 245);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(273, 34);
            this.txtPassword.TabIndex = 70;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(113, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 69;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // lblErrorPassword2
            // 
            this.lblErrorPassword2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblErrorPassword2.AutoSize = true;
            this.lblErrorPassword2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPassword2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword2.Location = new System.Drawing.Point(692, 274);
            this.lblErrorPassword2.Name = "lblErrorPassword2";
            this.lblErrorPassword2.Size = new System.Drawing.Size(450, 28);
            this.lblErrorPassword2.TabIndex = 68;
            this.lblErrorPassword2.Text = "Mật khẩu nhập lại phải trùng với mật khẩu ở trên!";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPassword2.Location = new System.Drawing.Point(779, 242);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(273, 34);
            this.txtPassword2.TabIndex = 67;
            this.txtPassword2.UseSystemPasswordChar = true;
            this.txtPassword2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword2_KeyUp);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(614, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 28);
            this.label14.TabIndex = 66;
            this.label14.Text = "Nhập lại mật khẩu:";
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(797, 218);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(322, 28);
            this.lblErrorPassword.TabIndex = 65;
            this.lblErrorPassword.Text = "Mật khẩu mới phải dài hơn 5 ký tự!";
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPasswordNew.Location = new System.Drawing.Point(779, 186);
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.Size = new System.Drawing.Size(273, 34);
            this.txtPasswordNew.TabIndex = 64;
            this.txtPasswordNew.UseSystemPasswordChar = true;
            this.txtPasswordNew.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsername.Location = new System.Drawing.Point(259, 186);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(273, 34);
            this.txtUsername.TabIndex = 63;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(614, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 28);
            this.label17.TabIndex = 62;
            this.label17.Text = "Mật khẩu mới";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(113, 189);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 28);
            this.label18.TabIndex = 61;
            this.label18.Text = "Tên tài khoản:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(425, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 92);
            this.label1.TabIndex = 60;
            this.label1.Text = "\r\nĐổi mật khẩu tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyCuaHangTienLoi.Properties.Resources.Main;
            this.pictureBox2.Location = new System.Drawing.Point(12, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErrorPassword2);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.txtPasswordNew);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorPassword2;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.TextBox txtPasswordNew;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}