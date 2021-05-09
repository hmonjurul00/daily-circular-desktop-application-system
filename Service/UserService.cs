using System;
using System.Collections.Generic;
using System.Text;
using daily_circular_desktop_application_system.DB;
using daily_circular_desktop_application_system.Model;
using MySql.Data.MySqlClient;

namespace daily_circular_desktop_application_system.Service
{
    class UserService
    {
        private MySQLConnector mySQLConnector;

        public UserService()
        {
            this.mySQLConnector = new MySQLConnector();
        }

        public bool createUser(User user)
        {
            if (getUserByEmail(user.Email) != null)
            {
                System.Windows.Forms.MessageBox.Show("This email is already registered!");
                return false;
            }
            string query = "INSERT INTO `user` (`user_id`, `email`, `password`, `fullname`) VALUES(NULL, '"
                + user.Email + "', '" + user.Password + "', '" + user.Fullname + "')";

            MySqlCommand mySqlCommand = new MySqlCommand(query, this.mySQLConnector.MySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            mySqlDataReader.Close();
            return true;
        }

        public User getUserByEmail(string email)
        {
            string query = "SELECT * FROM `user` WHERE `email` = '" + email + "'";
            MySqlCommand mySqlCommand = new MySqlCommand(query, this.mySQLConnector.MySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            User user = new User(-1, "", "", "");
            if (mySqlDataReader.Read())
            {
                user = new User(
                    mySqlDataReader.GetInt32("user_id"),
                    mySqlDataReader.GetString("email"),
                    mySqlDataReader.GetString("password"),
                    mySqlDataReader.GetString("fullname")
                );
            }
            mySqlDataReader.Close();
            if (user.UserId == -1)
            {
                return null;
            }
            return user;
        }

        public User getUserById(int userId)
        {
            string query = "SELECT * FROM `user` WHERE `user_id` = '" + userId + "'";
            MySqlCommand mySqlCommand = new MySqlCommand(query, this.mySQLConnector.MySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            User user = new User(-1, "", "", "");
            if (mySqlDataReader.Read())
            {
                user = new User(
                    mySqlDataReader.GetInt32("user_id"),
                    mySqlDataReader.GetString("email"),
                    mySqlDataReader.GetString("password"),
                    mySqlDataReader.GetString("fullname")
                );
            }
            mySqlDataReader.Close();
            if (user.UserId == -1)
            {
                return null;
            }
            return user;
        }
    }
}
