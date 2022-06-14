using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagement1
{
    class BUSDepartment
    {
        DAODepartment daoDepartment;
        public BUSDepartment()
        {
            daoDepartment = new DAODepartment();
        }
        public void GetDepartment(DataGridView dg)
        {
            dg.DataSource = daoDepartment.GetDepartment();
        }

        public void GetIDDepartmetn(ComboBox b, TextBox a, TextBox c)
        {
            b.DataSource = daoDepartment.GetIDDepartmetn();
            b.ValueMember = "DepartmentID";
            b.DisplayMember = "DepartmentName";
            a.DataBindings.Clear();
            a.DataBindings.Add("Text", b.DataSource, "DepartmentID");
            c.DataBindings.Clear();
            c.DataBindings.Add("Text", b.DataSource, "DepartmentName");
        }

        public void GetNV(ComboBox b, TextBox a, TextBox c)
        {
            b.DataSource = daoDepartment.GetNV();
            b.ValueMember = "EmployeeID";
            a.DataBindings.Clear();
            a.DataBindings.Add("Text", b.DataSource, "FullName");
            c.DataBindings.Clear();
            c.DataBindings.Add("Text", b.DataSource, "JobTitle");
        }

        public void themPB(string departmentName)
        {
            daoDepartment.themPB(departmentName);
        }
        public void UpPB(string departmentName,int IDDepartment)
        {
            daoDepartment.UpPB(departmentName, IDDepartment);
        }
        public void xoaNV(int IDDepartment)
        {
            daoDepartment.xoaPB(IDDepartment);
        }
        public void UPNvPB(int IDDepartment, int EmployeeID)
        {
            daoDepartment.UPNvPB(IDDepartment, EmployeeID);
        }
    }
}
