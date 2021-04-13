using System;
using System.Windows.Forms;
using Inventory_Management.Control;

namespace Inventory_Management
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Master master = new Master();
        }
    }
}
