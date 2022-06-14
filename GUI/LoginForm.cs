using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StaffManagement1
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public LoginForm()
        {
            InitializeComponent();
            string cnStr = ConfigurationManager.ConnectionStrings["cntr"].ConnectionString;
            conn = new SqlConnection(cnStr);
        }


        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                com.Connection = conn;
                com.CommandText = "select * from UserLogin";
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    if (txtId.Text.Equals(dr["UserName"].ToString()) && txtPassword.Text.Equals(dr["Password"].ToString()))
                    {
                        MessageBox.Show("Login Sucessfully", "congratulation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mform MainF = new Mform();
                        this.Hide();
                        MainF.Show();
                        return;
                    }
                }
                MessageBox.Show("Invalid UserName/Password or Please Fill UserName/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                conn.Close();
            }
        }


        private void btExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtId;
        }
    }
}
