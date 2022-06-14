using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagement1
{
    public partial class Mform : Form
    {
        public Mform()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
                LoginForm lf = new LoginForm();
                lf.Show();

            }
        }

        private void hồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();   
        }



        private void quảnLýPhòngBanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DepartmentForm f = new DepartmentForm();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();

        }


        private void Mform_Load(object sender, EventArgs e)
        {

        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm f = new RegistrationForm();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();

        }

        private void quảnLýLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryForm f = new SalaryForm();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();
        }
    }
}
