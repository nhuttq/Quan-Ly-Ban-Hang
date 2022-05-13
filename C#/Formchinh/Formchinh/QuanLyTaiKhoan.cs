using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Formchinh
{
    public partial class QuanLyTaiKhoan : Form
    {
        string sCon = "Data Source=LAPTOP-197P9JVU\\SQLEXPRESS01;Initial Catalog=BANHANG;Integrated Security=True";
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            // buoc 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            // buoc 2 - lay du lieu ve
            string sQuery = "exec pSelectALLTK";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "TAIKHOAN");
            dgvTaiKhoan.DataSource = ds.Tables["TAIKHOAN"];
            con.Close(); // buoc 3

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmGiaoDien f = new frmGiaoDien();
            f.ShowDialog();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            // buoc 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            // buoc 2

            string sTenDangNhap = txtTenDangNhap.Text;
            string sMatKhau = txtPassword.Text;
            string sQuery = "exec pThemTK @TenTK,@MatKhau";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@TenTK", sTenDangNhap);
            cmd.Parameters.AddWithValue("@MatKhau", sMatKhau);

            try
            {
                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Thêm tài khoản thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close(); //Buoc 3

        }

        private void butSua_Click(object sender, EventArgs e)
        {
            // buoc 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");

            }
            // buoc 2
            string sTenDangNhap = txtTenDangNhap.Text;
            string sMatKhau = txtPassword.Text;

            string sQuery = "exec pSuaTK @TenTK,@MatKhau";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@TenTK", sTenDangNhap);
            cmd.Parameters.AddWithValue("@MatKhau", sMatKhau);

            try
            {
                cmd.ExecuteNonQuery();
                 loaddata();
                MessageBox.Show("Cập nhật tài khoản thành công!");
            }
            catch
            {
                MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close(); //Buoc 3

        }

        private void butXoa_Click(object sender, EventArgs e)
        {

            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            { // buoc 1
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");

                }
                // buoc 2 
                string sTenDangNhap = txtTenDangNhap.Text;
                string sQuery = "exec pXoaTK @TenTK";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@TenTK", sTenDangNhap);

                try
                {
                    cmd.ExecuteNonQuery();
                    loaddata();
                    MessageBox.Show("Xoá thành công!");
                }
                catch
                {
                    MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close(); //Buoc 3

            }

        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenDangNhap.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["TenTK"].Value.ToString();
            txtPassword.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();

        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
            txtPassword.Text = "";
            loaddata();

        }
    }
}
