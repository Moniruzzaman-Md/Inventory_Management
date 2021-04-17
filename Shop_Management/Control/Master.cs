using Inventory_Management.Model;
using Inventory_Management.View;
using Inventory_Management.View.Admin;
using Inventory_Management.View.Employee;
using Inventory_Management.View.Notification;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management.Control
{
    public class Master
    {
        private static DatabaseConnection.DatabaseConnection db = new();
        private static int tabletrycount = 1;
        private int databasetrycount = 1;

        private Login _login = new();
        public Master()
        {

            if (db.IsConnectedToServer())
            {
                goto DatabaseConnectionCheck;
            }
            else
            {
                MessageBox.Show("Cannot connect to server!!. \nCheck if you have sql server installed. \nThis program requires sql server as database.");
                goto Exit;
            }

        DatabaseConnectionCheck:

            if (databasetrycount >= 20000)
            {
                MessageBox.Show("Unknown Error while attempting to connect to database \n Could not connect in 20,000 attempt");
                goto Exit;
            }

            if (db.IsConnectedToDatabase())
            {
                goto CreateTable;
            }
            else
            {
                db.InitializeDatabase();
                databasetrycount++;
                goto DatabaseConnectionCheck;
            }

        CreateTable:
            if (tabletrycount >= 2000)
            {
                MessageBox.Show("Unknown Error while attempting to connect to create table \n Could not create in 2000 attempt");
                goto Exit;
            }
            if (db.InitializeTables())
            {
#if DEBUG
                Alert($"Connected to Database with {databasetrycount} attempt", PopUp.enmType.Success);
                Alert($"Table created with {tabletrycount} attempt", PopUp.enmType.Success);
#endif
                if (!db.CreateDefaultAdmin())
                {
                    MessageBox.Show("Could not create the Default Admin account");
                }
                _login.setResources(this);
                Application.Run(_login);

            }
            else
            {
                tabletrycount++;
                goto CreateTable;
            }
        Exit:
            return;
        }
        public void Registration_Page(System.Drawing.Size size, System.Drawing.Point location)
        {
            Registration registration = new();
            registration.Size = size;
            registration.StartPosition = FormStartPosition.Manual;
            registration.Location = location;
            registration.setResources(this);
            registration.Show();
        }

        public void Login_Page(System.Drawing.Size size, System.Drawing.Point location)
        {
            _login.Size = size;
            _login.StartPosition = FormStartPosition.Manual;
            _login.Location = location;
            _login.setResources(this);
            _login.Show();
        }

        public void Admin_Page(User user, System.Drawing.Size size, System.Drawing.Point location)
        {
            Admin admin = new(user);
            admin.Size = size;
            admin.StartPosition = FormStartPosition.Manual;
            admin.Location = location;
            admin.setResources(this);
            admin.Show();
        }

        public void Employee_Page(User user, System.Drawing.Size size, System.Drawing.Point location)
        {
            Employee employee = new(user);
            employee.Size = size;
            employee.StartPosition = FormStartPosition.Manual;
            employee.Location = location;
            employee.setResources(this);
            employee.Show();
        }
        public static void Alert(string msg, PopUp.enmType type)
        {
            PopUp frm = new();
            frm.showAlert(msg, type);
        }
    }
}
