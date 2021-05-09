using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using daily_circular_desktop_application_system.Views;
using daily_circular_desktop_application_system.DB;

namespace daily_circular_desktop_application_system
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
            MySQLConnector mySQLConnector = new MySQLConnector();
            Application.Run(new LoginForm());
        }
    }
}
