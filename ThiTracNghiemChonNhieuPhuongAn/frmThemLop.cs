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
    public partial class frmThemLop : Form
    {
        public frmThemLop()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand cmd = new SqlCommand("PR_ThemLop", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("sLopID", txtMaLop.Text.Trim());
                cmd.Parameters.AddWithValue("sTenlop", txtTenLop.Text.Trim());
                try
                {
                    connection.Open();
                    int i = cmd.ExecuteNonQuery();
                    connection.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm lớp thành công");
                        (Program.FindOpenedForm("frmQuanLyLop") as frmQuanLyLop).LoadListLop();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm lớp không thành công");
                        this.Close();
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
