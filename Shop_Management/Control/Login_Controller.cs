using Inventory_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management.Control
{
    class Login_Controller
    {
        private Master _master;
        private DataAccess.DataAccess _dataAccess;
        public Login_Controller(Master master)
        {
            _master = master;
            _dataAccess = new(_master);
        }

        public User IsUserValid(User user)
        {
            return _dataAccess.IsUSerValid(user);
        }
    }
}
