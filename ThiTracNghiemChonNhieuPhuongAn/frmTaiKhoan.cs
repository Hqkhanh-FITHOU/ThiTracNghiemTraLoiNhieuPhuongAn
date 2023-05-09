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

namespace ThiTracNghiemChonNhieuPhuongAn
{
    public partial class frmTaiKhoan : Form
    {
        private string sTaikhoanID;
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        public frmTaiKhoan(string sTaikhoanID)
        {
            InitializeComponent();
            this.sTaikhoanID = sTaikhoanID;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            //Mở tính năng chỉnh sửa thông tin
            txtHoTen.Enabled = true;
            txtID.Enabled = true;
            dtNgaySinh.Enabled = true;
            radNam.Enabled = true;
            radNu.Enabled = true;

            //hiện nút Lưu và nút Hủy, ẩn nút cập nhật đi
            btnChinhSua.Visible = false;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //...
            // Xử lý sự kiện cập nhật thông tin tài khoản ở đây
            //...
            btnChinhSua.Visible = true;
            btnHuy.Visible = btnLuu.Visible = false;
            txtHoTen.Enabled = txtID.Enabled = dtNgaySinh.Enabled = radNam.Enabled = radNu.Enabled = false;
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            { 
                connection.Open();
                string sql_updateHoten = "UPDATE tblTaiKhoan SET sHoten = N'" + txtHoTen.Text + "' WHERE PK_sTaikhoanID = '" + sTaikhoanID + "'";
                SqlCommand cmd1 = new SqlCommand(sql_updateHoten,connection);
                cmd1.ExecuteNonQuery();

                string sql_updateNgaysinh = "UPDATE tblTaiKhoan SET dNgaysinh = '" + dtNgaySinh.Text + "' WHERE PK_sTaikhoanID = '" + sTaikhoanID + "'";
                
                SqlCommand cmd2 = new SqlCommand(sql_updateNgaysinh, connection);
                cmd2.ExecuteNonQuery();

                string sql_updateGioitinh = "UPDATE tblTaiKhoan SET sHoten = " + 0 + " WHERE PK_sTaikhoanID = '" + sTaikhoanID + "'";
                SqlCommand cmd3 = new SqlCommand(sql_updateGioitinh, connection);
                cmd3.ExecuteNonQuery();
                connection.Close();
                frmTaiKhoan_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnChinhSua.Visible = true;
            btnHuy.Visible = btnLuu.Visible = false;
            txtHoTen.Enabled = txtID.Enabled = dtNgaySinh.Enabled = radNam.Enabled = radNu.Enabled = false;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string query = "SELECT * FROM tblTaiKhoan WHERE PK_sTaikhoanID = '" + sTaikhoanID + "'";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable tb = new DataTable();
                adapter.Fill(tb);
                txtID.Text = tb.Rows[0]["PK_sTaikhoanID"].ToString();
                txtHoTen.Text = tb.Rows[0]["sHoten"].ToString();
                dtNgaySinh.Text = tb.Rows[0]["dNgaysinh"].ToString();
                if (tb.Rows[0]["bGioitinh"].Equals(true))
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                connection.Close();
            }
        }
    }
}
