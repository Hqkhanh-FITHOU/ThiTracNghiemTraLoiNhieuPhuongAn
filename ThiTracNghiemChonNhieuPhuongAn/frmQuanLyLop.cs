using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiemChonNhieuPhuongAn
{
    public partial class frmQuanLyLop : Form
    {
        public frmQuanLyLop()
        {
            InitializeComponent();
        }

        private void frmQuanLyLop_Load(object sender, EventArgs e)
        {
            LoadListLop();
        }

        public void LoadListLop()
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("PR_LayListLop", connection);
                DataTable tb = new DataTable();
                try
                {
                    adapter.Fill(tb);
                    
                    listLop.DataSource = tb;
                    listLop.DisplayMember = "sTenlop";
                    listLop.ValueMember = "PK_sLopID";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            if (Program.FindOpenedForm("frmThemLop") == null)
            {
                new frmThemLop().Show();
            }
            else
            {
                Program.FindOpenedForm("frmThemLop").Activate();
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand cmd = new SqlCommand("PR_XoaLop", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("sLopID",listLop.SelectedValue.ToString());
                try{
                    connection.Open();
                    int i = cmd.ExecuteNonQuery();
                    connection.Close();
                    if (i > 0)
                    {
                        LoadListLop();
                        MessageBox.Show("Đã xóa lớp");
                    }
                    else
                    {
                        MessageBox.Show("Lớp chưa được xóa");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listLop.DataSource != null)
            {
                txtMaLop.Text = listLop.SelectedValue.ToString();
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("PR_LayDSThanhVienLop", connection);
                    adapter.SelectCommand.CommandType= CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.AddWithValue("sLopID",listLop.SelectedValue.ToString());
                    DataTable tb = new DataTable();
                    try
                    {
                        adapter.Fill(tb);
                        dvThanhVienLop_1.DataSource = tb;
                        LoadDSChuaGhiDanh();
                        LoadDSGhiDanh();
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                btnXoaLop.Enabled = false;
            }
        }

        private void LoadDanhSachLop()
        {
            txtMaLop.Text = listLop.SelectedValue.ToString();
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("PR_LayDSThanhVienLop", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("sLopID", listLop.SelectedValue.ToString());
                DataTable tb = new DataTable();
                try
                {
                    adapter.Fill(tb);
                    dvThanhVienLop_1.DataSource = tb;
                    LoadDSChuaGhiDanh();
                    LoadDSGhiDanh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoadDSGhiDanh()
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand cmd = new SqlCommand("PR_LayDanhSachThanhVienDaGhiDanh_Lop", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("sLopID", listLop.SelectedValue.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    adapter.Fill(dt);
                    dvDaGhiDanh.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoadDSChuaGhiDanh()
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand cmd = new SqlCommand("PR_LayDanhSachThanhVienChuaGhiDanh_Lop", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("sLopID", listLop.SelectedValue.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    adapter.Fill(dt);
                    dvChuaGhiDanh.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBoGhiDanh_Click(object sender, EventArgs e)
        {
            int check = 0;
            //Bỏ ghi danh
            foreach (DataGridViewRow row in dvDaGhiDanh.SelectedRows)
            {

                if (!row.IsNewRow)
                {
                    string sql = "DELETE tblThanhVienLop WHERE sTaikhoanID = '" + row.Cells[0].Value.ToString() + "' AND sLopID = '" + listLop.SelectedValue.ToString() + "'";
                    //row.Cells[0].Value = 
                    //MessageBox.Show("" + row.Cells[0].Value);
                    using (SqlConnection connection = new SqlConnection(Program.connectionString))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;

                        connection.Open();
                        check += cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            if (check > 0)
            {
                //MessageBox.Show("Đã bỏ ghi danh " + check + " tài khoản");
                LoadDSChuaGhiDanh();
                LoadDSGhiDanh();
                LoadDanhSachLop();
            }
            else
            {
                //MessageBox.Show("Lỗi");
            }
        }

        private void btnGhiDanh_Click(object sender, EventArgs e)
        {
            //Ghi danh
            int check = 0;
            //Bỏ ghi danh
            foreach (DataGridViewRow row in dvChuaGhiDanh.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    string sql = "INSERT INTO tblThanhVienLop(sLopID,sTaikhoanID,sChucvu) VALUES ('" + listLop.SelectedValue.ToString() + "','" + row.Cells[0].Value.ToString() + "', N'"+cbChucVu.Text.ToString()+"')";
                    using (SqlConnection connection = new SqlConnection(Program.connectionString))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;

                        connection.Open();
                        check += cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            if (check > 0)
            {
                LoadDanhSachLop();
                LoadDSChuaGhiDanh();
                LoadDSGhiDanh();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
