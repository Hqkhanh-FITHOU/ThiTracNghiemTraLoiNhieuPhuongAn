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
    public partial class frmChiTietBaiThi : Form
    {
        private string sBaithiID;
        

        public frmChiTietBaiThi()
        {
            InitializeComponent();
        }
        public frmChiTietBaiThi(string sBaithiID)
        {
            InitializeComponent();
            this.sBaithiID = sBaithiID;
        }

        


        private void frmChiTietBaiThi_Load(object sender, EventArgs e)
        {
            LoadThongtinBaithi();
            LoadCauTraLoi();
        }

        private void LoadThongtinBaithi()
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand cmd = new SqlCommand("PR_LayBaithi_Taikhoan", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("sBaithiID", sBaithiID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                try
                {
                    adapter.Fill(tb);
                    if (tb.Rows.Count > 0)
                    {
                        txtMaBaithi.Text = tb.Rows[0]["PK_sBaithiID"].ToString();
                        txtMaPhong.Text  = tb.Rows[0]["sPhongthiID"].ToString();
                        txtMaTK.Text = tb.Rows[0]["sTaikhoanID"].ToString();
                        txtHoten.Text = tb.Rows[0]["sHoten"].ToString();
                        txtThoigianhoanthanh.Text = tb.Rows[0]["tThoigianhoanthanh"].ToString();
                        txtDiem.Text = tb.Rows[0]["fDiemso"].ToString() + "/30";
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoadCauTraLoi()
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand cmd = new SqlCommand("PR_LayCauHoi_CauTraLoi_2", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("sBaithiID", sBaithiID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                try
                {
                    adapter.Fill(tb);
                    dvCauTraLoi.DataSource = tb;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
