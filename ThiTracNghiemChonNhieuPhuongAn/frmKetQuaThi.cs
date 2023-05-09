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
    public partial class frmKetQuaThi : Form
    {
        private string TaikhoanID;
        
        public frmKetQuaThi()
        {
            InitializeComponent();
        }

        public frmKetQuaThi(string sTaikhoanID)
        {
            InitializeComponent();
            this.TaikhoanID = sTaikhoanID;
        }

        private void frmKetQuaThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_ThiTracNghiemDataSet.tblPhongThi' table. You can move, or remove it, as needed.
            this.tblPhongThiTableAdapter.Fill(this.db_ThiTracNghiemDataSet.tblPhongThi);
            LoadAllBaiThi();
        }

        

        private void LoadAllBaiThi()
        {
            cbPhongthi.Text = string.Empty;
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("PR_LayTatCaBaiThi",connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable tb = new DataTable();

                try
                {
                    adapter.Fill(tb);
                    
                    dvKetQua.DataSource = tb;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void cbPhongthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhongthi.SelectedValue != null)
            {
                string filter = "sPhongthiID = '" + cbPhongthi.SelectedValue.ToString() + "'";
                (dvKetQua.DataSource as DataTable).DefaultView.RowFilter = filter;
            }else
            {
                LoadAllBaiThi();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadAllBaiThi();
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

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            string filter = "{tblBangDiem.sPhongthiID} = '"+cbPhongthi.SelectedValue.ToString()+"'";
            
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("PR_BaocaoDiemthi_Phongthi", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
                        rpKetQua reportKeQua = new rpKetQua();                       
                        reportKeQua.SetDataSource(tb);
                        reportKeQua.SummaryInfo.ReportTitle = "BẢNG ĐIỂM " + cbPhongthi.SelectedValue.ToString();
                        reportKeQua.RecordSelectionFormula = filter;

                        formReportView.crystalReportViewer.ReportSource = reportKeQua;

                        formReportView.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi báo cáo!");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //show the report
            
        }
    }
}
