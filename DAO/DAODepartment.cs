using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagement1
{
    class DAODepartment
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public DAODepartment()
        {
            string cnStr = ConfigurationManager.ConnectionStrings["cntr"].ConnectionString;
            conn = new SqlConnection(cnStr);
        }
        //hien thi danh sach phong ban va nhan vien
        public DataTable GetDepartment()
        {
            ds = new DataSet();
            string query = "select b.DepartmentID, a.EmployeeID, a.LastName + ' ' + a.FirstName as FullName , a.Gender , b.DepartmentName, c.JobTitle " +
                "from Nhanvien a, PhongBan b, Jobtitle c where a.DepartmentID = b.DepartmentID and a.JobID = c.JobID ";
            da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            return ds.Tables[0];
        }
        
        //hien thi danh sach NV
        public DataTable GetNV()
        {
            ds = new DataSet();
            string query = "select DISTINCT EmployeeID,a.LastName + ' ' + a.FirstName as FullName, b.JobTitle   " +
               "from Nhanvien a, Jobtitle b where a.JobID = b.JobID ";
            da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            return ds.Tables[0];
        }

        //Hien thi danh sach Phong Ban
        public DataTable GetIDDepartmetn()
        {
            ds = new DataSet();
            string query = "select * from PhongBan";
            da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            return ds.Tables[0];
        }

        //them PB
        public void themPB(string departmentName)
        {
            
                try
                {
                    string query = string.Format(" insert into PhongBan(DepartmentName) values ('{0}')", departmentName);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Thêm Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        //Cap nhat PB
        public void UpPB(string departmentName, int IDDepartment)
        {

            try
            {
                SqlCommand cmd;
                string query = string.Format("UPDATE PhongBan SET DepartmentName = '{0}' WHERE DepartmentID = '{1}' ", departmentName, IDDepartment);
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saving Successfull!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Saving Failed!!!");
            }
            finally
            {
                conn.Close();
            }

        }

        // Cap nhat NV vao PB
        public void UPNvPB(int DepartmentID, int EmployeeID)
        {

            try
            {
                SqlCommand cmd;
                string query = string.Format("update Nhanvien set DepartmentID = '{0}' where EmployeeID = '{1}' ", DepartmentID, EmployeeID);
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saving Successfull!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Saving Failed!!!");
            }
            finally
            {
                conn.Close();
            }

        }
        //Xoa PB
        public void xoaPB(int IDDepartment)
        {
           
                try
                {
                MessageBox.Show("Phai xoa tat ca nhan vien truoc khi xoa Department nay !!!", "Information", MessageBoxButtons.OK);
                string query = string.Format("delete from PhongBan where DepartmentID = '{0}'", IDDepartment);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoá PB thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException sql)
                {
                    MessageBox.Show("Xoá Phong ban nay thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
        }
        //Xoa NV khoi PB dang chon
        public void xoaNVPB(int IDDepartment)
        {

            try
            {
                string query = string.Format("delete from PhongBan where DepartmentID = '{0}'", IDDepartment);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoá PB thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Xoá PB thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}
