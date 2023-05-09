using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiemChonNhieuPhuongAn
{
    public partial class frmDangNhap : Form
    {

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text.Equals(""))
            {
                MessageBox.Show("Chưa điền tên đăng nhập!");
            }
            else if (txtMatKhau.Text.Equals(""))
            {
                MessageBox.Show("Chưa điền tên mật khẩu!");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("PR_LayTaiKhoan", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@PK_sTaikhoanID", SqlDbType.NVarChar);
                    cmd.Parameters["@PK_sTaikhoanID"].Value = txtTenDangNhap.Text.Trim();
                    cmd.Parameters.AddWithValue("@sMatkhau", SqlDbType.NVarChar);
                    cmd.Parameters["@sMatkhau"].Value = txtMatKhau.Text;

                    int i = Convert.ToInt32(cmd.ExecuteScalar());

                    connection.Close();

                    if (i > 0 ) // Dang nhap thanh cong
                    {
                        if (Program.FindOpenedForm("frmTrangChinh") == null)
                        {
                            new frmTrangChinh(txtTenDangNhap.Text.Trim()).Show();
                        }
                        
                        Hide();
                        
                    }
                    else // Dang nhap khong thanh cong
                    {
                        MessageBox.Show(":Sai tên nhập hoặc mật khẩu", "Đăng nhập");
                    }
                }
            }

            
        }

        private void thoatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (Program.FindOpenedForm("frmTrangChinh") == null)
            {
                new frmTrangChinh(txtTenDangNhap.Text.Trim()).Show();
            }
        }


        
    }
}
