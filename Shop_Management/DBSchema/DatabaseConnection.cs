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

namespace Shop_Management.DBSchema
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
            SqlCommand cmd = new SqlCommand(query, ServerConnectionString);
            try
            {
                
                cmd.ExecuteNonQuery();
                ServerConnectionString.Close();
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
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
                "Approved BIT NOT NULL DEFAULT 0);";
            SqlCommand cmd = new SqlCommand(query, DatabaseConnectionString);
            try
            {
                cmd.ExecuteNonQuery();
                DatabaseConnectionString.Close();
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                DatabaseConnectionString.Close();
                return false;
            }
        }

    }
}
