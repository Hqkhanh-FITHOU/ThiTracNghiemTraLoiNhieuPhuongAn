using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ThiTracNghiemChonNhieuPhuongAn
{
    public partial class frmQuanLyPhongThi : Form
    {
        public frmQuanLyPhongThi()
        {
            InitializeComponent();
        }

        private void frmQuanLyPhongThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_ThiTracNghiemDataSet.tblMonHoc' table. You can move, or remove it, as needed.
            this.tblMonHocTableAdapter.Fill(this.db_ThiTracNghiemDataSet.tblMonHoc);


            LoadPhongThi();
        }

        public void LoadPhongThi()
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                
                SqlCommand cmd = new SqlCommand("PR_getDSPhongThi", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                

                listPhongThi.DataSource = tb;
                listPhongThi.ValueMember = "PK_sPhongthiID";
                listPhongThi.DisplayMember = "sTenphongthi";
            }
        }

        private void btnThemPhongThi_Click(object sender, EventArgs e)
        {
            if (Program.FindOpenedForm("frmThemPhongThi")==null)
            {
                new frmThemPhongThi().Show();
            }
            else
            {
                (Program.FindOpenedForm("frmThemPhongThi") as frmThemPhongThi).Activate();
            }
        }

        private void listPhongThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenPhongThi.Enabled = false;
            dtThoiGianTao.Enabled = false;
            chkKhoaPhongThi.Enabled = false;
            btnSuaPhongThi.Text = "Sửa";
            btnXoaPhongThi.Text = "Xóa phòng thi";

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                
                string query = "SELECT * FROM tblPhongThi WHERE PK_sPhongthiID = '" + listPhongThi.SelectedValue.ToString() + "'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query,connection);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                


                try
                {
                    if (tb.Rows.Count > 0)
                    {
                        txtMaPhongThi.Text = tb.Rows[0]["PK_sPhongthiID"].ToString();
                        txtTenPhongThi.Text = tb.Rows[0]["sTenphongthi"].ToString();
                        dtThoiGianTao.Text = tb.Rows[0]["dThoigiantao"].ToString();
                        if (tb.Rows[0]["bTrangthai"].Equals(true))
                        {
                            chkKhoaPhongThi.Checked = true;
                        }
                        else
                        {
                            chkKhoaPhongThi.Checked = false;
                        }
                        cbMon.SelectedValue = tb.Rows[0]["iMonID"].ToString();
                        LoadDanhSachThiSinh(tb.Rows[0]["PK_sPhongthiID"].ToString());
                        LoadDanhSachChuaGhiDanh(tb.Rows[0]["PK_sPhongthiID"].ToString());
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

            
        }


        private void LoadDanhSachThiSinh(string sPhongThiID)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string sql = "SELECT PK_sTaikhoanID, sHoten FROM tblThiSinh JOIN tblTaiKhoan ON tblThiSinh.sTaikhoanID = tblTaiKhoan.PK_sTaikhoanID"
                    + " WHERE tblThiSinh.sPhongthiID = '" + sPhongThiID + "'";

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(sql,connection);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dvDanhSachGhiDanh.DataSource = tb;
 
            }
        }


        private void LoadDanhSachChuaGhiDanh(string sPhongThiID)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string sql = "SELECT PK_sTaikhoanID, sHoten FROM tblThiSinh RIGHT JOIN tblTaiKhoan ON tblThiSinh.sTaikhoanID = tblTaiKhoan.PK_sTaikhoanID"
                    + " WHERE sPhongthiID NOT LIKE '" + sPhongThiID + "' OR sPhongthiID IS NULL";

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(sql, connection);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dvDanhSachChuaGhiDanh.DataSource = tb;

            }
        }

        private void btnSuaPhongThi_Click(object sender, EventArgs e)
        {
            if (btnSuaPhongThi.Text == "Sửa")
            {
                btnSuaPhongThi.Text = "Lưu";
                btnXoaPhongThi.Text = "Hủy";
                txtTenPhongThi.Enabled = true;
                dtThoiGianTao.Enabled = false;
                chkKhoaPhongThi.Enabled = true;
                cbMon.Enabled = true;
            }
            else
            {
                btnSuaPhongThi.Text = "Sửa";
                btnXoaPhongThi.Text = "Xóa phòng thi";      
                txtTenPhongThi.Enabled = false;
                dtThoiGianTao.Enabled = false;
                chkKhoaPhongThi.Enabled = false;
                cbMon.Enabled = false;
                //code update ở đây
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE tblPhongThi " +
                        "SET sTenphongthi = N'" + txtTenPhongThi.Text.Trim() +"'," +
                        "bTrangthai = " + (chkKhoaPhongThi.Checked?1:0) +","+
                        "iMonID = " + cbMon.SelectedValue.ToString() +
                        " WHERE PK_sPhongthiID = N'" + txtMaPhongThi.Text.ToString() + "'";
                    connection.Open();
                    int i = cmd.ExecuteNonQuery();
                    connection.Close();
                    if(i > 0)
                    {
                        MessageBox.Show("Phòng thi mã "+txtMaPhongThi.Text.ToString()+" đã được cập nhật");
                    }
                    else
                    {
                        MessageBox.Show("Phòng thi mã " + txtMaPhongThi.Text.ToString() + " cập nhật thất bại");
                    }
                }
            }
        }

        private void btnXoaPhongThi_Click(object sender, EventArgs e)
        {
            if (btnXoaPhongThi.Text == "Hủy")
            {
                btnXoaPhongThi.Text = "Xóa phòng thi";
                btnSuaPhongThi.Text = "Sửa";
                txtTenPhongThi.Enabled = false;
                dtThoiGianTao.Enabled = false;
                chkKhoaPhongThi.Enabled = false;
            }
            else
            {
                //MessageBox.Show("Xóa");
                //code xóa phòng thi ở đây
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE tblPhongThi WHERE PK_sPhongthiID = '" + listPhongThi.SelectedValue.ToString() + "'";

                    connection.Open();
                    int i = cmd.ExecuteNonQuery();
                    connection.Close();
                    if (i>0)
                    {
                        MessageBox.Show("Đã xóa phòng thi");
                    }
                }
                LoadPhongThi();//load lại danh sách phòng thi khi xóa 1 phòng thi
            }
        }

        private void dvDanhSachChuaGhiDanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBoGhiDanh_Click(object sender, EventArgs e)
        {
            int check = 0;
            //Bỏ ghi danh
            foreach (DataGridViewRow row in dvDanhSachGhiDanh.SelectedRows)
            {
                
                if (!row.IsNewRow)
                {
                    string sql = "DELETE tblThiSinh WHERE sTaikhoanID = '" + row.Cells[0].Value.ToString() + "' AND sPhongthiID = '" + txtMaPhongThi.Text.ToString() +"'" ;
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
                LoadDanhSachThiSinh(txtMaPhongThi.Text.ToString());
                LoadDanhSachChuaGhiDanh(txtMaPhongThi.Text.ToString());
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
            foreach (DataGridViewRow row in dvDanhSachChuaGhiDanh.SelectedRows)
            {

                if (!row.IsNewRow)
                {
                    string sql = "INSERT INTO tblThiSinh(sTaikhoanID,sPhongthiID) VALUES ('" + row.Cells[0].Value.ToString() + "','" + txtMaPhongThi.Text.ToString() +"')";
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
                LoadDanhSachThiSinh(txtMaPhongThi.Text.ToString());
                LoadDanhSachChuaGhiDanh(txtMaPhongThi.Text.ToString());
            }else
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnBaocaoDanhsachThi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select sTaikhoanID,sHoten,dNgaysinh,bGioitinh from tblTaiKhoan join tblThiSinh " +
                    "on tblTaiKhoan.PK_sTaikhoanID = tblThiSinh.sTaikhoanID " +
                    "where sPhongthiID = '"+listPhongThi.SelectedValue.ToString()+"'";
                adapter.SelectCommand = cmd;
                DataTable tb = new DataTable();
                try
                {
                    adapter.Fill(tb);
                    if (tb.Rows.Count > 0)
                    {
                        frmReportViewer formReportView = Program.FindOpenedForm("frmReportViewer") as frmReportViewer;
                        if (formReportView == null)
                        {
                            formReportView = new frmReportViewer();
                        }
                        rpDanhSachThi reportDanhSachThi = new rpDanhSachThi();
                        reportDanhSachThi.SetDataSource(tb);
                        reportDanhSachThi.SummaryInfo.ReportTitle = "DANH SÁCH THI " + listPhongThi.SelectedValue.ToString();
                        
                        formReportView.crystalReportViewer.ReportSource = reportDanhSachThi;

                        formReportView.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi báo cáo!");
                    }
                }
                catch(Exception ex) { 
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
