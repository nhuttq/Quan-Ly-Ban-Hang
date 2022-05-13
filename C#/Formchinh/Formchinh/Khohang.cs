using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Formchinh
{
    public partial class KhoHang : Form
    {
        string sCon = "Data Source=LAPTOP-197P9JVU\\SQLEXPRESS01;Initial Catalog=BANHANG;Integrated Security=True";

        public KhoHang()
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

            string sQuery = "exec pSelectHang";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HANG");
            dgvHang.DataSource = ds.Tables["HANG"];
            con.Close();

            txtMaSP.Enabled = false;


        }

       
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            frmGiaoDien f = new frmGiaoDien();
            f.ShowDialog();
            this.Hide();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhapChiTiet f = new NhapChiTiet();
            this.Hide();
            f.ShowDialog();
            loaddata();
            loaddata_nhap();
            this.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
         
        }

        private void butTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {

                if (txtTimKiem.Text != "")
                {
                    con.Open();
                    var cmd = new SqlCommand("pTimKiemHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = txtTimKiem.Text;
                    cmd.ExecuteNonQuery();
                    var dap = new SqlDataAdapter(cmd);
                    var table = new DataTable();
                    dap.Fill(table);
                    con.Close();
                    dgvHang.DataSource = table;

                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ dữ liệu tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void butThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                if (txtTenSP.Text != "" && txtDonGia.Text != "" && txtSoLuong.Text != "")
                {
                    con.Open();
                    var cmd = new SqlCommand("pThemHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = txtTenSP.Text;
                    cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = Convert.ToInt32(txtSoLuong.Text);
                    cmd.Parameters.Add("@DonGia", SqlDbType.Int).Value = Convert.ToInt32(txtDonGia.Text);
                    cmd.Parameters.Add("@DonViTinh", SqlDbType.NVarChar).Value = txtDonViTinh.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    loaddata();
                    MessageBox.Show("Thêm sản phẩm mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin sản phẩm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void butSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                if (txtMaSP.Text != "" && txtTenSP.Text != "" && txtDonGia.Text != "" && txtSoLuong.Text != "")
                {
                    con.Open();
                    var cmd = new SqlCommand("pSuaHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaSP", SqlDbType.VarChar).Value = txtMaSP.Text;
                    cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = txtTenSP.Text;
                    cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = Convert.ToInt32(txtSoLuong.Text);
                    cmd.Parameters.Add("@DonGia", SqlDbType.Int).Value = Convert.ToInt32(txtDonGia.Text);
                    cmd.Parameters.Add("@DonViTinh", SqlDbType.NVarChar).Value = txtDonViTinh.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Sửa thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();


                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

            private void butXoa_Click(object sender, EventArgs e)
        {
            string name = txtTenSP.Text;
            try
            {
                SqlConnection con = new SqlConnection(sCon);
                if (txtSoLuong.Text == "0" && MessageBox.Show(string.Format("Bạn có muốn xóa sản phẩm {0} ", name), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    con.Open();
                    var cmd = new SqlCommand("pXoaHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaSP", SqlDbType.VarChar).Value = txtMaSP.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Xóa sản phẩm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại !\nBạn chỉ được xóa khi bán hết sản phẩm này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void KhoHang_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddata_nhap();
          
        }

        private void button13_Click(object sender, EventArgs e)
        {
              try
            {
                if (txtTimKiem_Nhap.Text == "")
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ dữ liệu tìm kiếm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    SqlConnection con = new SqlConnection(sCon);
                    con.Open();
                    var cmd = new SqlCommand("pTimKiemHDN", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = txtTimKiem_Nhap.Text;
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
                    dgvNhap.DataSource = ds.Tables["TK"];

                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dgvHang.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
            txtTenSP.Text = dgvHang.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
            txtSoLuong.Text = dgvHang.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            txtDonGia.Text = dgvHang.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
            txtDonViTinh.Text = dgvHang.Rows[e.RowIndex].Cells["DonViTinh"].Value.ToString();

        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSoLuong.Text = "";
            txtDonViTinh.Text = "";
            txtDonGia.Text = "";
            txtTimKiem.Text = "";
            loaddata_nhap();
        }

        private void loaddata_nhap()
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

            string sQuery = "exec pSelectAllNhap";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "NHAP");
            dgvNhap.DataSource = ds.Tables["NHAP"];

            string sQuery1 = "select MaNCC, TenNCC from NHACUNGCAP";
            SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1, "NHACUNGCAP");
            cbMaNCC.DataSource = ds1.Tables["NHACUNGCAP"];
            cbMaNCC.ValueMember = "MaNCC";
            cbMaNCC.DisplayMember = "TenNCC"; 

            con.Close();

            txtMaHDN.Enabled = false;
            txtTongTien.Enabled = false;
            txtThue.Enabled = false;
            txtChietKhau.Enabled = false;
            txtPhaiTra.Enabled = false;

           
        }
        private void butThem_Nhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);

            try
            {
                if (cbMaNCC.Text == "" || dtpkNgayNhap.Text == "" )
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con.Open();
                    var cmd = new SqlCommand("pThemHDN", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar).Value = cbMaNCC.SelectedValue;
                    cmd.Parameters.Add("@ThoiGian", SqlDbType.NVarChar).Value = dtpkNgayNhap.Text;

                    cmd.ExecuteNonQuery();
                    loaddata_nhap();
                    con.Close();
                    MessageBox.Show("Thêm mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                }
            }
            catch
            {
                MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void butSua_Nhap_Click(object sender, EventArgs e)
        {

            try
            {
                if (cbMaNCC.SelectedValue == "" || dtpkNgayNhap.Text == "" )
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlConnection con = new SqlConnection(sCon);
                    con.Open();
                    var cmd = new SqlCommand("pSuaHDN", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaHDN", SqlDbType.VarChar).Value = txtMaHDN.Text;
                    cmd.Parameters.Add("@MaNCC", SqlDbType.NVarChar).Value = cbMaNCC.SelectedValue;
                    cmd.Parameters.Add("@ThoiGian", SqlDbType.DateTime).Value = dtpkNgayNhap.Text;
                    cmd.Parameters.Add("@Thue", SqlDbType.Int).Value = Convert.ToInt32(txtThue.Text);
                    cmd.Parameters.Add("@ChietKhau", SqlDbType.Int).Value = Convert.ToInt32(txtChietKhau.Text);
                    cmd.Parameters.Add("@ThanhToan", SqlDbType.Int).Value = Convert.ToInt32(txtPhaiTra.Text);

                    cmd.ExecuteNonQuery();
                    loaddata_nhap();
                    con.Close();
                    MessageBox.Show("Sửa thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch
            {
                MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void butXoa_Nhap_Click(object sender, EventArgs e)
        {
           

        }

        private void butHuy_Nhap_Click(object sender, EventArgs e)
        {
            txtMaHDN.Text = "";
            txtThue.Text  = "";
            txtChietKhau.Text  = "";
            cbMaNCC.SelectedValue = "";
            txtTongTien.Text  = "";
            txtPhaiTra.Text = "";
            loaddata_nhap();
        }

        private void dgvNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                txtMaHDN.Text = dgvNhap.Rows[e.RowIndex].Cells["MaHDN"].Value.ToString();
                cbMaNCC.Text = dgvNhap.Rows[e.RowIndex].Cells["TenNCC"].Value.ToString();
                dtpkNgayNhap.Value = Convert.ToDateTime(dgvNhap.Rows[e.RowIndex].Cells["ThoiGian"].Value);
                txtTongTien.Text = dgvNhap.Rows[e.RowIndex].Cells["TongTien"].Value.ToString();
                txtThue.Text = dgvNhap.Rows[e.RowIndex].Cells["Thue"].FormattedValue.ToString();
                txtChietKhau.Text = dgvNhap.Rows[e.RowIndex].Cells["ChietKhau"].Value.ToString();
                txtPhaiTra.Text = dgvNhap.Rows[e.RowIndex].Cells["ThanhToan"].Value.ToString();

                txtThue.Enabled = true;
                txtChietKhau.Enabled = true;

        }

        private void butXoa_Nhap_Click_1(object sender, EventArgs e)
        {
            string name = txtMaHDN.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa hóa đơn {0} ", name), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(sCon);
                con.Open();
                SqlCommand cmd = new SqlCommand("pXoaHDN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHDN", SqlDbType.VarChar).Value = txtMaHDN.Text;
                cmd.ExecuteNonQuery();
                loaddata_nhap();
                con.Close();
                MessageBox.Show("Xóa hóa đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
                con.Close();
            }
            else
            {
                MessageBox.Show("Xóa hóa đơn thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtThue_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
            
            double tt, th, ck, pt;
            
            tt = Convert.ToDouble(txtTongTien.Text);
            th = tt * 0.1;
            txtThue.Text = th.ToString();

            if (txtChietKhau.Text == "")
                ck = 0;
            else
                ck = Convert.ToDouble(txtChietKhau.Text);

            pt = tt + th - ck;
            txtPhaiTra.Text = pt.ToString();
        }
    }
    
}
