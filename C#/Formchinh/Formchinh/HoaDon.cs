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
    public partial class HoaDon : Form
    {
        string sCon = "Data Source=LAPTOP-197P9JVU\\SQLEXPRESS01;Initial Catalog=BANHANG;Integrated Security=True";
        public HoaDon()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xay ra loi trong qua trinh ket noi DB");
            }

            string sQuery = "exec pSelectHDB";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "BAN");
            dgvHoaDon.DataSource = ds.Tables["BAN"];

           
          
            string sQuery1 = "select MaKH, TenKH from KHACHHANG";
            SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1, "KHACHHANG");
            cbMaKH.DataSource = ds1.Tables["KHACHHANG"];
            cbMaKH.ValueMember = "MaKH";
            cbMaKH.DisplayMember = "TenKH";


            con.Close();
            txtMaHDB.Enabled = false;
            txtKhuyenMai.Enabled = false;
            txtTongTien.Enabled = false;
            txtPhaiTra.Enabled = false;
        }
     

        private void label5_Click(object sender, EventArgs e)
        {
            HoaDonChiTiet f = new HoaDonChiTiet();
            this.Hide();
            f.ShowDialog();
            loaddata();
            this.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

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
                if ( cbMaKH.Text == ""|| dtpkNgayBan.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông Báo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    SqlConnection conn = new SqlConnection(sCon);
                    conn.Open();
                    var cmd = new SqlCommand("pThemHDB", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = cbMaKH.SelectedValue;
                    cmd.Parameters.Add("@NgayBan", SqlDbType.DateTime).Value = dtpkNgayBan.Text;
                    
                    
                    cmd.ExecuteNonQuery();
                    loaddata();
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
               
                string sQuery = "exec pXoaHDB @MaHDB";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaHDB", txtMaHDB.Text);

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

            var cmd = new SqlCommand("pSuaHDB", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHDB", SqlDbType.NVarChar).Value = txtMaHDB.Text;
            cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = cbMaKH.SelectedValue;
            cmd.Parameters.Add("@NgayBan", SqlDbType.DateTime).Value = dtpkNgayBan.Text;
            cmd.Parameters.Add("@KhuyenMai", SqlDbType.Int).Value = txtKhuyenMai.Text;
            cmd.Parameters.Add("@PhaiTra", SqlDbType.Int).Value = txtPhaiTra.Text;

            try
            {
                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Sửa thành công", "Thông báo!");
            }

            catch
            {
                MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();

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
                catch 
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");

                }
                //buoc 2
                var cmd = new SqlCommand("pTkHDB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@text", SqlDbType.NVarChar).Value = txtTimKiem.Text;
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
                dgvHoaDon.DataSource = ds.Tables["TK"];

                con.Close();
            }

            }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            txtMaHDB.Text = "";
            cbMaKH.Text = "";
            dtpkNgayBan.Text = "";
            txtTongTien.Text = "";
            txtKhuyenMai.Text = "";
            txtPhaiTra.Text = "";
            txtTimKiem.Text = "";
            loaddata();
        }

       

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaHDB.Text = dgvHoaDon.Rows[e.RowIndex].Cells["MaHDB"].Value.ToString();
            cbMaKH.Text = dgvHoaDon.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
            dtpkNgayBan.Value = Convert.ToDateTime(dgvHoaDon.Rows[e.RowIndex].Cells["ThoiGian"].Value);
            txtTongTien.Text = dgvHoaDon.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString();
            txtKhuyenMai.Text = dgvHoaDon.Rows[e.RowIndex].Cells["KhuyenMai"].Value.ToString();
            txtPhaiTra.Text = dgvHoaDon.Rows[e.RowIndex].Cells["TongTien"].Value.ToString();

            txtKhuyenMai.Enabled = true;
            txtTongTien.Enabled =true;
            txtPhaiTra.Enabled = true;

        }

        private void txtKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            double tt, km, pt;
            tt = Convert.ToDouble(txtTongTien.Text);
            if (txtKhuyenMai.Text == "")
                km = 0;
            else
                km = Convert.ToDouble(txtKhuyenMai.Text);

          
            pt = tt - km;
            txtPhaiTra.Text = pt.ToString();
        }
    }
}
