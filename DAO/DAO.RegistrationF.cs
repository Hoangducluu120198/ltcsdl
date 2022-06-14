using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace StaffManagement1
{
    class DAO
    {
        SqlConnection conn;
        public DAO()
        {
            string cnStr = ConfigurationManager.ConnectionStrings["cntr"].ConnectionString;
            conn = new SqlConnection(cnStr);
        }
        public void AddUser(string Username, string Password, string Name, string Email, DateTime Date)
        {
            try
            {
                string query = string.Format("set dateformat dmy insert into UserLogin([UserName],[Password],[Name],[Date],[Email]) values('{0}','{1}','{2}','{3}', '{4}')", Username, Password, Name, Date, Email);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registering is successful!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

    }

}
