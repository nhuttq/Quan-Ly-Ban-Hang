namespace Formchinh
{
    partial class frmGiaoDien
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
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnQuanLyKhachHang = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnKhoHang = new System.Windows.Forms.Button();
            this.butDangXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butNhaCungCap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Location = new System.Drawing.Point(152, 149);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(241, 94);
            this.btnTaiKhoan.TabIndex = 7;
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnQuanLyKhachHang
            // 
            this.btnQuanLyKhachHang.Location = new System.Drawing.Point(152, 353);
            this.btnQuanLyKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            this.btnQuanLyKhachHang.Size = new System.Drawing.Size(241, 94);
            this.btnQuanLyKhachHang.TabIndex = 8;
            this.btnQuanLyKhachHang.Text = "Quản lý khách hàng";
            this.btnQuanLyKhachHang.UseVisualStyleBackColor = true;
            this.btnQuanLyKhachHang.Click += new System.EventHandler(this.btnQuanLyKhachHang_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(683, 353);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(241, 94);
            this.btnHoaDon.TabIndex = 9;
            this.btnHoaDon.Text = "Hoá Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.Location = new System.Drawing.Point(419, 246);
            this.btnKhoHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Size = new System.Drawing.Size(241, 94);
            this.btnKhoHang.TabIndex = 11;
            this.btnKhoHang.Text = "Kho hàng";
            this.btnKhoHang.UseVisualStyleBackColor = true;
            this.btnKhoHang.Click += new System.EventHandler(this.btnKhoHang_Click);
            // 
            // butDangXuat
            // 
            this.butDangXuat.Location = new System.Drawing.Point(955, 458);
            this.butDangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.butDangXuat.Name = "butDangXuat";
            this.butDangXuat.Size = new System.Drawing.Size(120, 46);
            this.butDangXuat.TabIndex = 13;
            this.butDangXuat.Text = "Đăng Xuất";
            this.butDangXuat.UseVisualStyleBackColor = true;
            this.butDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(334, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 47);
            this.label1.TabIndex = 14;
            this.label1.Text = "QUẢN LÝ HIỆU SÁCH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // butNhaCungCap
            // 
            this.butNhaCungCap.Location = new System.Drawing.Point(683, 149);
            this.butNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.butNhaCungCap.Name = "butNhaCungCap";
            this.butNhaCungCap.Size = new System.Drawing.Size(241, 94);
            this.butNhaCungCap.TabIndex = 15;
            this.butNhaCungCap.Text = "Nhà cung cấp";
            this.butNhaCungCap.UseVisualStyleBackColor = true;
            this.butNhaCungCap.Click += new System.EventHandler(this.butNhaCungCap_Click);
            // 
            // frmGiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formchinh.Properties.Resources.pngtree_6_beautiful_background_photos_image_263872;
            this.ClientSize = new System.Drawing.Size(1117, 532);
            this.Controls.Add(this.butNhaCungCap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDangXuat);
            this.Controls.Add(this.btnKhoHang);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnQuanLyKhachHang);
            this.Controls.Add(this.btnTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiaoDien";
            this.Text = "Giao diện chính";
            this.Load += new System.EventHandler(this.frmGiaoDien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnQuanLyKhachHang;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnKhoHang;
        private System.Windows.Forms.Button butDangXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butNhaCungCap;
    }
}

