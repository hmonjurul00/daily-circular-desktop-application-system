using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace daily_circular_desktop_application_system.DB
{
    class MySQLConnector
    {
        private static string connectionString = "server=localhost;database=dailycircular;UID=root;password=";
        private static MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

        public MySQLConnector()
        {
            if (mySqlConnection.State.ToString() != "Open") 
            {
                try
                {
                    mySqlConnection.Open();
                    /*System.Windows.Forms.MessageBox.Show("database connected successful!");*/
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("database connection failed!");
                }
            }
            else
            {
                /*System.Windows.Forms.MessageBox.Show("database connected!");*/
            }
        }

        public MySqlConnection MySqlConnection { get => mySqlConnection; }
    }
}
