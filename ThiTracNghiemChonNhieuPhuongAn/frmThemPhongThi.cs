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
    public partial class frmThemPhongThi : Form
    {
        public frmThemPhongThi()
        {
            InitializeComponent();
        }

        private void btnTaoPhongThi_MouseClick(object sender, MouseEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;   
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tblPhongThi(PK_sPhongthiID,sTenphongthi,dThoigiantao,bTrangthai,iMonID) " +
                    "VALUES ('"+ txtMaPhong.Text.ToString()+"',"+
                    "'"+txtTenPhong.Text.ToString()+"'," +
                    "'"+dtThoiGianTaoPhong.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                    (chkDongPhongthi.Checked?1:0)+"," +
                    cbMon.SelectedValue.ToString()+")";

                connection.Open();
                int i = cmd.ExecuteNonQuery();
                connection.Close();

                if (i > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    (Program.FindOpenedForm("frmQuanLyPhongThi") as frmQuanLyPhongThi).LoadPhongThi();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private void btnHuyThemPhongThi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemPhongThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_ThiTracNghiemDataSet.tblMonHoc' table. You can move, or remove it, as needed.
            this.tblMonHocTableAdapter.Fill(this.db_ThiTracNghiemDataSet.tblMonHoc);
            dtThoiGianTaoPhong.Value = DateTime.Now;
            
        }
    }
}
