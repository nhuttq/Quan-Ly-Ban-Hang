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
  
    public partial class NhaCungCap : Form
    {
        string sCon = "Data Source=LAPTOP-197P9JVU\\SQLEXPRESS01;Initial Catalog=BANHANG;Integrated Security=True";
        public NhaCungCap()
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
            string sQuery = "exec pSelectALLNCC";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "NHACUNGCAP");
            dgvNhaCungCap.DataSource = ds.Tables["NHACUNGCAP"];
            con.Close();

            txtMaNCC.Enabled = false;
        }
        private void NhaCungCap_Load(object sender, EventArgs e)
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
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB ");
                return;
            }
            try
            {
                if (txtTenNCC.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông Báo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    SqlConnection conn = new SqlConnection(sCon);
                    conn.Open();
                    var cmd = new SqlCommand("pThemNCC", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = txtTenNCC.Text;
                    cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar).Value = txtDienThoai.Text;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;

                    cmd.ExecuteNonQuery();
                    Loaddata();
                    conn.Close();
                    MessageBox.Show("Thêm hóa đơn mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }

            var cmd = new SqlCommand("pSuaNCC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar).Value = txtMaNCC.Text;
            cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = txtTenNCC.Text;
            cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar).Value = txtDienThoai.Text;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;

            try
            {
                cmd.ExecuteNonQuery();
                Loaddata();
                MessageBox.Show("Sửa thành công", "Thông báo!");
            }

            catch
            {
                MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
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
                // buoc 2 lay gia tri

                string sQuery = "exec pXoaNCC @MaNCC";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    Loaddata();

                    MessageBox.Show("Xoá thành công!");
                }
                catch
                {
                    MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close(); //Buoc 3

            }
        }

        private void butTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                MessageBox.Show("Vui lòng nhập để tìm kiếm!");
            else
            {
                //buoc 1
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");

                }
                //buoc 2
                var cmd = new SqlCommand("pTimKiemNCC", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = txtTimKiem.Text;
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                try
                {
                    adapter.Fill(ds, "TK");
                }
                catch
                {
                    MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvNhaCungCap.DataSource = ds.Tables["TK"];

                con.Close();
            }
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells["TenNCC"].Value.ToString();
            txtDienThoai.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
            txtDiaChi.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            
        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            frmGiaoDien f = new frmGiaoDien();
            f.ShowDialog();
            this.Hide();
          
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
