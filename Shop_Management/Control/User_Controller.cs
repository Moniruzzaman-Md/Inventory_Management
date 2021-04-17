using Inventory_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management.Control
{
    class User_Controller
    {
        private Master _master;
        private DataAccess.DataAccess _dataAccess;

        public User_Controller(Master master)
        {
            _master = master;
            _dataAccess = new(_master);
        }

        public bool SaveUserImage(byte[] image, int userId)
        {
            return _dataAccess.SaveUserImage(image, userId);
        }

        public User GetUserDetails (int UserID)
        {
            return _dataAccess.GetUserDetails(UserID);
        }

        public bool UpdateUserName(string UserName, int UserId)
        {
            return _dataAccess.UpdateUserName(UserName, UserId);
        }

        public bool UpdateName(string Name, int UserId)
        {
            return _dataAccess.UpdateName(Name, UserId);
        }

        public bool CheckOldPassowrd(string password, int id)
        {
            return _dataAccess.CheckOldPassowrd(password, id);
        }

        public bool UpdatPassword(string Password, int UserId)
        {
            return _dataAccess.UpdatPassword(Password, UserId);
        }
    }


}
