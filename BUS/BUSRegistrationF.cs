using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagement1
{
    class BUSRegistrationF
    {
        DAO dao;
        public BUSRegistrationF()
        {
            dao = new DAO();
        }
        public void AddUser(string Username, string Password, string Name, string Email, DateTime Date)
        {
            dao.AddUser(Username, Password, Name, Email, Date);
        }
    }
}
