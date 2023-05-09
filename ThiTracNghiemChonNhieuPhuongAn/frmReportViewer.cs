using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ThiTracNghiemChonNhieuPhuongAn
{
    public partial class frmReportViewer : Form
    {
        public frmReportViewer()
        {
            InitializeComponent();
        }



        public void ShowReport(string reportFileName, string recordFilter = "", string reportTitle="")
        {
            //1.Khai báo report object 
            ReportDocument rpt = new ReportDocument();
            string path = string.Format("{0}\\{1}", Application.StartupPath, reportFileName);
            rpt.Load(path);

            //2.Cập nhật data source cho report
            TableLogOnInfo logOnInfo = new TableLogOnInfo();
            logOnInfo.ConnectionInfo.ServerName = "HQK\\SQLEXPRESS";
            logOnInfo.ConnectionInfo.DatabaseName = "db_ThiTracNghiem";
            logOnInfo.ConnectionInfo.UserID = "khanh";
            logOnInfo.ConnectionInfo.Password= "khanh";

            foreach (Table t in rpt.Database.Tables)
            {
                t.ApplyLogOnInfo(logOnInfo);
            }

            //3.Truyền filter cho report
            /*if (!string.IsNullOrEmpty(recordFilter))
                rpt.RecordSelectionFormula = recordFilter;*/
            /*if (!string.IsNullOrEmpty(reportTitle))
                rpt.SummaryInfo.ReportTitle = reportTitle;*/

            //4.Hiện report
            crystalReportViewer.ReportSource = rpt;
        }
    }
}
