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
    public partial class frmLamBaiThi : Form
    {
        int phut;
        int giay;
        private string sTaikhoanID;
        private string sBaithiID;
        string selectedCauHoi;
        Button btnCauHoiDangChon;
        int ketquathi = 0;


        public frmLamBaiThi() //CONTRACTOR
        {
            InitializeComponent();
        }

       
        public frmLamBaiThi(string sTaikhoanID) //CONTRACTOR
        {
            InitializeComponent();
            this.sTaikhoanID = sTaikhoanID;
        }


        private void frmLamBaiThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_ThiTracNghiemDataSet.tblMonHoc' table. You can move, or remove it, as needed.
            this.tblMonHocTableAdapter.Fill(this.db_ThiTracNghiemDataSet.tblMonHoc);

            LoadDSPhong(sender, e);
            if (LayTaiKhoan().Rows.Count > 0)
            {
                txtThongTinThiSinh.Text = LayTaiKhoan().Rows[0]["sHoten"].ToString() +" - "+ sTaikhoanID;
            }
        }

        private DataTable LayTaiKhoan()
        {
            DataTable tb = new DataTable();
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string query = "SELECT sHoten FROM tblTaiKhoan WHERE PK_sTaikhoanID = '" + sTaikhoanID + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(tb);
            }
            return tb;
        }

        private void LoadDSPhong(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("PR_GetPhongThi_ThiSinh", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("sTaikhoanID",sTaikhoanID);
                DataTable tb = new DataTable();
                try
                {
                    adapter.Fill(tb);
                    listPhongThi.DataSource = tb;
                    listPhongThi.DisplayMember = "sTenphongthi";
                    listPhongThi.ValueMember = "PK_sPhongthiID";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            listPhongThi_SelectedIndexChanged(sender,e);// Tự động chọn phòng thi đầu tiên
        }

        private void listPhongThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPhongThi.SelectedValue == null)
            {
                cbMon.Text = "";
            }
            else
            {
                try
                {
                    string sPhongthiID = listPhongThi.SelectedValue.ToString();
                    using (SqlConnection connection = new SqlConnection(Program.connectionString))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter("PR_GetPhongThi", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("sPhongthiID", sPhongthiID);
                        DataTable tb = new DataTable();

                        adapter.Fill(tb);
                        if (tb.Rows.Count > 0)
                        {
                            label4.Text = txtMaPhong.Text = tb.Rows[0]["PK_sPhongthiID"].ToString();
                            cbMon.SelectedValue = int.Parse(tb.Rows[0]["iMonID"].ToString());

                        }
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Hiện tại không có phòng thi nào cho bạn");
                    Console.WriteLine(ex.Message);
                }
                
            }
            
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            //TODO: Xử lý ghi nhận câu trả lời
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand cmd = new SqlCommand("PR_GhinhanCauTraLoi", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("sBaithiID", sBaithiID);
                cmd.Parameters.Add("iThutuCau",SqlDbType.Int);
                cmd.Parameters["iThutuCau"].Value = int.Parse(selectedCauHoi);
                string cautraloi = "";
                if (chkA.Checked)
                {
                    cautraloi += "A ";
                }
                if (chkB.Checked)
                {
                    cautraloi += "B ";
                }
                if (chkC.Checked)
                {
                    cautraloi += "C ";
                }
                if (chkD.Checked)
                {
                    cautraloi += "D ";
                }

                cmd.Parameters.AddWithValue("@sPhuongantraloi",cautraloi);

                try
                {
                    if (chkA.Checked || chkB.Checked || chkC.Checked || chkD.Checked)
                    {
                        connection.Open();
                        int i = cmd.ExecuteNonQuery();
                        connection.Close();
                        if (i > 0)
                        {
                            btnCauHoiDangChon.BackColor = Color.DarkSlateBlue;
                            btnCauHoiDangChon.ForeColor = Color.White;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn ít nhất 1 phương án trước khi ghi nhận");
                    }
                    
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            //TODO: Xử lý khi nộp bài
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn nộp bài",txtMaPhong.Text.ToString(), MessageBoxButtons.OKCancel);

            switch (result)
            {
                case DialogResult.OK:
                    {
                        using (SqlConnection connection = new SqlConnection(Program.connectionString))
                        {
                            SqlCommand cmd = new SqlCommand("PR_LayCauHoi_CauTraLoi_1", connection);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("sBaithiID", sBaithiID);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable tb = new DataTable();

                            adapter.Fill(tb);
                            if (tb.Rows.Count > 0)
                            {
                                foreach (DataRow row in tb.Rows)
                                {
                                    if (row["sPhuongantraloi"].ToString().Equals(""))
                                    {
                                        ketquathi += 0;
                                    }
                                    else
                                    {
                                        string phuongantraloi = row["sPhuongantraloi"].ToString().Trim();
                                        string dapan = row["sDapan"].ToString().Trim();
                                        if (phuongantraloi.Equals(dapan))
                                        {
                                            ketquathi += 1;
                                        }
                                        else
                                        {
                                            ketquathi += 0;
                                        }
                                    }
                                }
                            }
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update tblBaithi set " +
                                "fDiemso = " + ketquathi + "," +
                                "tThoigianhoanthanh = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'" +
                                " where PK_sBaithiID ='" + sBaithiID + "'";
                            try
                            {
                                connection.Open();
                                int i = cmd.ExecuteNonQuery();
                                connection.Close();
                                if (i > 0)
                                {
                                    MessageBox.Show("Bài thi của bạn đã được lưu lại");
                                    groupLamBaiThi.Visible = false;
                                    timer1.Stop();
                                    timer1.Enabled = false;
                                    groupPhongThi.Visible = true;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        break;
                    }
                    
                case DialogResult.Cancel:
                    {

                        break;
                    }
            }
            
        }


        
        private void btnLamBaiThi_Click(object sender, EventArgs e)
        {
            

            
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand cmd = new SqlCommand("PR_taoBaiThi", connection);
                SqlCommand cmd1 = new SqlCommand("PR_luuRandomCauHoi", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd1.CommandType = CommandType.StoredProcedure;
                if (checkExistBaiThi() == true)
                {
                    MessageBox.Show("Bạn đã làm bài thi này và không thể làm lại");
                }
                else
                {
                    groupPhongThi.Visible = false;
                    groupLamBaiThi.Visible = true;

                    phut = int.Parse(txtMM.Text.ToString());
                    giay = int.Parse(txtSS.Text.ToString());
                    timer1.Enabled = true;
                    

                    //TODO: Code sử lý làm bài thi
                    //...
                    sBaithiID = createBaithiID();
                    cmd.Parameters.AddWithValue("sBaithiID", sBaithiID);
                    cmd.Parameters.AddWithValue("sPhongthiID", txtMaPhong.Text.ToString());
                    cmd.Parameters.AddWithValue("sTaikhoanID", sTaikhoanID);
                    
                    try
                    {
                        connection.Open();
                        int i = cmd.ExecuteNonQuery();
                        cmd1.Parameters.AddWithValue("sBaithiID",sBaithiID);
                        int i1 = cmd1.ExecuteNonQuery();
                        connection.Close();
                        if (i > 0)
                        {
                            label7.Text = getBaithiID();
                        }
                        else
                        {
                            label7.Text = "NoID";
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    timer1.Start();
                }
                
            }
        }

        private string createBaithiID() //Tạo BaithiID một cách tự động
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string sql = "SELECT MAX(PK_sBaithiID) as [PK_sBaithiID] from tblBaithi";
                SqlDataAdapter adapter = new SqlDataAdapter(sql,connection);

                DataTable tb = new DataTable();
                adapter.Fill(tb);
                int i;
                if (int.TryParse(tb.Rows[0]["PK_sBaithiID"].ToString(),out i))
                {
                    
                    return (i+1)+"";
                }
                else
                {
                    return 1 + "";
                }
            }
        }

        private string getBaithiID() //Lấy BaithiID của thí sinh đang làm
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string sql = "select PK_sBaithiID from tblBaiThi where sPhongthiID = '" + txtMaPhong.Text.ToString() + "' and sTaikhoanID = '" + sTaikhoanID + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable tb = new DataTable();
                adapter.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    return tb.Rows[0]["PK_sBaithiID"].ToString();
                }
                return "";
            }
        }

        private bool checkExistBaiThi() //Kiểm tra bài thi có tồn tại hay không, tức đã làm bài thi chưa
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string sql = "select PK_sBaithiID from tblBaiThi where sPhongthiID = '"+txtMaPhong.Text.ToString()+"' and sTaikhoanID = '"+sTaikhoanID+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable tb = new DataTable();
                adapter.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    return true;
                }
                return false;
            }
        }
        
        
        private void timer1_Tick(object sender, EventArgs e) // Đếm thời gian thi
        {
            if (phut > 0)
            {
                if (giay > 0)
                {
                    giay = giay - 1;
                    txtSS.Text = giay >= 0 && giay <= 9 ? "0" + giay.ToString() : giay.ToString();
                }
                else
                {
                    giay = 59;
                    phut = phut - 1 ;
                    txtSS.Text = giay >= 0 && giay <= 9 ? "0" + giay.ToString() : giay.ToString();
                    txtMM.Text = phut >= 0 && phut <= 9 ? "0" + phut.ToString() : phut.ToString();
                }
            }
            else
            {
                if (giay > 0)
                {
                    giay--;
                    txtSS.Text = giay >= 0 && giay <= 9 ? "0" + giay.ToString() : giay.ToString();
                }
                else
                {
                    txtMM.Text = "00";
                    txtSS.Text = "00";
                    timer1.Stop();
                    timer1.Enabled = false;
                    //TODO: Code xử lý khi hết giờ 
                    MessageBox.Show("Xong");
                }
            }
        }

        private void ChonCauHoi(object sender, EventArgs e)
        {
            btnCauHoiDangChon = sender as Button;
            foreach (Button c in this.flowLayoutPanel2.Controls)
            {
                if (c is Button)
                {
                    c.FlatAppearance.BorderColor = Color.Empty;
                    c.FlatAppearance.BorderSize = 1;
                    c.FlatStyle = FlatStyle.Standard;
                }
            }
            btnCauHoiDangChon.FlatStyle = FlatStyle.Popup;
            btnCauHoiDangChon.FlatAppearance.BorderSize = 2;
            btnCauHoiDangChon.FlatAppearance.BorderColor = Color.Black;
            selectedCauHoi = btnCauHoiDangChon.Text.ToString();
            groupCauHoi.Text = "Câu " + selectedCauHoi;
            chkA.Checked = chkB.Checked = chkC.Checked = chkD.Checked = false;
            
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand cmd = new SqlCommand("PR_LayCauHoi_CauTraLoi", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("sBaithiID", sBaithiID);
                cmd.Parameters.Add("iThutuCau", SqlDbType.Int);
                cmd.Parameters["iThutuCau"].Value = int.Parse(selectedCauHoi);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();

                adapter.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    txtNoiDungCauHoi.Text = tb.Rows[0]["sNoidung"].ToString();
                    txtA.Text = tb.Rows[0]["sPhuonganA"].ToString();
                    txtB.Text = tb.Rows[0]["sPhuonganB"].ToString();
                    txtC.Text = tb.Rows[0]["sPhuonganC"].ToString();
                    txtD.Text = tb.Rows[0]["sPhuonganD"].ToString();

                    string cautraloi = tb.Rows[0]["sPhuongantraloi"].ToString().Trim();
                    if (cautraloi.Equals(""))
                    {
                        chkA.Checked = false;
                        chkB.Checked = false;
                        chkC.Checked = false;
                        chkD.Checked = false;
                    }
                    else
                    {
                        string[] ctl = cautraloi.Split(' ');
                        foreach (string chon in ctl)
                        {
                            if (chon.Equals("A"))
                            {
                                chkA.Checked = true;
                            }
                            else if (chon.Equals("B"))
                            {
                                chkB.Checked = true;
                            }
                            else if (chon.Equals("C"))
                            {
                                chkC.Checked = true;
                            }
                            else if (chon.Equals("D"))
                            {
                                chkD.Checked = true;
                            }
                        }
                    }
                    
                }
            }
        }







        private void btnCau1_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender,e);
            
        }

        private void btnCau2_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau3_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau4_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau5_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau6_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau7_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau8_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau9_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau10_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau11_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau12_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau13_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau14_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau15_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau16_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau17_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau18_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau19_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau20_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau21_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau22_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau23_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau24_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau25_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau26_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau27_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau28_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau29_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }

        private void btnCau30_Click(object sender, EventArgs e)
        {
            ChonCauHoi(sender, e);
            
        }


        

        private void chkA_CheckedChanged(object sender, EventArgs e)
        {
            btnGhiNhan.Enabled = true;
        }

        private void chkB_CheckedChanged(object sender, EventArgs e)
        {
            btnGhiNhan.Enabled = true;
        }

        private void chkC_CheckedChanged(object sender, EventArgs e)
        {
            btnGhiNhan.Enabled = true;
        }

        private void chkD_CheckedChanged(object sender, EventArgs e)
        {
            btnGhiNhan.Enabled = true;
        }
    }
}
