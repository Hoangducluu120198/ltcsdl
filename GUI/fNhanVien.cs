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
    public partial class fNhanVien : Form
    {
        BUS_NhanVien bus;
        SqlConnection conn;
        bool pbcheckAdd = false;
        string radioCheck;

        public fNhanVien()
        {
            InitializeComponent();
            bus = new BUS_NhanVien();
            string cnStr = System.Configuration.ConfigurationManager.ConnectionStrings["cntr"].ConnectionString;
            conn = new SqlConnection(cnStr);
        }


        //Ham Load
        private void fNhanVien_Load(object sender, EventArgs e)
        {
            checkLength();
            dgNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            bus.HienthiDSNV(dgNhanVien);
            bus.HienthiChucVu(cbChucVu);
            bus.HienthiDSPhongBan(cbPhongBan);

        }

        //Ham cellclick
        private void dGNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgNhanVien.Rows.Count)
            {
                txtHo.Text = dgNhanVien.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                txtTen.Text = dgNhanVien.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                txtGT.Text = dgNhanVien.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                txtCMND.Text = dgNhanVien.Rows[e.RowIndex].Cells["CMND"].Value.ToString();
                txtDT.Text = dgNhanVien.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                txtEducation.Text = dgNhanVien.Rows[e.RowIndex].Cells["Education"].Value.ToString();
                txtDiaChi.Text = dgNhanVien.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                dtpNgaySinh.Text = dgNhanVien.Rows[e.RowIndex].Cells["BirthDay"].Value.ToString();
                cbPhongBan.Text = dgNhanVien.Rows[e.RowIndex].Cells["DepartmentName"].Value.ToString();
                cbChucVu.Text = dgNhanVien.Rows[e.RowIndex].Cells["JobTitle"].Value.ToString();
            }
        }

        //button report
        private void btRP_Click(object sender, EventArgs e)
        {
            ReportViewF RePF = new ReportViewF();
            RePF.Show();
        }

        //button thoat
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();

            }
        }


        //button Them NV
        private void btThem_Click(object sender, EventArgs e)
        {
            if (pbcheckAdd == false)
            {
                txtHo.Text = "";
                txtTen.Text = "";
                txtCMND.Text = "";
                txtDiaChi.Text = "";
                txtDT.Text = "";
                txtEducation.Text = "";
                txtHo.Focus();
                pbcheckAdd = true;
            }
            else if (txtHo.Text == "" || txtTen.Text == "" || txtEducation.Text == "" || txtCMND.Text == "" || txtDiaChi.Text == "" || txtDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin các ô!");
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("select CMND from Nhanvien where CMND = '" + txtCMND.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("CMND có cùng mã số với người khác!!!");
                }
                else
                {
                    string cbCV = cbChucVu.SelectedValue.ToString();
                    cbChucVu.SelectedItem.ToString();
                    int maPB = Convert.ToInt32(cbPhongBan.SelectedValue);
                    bus.ThemNV(cbCV, maPB, txtGT.Text, txtTen.Text, txtHo.Text, dtpNgaySinh.Value, int.Parse(txtCMND.Text), txtDT.Text, txtDiaChi.Text, txtEducation.Text);
                    dgNhanVien.Columns.Clear();
                    bus.HienthiDSNV(dgNhanVien);
                }
            }

        }
        //Button Sua NV
        private void btSua_Click(object sender, EventArgs e)
        {

            string JobID = cbChucVu.SelectedValue.ToString();
            cbChucVu.SelectedItem.ToString();
            int DepartmentID = Convert.ToInt32(cbPhongBan.SelectedValue);
            int maNV = int.Parse(dgNhanVien.CurrentRow.Cells["EmployeeID"].Value.ToString());
            MessageBox.Show("++ " + maNV);
            bus.CapNhatNV(JobID, DepartmentID, txtGT.Text, txtTen.Text, txtHo.Text, dtpNgaySinh.Value, int.Parse(txtCMND.Text), txtDT.Text, txtDiaChi.Text, txtEducation.Text, maNV);
            dgNhanVien.Columns.Clear();
            bus.HienthiDSNV(dgNhanVien);

        }

        // Button xoa NV
        private void btXoa_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(dgNhanVien.CurrentRow.Cells["EmployeeID"].Value.ToString());
            bus.xoaNV(maNV);
            dgNhanVien.Columns.Clear();
            bus.HienthiDSNV(dgNhanVien);
        }

        // su kien radio button
        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNam.Checked)
            {
                txtGT.Text = "NAM";
            }
            
           
        }
        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Checked)
            {
                txtGT.Text = "NU";
            }
            
            
        }
        // Tim Kiem text change
        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
            loaddataviewe();

        }


        private void loaddataviewe()
        {
            DataTable dt = new DataTable("Nhanvien");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Nhanvien", conn);
            da.Fill(dt);
            dgNhanVien.DataSource = dt;
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("FirstName like '%{0}%'", txtTimTen.Text);
            dgNhanVien.DataSource = dv.ToTable();
            dgNhanVien.Enabled = false;
        }
        //Su kien cac phim bam 
        private void txtTimTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numberonly(sender, e);
        }
        private void txtHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letteronly(sender, e);
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letteronly(sender, e);

        }

        private void txtDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numberonly(sender, e);
        }

        // ham input chi nhap so
        private void Numberonly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Letteronly(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        // ham kiem tra do dai toi da
        private void checkLength()
        {
            txtHo.MaxLength = 20;
            txtTen.MaxLength = 10;
            txtCMND.MaxLength = 10;
            txtDiaChi.MaxLength = 10;
            txtDT.MaxLength = 10;
            txtEducation.MaxLength = 10;
            txtHo.Focus();
            txtTimTen.MaxLength = 10;
        }

       
    }
}
