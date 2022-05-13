using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formchinh
{
    public partial class frmGiaoDien : Form
    {
        private string title;
        private string txt;

        public frmGiaoDien()
        {
            InitializeComponent();
        }

        public frmGiaoDien(string title, string txt)
        {
            this.title = title;
            this.txt = txt;
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan f = new QuanLyTaiKhoan();
            f.Show();
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
             KhoHang f = new KhoHang();
             f.Show();
        }

		private void frmGiaoDien_Load(object sender, EventArgs e)
		{

		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            this.Hide();
            f.Show(); 
            
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            f.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon f = new HoaDon();
            f.Show();
        }

        private void butChiTietHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonChiTiet f = new HoaDonChiTiet();
            f.Show();
        }

        private void butNhaCungCap_Click(object sender, EventArgs e)
        {
            NhaCungCap f = new NhaCungCap();
            f.Show();
        }
    }
}
