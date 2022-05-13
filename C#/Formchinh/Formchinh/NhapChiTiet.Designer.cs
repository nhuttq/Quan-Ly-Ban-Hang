
namespace Formchinh
{
    partial class NhapChiTiet
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
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbMaSP = new System.Windows.Forms.ComboBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMaHDN = new System.Windows.Forms.ComboBox();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butHuy = new System.Windows.Forms.Button();
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
            this.dgvNhapChiTiet = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(431, 261);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 26);
            this.label14.TabIndex = 8;
            this.label14.Text = "NHẬP CHI TIẾT";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.BackgroundImage = global::Formchinh.Properties.Resources.background_dep_va_tinh_te_840x473;
            this.panel2.Controls.Add(this.cbMaSP);
            this.panel2.Controls.Add(this.txtDonGiaNhap);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbMaHDN);
            this.panel2.Controls.Add(this.txtSoLuongNhap);
            this.panel2.Controls.Add(this.txtThanhTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.butHuy);
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
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbMaSP
            // 
            this.cbMaSP.FormattingEnabled = true;
            this.cbMaSP.Location = new System.Drawing.Point(228, 89);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(151, 24);
            this.cbMaSP.TabIndex = 65;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(44, 155);
            this.txtDonGiaNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(151, 22);
            this.txtDonGiaNhap.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Location = new System.Drawing.Point(65, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 63;
            this.label7.Text = "Đơn Giá Nhập";
            // 
            // cbMaHDN
            // 
            this.cbMaHDN.FormattingEnabled = true;
            this.cbMaHDN.Location = new System.Drawing.Point(44, 89);
            this.cbMaHDN.Name = "cbMaHDN";
            this.cbMaHDN.Size = new System.Drawing.Size(151, 24);
            this.cbMaHDN.TabIndex = 60;
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Location = new System.Drawing.Point(228, 155);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(151, 22);
            this.txtSoLuongNhap.TabIndex = 59;
            this.txtSoLuongNhap.TextChanged += new System.EventHandler(this.txtSoLuongNhap_TextChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(171, 213);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(208, 22);
            this.txtThanhTien.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(78, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Thành Tiền:";
            // 
            // butHuy
            // 
            this.butHuy.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.butHuy.Location = new System.Drawing.Point(769, 187);
            this.butHuy.Margin = new System.Windows.Forms.Padding(4);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(100, 28);
            this.butHuy.TabIndex = 55;
            this.butHuy.Text = "Hủy";
            this.butHuy.UseVisualStyleBackColor = false;
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // butSua
            // 
            this.butSua.BackColor = System.Drawing.SystemColors.HotTrack;
            this.butSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butSua.Location = new System.Drawing.Point(769, 135);
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
            this.butXoa.Location = new System.Drawing.Point(585, 187);
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
            this.butThem.Location = new System.Drawing.Point(585, 135);
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
            this.label4.Location = new System.Drawing.Point(257, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Số Lượng Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(249, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Mã Sản Phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(55, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mã Hoá Đơn Nhập:";
            // 
            // DanhMucHoaDon
            // 
            this.DanhMucHoaDon.AutoSize = true;
            this.DanhMucHoaDon.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DanhMucHoaDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhMucHoaDon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DanhMucHoaDon.Location = new System.Drawing.Point(431, 9);
            this.DanhMucHoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DanhMucHoaDon.Name = "DanhMucHoaDon";
            this.DanhMucHoaDon.Size = new System.Drawing.Size(191, 26);
            this.DanhMucHoaDon.TabIndex = 0;
            this.DanhMucHoaDon.Text = "NHẬP CHI TIẾT";
            // 
            // dgvNhapChiTiet
            // 
            this.dgvNhapChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapChiTiet.Location = new System.Drawing.Point(0, 290);
            this.dgvNhapChiTiet.Name = "dgvNhapChiTiet";
            this.dgvNhapChiTiet.RowHeadersWidth = 51;
            this.dgvNhapChiTiet.RowTemplate.Height = 24;
            this.dgvNhapChiTiet.Size = new System.Drawing.Size(1067, 267);
            this.dgvNhapChiTiet.TabIndex = 9;
            this.dgvNhapChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapChiTiet_CellClick);
            // 
            // NhapChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvNhapChiTiet);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhapChiTiet";
            this.Text = "NhapChiTiet";
            this.Load += new System.EventHandler(this.NhapChiTiet_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butHuy;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DanhMucHoaDon;
        private System.Windows.Forms.DataGridView dgvNhapChiTiet;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMaHDN;
        private System.Windows.Forms.ComboBox cbMaSP;
    }
}