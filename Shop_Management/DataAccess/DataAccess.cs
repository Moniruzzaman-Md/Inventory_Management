using Inventory_Management.Control;
using Inventory_Management.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management.DataAccess
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
                try
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    try
                    {
                        _databaseConnection.CloseConnection();
                    }
                    catch (Exception e)
                    {
#if DEBUG
                        Trace.WriteLine(e.ToString());
#endif
                        _master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                    }
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
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
                return true;
            }
        }
        public bool RegisterUser(User user)
        {
            if (_databaseConnection.OpenConnection())
            {
                string query = "INSERT INTO Users " +
                    "(UserName, Name, Password, Approved, Role)" +
                    $"VALUES ('{user.UserName}', '{user.Name}', '{user.Password}', '{user.Approved}', {Convert.ToByte(user.Role)})";

                SqlCommand cmd = new(query, _databaseConnection.GetConnectionString());

                try
                {
                    cmd.ExecuteNonQuery();
                    try
                    {
                        _databaseConnection.CloseConnection();
                    }
                    catch (Exception e)
                    {
#if DEBUG
                        Trace.WriteLine(e.ToString());
#endif
                        _master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                    }
                    return true;
                }
                catch (Exception e)
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
                            userFromDB.Approved = Convert.ToString(result["Approved"]);
                            userFromDB.Role = Convert.ToBoolean(result["Role"]);
                        }
                        try
                        {
                            _databaseConnection.CloseConnection();
                        }
                        catch (Exception e)
                        {
#if DEBUG
                            Trace.WriteLine(e.ToString());
#endif
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

        public List<User> GetUnapprovedUsers()
        {
            string query = "SELECT * FROM Users WHERE Approved = 'Unapproved'";
            SqlCommand cmd = new(query, _databaseConnection.GetConnectionString());

            if (_databaseConnection.OpenConnection())
            {
                try
                {
                    SqlDataReader result = cmd.ExecuteReader();
                    if (result.HasRows)
                    {
                        List<User> users = new();
                        while (result.Read())
                        {
                            User user = new();
                            user.UserID = Convert.ToInt32(result["UserID"]);
                            user.Name = Convert.ToString(result["Name"]);
                            user.Approved = Convert.ToString(result["Approved"]);
                            user.Role = Convert.ToBoolean(result["Role"]);
                            user.UserName = Convert.ToString(result["UserName"]);
                            users.Add(user);
                        }
                        try
                        {
                            _databaseConnection.CloseConnection();
                        }
                        catch (Exception e)
                        {
#if DEBUG
                            Trace.WriteLine(e.ToString());
#endif
                            _master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                        }
                        return users;
                    }
                    else
                    {
                        List<User> users = null;
                        return users;
                    }
                }
                catch (Exception e)
                {
#if DEBUG
                    Trace.WriteLine(e.ToString());
#endif
                    List<User> users = null;
                    return users;
                }
            }
            else
            {
                _master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                List<User> users = null;
                return users;
            }
        }

        public bool ApproveUser(int id)
        {
            string query = $"UPDATE Users SET Approved = 'Approved' WHERE UserID = '{id}'";
            SqlCommand cmd = new(query, _databaseConnection.GetConnectionString());
            if (_databaseConnection.OpenConnection())
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    try
                    {
                        _databaseConnection.CloseConnection();
                    }
                    catch (Exception e)
                    {
#if DEBUG
                        Trace.WriteLine(e.ToString());
#endif
                        _master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                    }
                    return true;

                }
                catch (Exception e)
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

        public bool RestrictUser(int id)
        {
            string query = $"UPDATE Users SET Approved = 'Restricted' WHERE UserID = '{id}'";
            SqlCommand cmd = new(query, _databaseConnection.GetConnectionString());
            if (_databaseConnection.OpenConnection())
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    try
                    {
                        _databaseConnection.CloseConnection();
                    }
                    catch (Exception e)
                    {
#if DEBUG
                        Trace.WriteLine(e.ToString());
#endif
                        _master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                    }
                    return true;

                }
                catch (Exception e)
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

        public bool AddInventory(Product product)
        {
            if (_databaseConnection.OpenConnection())
            {
                string query = "INSERT INTO Products" +
                "(ProductName, Price, Quantity, Approved)" +
                $"VALUES ('{product.ProductName}','{product.Price}','{product.Quantity}', '{Convert.ToByte(product.Approved)}')";

                SqlCommand cmd = new(query, _databaseConnection.GetConnectionString());
                try
                {
                    cmd.ExecuteNonQuery();
                    try
                    {
                        _databaseConnection.CloseConnection();
                    }
                    catch (Exception e)
                    {
#if DEBUG
                        Trace.WriteLine(e.ToString());
#endif
                        _master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                    }
                    return true;
                }
                catch (Exception e)
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

        public bool ProductExists(string name)
        {
            if (_databaseConnection.OpenConnection())
            {
                string query = $"SELECT COUNT(*) FROM Products WHERE ProductName = '{name}'";
                SqlCommand cmd = new(query, _databaseConnection.GetConnectionString());
                try
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    try
                    {
                        _databaseConnection.CloseConnection();
                    }
                    catch (Exception e)
                    {
#if DEBUG
                        Trace.WriteLine(e.ToString());
#endif
                        _master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                    }
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
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
                return true;
            }
        }

        public List<Product> GetUnapprovedProducts()
        {
            string query = "SELECT * FROM Products WHERE Approved = 0";
            SqlCommand cmd = new(query, _databaseConnection.GetConnectionString());

            if (_databaseConnection.OpenConnection())
            {
                try
                {
                    SqlDataReader result = cmd.ExecuteReader();
                    if (result.HasRows)
                    {
                        List<Product> products = new();
                        while (result.Read())
                        {
                            Product product = new();
                            product.ProductID = Convert.ToInt32(result["ProductID"]);
                            product.ProductName = Convert.ToString(result["ProductName"]);
                            product.Approved = Convert.ToBoolean(result["Approved"]);
                            product.Price = Convert.ToInt32(result["Price"]);
                            products.Add(product);
                        }
                        try
                        {
                            _databaseConnection.CloseConnection();
                        }
                        catch (Exception e)
                        {
#if DEBUG
                            Trace.WriteLine(e.ToString());
#endif
                            _master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                        }
                        return products;
                    }
                    else
                    {
                        List<Product> products = null;
                        return products;
                    }
                }
                catch (Exception e)
                {
#if DEBUG
                    Trace.WriteLine(e.ToString());
#endif
                    List<Product> products = null;
                    return products;
                }
            }
            else
            {
                _master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                List<Product> products = null;
                return products;
            }
        }
    }
}
