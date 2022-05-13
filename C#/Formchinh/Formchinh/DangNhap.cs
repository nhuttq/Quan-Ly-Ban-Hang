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
    public partial class DangNhap : Form
    {
        string sCon = "Data Source=LAPTOP-197P9JVU\\SQLEXPRESS01;Initial Catalog=BANHANG;Integrated Security=True";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
          
        }

        private void DangNhapTaiKhoan_Click(object sender, EventArgs e)
        {

        }

		private void lbltendangnhap_Click(object sender, EventArgs e)
		{

		}

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            if (txtTenDangNhap.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    con.Open();
                    var cmd = new SqlCommand("pDangNhap", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TenTK", SqlDbType.VarChar).Value = txtTenDangNhap.Text;
                    cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = txtPassword.Text;
                    var data = cmd.ExecuteReader();
                    if (data.Read() == true)
                    {
                        frmGiaoDien f = new frmGiaoDien();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();

                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
