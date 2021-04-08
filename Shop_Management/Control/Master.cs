using Shop_Management.DBSchema;
using Shop_Management.View;
using Shop_Management.View.Notification;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management.Control
{
    public class Master
    {
        private static DatabaseConnection db = new DatabaseConnection();
        private static int tabletrycount = 1;
        private int databasetrycount = 1;
        private string massage;

        private Login _login = new();
        public Master()
        {

            if (db.IsConnectedToServer())
            {
                goto DatabaseConnectionCheck;
            }
            else
            {
                MessageBox.Show("Cannot connect to server!!");
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
                //MessageBox.Show($"Database Success with {databasetrycount} attempt");
                //MessageBox.Show($"Table Success with {tabletrycount} attempt");
#endif
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
        public void Registration_Page()
        {
            Registration registration = new();
            registration.setResources(this);
            registration.Show();
        }

        public void Login_Page()
        {
            _login.setResources(this);
            _login.Show();
        }

        public void Alert(string msg, PopUp.enmType type)
        {
            PopUp frm = new();
            frm.showAlert(msg, type);
        }
    }
}
