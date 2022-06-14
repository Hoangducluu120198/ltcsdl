using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace StaffManagement1
{
    class DAO_NhanVien
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;

        public DAO_NhanVien()
        {

            string query = ConfigurationManager.ConnectionStrings["cntr"].ConnectionString;
            conn = new SqlConnection(query);


        }
        public DataTable LayDSNV()
        {
            DataSet ds = new DataSet();
            string query = "select a.EmployeeID, b.DepartmentName, c.JobTitle,  a.LastName ,a.FirstName , a.Gender ,  a.CMND, a.Address, a.PhoneNumber, a.Education ,a.BirthDay " +
                "from Nhanvien a, PhongBan b, Jobtitle c " +
                "where a.DepartmentID = b.DepartmentID and c.JobID = a.JobID";
            da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            return ds.Tables[0];
        }

        


        public DataTable LayChucVu()
        {
            ds = new DataSet();
            string query = "select JobID, JobTitle from Jobtitle ";
            da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            return ds.Tables[0];
        }
        public DataTable LayDSPhongBan()
        {
            ds = new DataSet();
            string query = "select * from PhongBan ";
            da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            return ds.Tables[0];
        }

        public void ThemNV(string JobID, int DepartmentID, string Gender, string firstName, string LastName, DateTime BirthDay, int CMND,string PhoneNumber, string Address,string Education)
        {
            DialogResult check = MessageBox.Show("Bạn muốn thêm NV", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (check == DialogResult.OK)
            {
                try
                {
                    string query = string.Format("set dateformat dmy insert into Nhanvien(JobID, DepartmentID, Gender, LastName, FirstName, CMND, PhoneNumber, BirthDay,Address,Education)" +
                        "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", JobID, DepartmentID, Gender, LastName, firstName, CMND, PhoneNumber, BirthDay, Address, Education);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm NV thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Thêm NV thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void CapNhatNV(string JobID, int DepartmentID, string Gender, string firstName, string LastName, DateTime BirthDay, int CMND, string PhoneNumber, string Address, string Education, int employID)
        {
            SqlCommand cmd;
            try
            {
                string query = string.Format("set dateformat dmy UPDATE Nhanvien  set  JobID = '{0}', DepartmentID = '{1}', Gender = '{2}' , LastName = '{3}' ,FirstName = '{4}',CMND = '{5}', PhoneNumber = '{6}', BirthDay = '{7}', Address = '{8}', Education = '{9}'" +
                    "where EmployeeID = '{10}'",JobID,DepartmentID,Gender,LastName, firstName,CMND,PhoneNumber,BirthDay,Address,Education,employID);
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhập NV thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException )
            {

                MessageBox.Show("Cập nhật NV thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }
        }

        public void xoaNV(int EmployID)
        {

            try
            {
                string query = string.Format("delete from Nhanvien where EmployeeID ='{0}'", EmployID);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoá Nhân Viên thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Xoá Nhân Viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        
    }
}