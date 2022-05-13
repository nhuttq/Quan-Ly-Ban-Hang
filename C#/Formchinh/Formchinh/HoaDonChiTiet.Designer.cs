
namespace Formchinh
{
    partial class HoaDonChiTiet
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.butHuy = new System.Windows.Forms.Button();
            this.cbMaHDB = new System.Windows.Forms.ComboBox();
            this.cbMaSP = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butSua = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.butThem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butTimKiem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DanhMucHoaDon = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.BackgroundImage = global::Formchinh.Properties.Resources.background_dep_va_tinh_te_840x473;
            this.panel2.Controls.Add(this.butHuy);
            this.panel2.Controls.Add(this.cbMaHDB);
            this.panel2.Controls.Add(this.cbMaSP);
            this.panel2.Controls.Add(this.txtDonGia);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.txtThanhTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.butSua);
            this.panel2.Controls.Add(this.butXoa);
            this.panel2.Controls.Add(this.butThem);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.butTimKiem);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.DanhMucHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 257);
            this.panel2.TabIndex = 3;
            // 
            // butHuy
            // 
            this.butHuy.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.butHuy.Location = new System.Drawing.Point(797, 196);
            this.butHuy.Margin = new System.Windows.Forms.Padding(4);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(100, 28);
            this.butHuy.TabIndex = 64;
            this.butHuy.Text = "Hủy";
            this.butHuy.UseVisualStyleBackColor = false;
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // cbMaHDB
            // 
            this.cbMaHDB.FormattingEnabled = true;
            this.cbMaHDB.Location = new System.Drawing.Point(39, 86);
            this.cbMaHDB.Name = "cbMaHDB";
            this.cbMaHDB.Size = new System.Drawing.Size(121, 24);
            this.cbMaHDB.TabIndex = 63;
            // 
            // cbMaSP
            // 
            this.cbMaSP.FormattingEnabled = true;
            this.cbMaSP.Location = new System.Drawing.Point(223, 89);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(137, 24);
            this.cbMaSP.TabIndex = 62;
            this.cbMaSP.SelectionChangeCommitted += new System.EventHandler(this.cbMaSP_SelectionChangeCommitted);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(38, 147);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(122, 22);
            this.txtDonGia.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(63, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "Đơn Giá:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(223, 147);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(137, 22);
            this.txtSoLuong.TabIndex = 59;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(168, 204);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(151, 22);
            this.txtThanhTien.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(63, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Thành tiền:";
            // 
            // butSua
            // 
            this.butSua.BackColor = System.Drawing.SystemColors.HotTrack;
            this.butSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butSua.Location = new System.Drawing.Point(797, 136);
            this.butSua.Margin = new System.Windows.Forms.Padding(4);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(100, 28);
            this.butSua.TabIndex = 54;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = false;
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butXoa
            // 
            this.butXoa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.butXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butXoa.Location = new System.Drawing.Point(608, 196);
            this.butXoa.Margin = new System.Windows.Forms.Padding(4);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(100, 28);
            this.butXoa.TabIndex = 53;
            this.butXoa.Text = "Xoá";
            this.butXoa.UseVisualStyleBackColor = false;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butThem
            // 
            this.butThem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.butThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butThem.Location = new System.Drawing.Point(608, 136);
            this.butThem.Margin = new System.Windows.Forms.Padding(4);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(100, 28);
            this.butThem.TabIndex = 52;
            this.butThem.Text = "Thêm";
            this.butThem.UseVisualStyleBackColor = false;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(617, 85);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(280, 22);
            this.txtTimKiem.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(509, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Nhập từ khoá:";
            // 
            // butTimKiem
            // 
            this.butTimKiem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.butTimKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butTimKiem.Location = new System.Drawing.Point(916, 82);
            this.butTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.butTimKiem.Name = "butTimKiem";
            this.butTimKiem.Size = new System.Drawing.Size(97, 28);
            this.butTimKiem.TabIndex = 49;
            this.butTimKiem.Text = "Tìm kiếm";
            this.butTimKiem.UseVisualStyleBackColor = false;
            this.butTimKiem.Click += new System.EventHandler(this.butTimKiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(259, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Số Lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(245, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = " Sản Phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mã Hoá Đơn Bán:";
            // 
            // DanhMucHoaDon
            // 
            this.DanhMucHoaDon.AutoSize = true;
            this.DanhMucHoaDon.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DanhMucHoaDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhMucHoaDon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DanhMucHoaDon.Location = new System.Drawing.Point(392, 21);
            this.DanhMucHoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DanhMucHoaDon.Name = "DanhMucHoaDon";
            this.DanhMucHoaDon.Size = new System.Drawing.Size(237, 26);
            this.DanhMucHoaDon.TabIndex = 0;
            this.DanhMucHoaDon.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(408, 261);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(238, 26);
            this.label14.TabIndex = 5;
            this.label14.Text = "CHI TIẾT HOÁ ĐƠN";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(0, 290);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.RowTemplate.Height = 24;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(1067, 264);
            this.dgvChiTietHoaDon.TabIndex = 6;
            this.dgvChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellClick);
            // 
            // HoaDonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvChiTietHoaDon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoaDonChiTiet";
            this.Text = "HoaDonChiTiet";
            this.Load += new System.EventHandler(this.HoaDonChiTiet_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DanhMucHoaDon;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaSP;
        private System.Windows.Forms.ComboBox cbMaHDB;
        private System.Windows.Forms.Button butHuy;
    }
}