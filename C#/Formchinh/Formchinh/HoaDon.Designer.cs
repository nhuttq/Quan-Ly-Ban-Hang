
namespace Formchinh
{
    partial class HoaDon
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
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.dtpkNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhaiTra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butHuy = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.butThem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butTimKiem = new System.Windows.Forms.Button();
            this.butHoaDonChiTiet = new System.Windows.Forms.Button();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.KH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DanhMucHoaDon = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.BackgroundImage = global::Formchinh.Properties.Resources.background_dep_va_tinh_te_840x473;
            this.panel2.Controls.Add(this.cbMaKH);
            this.panel2.Controls.Add(this.dtpkNgayBan);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtKhuyenMai);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPhaiTra);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.butHuy);
            this.panel2.Controls.Add(this.butSua);
            this.panel2.Controls.Add(this.butXoa);
            this.panel2.Controls.Add(this.butThem);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.butTimKiem);
            this.panel2.Controls.Add(this.butHoaDonChiTiet);
            this.panel2.Controls.Add(this.txtMaHDB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.KH);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.DanhMucHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 265);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbMaKH
            // 
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(180, 86);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(166, 24);
            this.cbMaKH.TabIndex = 90;
            // 
            // dtpkNgayBan
            // 
            this.dtpkNgayBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpkNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayBan.Location = new System.Drawing.Point(353, 86);
            this.dtpkNgayBan.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkNgayBan.MaxDate = new System.DateTime(2021, 11, 23, 0, 0, 0, 0);
            this.dtpkNgayBan.Name = "dtpkNgayBan";
            this.dtpkNgayBan.Size = new System.Drawing.Size(131, 27);
            this.dtpkNgayBan.TabIndex = 89;
            this.dtpkNgayBan.Value = new System.DateTime(2021, 11, 23, 0, 0, 0, 0);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(68, 165);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(115, 22);
            this.txtTongTien.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "Tổng tiền:";
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Location = new System.Drawing.Point(192, 165);
            this.txtKhuyenMai.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(115, 22);
            this.txtKhuyenMai.TabIndex = 68;
            this.txtKhuyenMai.TextChanged += new System.EventHandler(this.txtKhuyenMai_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 67;
            this.label5.Text = "Khuyến mãi:";
            // 
            // txtPhaiTra
            // 
            this.txtPhaiTra.Location = new System.Drawing.Point(321, 165);
            this.txtPhaiTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhaiTra.Name = "txtPhaiTra";
            this.txtPhaiTra.Size = new System.Drawing.Size(131, 22);
            this.txtPhaiTra.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "Phải trả:";
            // 
            // butHuy
            // 
            this.butHuy.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.butHuy.Location = new System.Drawing.Point(963, 143);
            this.butHuy.Margin = new System.Windows.Forms.Padding(4);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(100, 28);
            this.butHuy.TabIndex = 63;
            this.butHuy.Text = "Hủy";
            this.butHuy.UseVisualStyleBackColor = false;
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // butSua
            // 
            this.butSua.BackColor = System.Drawing.SystemColors.HotTrack;
            this.butSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butSua.Location = new System.Drawing.Point(695, 143);
            this.butSua.Margin = new System.Windows.Forms.Padding(4);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(100, 28);
            this.butSua.TabIndex = 62;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = false;
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butXoa
            // 
            this.butXoa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.butXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butXoa.Location = new System.Drawing.Point(821, 143);
            this.butXoa.Margin = new System.Windows.Forms.Padding(4);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(100, 28);
            this.butXoa.TabIndex = 61;
            this.butXoa.Text = "Xoá";
            this.butXoa.UseVisualStyleBackColor = false;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butThem
            // 
            this.butThem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.butThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butThem.Location = new System.Drawing.Point(568, 143);
            this.butThem.Margin = new System.Windows.Forms.Padding(4);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(100, 28);
            this.butThem.TabIndex = 60;
            this.butThem.Text = "Thêm";
            this.butThem.UseVisualStyleBackColor = false;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(664, 73);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(280, 22);
            this.txtTimKiem.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(556, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Nhập từ khoá:";
            // 
            // butTimKiem
            // 
            this.butTimKiem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.butTimKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butTimKiem.Location = new System.Drawing.Point(963, 70);
            this.butTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.butTimKiem.Name = "butTimKiem";
            this.butTimKiem.Size = new System.Drawing.Size(97, 28);
            this.butTimKiem.TabIndex = 57;
            this.butTimKiem.Text = "Tìm kiếm";
            this.butTimKiem.UseVisualStyleBackColor = false;
            this.butTimKiem.Click += new System.EventHandler(this.butTimKiem_Click);
            // 
            // butHoaDonChiTiet
            // 
            this.butHoaDonChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHoaDonChiTiet.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.butHoaDonChiTiet.Location = new System.Drawing.Point(644, 187);
            this.butHoaDonChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.butHoaDonChiTiet.Name = "butHoaDonChiTiet";
            this.butHoaDonChiTiet.Size = new System.Drawing.Size(344, 49);
            this.butHoaDonChiTiet.TabIndex = 40;
            this.butHoaDonChiTiet.Text = "Hoá đơn chi tiết";
            this.butHoaDonChiTiet.UseVisualStyleBackColor = true;
            this.butHoaDonChiTiet.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Location = new System.Drawing.Point(56, 86);
            this.txtMaHDB.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(115, 22);
            this.txtMaHDB.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Thời gian:";
            // 
            // KH
            // 
            this.KH.AutoSize = true;
            this.KH.Location = new System.Drawing.Point(200, 66);
            this.KH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KH.Name = "KH";
            this.KH.Size = new System.Drawing.Size(84, 17);
            this.KH.TabIndex = 31;
            this.KH.Text = "Khách hàng";
            this.KH.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã HĐB:";
            // 
            // DanhMucHoaDon
            // 
            this.DanhMucHoaDon.AutoSize = true;
            this.DanhMucHoaDon.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DanhMucHoaDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhMucHoaDon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DanhMucHoaDon.Location = new System.Drawing.Point(477, 9);
            this.DanhMucHoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DanhMucHoaDon.Name = "DanhMucHoaDon";
            this.DanhMucHoaDon.Size = new System.Drawing.Size(125, 26);
            this.DanhMucHoaDon.TabIndex = 0;
            this.DanhMucHoaDon.Text = "HÓA ĐƠN";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(476, 269);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 26);
            this.label14.TabIndex = 3;
            this.label14.Text = "HOÁ ĐƠN";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 297);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(1103, 248);
            this.dgvHoaDon.TabIndex = 4;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 545);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DanhMucHoaDon;
        private System.Windows.Forms.Button butHoaDonChiTiet;
        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label KH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butHuy;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butTimKiem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhaiTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpkNgayBan;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.ComboBox cbMaKH;
    }
}