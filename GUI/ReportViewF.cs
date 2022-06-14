using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagement1
{
    public partial class ReportViewF : Form
    {
        ReportDocument crypt = new ReportDocument();
        public ReportViewF()
        {
            InitializeComponent();

        }
        private void ReportViewF_Click(object sender, EventArgs e)
        {
            try
            {

                string cnStr = ConfigurationManager.ConnectionStrings["cntr"].ConnectionString;
                SqlConnection conn = new SqlConnection(cnStr);
                string querry = "select * from Payroll";
                DataSet dst = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(querry, conn);
                da.Fill(dst, "Payroll");
                crypt.Load(@"D:\rar file\StaffManagement1\report\CrystalReportPRoll.rpt");
                crypt.SetDataSource(dst);
                RPView.ReportSource = crypt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "No crystal reports installed. Pls. contact administrator.");
            }
        }
        private void btReportEmployee_Click(object sender, EventArgs e)
        {
            
            try
            {
                string cnStr = ConfigurationManager.ConnectionStrings["cntr"].ConnectionString;
                SqlConnection conn = new SqlConnection(cnStr);
                string querry = "select * from Nhanvien";
                DataSet dst = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(querry, conn);
                da.Fill(dst, "Nhanvien");
                crypt.Load(@"D:\rar file\StaffManagement1\report\CrystalReportEmployee.rpt");
                crypt.SetDataSource(dst);
                RPView.ReportSource = crypt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "No crystal reports installed. Pls. contact administrator.");
            }
        }
    }
}

