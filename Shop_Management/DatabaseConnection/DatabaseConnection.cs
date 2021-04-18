using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Threading;
using System.Data;
using Inventory_Management.View.Notification;

namespace Inventory_Management.DatabaseConnection
{
    class DatabaseConnection
    {
        private SqlConnection DatabaseConnectionString;
        private SqlConnection ServerConnectionString;

        public DatabaseConnection()
        {
            DB_Initialize();
        }

        private void DB_Initialize()
        {
            string server = "localhost";
            string database = "ShopManagement";
            //ConnectionString = "Server = " + server + "; Integrated Security = true; Database = " + database;
            DatabaseConnectionString = new SqlConnection($"Server={server}; Integrated Security = true; Database ={database}");
            ServerConnectionString = new SqlConnection("Server=localhost;Integrated security=true;database=master");
        }

        public bool IsConnectedToServer()
        {
            try
            {
                ServerConnectionString.Open();
                ServerConnectionString.Close();
                return true;
            }
            catch (Exception ex)
            {
#if DEBUG
                Trace.WriteLine(ex.ToString());
#endif
                return false;
            }
        }

        public bool IsConnectedToDatabase()
        {
            try
            {
                DatabaseConnectionString.Open();
                DatabaseConnectionString.Close();
                return true;
            }
            catch (Exception ex)
            {
#if DEBUG
                Trace.WriteLine(ex.ToString());
#endif
                return false;
            }
        }

        public bool InitializeDatabase()
        {
            ServerConnectionString.Open();
            string query = "IF NOT EXISTS(" +
                "SELECT * " +
                "FROM sys.databases " +
                "WHERE name = 'ShopManagement') " +
                "CREATE DATABASE ShopManagement;";
            SqlCommand cmd = new (query, ServerConnectionString);
            try
            {

                cmd.ExecuteNonQuery();
                ServerConnectionString.Close();
                return true;
            }
            catch (Exception ex)
            {
#if DEBUG
                Trace.WriteLine(ex.ToString());
#endif
                ServerConnectionString.Close();
                return false;
            }
        }
        public bool InitializeTables()
        {
            DatabaseConnectionString.Open();
            string queryUser = "IF NOT EXISTS (" +
                "SELECT * " +
                "FROM sys.objects " +
                "WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U')) " +
                "CREATE TABLE [dbo].Users(" +
                "UserID int identity(1, 1) primary key," +
                "UserName nvarchar(50) NOT NULL UNIQUE," +
                "Name nvarchar(50) NOT NULL," +
                "Password nvarchar(60) NOT NULL," +
                "Approved nvarchar(10) NOT NULL DEFAULT 'Unapproved'," +
                "Role BIT NOT NULL DEFAULT 0);";
            SqlCommand cmdUser = new (queryUser, DatabaseConnectionString);

            string queryProduct = "IF NOT EXISTS(" +
                "SELECT * " +
                "FROM sys.objects " +
                "WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U')) " +
                "CREATE TABLE [dbo].Products(" +
                "ProductID int identity(1, 1) primary key," +
                "ProductName nvarchar(50) NOT NULL UNIQUE," +
                "Price int NOT NULL," +
                "Quantity int NOT NULL DEFAULT 0," +
                "Approved BIT NOT NULL DEFAULT 0);";
            SqlCommand cmdProduct = new(queryProduct, DatabaseConnectionString);

            string queryUserInage = "IF NOT EXISTS(" +
                "SELECT * " +
                "FROM sys.objects " +
                "WHERE object_id = OBJECT_ID(N'[dbo].[UserImage]') AND type in (N'U')) " +
                "CREATE TABLE [dbo].UserImage(" +
                "ImageID int identity(1, 1) primary key," +
                "UserID int NOT NULL FOREIGN KEY REFERENCES Users(UserID)," +
                "Image  VARBINARY(MAX) NOT NULL)";
            SqlCommand cmdImage = new(queryUserInage, DatabaseConnectionString);
            try
            {
                cmdUser.ExecuteNonQuery();
                cmdProduct.ExecuteNonQuery();
                cmdImage.ExecuteNonQuery();
                DatabaseConnectionString.Close();
                return true;
            }
            catch (Exception ex)
            {
#if DEBUG
                Trace.WriteLine(ex.ToString());
#endif
                DatabaseConnectionString.Close();
                return false;
            }
        }

        public bool CreateDefaultAdmin()
        {
            DatabaseConnectionString.Open();

            string query = "SELECT COUNT(*) FROM Users WHERE Role = 1";
            SqlCommand cmd = new(query, DatabaseConnectionString);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if(count < 1)
            {
                query = "INSERT INTO Users " +
                    "(UserName, Name, Password, Approved, Role)" +
                    "VALUES ('Admin', 'Default Admin', 'Admin', 'Approved', 1)";
                cmd = new(query, DatabaseConnectionString);
                try
                {
                    cmd.ExecuteNonQuery();
                    DatabaseConnectionString.Close();

                    Task.Run(() => {
                        DialogResult result = MessageBox.Show("An Admin Account has been created for the first time. \n" +
                        "User Name = Admin \n Password = Admin", "Important Message", MessageBoxButtons.OK);
                    });
                    //Task.Run(()=> {
                    //    MessageBox.Show("An Admin Account has been created for the first time. \n" +
                    //    "User Name = Admin \n Password = Admin");
                    //});
                    
                    return true;
                }
                catch (Exception ex)
                {
#if DEBUG
                    Trace.WriteLine(ex.ToString());
#endif
                    DatabaseConnectionString.Close();
                    return false;
                }
            }
            return true;

            
        }
        public bool OpenConnection()
        {
            if(DatabaseConnectionString.State != ConnectionState.Open)
            {
                try
                {
                    DatabaseConnectionString.Close();
                }
                catch(Exception e)
                {
#if DEBUG
                    Trace.WriteLine(e.ToString());
#endif
                }
                try
                {
                    DatabaseConnectionString.Open();
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
                return true;
            }
            
        }
        public bool CloseConnection()
        {
            if(DatabaseConnectionString.State != ConnectionState.Closed)
            {
                try
                {
                    DatabaseConnectionString.Close();
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
                return true;
            }
        }

        public SqlConnection GetConnectionString()
        {
            return DatabaseConnectionString;
        }

    }
}
