using Inventory_Management.Control;
using Inventory_Management.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
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
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
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
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
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
                            userFromDB.UserName = Convert.ToString(result["USerName"]);
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
                            Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                        }
                        try
                        {
                            if (_databaseConnection.OpenConnection())
                            {
                                string imageQuery = $"SELECT Image FROM UserImage WHERE UserID = {userFromDB.UserID}";
                                SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand(imageQuery, _databaseConnection.GetConnectionString()));
                                DataSet dataSet = new DataSet();
                                dataAdapter.Fill(dataSet);
                                if (dataSet.Tables[0].Rows.Count == 1)
                                {
                                    Byte[] data = new Byte[0];
                                    data = (Byte[])(dataSet.Tables[0].Rows[0]["Image"]);
                                    userFromDB.image = data;
                                }
                            }
                        }
                        catch (Exception e)
                        {
#if DEBUG
                            Trace.WriteLine(e.ToString());
#endif
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
                            Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                User userFromDB = null;
                return userFromDB;
            }
        }

        public User GetUserDetails(int UserID)
        {
            string query = $"SELECT * FROM Users WHERE UserID = '{UserID}'";
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
                            userFromDB.UserName = Convert.ToString(result["USerName"]);
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
                            Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                        }
                        try
                        {
                            if (_databaseConnection.OpenConnection())
                            {
                                string imageQuery = $"SELECT Image FROM UserImage WHERE UserID = {userFromDB.UserID}";
                                SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand(imageQuery, _databaseConnection.GetConnectionString()));
                                DataSet dataSet = new DataSet();
                                dataAdapter.Fill(dataSet);
                                if (dataSet.Tables[0].Rows.Count == 1)
                                {
                                    Byte[] data = new Byte[0];
                                    data = (Byte[])(dataSet.Tables[0].Rows[0]["Image"]);
                                    userFromDB.image = data;
                                }
                            }
                        }
                        catch (Exception e)
                        {
#if DEBUG
                            Trace.WriteLine(e.ToString());
#endif
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
                            Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
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
                            Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
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
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
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
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
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
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
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
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
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
                            Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                List<Product> products = null;
                return products;
            }
        }

        public bool ApproveInventory(int id)
        {
            string query = $"UPDATE Products SET Approved = 1 WHERE ProductID = '{id}'";
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
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                return false;
            }
        }


        public bool DeleteInventory(int id)
        {
            string query = $"DELETE FROM Products WHERE ProductID = '{id}'";
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
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                return false;
            }
        }

        public List<Product> GetAllProducts()
        {
            string query = "SELECT * FROM Products WHERE Approved = 1";
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
                            product.Quantity = Convert.ToInt32(result["Quantity"]);
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
                            Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                List<Product> products = null;
                return products;
            }
        }

        public bool SaveUserImage(byte[] image, int userId)
        {
            string checkquery = $"SELECT COUNT(*) FROM UserImage WHERE UserID = '{userId}'";
            SqlCommand cmd = new(checkquery, _databaseConnection.GetConnectionString());

            if (_databaseConnection.OpenConnection())
            {
                try
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        try
                        {
                            string query = $"UPDATE UserImage SET Image = @image WHERE UserID = @UserID";
                            cmd = new(query, _databaseConnection.GetConnectionString());
                            cmd.Parameters.Add(new SqlParameter("@image", image));
                            cmd.Parameters.Add(new SqlParameter("@UserID", userId));
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
                                Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                            }
                            return true;
                        }
                        catch (Exception e)
                        {
#if DEBUG
                            Trace.WriteLine(e.ToString());

                            try
                            {
                                _databaseConnection.CloseConnection();
                            }
                            catch (Exception ex)
                            {
#if DEBUG
                                Trace.WriteLine(ex.ToString());
#endif
                                Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                            }
#endif
                            return false;
                        }

                    }
                    else
                    {
                        try
                        {
                            string query = $"INSERT INTO UserImage" +
                                $"(UserID, Image)" +
                                $"VALUES (@UserID, @image)";
                            cmd = new(query, _databaseConnection.GetConnectionString());
                            cmd.Parameters.Add(new SqlParameter("@image", image));
                            cmd.Parameters.Add(new SqlParameter("@UserID", userId));
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
                                Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                            }

                            return true;
                        }
                        catch (Exception e)
                        {
#if DEBUG
                            Trace.WriteLine(e.ToString());

                            try
                            {
                                _databaseConnection.CloseConnection();
                            }
                            catch (Exception ex)
                            {
#if DEBUG
                                Trace.WriteLine(ex.ToString());
#endif
                                Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                            }
#endif
                            return false;
                        }
                    }
                }
                catch (Exception e)
                {
#if DEBUG
                    Trace.WriteLine(e.ToString());

                    try
                    {
                        _databaseConnection.CloseConnection();
                    }
                    catch (Exception ex)
                    {
#if DEBUG
                        Trace.WriteLine(ex.ToString());
#endif
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                    }
#endif
                    return false;
                }
               
            }
            else
            {
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                return true;
            }
        }

        public bool UpdateUserName(string UserName, int UserId)
        {
            string query = $"UPDATE Users SET UserName = '{UserName}' WHERE UserID = '{UserId}'";
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
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                return false;
            }
        }

        public bool UpdateName(string Name, int UserId)
        {
            string query = $"UPDATE Users SET Name = '{Name}' WHERE UserID = '{UserId}'";
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
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                return false;
            }
        }

        public bool CheckOldPassowrd(string password, int id)
        {
            if (_databaseConnection.OpenConnection())
            {
                string query = $"SELECT COUNT(*) FROM Users WHERE UserID = '{id}' AND Password = '{password}'";
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
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                return true;
            }
        }

        public bool UpdatPassword(string Password, int UserId)
        {
            string query = $"UPDATE Users SET Password = '{Password}' WHERE UserID = '{UserId}'";
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
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                return false;
            }
        }

        public Product GetProductDetails(int ProductID)
        {
            string query = $"SELECT * FROM Products WHERE ProductID = '{ProductID}'";
            SqlCommand cmd = new(query, _databaseConnection.GetConnectionString());

            if (_databaseConnection.OpenConnection())
            {
                try
                {
                    SqlDataReader result = cmd.ExecuteReader();
                    if (result.HasRows)
                    {
                        Product products = new();
                        while (result.Read())
                        {
                            products.ProductID = Convert.ToInt32(result["ProductID"]);
                            products.ProductName = Convert.ToString(result["ProductName"]);
                            products.Approved = Convert.ToBoolean(result["Approved"]);
                            products.Price = Convert.ToInt32(result["Price"]);
                            products.Quantity = Convert.ToInt32(result["Quantity"]);
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
                            Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
                        }
                        return products;
                    }
                    else
                    {
                        Product products = null;
                        return products;
                    }
                }
                catch (Exception e)
                {
#if DEBUG
                    Trace.WriteLine(e.ToString());
#endif
                    Product products = null;
                    return products;
                }
            }
            else
            {
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                Product products = null;
                return products;
            }
        }

        public bool UpdateProductName(string ProductName, int ProductID)
        {
            string query = $"UPDATE Products SET ProductName = '{ProductName}' WHERE ProductID = '{ProductID}'";
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
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                return false;
            }
        }

        public bool UpdateProductPrice(int ProductPrice, int ProductID)
        {
            string query = $"UPDATE Products SET Price = '{ProductPrice}' WHERE ProductID = '{ProductID}'";
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
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                return false;
            }
        }


        public bool UpdateProductQuantity(int Quantity, int ProductID)
        {
            string query = $"UPDATE Products SET Quantity = '{Quantity}' WHERE ProductID = '{ProductID}'";
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
                        Master.Alert("Error while closing database Connection", View.Notification.PopUp.enmType.Error);
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
                Master.Alert("Could not establish connection with database -_-", View.Notification.PopUp.enmType.Error);
                return false;
            }
        }
    }
}
