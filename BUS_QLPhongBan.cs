using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLPB
{
    class BUS_QLPhongBan
    {
        DAO_QLPhongBan da;
        public BUS_QLPhongBan()
        {
            da = new DAO_QLPhongBan();
        }
        public DataTable LayDS_PB()
        {
            return da.LayDS_BP();
        }
        public void HienThiDSBP(ComboBox cbmaBP)
        {
            cbmaBP.DataSource = da.LayDS_BP();
            cbmaBP.DisplayMember = "MaBP";
            cbmaBP.ValueMember = "TenBP";
        }
        public void HienThiDSPB(DataGridView dg)
        {
            dg.DataSource = da.LayDS_PB();
        }
        public void themPB(string DepartmentID, string DepartmentName, string maBP, DateTime NgayThanhLap, string GhiChu)
        {
            da.themPB(DepartmentID, DepartmentName, maBP, NgayThanhLap, GhiChu);
        }
        public void suaPB(string DepartmentID, string DepartmentName, string maBP, DateTime NgayThanhLap, string GhiChu)
        {
            da.suaPB(DepartmentID, DepartmentName, maBP, NgayThanhLap, GhiChu);
        }
        public void xoaPB(string DepartmentID)
        {
            da.xoaPB(DepartmentID);
        }
    }
}
