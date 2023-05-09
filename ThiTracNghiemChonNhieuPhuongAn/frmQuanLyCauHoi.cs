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
    public partial class frmQuanLyCauHoi : Form
    {
        public frmQuanLyCauHoi()
        {
            InitializeComponent();
        }

        private void frmQuanLyCauHoi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_ThiTracNghiemDataSet.tblMonHoc' table. You can move, or remove it, as needed.
            this.tblMonHocTableAdapter.Fill(this.db_ThiTracNghiemDataSet.tblMonHoc);

            LoadDanhSachCauHoi();
        }
        
        private void LoadDanhSachCauHoi()
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("PR_LayCauHoi", connection);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt);
                    dvDanhSachCauHoi.DataSource = dt;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dvDanhSachCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dvDanhSachCauHoi.CurrentRow.Index;
            txtMaCauHoi.Text = dvDanhSachCauHoi.Rows[i].Cells["Pk_sCauhoiID"].Value.ToString();
            cbMon.SelectedValue = dvDanhSachCauHoi.Rows[i].Cells["iMonID"].Value;
            txtNoiDungCauHoi.Text = dvDanhSachCauHoi.Rows[i].Cells["sNoidung"].Value.ToString();
            txtPA1.Text = dvDanhSachCauHoi.Rows[i].Cells["sPhuonganA"].Value.ToString();
            txtPA2.Text = dvDanhSachCauHoi.Rows[i].Cells["sPhuonganB"].Value.ToString();
            txtPA3.Text = dvDanhSachCauHoi.Rows[i].Cells["sPhuonganC"].Value.ToString();
            txtPA4.Text = dvDanhSachCauHoi.Rows[i].Cells["sPhuonganD"].Value.ToString();
            txtDapAn.Text = dvDanhSachCauHoi.Rows[i].Cells["sDapan"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMaCauHoi.Text = "";
            cbMon.SelectedValue = 1;
            txtNoiDungCauHoi.Text = "";
            txtPA1.Text = "";
            txtPA2.Text = "";
            txtPA3.Text = "";
            txtPA4.Text = "";
            txtDapAn.Text = "";
            LoadDanhSachCauHoi();
        }

        private void btnThemCauHoi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("PR_ThemCauHoi", connection);
                SqlCommand cmd = new SqlCommand("PR_ThemCauHoi", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.Parameters.AddWithValue("PK_sCauhoiID",txtMaCauHoi.Text.Trim());
                adapter.InsertCommand.Parameters.Add("iMonID",SqlDbType.Int);
                adapter.InsertCommand.Parameters["iMonID"].Value = cbMon.SelectedValue;
                adapter.InsertCommand.Parameters.AddWithValue("sNoidung",txtNoiDungCauHoi.Text.ToString());
                adapter.InsertCommand.Parameters.AddWithValue("sPhuonganA",txtPA1.Text.ToString());
                adapter.InsertCommand.Parameters.AddWithValue("sPhuonganB", txtPA2.Text.ToString());
                adapter.InsertCommand.Parameters.AddWithValue("sPhuonganC", txtPA3.Text.ToString());
                adapter.InsertCommand.Parameters.AddWithValue("sPhuonganD", txtPA4.Text.ToString());
                adapter.InsertCommand.Parameters.AddWithValue("sDapan",txtDapAn.Text.ToString());


                try
                {
                    connection.Open();
                    int i = adapter.InsertCommand.ExecuteNonQuery();
                    connection.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm câu hỏi thành công");
                        txtMaCauHoi.Text = "";
                        txtNoiDungCauHoi.Text = "";
                        txtPA1.Text = "";
                        txtPA2.Text = "";
                        txtPA3.Text = "";
                        txtPA4.Text = "";
                        txtDapAn.Text = "";
                        LoadDanhSachCauHoi();
                    }
                    else
                    {
                        MessageBox.Show("Thêm câu hỏi không thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnSuaCauHoi_Click(object sender, EventArgs e)
        {
            if (txtMaCauHoi.Text.Equals(""))
            {
                MessageBox.Show("Hãy chọn bản ghi cần sửa!");
            }
            else
            {
                if (btnSuaCauHoi.Text.Equals("Sửa"))
                {
                    btnSuaCauHoi.Text = "Lưu";
                }
                else
                {
                    btnSuaCauHoi.Text = "Sửa";

                    using (SqlConnection connection = new SqlConnection(Program.connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("PR_SuaCauHoi", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("PK_sCauhoiID", txtMaCauHoi.Text.Trim());
                        cmd.Parameters.Add("iMonID", SqlDbType.Int);
                        cmd.Parameters["iMonID"].Value = cbMon.SelectedValue;
                        cmd.Parameters.AddWithValue("sNoidung", txtNoiDungCauHoi.Text.ToString());
                        cmd.Parameters.AddWithValue("sPhuonganA", txtPA1.Text.ToString());
                        cmd.Parameters.AddWithValue("sPhuonganB", txtPA2.Text.ToString());
                        cmd.Parameters.AddWithValue("sPhuonganC", txtPA3.Text.ToString());
                        cmd.Parameters.AddWithValue("sPhuonganD", txtPA4.Text.ToString());
                        cmd.Parameters.AddWithValue("sDapan", txtDapAn.Text.ToString());

                        try
                        {
                            connection.Open();
                            int i = cmd.ExecuteNonQuery();
                            connection.Close();
                            if (i > 0)
                            {
                                MessageBox.Show("Sửa câu hỏi thành công");
                                txtMaCauHoi.Text = "";
                                txtNoiDungCauHoi.Text = "";
                                txtPA1.Text = "";
                                txtPA2.Text = "";
                                txtPA3.Text = "";
                                txtPA4.Text = "";
                                txtDapAn.Text = "";
                                LoadDanhSachCauHoi();
                            }
                            else
                            {
                                MessageBox.Show("Sửa câu hỏi không thành công");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                
            }
        }

        private void btnXoaCauHoi_Click(object sender, EventArgs e)
        {
            if (txtMaCauHoi.Text.Equals(""))
            {
                MessageBox.Show("Hãy chọn bản ghi cần xóa!");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("PR_XoaCauHoi", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("PK_sCauhoiID", txtMaCauHoi.Text.Trim());
                    try
                    {
                        connection.Open();
                        int i = cmd.ExecuteNonQuery();
                        connection.Close();
                        if (i > 0)
                        {
                            MessageBox.Show("Xóa câu hỏi thành công");
                            txtMaCauHoi.Text = "";
                            txtNoiDungCauHoi.Text = "";
                            txtPA1.Text = "";
                            txtPA2.Text = "";
                            txtPA3.Text = "";
                            txtPA4.Text = "";
                            txtDapAn.Text = "";
                            LoadDanhSachCauHoi();
                        }
                        else
                        {
                            MessageBox.Show("Xóa câu hỏi không thành công");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        

        private void btnLocTheoMon_Click(object sender, EventArgs e)
        {
            string filter = "iMonID = " + cbMon.SelectedValue;
            (dvDanhSachCauHoi.DataSource as DataTable).DefaultView.RowFilter = filter;
        }
    }
}
