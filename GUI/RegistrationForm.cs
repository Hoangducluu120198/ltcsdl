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

namespace StaffManagement1
{
    public partial class RegistrationForm : Form
    {
        BUSRegistrationF busRF;
        SqlConnection conn;
        public RegistrationForm()
        {
            InitializeComponent();
            busRF = new BUSRegistrationF();
            string cnStr = System.Configuration.ConfigurationManager.ConnectionStrings["cntr"].ConnectionString;
            conn = new SqlConnection(cnStr);
        }

        private void btRegistering_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select UserName from UserLogin where UserName = '" + txtUserId.Text + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Name Existing Already!!!");
            }
            else if (txtUserId.Text == "" || txtPassword.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("please fill information");
            }
            else if (txtPassword.Text != txtCfPassword.Text)
            {
                MessageBox.Show("Password not match");
            }
            else
            {
                busRF.AddUser(txtUserId.Text, txtPassword.Text, txtName.Text, txtEmail.Text, dtRegistration.Value);
            }


        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserId;
            txtUserId.MaxLength = 10;
            txtPassword.MaxLength = 20;
            txtName.MaxLength = 20;
            txtCfPassword.MaxLength = 20;
            txtEmail.MaxLength = 20;

        }

        private void cPS_CheckedChanged(object sender, EventArgs e)
        {
            if (cPS.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
