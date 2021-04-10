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
using Shop_Management.View.Notification;

namespace Shop_Management.DatabaseConnection
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
                ServerConnectionString.Close();
                return false;
            }
        }
        public bool InitializeTables()
        {
            DatabaseConnectionString.Open();
            string query = "IF NOT EXISTS (" +
                "SELECT * " +
                "FROM sys.objects " +
                "WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U')) " +
                "CREATE TABLE [dbo].Users(" +
                "UserID int identity(1, 1) primary key," +
                "UserName nvarchar(50) NOT NULL UNIQUE," +
                "Name nvarchar(50) NOT NULL," +
                "Password nvarchar(60) NOT NULL," +
                "Approved BIT NOT NULL DEFAULT 0," +
                "Role BIT NOT NULL DEFAULT 0);";
            SqlCommand cmd = new (query, DatabaseConnectionString);
            try
            {
                cmd.ExecuteNonQuery();
                DatabaseConnectionString.Close();
                return true;
            }
            catch (Exception ex)
            {
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
                    "VALUES ('Admin', 'Default Admin', 'Admin', 1, 1)";
                cmd = new(query, DatabaseConnectionString);
                try
                {
                    cmd.ExecuteNonQuery();
                    DatabaseConnectionString.Close();

                    Task.Run(() => {
                        new Modal("An Admin Account has been created for the first time. \n" +
                        "User Name = Admin \n Password = Admin").ShowDialog();
                    });
                    //Task.Run(()=> {
                    //    MessageBox.Show("An Admin Account has been created for the first time. \n" +
                    //    "User Name = Admin \n Password = Admin");
                    //});
                    
                    return true;
                }
                catch (Exception ex)
                {
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

                }
                try
                {
                    DatabaseConnectionString.Open();
                    return true;
                }
                catch (Exception e)
                {
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
