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
    public partial class frmKetQuaThiCaNhan : Form
    {
        private string sTaikhoanID;
        public frmKetQuaThiCaNhan()
        {
            InitializeComponent();
        }

        public frmKetQuaThiCaNhan(string sTaikhoanID)
        {
            InitializeComponent();
            this.sTaikhoanID = sTaikhoanID;
        }



        private void LoadAllBaiThi_Taikhoan()
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("PR_LayTatCaBaiThiCuaTaiKhoan", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("TaikhoanID",sTaikhoanID);
                DataTable tb = new DataTable();

                try
                {
                    adapter.Fill(tb);
                    dvKetQua.DataSource = tb;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void frmKetQuaThiCaNhan_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            LoadAllBaiThi_Taikhoan();
        }

        private void LoadThongTin()
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string sql = "select sHoten from tblTaiKhoan where PK_sTaikhoanID = '"+ sTaikhoanID + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    txtMaTK.Text = sTaikhoanID;
                    txtHoten.Text = tb.Rows[0]["sHoten"].ToString().Trim();
                }
            }
        }

        private void dvKetQua_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.FindOpenedForm("frmChiTietBaiThi") == null)
            {

                string baithiID = dvKetQua.SelectedRows[0].Cells["PK_sBaithiID"].Value.ToString();
                new frmChiTietBaiThi(baithiID).Show();

            }
            else
            {
                Program.FindOpenedForm("frmChiTietBaiThi").Activate();
            }
        }
    }
}
