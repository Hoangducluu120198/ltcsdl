using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
namespace QLPB
{
    class DAO_QLPhongBan
    { 

      SqlConnection conn;
      SqlDataAdapter da;
      DataSet ds;
      public DAO_QLPhongBan()
        {
            string query = ConfigurationManager.ConnectionStrings["cntr"].ConnectionString;
            conn = new SqlConnection(query);
        }
      public DataTable LayDS_BP()
      {
          string query = "select MaBP, TenBP from BoPhan";
          da = new SqlDataAdapter(query, conn);
          ds = new DataSet();
          da.Fill(ds);
          return ds.Tables[0];
      }

      public DataTable LayDS_PB()
      {
          string query = "select DepartmentID, DepartmentName, NgayThanhLap, GhiChu from PhongBan";
          da = new SqlDataAdapter(query, conn);
          ds = new DataSet();
          da.Fill(ds);
          return ds.Tables[0];
      }
      public void themPB(string DepartmentID, string DepartmentName, string maBP, DateTime NgayThanhLap, string GhiChu)
      {

                  conn.Open();
                  string sql = "INSERT INTO PhongBan VALUES(@DepartmentID, @DepartmentName, @maBP, @NgayThanhLap, @GhiChu)";
                  SqlCommand cmd = new SqlCommand(sql, conn);
                  cmd.Parameters.AddWithValue("DepartmentID", DepartmentID);
                  cmd.Parameters.AddWithValue("DepartmentName", DepartmentName);
                  cmd.Parameters.AddWithValue("maBP", maBP);
                  cmd.Parameters.AddWithValue("NgayThanhLap", NgayThanhLap);
                  cmd.Parameters.AddWithValue("GhiChu", GhiChu);
                  cmd.ExecuteNonQuery();
                  conn.Close();
     
      
      }
      public void suaPB(string DepartmentID, string DepartmentName, string maBP, DateTime NgayThanhLap, string GhiChu)
      {

              conn.Open();
              string sql = "UPDATE PhongBan SET DepartmentName = @DepartmentName, GhiChu = @GhiChu, NgayThanhLap = @NgayThanhLap WHERE DepartmentID = @DepartmentID";
              SqlCommand cmd = new SqlCommand(sql, conn);
              cmd.Parameters.AddWithValue("DepartmentID", DepartmentID);
              cmd.Parameters.AddWithValue("DepartmentName", DepartmentName);
              cmd.Parameters.AddWithValue("maBP", maBP);
              cmd.Parameters.AddWithValue("NgayThanhLap", NgayThanhLap);
              cmd.Parameters.AddWithValue("GhiChu", GhiChu);
              cmd.ExecuteNonQuery();
              conn.Close();

      }
      public void xoaPB(string DepartmentID)
      {
              conn.Open();
              string sql = "DELETE FROM PhongBan WHERE DepartmentID = @DepartmentID";
              if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
              {
                  SqlCommand cmd = new SqlCommand(sql, conn);
                  cmd.Parameters.AddWithValue("DepartmentID", DepartmentID);
                  cmd.ExecuteNonQuery();
                  conn.Close();
              }
          }

      

    }
}
