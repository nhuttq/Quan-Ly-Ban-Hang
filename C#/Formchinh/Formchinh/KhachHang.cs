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
    public partial class KhachHang : Form
    {
        string sCon = "Data Source=LAPTOP-197P9JVU\\SQLEXPRESS01;Initial Catalog=BANHANG;Integrated Security=True";
        public KhachHang()
        {
            InitializeComponent();
        }

        private void Loaddata()
        {

            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu!!");
            }
            string sQuery = "exec pSelectALLKH";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "KHACHHANG");
            dgvKhachHang.DataSource = ds.Tables["KHACHHANG"];
            con.Close();

            txtMaKH.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmGiaoDien f = new frmGiaoDien();
            f.ShowDialog();
            this.Hide();

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
            }
            try
            {
               
                string sQuery = "exec pThemKH @TenKH, @DiaChi, @DienThoai";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);
                cmd.ExecuteNonQuery();
                Loaddata();
                MessageBox.Show("Thêm mới thành công.");
            }
            catch (Exception)
            {
                MessageBox.Show("bạn chưa nhập đủ thông tin.");
            }

            con.Close();

        }

        private void butSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
            }

            string sQuery = "exec pSuaKH @MaKH,@TenKH,@DiaChi,@DienThoai";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
            cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);
            try
            {
                cmd.ExecuteNonQuery();
                Loaddata();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thay đổi dữ liệu!!");
            }

            con.Close();

        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn thật sự muốn xóa??", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {//step 1
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
                }
                try
                {
                    string sQuery = "exec pXoaKH @MaKH";
                    SqlCommand cmd = new SqlCommand(sQuery, con);
                    cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    cmd.ExecuteNonQuery();
                    Loaddata();
                    MessageBox.Show("Xóa thành công.");
                }
                catch
                {
                    MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();

            }
        }

        private void butTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch 
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu!!");
            }
            var cmd = new SqlCommand("pTimKiemKH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = txtTimKiem.Text;
            cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds, "KHACHHANG");
            }
            catch
            {
                MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvKhachHang.DataSource = ds.Tables["KHACHHANG"];
            con.Close();

        }

      

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            txtDienThoai.Text = dgvKhachHang.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();

        }

        private void butHuy_Click_1(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtDienThoai.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtTimKiem.Text = "";
            Loaddata();
        }
    }
}

