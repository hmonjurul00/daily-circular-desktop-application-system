using daily_circular_desktop_application_system.DB;
using daily_circular_desktop_application_system.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace daily_circular_desktop_application_system.Service
{
    class CircularService
    {
        private MySQLConnector mySQLConnector;

        public CircularService()
        {
            this.mySQLConnector = new MySQLConnector();
        }

        public bool createCircular(Circular circular)
        {
            string query = "";
            if (getCircularById(circular.CircularId) != null)
            {
                query = "UPDATE `circular` SET "
                    + " `title`='" + circular.Title + "', "
                    + " `body`='" + circular.Body + "' WHERE "
                    + " `circular_id`='" + circular.CircularId + "';";
            }
            else
            {
                query = "INSERT INTO `circular` "
                    + " (`circular_id`, `title`, `body`, `created_at`, `created_by`) VALUES "
                    + "('NULL', '"
                    + circular.Title + "', '"
                    + circular.Body + "', '"
                    + circular.CreatedAt.ToString("yyyy-MM-dd H:mm:ss") + "', '"
                    + circular.CreatedBy.UserId + "')";
            }
            MySqlCommand mySqlCommand = new MySqlCommand(query, this.mySQLConnector.MySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            mySqlDataReader.Close();
            return true;
        }

        public Circular getCircularById(int circularId)
        {
            string query = "SELECT * FROM `circular`"
                + " WHERE `circular_id`='" + circularId + "';";

            MySqlCommand mySqlCommand = new MySqlCommand(query, this.mySQLConnector.MySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            Circular circular = null;
            if (mySqlDataReader.Read())
            {
                circular = new Circular(
                    mySqlDataReader.GetInt32("circular_id"),
                    mySqlDataReader.GetString("title"),
                    mySqlDataReader.GetString("body"),
                    mySqlDataReader.GetDateTime("created_at"),
                    new User()
                );
            }
            mySqlDataReader.Close();
            return circular;
        }

        public List<Circular> getAllCirculars()
        {
            string query = "SELECT * FROM `circular`" 
                + " INNER JOIN `user` " 
                + " ON `created_by`=`user_id` " 
                + " ORDER BY `created_at` DESC";

            MySqlCommand mySqlCommand = new MySqlCommand(query, this.mySQLConnector.MySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            List<Circular> circulars = new List<Circular>();
            while (mySqlDataReader.Read())
            {
                Circular circular = new Circular(
                    mySqlDataReader.GetInt32("circular_id"),
                    mySqlDataReader.GetString("title"),
                    mySqlDataReader.GetString("body"),
                    mySqlDataReader.GetDateTime("created_at"),
                    new User(
                        mySqlDataReader.GetInt32("user_id"),
                        mySqlDataReader.GetString("email"),
                        mySqlDataReader.GetString("password"),
                        mySqlDataReader.GetString("fullname")
                    )
                );
                circulars.Add(circular);
            }
            mySqlDataReader.Close();
            return circulars;
        }

        public List<Circular> getAllCircularsByEmail(string email)
        {
            string query = "SELECT * FROM `circular` " 
                + " INNER JOIN `user` " 
                + " ON `created_by`=`user_id` WHERE `email`='" 
                + email + "'" 
                + " ORDER BY `created_at` DESC";

            MySqlCommand mySqlCommand = new MySqlCommand(query, this.mySQLConnector.MySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            List<Circular> circulars = new List<Circular>();
            while (mySqlDataReader.Read())
            {
                Circular circular = new Circular(
                    mySqlDataReader.GetInt32("circular_id"),
                    mySqlDataReader.GetString("title"),
                    mySqlDataReader.GetString("body"),
                    mySqlDataReader.GetDateTime("created_at"),
                    new User(
                        mySqlDataReader.GetInt32("user_id"),
                        mySqlDataReader.GetString("email"),
                        mySqlDataReader.GetString("password"),
                        mySqlDataReader.GetString("fullname")
                    )
                );
                circulars.Add(circular);
            }
            mySqlDataReader.Close();
            return circulars;
        }

        internal void deleteCircularById(int circularId)
        {
            string query = "DELETE FROM `circular` WHERE `circular_id`='" + circularId + "'";
            MySqlCommand mySqlCommand = new MySqlCommand(query, this.mySQLConnector.MySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            mySqlDataReader.Close();
        }
    }
}
