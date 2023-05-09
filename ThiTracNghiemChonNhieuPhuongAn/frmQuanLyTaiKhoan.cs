using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiemChonNhieuPhuongAn
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_ThiTracNghiemDataSet.tblQuyenHan' table. You can move, or remove it, as needed.
            //this.tblQuyenHanTableAdapter.Fill(this.db_ThiTracNghiemDataSet.tblQuyenHan);



            HienTatCaTaiKhoan();
        }

        private void HienTatCaTaiKhoan()
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("PR_getDanhSachTaiKhoan", connection);

                DataTable tb = new DataTable();

                adapter.Fill(tb);

                connection.Close();

                dvTaiKhoan.DataSource = tb;
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dvTaiKhoan.CurrentRow.Index;
            txtMaTaiKhoan.Text = dvTaiKhoan.Rows[i].Cells["PK_sTaikhoanID"].Value.ToString();
            txtHoTen.Text = dvTaiKhoan.Rows[i].Cells["sHoten"].Value.ToString();
            dtNgaySinh.Text = dvTaiKhoan.Rows[i].Cells["dNgaysinh"].Value.ToString();
            if (dvTaiKhoan.Rows[i].Cells[3].Value.Equals(true))
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }

            string permission = cbQuyenHan.Text = dvTaiKhoan.Rows[i].Cells["sQuyenID"].Value.ToString();
            if (permission.Equals("AD"))
            {
                cbQuyenHan.Text = "Quản trị";
            }else if (permission.Equals("HV"))
            {
                cbQuyenHan.Text = "Học viên";
            }
            else
            {
                cbQuyenHan.Text = "Giám thị";
            }
            txtMatKhau.Text = dvTaiKhoan.Rows[i].Cells["sMatkhau"].Value.ToString();
            
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if(btnSua.Text.Equals("Bật chỉnh sửa"))
            {
                //...Bật chỉnh sửa
                btnSua.Text = "Lưu";
                btnHuySua.Visible = true;
                txtMaTaiKhoan.ReadOnly = true;
                txtMaTaiKhoan.Enabled = true;
                txtHoTen.Enabled = true;
                dtNgaySinh.Enabled = true;
                radNam.Enabled = true;
                radNu.Enabled = true;
                cbQuyenHan.Enabled = true;
                txtMatKhau.Enabled = true;
            }
            else
            {
                btnSua.Text = "Bật chỉnh sửa";
                btnHuySua.Visible = false;
                txtMaTaiKhoan.ReadOnly = true;
                txtMaTaiKhoan.Enabled = false;
                txtHoTen.Enabled = false;
                dtNgaySinh.Enabled = false;
                radNam.Enabled = false;
                radNu.Enabled = false;
                cbQuyenHan.Enabled = false;
                txtMatKhau.Enabled = false;
                //cập nhật sơ sở dữ liệu
                //....
                //...
            }
        }

        private void btnHuySua_Click(object sender, EventArgs e)
        {
            //...Tắt chỉnh sửa, không cập nhật lại cơ sở dữ liệu
            btnSua.Text = "Bật chỉnh sửa";
            btnHuySua.Visible = false;
            txtMaTaiKhoan.ReadOnly = true;
            txtMaTaiKhoan.Enabled = false;
            txtHoTen.Enabled = false;
            dtNgaySinh.Enabled = false;
            radNam.Enabled = false;
            radNu.Enabled = false;
            cbQuyenHan.Enabled = false;
            txtMatKhau.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();
                try
                {
                    string query = "DELETE tblTaiKhoan WHERE PK_sTaikhoanID = '" + txtMaTaiKhoan.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    var result = MessageBox.Show("Bạn có chắc muốn xóa không", "Xóa tài khoản", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Xóa thành công");
                            HienTatCaTaiKhoan();
                        }
                        else
                        {
                            MessageBox.Show("Không có tài khoản cần xóa");
                        }
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (btnTimKiem.Text.Equals("Bật tìm kiếm"))
            {
                //...Bật tìm kiếm
                btnTimKiem.Text = "Tắt tìm kiếm";
                txtMaTaiKhoan.Enabled = true;
                txtMaTaiKhoan.ReadOnly = false;
                txtMaTaiKhoan.Text = "";
                txtHoTen.Enabled = true;
                dtNgaySinh.Enabled = true;
                radNam.Enabled = true;
                radNu.Enabled = true;
                cbQuyenHan.Enabled = true;
                txtMatKhau.Enabled = true;
                btnTim.Visible = true;
                numTuoi.Visible = true;
                label7.Visible= true;
            }
            else
            {
                //...Tắt tìm kiếm
                btnTimKiem.Text = "Bật tìm kiếm";
                txtMaTaiKhoan.ReadOnly = true;
                txtMaTaiKhoan.Enabled = false;
                txtMaTaiKhoan.Text = "";
                txtHoTen.Enabled = false;
                dtNgaySinh.Enabled = false;
                radNam.Enabled = false;
                radNu.Enabled = false;
                cbQuyenHan.Enabled = false;
                txtMatKhau.Enabled = false;
                btnTim.Visible = false;
                numTuoi.Visible = false;
                label7.Visible = false;
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            HienTatCaTaiKhoan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("Thêm"))
            {
                //...Bật chỉnh tính năng nhập thông tin cần thêm
                btnThem.Text = "Xác nhận thêm";
                btnHuy1.Visible = true;
                txtMaTaiKhoan.ReadOnly = false;
                txtMaTaiKhoan.Enabled = true;
                txtHoTen.Enabled = true;
                dtNgaySinh.Enabled = true;
                radNam.Enabled = true;
                radNu.Enabled = true;
                cbQuyenHan.Enabled = true;
                txtMatKhau.Enabled = true;
            }
            else //Kiểm soát dữ liệu nhập vào
            {
                if (txtMaTaiKhoan.Text.Equals(""))
                {
                    MessageBox.Show("Hãy nhập mã cho tài khoản mới");
                }
                else if(txtHoTen.Text.Equals(""))
                {
                    MessageBox.Show("Hãy nhập họ tên chủ tài khoản");
                }
                else if (txtMatKhau.Text.Equals(""))
                {
                    MessageBox.Show("Hãy đặt mật khẩu cho tài khoản");
                }
                else if (!radNam.Checked && !radNu.Checked)
                {
                    MessageBox.Show("Hãy chọn giới tính");
                }
                else if(cbQuyenHan.Text.Equals(""))
                {
                    MessageBox.Show("Hãy chọn vai trò của tài khoản");
                }
                else if (dtNgaySinh.Text != "")
                {
                    if(dtNgaySinh.Value.Year > DateTime.Now.Year)
                    {
                        MessageBox.Show("Năm sinh không hợp lệ");
                    }
                    else
                    {
                        if (dtNgaySinh.Value.Month == DateTime.Now.Month)
                        {
                            if (dtNgaySinh.Value.Day >= DateTime.Now.Day)
                            {
                                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại");
                            }
                        }
                        else if(dtNgaySinh.Value.Month > DateTime.Now.Month)
                        {
                            MessageBox.Show("Tháng sinh không hợp lệ");
                        }
                    }
                }
                else
                {
                    btnThem.Text = "Thêm";
                    btnHuy1.Visible = false;
                    txtMaTaiKhoan.ReadOnly = true;
                    txtMaTaiKhoan.Enabled = false;
                    txtHoTen.Enabled = false;
                    dtNgaySinh.Enabled = false;
                    radNam.Enabled = false;
                    radNu.Enabled = false;
                    cbQuyenHan.Enabled = false;
                    txtMatKhau.Enabled = false;
                    //cập nhật sơ sở dữ liệu
                    //....
                    //...
                    try
                    {
                        bool check = ThemTaiKhoan(Program.connectionString);
                        if (check == true)
                        {
                            MessageBox.Show("Thêm thành công", "Thêm tài khoản");
                            txtMatKhau.Text = "";
                            txtMaTaiKhoan.Text = "";
                            txtHoTen.Text = "";
                            cbQuyenHan.Text = "";
                            radNam.Checked = false;
                            radNu.Checked = false;
                            dtNgaySinh.Value = DateTime.Now;
                            HienTatCaTaiKhoan();
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công", "Thêm Tài khoản");
                            txtMatKhau.Text = "";
                            txtMaTaiKhoan.Text = "";
                            txtHoTen.Text = "";
                            cbQuyenHan.Text = "";
                            radNam.Checked = false;
                            radNu.Checked = false;
                            dtNgaySinh.Value = DateTime.Now;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private bool ThemTaiKhoan(string connectionString)
        {
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    connection.Open();
                    adapter.InsertCommand = new SqlCommand("PR_insertTaiKhoan", connection);
                    adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                    adapter.InsertCommand.Parameters.AddWithValue("PK_sTaikhoanID",txtMaTaiKhoan.Text.Trim());
                    adapter.InsertCommand.Parameters.AddWithValue("sHoten", txtHoTen.Text.Trim());
                    adapter.InsertCommand.Parameters.Add("dNgaysinh", SqlDbType.Date);
                    adapter.InsertCommand.Parameters["dNgaysinh"].Value = dtNgaySinh.Value;
                    adapter.InsertCommand.Parameters.Add("bGioitinh", SqlDbType.Bit);
                    if(radNam.Checked)
                    {
                        adapter.InsertCommand.Parameters["bGioitinh"].Value = true;
                    }
                    else
                    {
                        adapter.InsertCommand.Parameters["bGioitinh"].Value = false;
                    }
                    adapter.InsertCommand.Parameters.Add("sQuyenID", SqlDbType.NVarChar);
                    if (cbQuyenHan.Text.Equals("Quản trị"))
                    {
                        adapter.InsertCommand.Parameters["sQuyenID"].Value = "AD";
                    }else if (cbQuyenHan.Text.Equals("Học viên"))
                    {
                        adapter.InsertCommand.Parameters["sQuyenID"].Value = "HV";
                    }
                    else
                    {
                        adapter.InsertCommand.Parameters["sQuyenID"].Value = "GT";
                    }

                    adapter.InsertCommand.Parameters.AddWithValue("@sMatKhau", txtMatKhau.Text.Trim());

                    int i = adapter.InsertCommand.ExecuteNonQuery();
                    connection.Close();

                    return i > 0;
                }
            }


        }

        private void btnHuy1_Click(object sender, EventArgs e)
        {
            //...Hủy bỏ việc thêm tài khoản, không cập nhật lại cơ sở dữ liệu
            btnThem.Text = "Thêm";
            btnHuy1.Visible = false;
            txtMaTaiKhoan.Enabled = false;
            txtHoTen.Enabled = false;
            dtNgaySinh.Enabled = false;
            radNam.Enabled = false;
            radNu.Enabled = false;
            cbQuyenHan.Enabled = false;
            txtMatKhau.Enabled = false;
        }

        private void cbQuyenHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string filter = "PK_sTaikhoanID IS NOT NULL ";
            //filter += string.Format("AND {0} = '{1}' ", "dNgaysinh", dtNgaySinh.Text);
            if(txtMaTaiKhoan.Text!=""){
                filter += string.Format("AND {0} LIKE '{1}' ", "PK_sTaikhoanID", "%" + txtMaTaiKhoan.Text + "%");
            }
            if (txtHoTen.Text != "")
            {
                filter += string.Format("AND {0} LIKE '{1}' ", "sHoten", "%" + txtHoTen.Text + "%");
            }
            if (radNam.Checked)
            {
                filter += string.Format("AND {0} = {1} ", "bGioitinh", 1);
            }
            if (radNu.Checked)
            {
                filter += string.Format("AND {0} = {1} ", "bGioitinh", 0);
            }
            if (numTuoi.Value > 0)
            {
                filter += string.Format("AND {0}={1} ", "DATEDIFF(YEAR,dNgaysinh,GETDATE())", numTuoi.Value);
            }
            else if (numTuoi.Value == 0)
            {
                MessageBox.Show("Tuổi phải lớn hơn 0");
            }
            try
            {
                (dvTaiKhoan.DataSource as DataTable).DefaultView.RowFilter = filter;
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
            
        }
    }
}
