using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace StaffManagement1
{
    class BUSPayroll
    {
        DAOPayroll daopay;
        public BUSPayroll()
        {
            daopay = new DAOPayroll();
        }
        public void HienThi_Payroll(DataGridView dg)
        {
            dg.DataSource = daopay.LayDS_Payroll();
        }

        public void GetIDEmployee1(ComboBox b,TextBox a, TextBox c, TextBox d,  TextBox e )
        {
            b.DataSource = daopay.GetIDEmployee();
            b.ValueMember = "EmployeeID";
            a.DataBindings.Clear();
            a.DataBindings.Add("Text", b.DataSource, "JobTitle");
            c.DataBindings.Clear();
            c.DataBindings.Add("Text", b.DataSource, "FName");
            d.DataBindings.Clear();
            d.DataBindings.Add("Text", b.DataSource, "DailyRate");
            e.DataBindings.Clear();
            e.DataBindings.Add("Text", b.DataSource, "OverRate");
            
        }
        public void GetEmployee(ComboBox b, TextBox a, TextBox c, TextBox d, TextBox e, TextBox f, TextBox g, TextBox k, TextBox j, TextBox h)
        {
            b.DataSource = daopay.GetEmployee();
            b.ValueMember = "EmployeeID";
            a.DataBindings.Clear();
            a.DataBindings.Add("Text", b.DataSource, "JobTitle");
            c.DataBindings.Clear();
            c.DataBindings.Add("Text", b.DataSource, "FName");
            d.DataBindings.Clear();
            d.DataBindings.Add("Text", b.DataSource, "DailyRate");
            e.DataBindings.Clear();
            e.DataBindings.Add("Text", b.DataSource, "OverRate");
            f.DataBindings.Clear();
            f.DataBindings.Add("Text", b.DataSource, "WorkDay");
            g.DataBindings.Clear();
            g.DataBindings.Add("Text", b.DataSource, "OTHour");
            k.DataBindings.Clear();
            k.DataBindings.Add("Text", b.DataSource, "GrossOT");
            j.DataBindings.Clear();
            j.DataBindings.Add("Text", b.DataSource, "GrossWage");
            h.DataBindings.Clear();
            h.DataBindings.Add("Text", b.DataSource, "GrossIncome");
        }
        public void UpdatePayroll(int maNV, int WD, int OTtime, double grossWage, double grossOt, double NetIncome)
        {
            daopay.UpdatePayroll(maNV, WD, OTtime, grossWage, grossOt, NetIncome);
        }
        public void ThemBangLuong(int maNV, int WD, int OTtime, double grossWage, double grossOt, double NetIncome)
        {
            daopay.ThemBangLuong(maNV, WD, OTtime, grossWage, grossOt, NetIncome);
        }
        public void xoaPhieuLuong(int EmployeeID)
        {
            daopay.xoaPhieuLuong(EmployeeID);
        }

    }

}
