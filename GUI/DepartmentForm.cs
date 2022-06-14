using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagement1
{
    public partial class DepartmentForm : Form
    {
        BUSDepartment busDP;
        bool pbUP = false;
        int num, num2;
        public DepartmentForm()
        {
            InitializeComponent();
            busDP = new BUSDepartment();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            txtDepartment.MaxLength = 20;

            dgDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            busDP.GetIDDepartmetn(cbDepartment,txtIDDepartment,txtDepartment);
            
            
        }
        

        private void dgDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgDepartment.Rows.Count)
            {
                txtIdNV.Text = dgDepartment.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                txtNameNV.Text = dgDepartment.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                txtTitleNV.Text = dgDepartment.Rows[e.RowIndex].Cells["JobTitle"].Value.ToString();
            
            }
        }
        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IDselected();
                string cnStr = ConfigurationManager.ConnectionStrings["cntr"].ConnectionString;
                SqlConnection conn = new SqlConnection(cnStr);
                var dap = new SqlDataAdapter("select a.EmployeeID, a.LastName + ' ' + a.FirstName as FullName , a.Gender , a.CMND, b.DepartmentName, c.JobTitle " +
                    "from Nhanvien a, PhongBan b, Jobtitle c where a.DepartmentID = b.DepartmentID and a.JobID = c.JobID and b.DepartmentID = " + num + "", conn);
                var ds = new DataTable();
                dap.Fill(ds);
                dgDepartment.DataSource = ds;
            }
            catch
            {
                MessageBox.Show("Truy xuat du lieu that bai");
            }

        }
        
        //Nut them NV vao PB
        private void btAddNvPB_Click(object sender, EventArgs e)
        {
            txtIdNV.Text = "";
            txtNameNV.Text = "";
            txtTitleNV.Text = "";
            busDP.GetNV(cbNV, txtNameNV, txtTitleNV);

        }

        //Nut them PB
        private void btaddDepartment_Click(object sender, EventArgs e)
        {
            txtIDDepartment.Text = "";
            txtDepartment.Text = "";
            txtDepartment.Focus();
            pbUP = true;
        }
        
        //nut Update PB
        private void btSavingPB_Click(object sender, EventArgs e)
        {
            if (pbUP == true)
            {
                busDP.themPB(txtDepartment.Text);
                dgDepartment.Columns.Clear();
                busDP.GetIDDepartmetn(cbDepartment, txtIDDepartment, txtDepartment);

            }
            else
            {
                busDP.UpPB(txtDepartment.Text,num);
                dgDepartment.Columns.Clear();
                busDP.GetIDDepartmetn(cbDepartment, txtIDDepartment, txtDepartment);
            }
        }

        //nut Xoa PB
        private void btDeletePB_Click(object sender, EventArgs e)
        {
                busDP.xoaNV(num);
                dgDepartment.Columns.Clear();
                busDP.GetIDDepartmetn(cbDepartment, txtIDDepartment, txtDepartment);
            
        }

        //update PB
        private void btSavingNvPB_Click(object sender, EventArgs e)
        {
            int ISNVPB = int.Parse(cbNV.SelectedValue.ToString());
            busDP.UPNvPB(num, ISNVPB);
            dgDepartment.Columns.Clear();
            busDP.GetIDDepartmetn(cbDepartment, txtIDDepartment, txtDepartment);


        }
        //Xoa Nhan Vien khoi Pb
        private void btDeleteNvPB_Click(object sender, EventArgs e)
        {
            num2 = 1;
            int maNV = int.Parse(dgDepartment.CurrentRow.Cells["EmployeeID"].Value.ToString());
            busDP.UPNvPB(num2, maNV);
            dgDepartment.Columns.Clear();
            busDP.GetIDDepartmetn(cbDepartment, txtIDDepartment, txtDepartment);

        }

        //ham combobox selected
        private void IDselected()
        {
            if (cbDepartment.SelectedValue.ToString() == "1")
            {
                num = 1;
            }
            else if (cbDepartment.SelectedValue.ToString() == "2")
            {
                num = 2;
            }
            else if (cbDepartment.SelectedValue.ToString() == "3")
            {
                num = 3;
            }
            else if (cbDepartment.SelectedValue.ToString() == "4")
            {
                num = 4;
            }
            else if (cbDepartment.SelectedValue.ToString() == "5")
            {
                num = 5;
            }
            else if (cbDepartment.SelectedValue.ToString() == "6")
            {
                num = 6;
            }
            else if (cbDepartment.SelectedValue.ToString() == "7")
            {
                num = 7;
            }
            else if (cbDepartment.SelectedValue.ToString() == "8")
            {
                num = 8;
            }
            else if (cbDepartment.SelectedValue.ToString() == "9")
            {
                num = 9;
            }
            else if (cbDepartment.SelectedValue.ToString() == "10")
            {
                num = 10;
            }
            else if (cbDepartment.SelectedValue.ToString() == "11")
            {
                num = 11;
            }
            else if (cbDepartment.SelectedValue.ToString() == "12")
            {
                num = 12;
            }
            else if (cbDepartment.SelectedValue.ToString() == "13")
            {
                num = 13;
            }
            else if (cbDepartment.SelectedValue.ToString() == "14")
            {
                num = 14;

            }
            else if (cbDepartment.SelectedValue.ToString() == "15")
            {
                num = 15;
            }
            else if (cbDepartment.SelectedValue.ToString() == "16")
            {
                num = 16;
            }
            else if (cbDepartment.SelectedValue.ToString() == "17")
            {
                num = 17;
            }
            else if (cbDepartment.SelectedValue.ToString() == "18")
            {
                num = 18;
            }
            else if (cbDepartment.SelectedValue.ToString() == "19")
            {
                num = 19;
            }
            else if (cbDepartment.SelectedValue.ToString() == "20")
            {
                num = 20;
            }
            else if (cbDepartment.SelectedValue.ToString() == "21")
            {
                num = 21;
            }

        }

        
    }
}
