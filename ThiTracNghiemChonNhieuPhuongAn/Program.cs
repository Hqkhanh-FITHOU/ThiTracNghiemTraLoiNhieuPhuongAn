using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiemChonNhieuPhuongAn
{
    internal static class Program
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["db_ThiTracNghiem"].ConnectionString;
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
            //Application.Run(new frmTaiKhoan());
            //Application.Run(new frmTrangChinh());
            //Application.Run(new frmQuanLyTaiKhoan()); 
            //Application.Run(new frmQuanLyPhongThi());
            //Application.Run(new frmQuanLyCauHoi());
        }


        public static Form FindOpenedForm(string name) //kiểm tra xem form đã được khởi tạo chưa
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)) //nếu có trả về một đối tượng Form
                {
                    return f;
                }
            }
            return null; // nếu chưa thì trả về null
        }
    }
}
