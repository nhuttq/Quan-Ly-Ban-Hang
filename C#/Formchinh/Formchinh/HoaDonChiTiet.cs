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
    public partial class HoaDonChiTiet : Form
    {
        string sCon = "Data Source=LAPTOP-197P9JVU\\SQLEXPRESS01;Initial Catalog=BANHANG;Integrated Security=True";
        public HoaDonChiTiet()
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

            string sQuery = "exec pSelectCTHDB";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "BANCHITIET");
            dgvChiTietHoaDon.DataSource = ds.Tables["BANCHITIET"];
            

            string sQuery1 = "select MaHDB from BAN";
            SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1, "BAN");
            cbMaHDB.DataSource = ds1.Tables["BAN"];
            cbMaHDB.ValueMember = "MaHDB";
            cbMaHDB.DisplayMember = "MaHDB";

            string sQuery2 = "select MaSP, TenSP from HANG";
            SqlDataAdapter adapter2 = new SqlDataAdapter(sQuery2, con);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2, "HANG");
            cbMaSP.DataSource = ds2.Tables["HANG"];
            cbMaSP.ValueMember = "MaSp";
            cbMaSP.DisplayMember = "TenSP";

            con.Close();
            
        }
   
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            HoaDon f = new HoaDon();
            f.ShowDialog();
            this.Hide();
            
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
                if (cbMaHDB.SelectedValue == "" || cbMaSP.SelectedValue == "" || txtSoLuong.Text == "") 
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông Báo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    
                    var cmd = new SqlCommand("pThemCTHD", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaHDB", SqlDbType.VarChar).Value = cbMaHDB.SelectedValue;
                    cmd.Parameters.Add("@MaSP", SqlDbType.VarChar).Value = cbMaSP.SelectedValue;
                    cmd.Parameters.Add("@SoLuongBan", SqlDbType.Int).Value = Convert.ToInt32(txtSoLuong.Text);
                    cmd.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = txtThanhTien.Text;
                    cmd.ExecuteNonQuery();
                    loaddata();
                    con.Close();
                    MessageBox.Show("Thêm hóa đơn mới thành công !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
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

            var cmd = new SqlCommand("pSuaCTHDB", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHDB", SqlDbType.NVarChar).Value = cbMaHDB.SelectedValue;
            cmd.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = cbMaSP.SelectedValue;
            cmd.Parameters.Add("@SoLuongBan", SqlDbType.Int).Value = txtSoLuong.Text;
            cmd.Parameters.Add("@ThanhTien", SqlDbType.Int).Value = txtThanhTien.Text;

            try
            {
                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Cập nhật thành công ", "Thông báo");
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
                var cmd = new SqlCommand("pXoaCTHDB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHDB", SqlDbType.VarChar).Value = cbMaHDB.SelectedValue;
                cmd.Parameters.Add("@MaSP", SqlDbType.VarChar).Value = cbMaSP.SelectedValue;
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
                    MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //buoc 2
                var cmd = new SqlCommand("pTimKiemCTHDB", con);
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
                dgvChiTietHoaDon.DataSource = ds.Tables["TK"];
                con.Close();
            }

        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaHDB.SelectedValue = dgvChiTietHoaDon.Rows[e.RowIndex].Cells["MaHDB"].Value.ToString();
            cbMaSP.Text = dgvChiTietHoaDon.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
            txtSoLuong.Text = dgvChiTietHoaDon.Rows[e.RowIndex].Cells["SoLuongBan"].Value.ToString();
            txtDonGia.Text = dgvChiTietHoaDon.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
            txtThanhTien.Text = dgvChiTietHoaDon.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString();
        }

        private void HoaDonChiTiet_Load(object sender, EventArgs e)
        {
            loaddata();
        }

     

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();

        }

        private void cbMaSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            try
            {
                
                var cmd = new SqlCommand("pDonGia", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaSP", SqlDbType.VarChar).Value = cbMaSP.SelectedValue;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds2 = new DataSet();
                adapter.Fill(ds2, "BANCHITIET");

                txtDonGia.Text = ds2.Tables["BANCHITIET"].Rows[0][0].ToString();
            }

            catch
            {
                MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            cbMaHDB.SelectedValue = "";
            cbMaSP.SelectedValue = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
            txtTimKiem.Text = "";
            loaddata();
        }
    }
}
