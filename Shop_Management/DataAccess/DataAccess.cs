﻿using Shop_Management.Control;
using Shop_Management.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management.DataAccess
{
    class DataAccess
    {
        private DatabaseConnection.DatabaseConnection _databaseConnection = new();
        private Master _master;
        public DataAccess(Master master)
        {
            _master = master;
        }

        public bool UserNameExists(string name)
        {
            if (_databaseConnection.OpenConnection())
            {
                string query = $"SELECT COUNT(*) FROM Users WHERE UserName = '{name}'";
                SqlCommand cmd = new(query, _databaseConnection.GetConnectionString());
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                try
                {
                    _databaseConnection.CloseConnection();
                }
                catch (Exception e)
                {
                    _master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                }
                if (count> 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                _master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                return true;
            }
        }
        public bool RegisterUser(User user)
        {
            if (_databaseConnection.OpenConnection())
            {
                string query = "INSERT INTO Users " +
                    "(UserName, Name, Password, Approved, Role)" +
                    $"VALUES ('{user.UserName}', '{user.Name}', '{user.Password}', {Convert.ToByte(user.Approved)}, {Convert.ToByte(user.Role)})";

                SqlCommand cmd = new(query, _databaseConnection.GetConnectionString());

                try
                {
                    cmd.ExecuteNonQuery();
                    try
                    {
                        _databaseConnection.CloseConnection();
                    }
                   catch(Exception e)
                    {
                        _master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                    }
                    return true;
                }
                catch(Exception e)
                {
#if DEBUG
                    Trace.WriteLine(e.ToString());
#endif
                    return false;
                }
            }
            else
            {
                _master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                return false;
            }
        }

        public User IsUSerValid(User user)
        {
            string query = $"SELECT * FROM Users WHERE UserName = '{user.UserName}' AND Password = '{user.Password}'";
            SqlCommand cmd = new(query, _databaseConnection.GetConnectionString());
            
            if (_databaseConnection.OpenConnection())
            {
                try
                {
                    SqlDataReader result = cmd.ExecuteReader();
                    if (result.HasRows)
                    {
                        User userFromDB = new();
                        while (result.Read())
                        {
                            userFromDB.UserID = Convert.ToInt32(result["UserID"]);
                            userFromDB.Name = Convert.ToString(result["Name"]);
                            userFromDB.Approved = Convert.ToBoolean(result["Approved"]);
                            userFromDB.Role = Convert.ToBoolean(result["Role"]);
                            return userFromDB;
                        }
                        try
                        {
                            _databaseConnection.CloseConnection();
                        }
                        catch (Exception e)
                        {
                            _master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                        }
                        return userFromDB;
                    }
                    else
                    {
                        User userFromDB = null;
                        return userFromDB;
                    }
                }
                catch (Exception e)
                {
#if DEBUG
                    Trace.WriteLine(e.ToString());
#endif
                    User userFromDB = null;
                    return userFromDB;
                }
            }
            else
            {
                _master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                User userFromDB = null;
                return userFromDB;
            }
        }
    }
}
