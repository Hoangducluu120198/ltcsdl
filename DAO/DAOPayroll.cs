using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace StaffManagement1
{
    class DAOPayroll
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public DAOPayroll()
        {
            string cnStr = ConfigurationManager.ConnectionStrings["cntr"].ConnectionString;
            conn = new SqlConnection(cnStr);
        }


        public DataTable LayDS_Payroll()
        {
            string query = "select * from Payroll";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public DataTable GetEmployee()
        {
            ds = new DataSet();
            string query = "select a.EmployeeID , b.JobTitle, a.LastName + ' ' + a.FirstName as FName, c.WorkDay, b.DailyRate, c.OTHour, b.OverRate, c.GrossOT, c.GrossWage, c.GrossIncome " +
                "from Nhanvien a, Jobtitle b, Payroll c where a.EmployeeID = c.EmployeeID and b.JobID = a.JobID";
            da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            return ds.Tables[0];
        }
        
        public DataTable GetIDEmployee()
        {
          
            ds = new DataSet();
            string query = " select a.EmployeeID, b.JobTitle, a.LastName + ' ' + a.FirstName as FName, b.DailyRate, b.OverRate " +
                "from Nhanvien a, Jobtitle b where a.JobID = b.JobID";
            da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            return ds.Tables[0];
        }


        public void UpdatePayroll(int maNV, int WD, int OTtime, double grossWage, double grossOt, double NetIncome)
        {

            try
            {
                SqlCommand cmd;
                string query = string.Format("UPDATE Payroll " +
                    "SET WorkDay = {1} , OTHour = {2} , GrossWage = {3} , GrossOT = {4} , GrossIncome = {5} " +
                    "WHERE EmployeeID = {0}", maNV, WD, OTtime, grossWage, grossOt, NetIncome);
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saving Successfull!");
            }
            catch (SqlException )
            {
                MessageBox.Show("Saving Failed!!!");
            }
            finally
            {
                conn.Close();
            }
            
        }

        public void ThemBangLuong(int maNV, int WD, int OTtime, double grossWage, double grossOt, double NetIncome)
        {     
                try
                {
                    string query = string.Format("insert into Payroll(EmployeeID,WorkDay,OTHour,GrossWage,GrossOT,GrossIncome) values ('{0}','{1}','{2}','{3}','{4}','{5}')"
                        , maNV, WD, OTtime, grossWage, grossOt, NetIncome);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm bảng tính lương thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                catch
                {
                    MessageBox.Show("Thêm bảng tính lương thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        public void xoaPhieuLuong(int EmployeeID)
        {

            try
            {
                string query = string.Format("delete from Payroll where EmployeeID = '{0}'", EmployeeID);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoá thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Xoá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}
