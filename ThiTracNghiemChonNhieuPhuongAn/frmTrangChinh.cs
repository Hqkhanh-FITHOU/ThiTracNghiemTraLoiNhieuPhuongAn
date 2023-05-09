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
    public partial class frmTrangChinh : Form
    {
        private Form currentChildForm;
        private string sTaikhoanID;

        public frmTrangChinh()
        {
            InitializeComponent();
        }

        public frmTrangChinh(string sTaikhoanID)
        {
            InitializeComponent();
            this.sTaikhoanID = sTaikhoanID;
        }


        private void frmTrangChinh_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string query = "SELECT sQuyenID FROM tblTaiKhoan WHERE PK_sTaikhoanID = '" + sTaikhoanID + "'";
                
                SqlDataAdapter adapter = new SqlDataAdapter(query,connection);

                DataTable tb = new DataTable();
                adapter.Fill(tb);

                //kiểm tra quyền của tài khoản
                if (tb.Rows.Count > 0)
                {
                    if (tb.Rows[0][0].ToString() == "AD") //quyền quản trị
                    {

                    }
                    else if (tb.Rows[0][0].ToString() == "HV") //quyền học viên
                    {
                        btnQuanLyTaiKhoan.Visible = false;
                        btnLop.Visible = false;
                        btnMonThi.Visible = false;
                        btnCauHoiThi.Visible = false;
                        btnQuanLyPhongThi.Visible = false;
                    }
                    else //quyền giao vien
                    {

                    }
                }
                
                
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            (Program.FindOpenedForm("frmDangNhap") as frmDangNhap).Show();
            this.Close();
        }

        private void btnCaiDatTaiKhoan_Click(object sender, EventArgs e)
        {
            if (Program.FindOpenedForm("frmTaiKhoan")==null)
            {
                if(currentChildForm!=null)
                { currentChildForm.Close(); }
                OpenFormSelected(new frmTaiKhoan(sTaikhoanID));
            }
            else
            {
                Program.FindOpenedForm("frmTaiKhoan").Activate();
            }
        }

        private void OpenFormSelected(Form childFormSelectedToOpen)
        {
            currentChildForm = childFormSelectedToOpen;
            currentChildForm.TopLevel = false;
            currentChildForm.Dock = DockStyle.Fill;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            panelChildForm.Controls.Add(currentChildForm);
            panelChildForm.Tag = currentChildForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            if (Program.FindOpenedForm("frmQuanLyTaiKhoan") == null)
            {
                if (currentChildForm != null)
                { currentChildForm.Close(); }
                OpenFormSelected(new frmQuanLyTaiKhoan());
            }
            else
            {
                Program.FindOpenedForm("frmQuanLyTaiKhoan").Activate();
            }
        }

        private void quảnLýPhòngThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.FindOpenedForm("frmQuanLyPhongThi") == null)
            {
                if (currentChildForm != null)
                { currentChildForm.Close(); }
                OpenFormSelected(new frmQuanLyPhongThi());
            }
            else
            {
                Program.FindOpenedForm("frmQuanLyPhongThi").Activate();
            }
        }

        private void btnCauHoiThi_Click(object sender, EventArgs e)
        {
            if (Program.FindOpenedForm("frmQuanLyCauHoi") == null)
            {
                if (currentChildForm != null)
                { currentChildForm.Close(); }
                OpenFormSelected(new frmQuanLyCauHoi());
            }
            else
            {
                Program.FindOpenedForm("frmQuanLyCauHoi").Activate();
            }
        }

        private void btnLamBaiThi_Click(object sender, EventArgs e)
        {
            if (Program.FindOpenedForm("frmLamBaiThi") == null)
            {
                if (currentChildForm != null)
                { currentChildForm.Close(); }
                OpenFormSelected(new frmLamBaiThi(sTaikhoanID));
            }
            else
            {
                Program.FindOpenedForm("frmLamBaiThi").Activate();
            }
        }

        private void btnKetQuaThi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string query = "SELECT sQuyenID FROM tblTaiKhoan WHERE PK_sTaikhoanID = '" + sTaikhoanID + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable tb = new DataTable();
                adapter.Fill(tb);

                //kiểm tra quyền của tài khoản
                if (tb.Rows.Count > 0)
                {
                    if (tb.Rows[0][0].ToString() == "AD") //quyền quản trị
                    {
                        if (Program.FindOpenedForm("frmKetQuaThi") == null)
                        {
                            if (currentChildForm != null)
                            { currentChildForm.Close(); }
                            OpenFormSelected(new frmKetQuaThi(sTaikhoanID));
                        }
                        else
                        {
                            Program.FindOpenedForm("frmKetQuaThi").Activate();
                        }
                    }
                    else if (tb.Rows[0][0].ToString() == "HV") //quyền học viên
                    {
                        if (Program.FindOpenedForm("frmKetQuaThiCaNhan") == null)
                        {
                            if (currentChildForm != null)
                            { currentChildForm.Close(); }
                            OpenFormSelected(new frmKetQuaThiCaNhan(sTaikhoanID));
                        }
                        else
                        {
                            Program.FindOpenedForm("frmKetQuaThiCaNhan").Activate();
                        }
                    }
                    else //quyền giao vien
                    {

                    }
                }


            }
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            if (Program.FindOpenedForm("frmQuanLyLop") == null)
            {
                if (currentChildForm != null)
                { currentChildForm.Close(); }
                OpenFormSelected(new frmQuanLyLop());
            }
            else
            {
                Program.FindOpenedForm("frmQuanLyLop").Activate();
            }
        }
    }
}
