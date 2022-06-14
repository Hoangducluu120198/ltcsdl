using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;

namespace StaffManagement1
{

    class BUS_NhanVien
    {

        DAO_NhanVien da;

        public BUS_NhanVien()
        {
            da = new DAO_NhanVien();

        }

        public void HienthiDSNV(DataGridView dg)
        {
            dg.DataSource = da.LayDSNV();
        }
        public void HienthiChucVu(ComboBox cb)
        {
            cb.DataSource = da.LayChucVu();
            cb.DisplayMember = "JobTitle";
            cb.ValueMember = "JobID";
        }
        public void HienthiDSPhongBan(ComboBox cb)
        {
            cb.DataSource = da.LayDSPhongBan();
            cb.DisplayMember = "DepartmentName";
            cb.ValueMember = "DepartmentID";
        }

        public void ThemNV(string JobID, int DepartmentID, string Gender, string firstName, string LastName, DateTime BirthDay, int CMND, string PhoneNumber, string Address, string Education)
        {
            da.ThemNV(JobID, DepartmentID, Gender, firstName, LastName, BirthDay, CMND, PhoneNumber, Address, Education);
        }

        public void CapNhatNV(string JobID, int DepartmentID, string Gender, string firstName, string LastName, DateTime BirthDay, int CMND, string PhoneNumber, string Address, string Education, int employID)

        {
            da.CapNhatNV(JobID, DepartmentID, Gender, firstName, LastName, BirthDay, CMND, PhoneNumber, Address, Education, employID);
        }

        public void xoaNV(int EmployID)
        {
            da.xoaNV(EmployID);
        }
        
    }
}
