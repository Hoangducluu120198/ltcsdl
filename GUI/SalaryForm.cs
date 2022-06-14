using CrystalDecisions.CrystalReports.Engine;
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
    public partial class SalaryForm : Form
    {
        SqlConnection conn;
        BUSPayroll buspayrol;
        double OT, WorkDay, GrossWage, grossOT, NetInCom;       

        public SalaryForm()
        {
            InitializeComponent();
            buspayrol = new BUSPayroll();
            string cnStr = System.Configuration.ConfigurationManager.ConnectionStrings["cntr"].ConnectionString;
            conn = new SqlConnection(cnStr);


        }
        //Ham Load
        private void SalaryForm_Load(object sender, EventArgs e)
        {
            load_data();
            checkLength();
            buspayrol.HienThi_Payroll(dgPayroll);
            dgPayroll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }


        //nut Report
        private void btReport_Click(object sender, EventArgs e)
        {

            ReportViewF RePF = new ReportViewF();
            RePF.Show();


        }

        //nut Delete

        private void btDelete_Click(object sender, EventArgs e)
        {
            int IdNV;
            IdNV = int.Parse(cbIDEmployee.SelectedValue.ToString());
            buspayrol.xoaPhieuLuong(IdNV); ;
            dgPayroll.Columns.Clear();
            buspayrol.HienThi_Payroll(dgPayroll);
        }
        
        //Nut submitt
        private void btSubmit_Click(object sender, EventArgs e)
        {

            int number;
            if (int.TryParse(txtWD.Text, out number))
            {
                if (number <= 30)
                {
                    try
                    {
                        Calulating();
                        MessageBox.Show("Successfull!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Số ngày làm việc lớn hơn 30! Vui lòng nhập lại");
                }

            }
        }
        //su kien cellclick
        private void dgPayroll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgPayroll.Rows.Count)
            {  
                cbIDEmployee.Text = dgPayroll.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                txtWD.Text = dgPayroll.Rows[e.RowIndex].Cells["WorkDay"].Value.ToString();
                txtOtTime.Text = dgPayroll.Rows[e.RowIndex].Cells["OTHour"].Value.ToString();
                txtSumDD.Text = dgPayroll.Rows[e.RowIndex].Cells["GrossWage"].Value.ToString();
                txtSumOT.Text = dgPayroll.Rows[e.RowIndex].Cells["GrossOT"].Value.ToString();
                txtGross.Text = dgPayroll.Rows[e.RowIndex].Cells["GrossIncome"].Value.ToString();
            }
        }

        //cap nhat du lieu
        private void button2_Click(object sender, EventArgs e)
        {
            Calulating();
            int IdNV;
            IdNV = int.Parse(cbIDEmployee.SelectedValue.ToString());
            SqlDataAdapter da = new SqlDataAdapter("select EmployeeID from Payroll where EmployeeID = '" + IdNV + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                buspayrol.UpdatePayroll(IdNV, int.Parse(txtWD.Text), int.Parse(txtOtTime.Text), double.Parse(txtSumDD.Text), double.Parse(txtSumOT.Text), double.Parse(txtGross.Text));
                dgPayroll.Columns.Clear();
                buspayrol.HienThi_Payroll(dgPayroll);
                
            }
            else
            {
                buspayrol.ThemBangLuong(IdNV, int.Parse(txtWD.Text), int.Parse(txtOtTime.Text), double.Parse(txtSumDD.Text), double.Parse(txtSumOT.Text), double.Parse(txtGross.Text));
                dgPayroll.Columns.Clear();
                buspayrol.HienThi_Payroll(dgPayroll);
            }
        }
        //Ham gioi han ky tu
        private void checkLength()
        {
            txtOtTime.MaxLength = 2;
            txtWD.MaxLength = 2;         

        }

        private void txtWD_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numberonly(sender,e);
            
        }

        private void cbIDEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtWD.Text = "";
            txtOtTime.Text = "";


        }

        private void txtOtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numberonly(sender, e);
        }

        //Ham chi nhap so
        private void Numberonly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Ham LoadData
        private void load_data()
        {

            buspayrol.GetIDEmployee1(cbIDEmployee, txtTitle, txtName, txtRPD, txtOTR);
            
        }

 
        //Ham tinh toan
        private void Calulating()
        {
            //WorkDay = Double.Parse(txtWD.Text);
            //OT = Double.Parse(txtOtTime.Text);
            //Tinh tien OT
            if (txtOtTime.Text == "0" || txtOtTime.Text == "")
            {
                txtSumOT.Text = "0";
                txtOtTime.Text = "0";
                grossOT = double.Parse(txtSumOT.Text);
            }
            else
            {
                grossOT = double.Parse(txtOtTime.Text) * double.Parse(txtOTR.Text);
                txtSumOT.Text = grossOT.ToString();
            }
            //Tinh tien Luong thang
            if (txtWD.Text == "0" || txtWD.Text == "")
            {
                txtWD.Text = "0";
                txtSumDD.Text = "0";
                GrossWage = double.Parse(txtSumDD.Text);
            }
            else
            {
                GrossWage = double.Parse(txtWD.Text) * double.Parse(txtRPD.Text);
                txtSumDD.Text = GrossWage.ToString();
            }
            //Tong Tien
            NetInCom = GrossWage + grossOT;
            txtGross.Text = NetInCom.ToString();
        }

    }
}
