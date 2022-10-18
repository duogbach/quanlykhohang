
namespace QuanLyCuaHangTienLoi
{
    partial class frmShowDialogQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowDialogQuestion));
            this.btnCo = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCo
            // 
            this.btnCo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.btnCo.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnCo.FlatAppearance.BorderSize = 0;
            this.btnCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCo.Location = new System.Drawing.Point(98, 255);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(131, 40);
            this.btnCo.TabIndex = 1;
            this.btnCo.Text = "Có";
            this.btnCo.UseVisualStyleBackColor = false;
            this.btnCo.Click += new System.EventHandler(this.btnCo_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.btnKhong.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnKhong.FlatAppearance.BorderSize = 0;
            this.btnKhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhong.Location = new System.Drawing.Point(351, 255);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(131, 40);
            this.btnKhong.TabIndex = 2;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = false;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtQuestion.Location = new System.Drawing.Point(98, 54);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(384, 121);
            this.txtQuestion.TabIndex = 3;
            this.txtQuestion.Text = "Bạn có muốn ... không?";
            this.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyCuaHangTienLoi.Properties.Resources.Main;
            this.pictureBox2.Location = new System.Drawing.Point(11, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // frmShowDialogQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnCo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmShowDialogQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowDialogQuestion";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCo;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}