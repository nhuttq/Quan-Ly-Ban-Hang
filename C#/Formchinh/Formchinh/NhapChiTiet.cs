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
    public partial class NhapChiTiet : Form
    {
        string sCon = "Data Source=LAPTOP-197P9JVU\\SQLEXPRESS01;Initial Catalog=BANHANG;Integrated Security=True";
        public NhapChiTiet()
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

            string sQuery = "exec pSelectAllCTN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "CHITIETNHAP");
            dgvNhapChiTiet.DataSource = ds.Tables["CHITIETNHAP"];


            string sQuery1 = "select MaHDN from NHAP";
            SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1, "NHAP");
            cbMaHDN.DataSource = ds1.Tables["NHAP"];
            cbMaHDN.ValueMember = "MaHDN";
            cbMaHDN.DisplayMember = "MaHDN";

            string sQuery2 = "select MaSP, TenSP from HANG";
            SqlDataAdapter adapter2 = new SqlDataAdapter(sQuery2, con);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2, "HANG");
            cbMaSP.DataSource = ds2.Tables["HANG"];
            cbMaSP.ValueMember = "MaSP";
            cbMaSP.DisplayMember = "TenSP";

            con.Close();
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            KhoHang f = new KhoHang();
            f.ShowDialog();
            this.Hide();
        }

        private void NhapChiTiet_Load(object sender, EventArgs e)
        {
            loaddata();
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
                if (cbMaHDN.SelectedValue == "" || cbMaSP.SelectedValue == "" || txtSoLuongNhap.Text == "" || txtDonGiaNhap.Text == "" || txtThanhTien.Text == "")
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var cmd = new SqlCommand("PThemCTN", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaHDN", SqlDbType.NVarChar).Value = cbMaHDN.SelectedValue;
                    cmd.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = cbMaSP.SelectedValue;
                    cmd.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = txtSoLuongNhap.Text;
                    cmd.Parameters.Add("@ThanhTien", SqlDbType.Int).Value = txtThanhTien.Text;
                    cmd.Parameters.Add("@DonGiaNhap", SqlDbType.Int).Value = txtDonGiaNhap.Text;
                    cmd.ExecuteNonQuery();
                    loaddata();
                    
                    MessageBox.Show("Thêm chi tiết nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
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
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB ");
                return;
            }
            try
            {
                if (cbMaHDN.SelectedValue == "" || cbMaSP.SelectedValue == ""||  txtSoLuongNhap.Text == "" || txtDonGiaNhap.Text == "" || txtThanhTien.Text == "")
                {

                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var cmd = new SqlCommand("pSuaCTN", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaHDN", SqlDbType.NVarChar).Value = cbMaHDN.SelectedValue;
                    cmd.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = cbMaSP.SelectedValue;
                    cmd.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = txtSoLuongNhap.Text;
                    cmd.Parameters.Add("@ThanhTien", SqlDbType.Int).Value = txtThanhTien.Text;
                    cmd.Parameters.Add("@DonGiaNhap", SqlDbType.Int).Value = txtDonGiaNhap.Text;
                    cmd.ExecuteNonQuery();
                    loaddata();
                    con.Close();
                    MessageBox.Show("Sửa thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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
                DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo", MessageBoxButtons.OKCancel);
                if (ret == DialogResult.OK)
                {
                    
                    var cmd = new SqlCommand("pXoaCTN", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaHDN", SqlDbType.NVarChar).Value = cbMaHDN.SelectedValue;
                    cmd.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = cbMaSP.SelectedValue;
                    cmd.ExecuteNonQuery();
                    loaddata();
                    con.Close();
                    MessageBox.Show("Xóa hóa đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();

        }

        private void butTimKiem_Click(object sender, EventArgs e)
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
                if (txtTimKiem.Text == "")
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ dữ liệu tìm kiếm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var cmd = new SqlCommand("pTimKiemCTN", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = txtTimKiem.Text;
                    cmd.ExecuteNonQuery();
                    var dap = new SqlDataAdapter(cmd);
                    var table = new DataTable();
                    dap.Fill(table);
                    con.Close();
                    dgvNhapChiTiet.DataSource = table;
                    
                }
            }
            catch
            {
                MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        

        private void butHuy_Click(object sender, EventArgs e)
        {
            cbMaHDN.SelectedValue = "";
            cbMaSP.SelectedValue = "";
            txtSoLuongNhap.Text = "";
            txtDonGiaNhap.Text = "";
            txtThanhTien.Text = "";
            txtTimKiem.Text = "";
            loaddata();
        }

        private void dgvNhapChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaHDN.SelectedValue = dgvNhapChiTiet.Rows[e.RowIndex].Cells["MaHDN"].Value.ToString();
            cbMaSP.Text = dgvNhapChiTiet.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
            txtSoLuongNhap.Text = dgvNhapChiTiet.Rows[e.RowIndex].Cells["SoLuongNhap"].Value.ToString();
            txtThanhTien.Text = dgvNhapChiTiet.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString();
            txtDonGiaNhap.Text = dgvNhapChiTiet.Rows[e.RowIndex].Cells["DonGiaNhap"].Value.ToString();




        }

        private void txtSoLuongNhap_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoLuongNhap.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuongNhap.Text);

            if (txtDonGiaNhap.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaNhap.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
