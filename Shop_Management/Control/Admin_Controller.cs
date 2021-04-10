using Shop_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management.Control
{
    class Admin_Controller
    {
        private Master _master;
        private DataAccess.DataAccess _dataAccess;

        public Admin_Controller(Master master)
        {
            _master = master;
            _dataAccess = new(_master);
        }
        public List<User> GetUnapprovedUsers()
        {
            return _dataAccess.GetUnapprovedUsers();
        }

        public bool ApproveUser(int id)
        {
            return _dataAccess.ApproveUser(id);
        }
    }
}
