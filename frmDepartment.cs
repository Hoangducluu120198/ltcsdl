using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLPB
{
    public partial class frmDepartment : Form
    {
        BUS_QLPhongBan busPB;
        public frmDepartment()
        {
            InitializeComponent();
            busPB = new BUS_QLPhongBan();
        }


        private void frmDepartment_Load(object sender, EventArgs e)
        {
            //HienThiDSPB();
            busPB.HienThiDSBP(cbmaBP);
            busPB.HienThiDSPB(dgPB);
        }

        private void dgPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dgPB.Rows.Count)
            textTenPB.Text = dgPB.Rows[e.RowIndex].Cells["DepartmentName"].Value.ToString();
            textMaPB.Text = dgPB.Rows[e.RowIndex].Cells["DepartmentID"].Value.ToString();
            textDate.Text = dgPB.Rows[e.RowIndex].Cells["NgayThanhLap"].Value.ToString();
            textGhiChu.Text = dgPB.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();            
       

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (textMaPB.Text == "")
            {
                MessageBox.Show("Hãy nhập mã PB");
                textMaPB.Focus();
            }
            else
            {
                busPB.themPB(textMaPB.Text, textTenPB.Text, textMaPB.Text, textDate.MaxDate, textGhiChu.Text);
                frmDepartment_Load(sender, e);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (textMaPB.Text == "")
            {
                MessageBox.Show("Hãy nhập mã PB");
                textMaPB.Focus();
            }
            else
            {
                busPB.suaPB(textMaPB.Text, textTenPB.Text, textMaPB.Text, textDate.MaxDate, textGhiChu.Text);
                frmDepartment_Load(sender, e);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (textMaPB.Text == "")
            {
                MessageBox.Show("Hãy nhập mã PB");
                textMaPB.Focus();
            }
            else
            {
                busPB.xoaPB(textMaPB.Text);
                frmDepartment_Load(sender, e);
            }
        }

        private void dgPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ;
            if (f == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}
