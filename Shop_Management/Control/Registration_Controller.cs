using Inventory_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management.Control
{
    class Registration_Controller
    {
        private DataAccess.DataAccess _dataAccess;
        private Master _master;
        public Registration_Controller(Master master)
        {
            _master = master;
            _dataAccess = new(_master);
        }
        public bool RegisterUser(User user)
        {
            return _dataAccess.RegisterUser(user);
        }
        public bool UserNameExists(string name)
{
            return _dataAccess.UserNameExists(name);
        }
    }
}
