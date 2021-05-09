using System;
using System.Collections.Generic;
using System.Text;

namespace daily_circular_desktop_application_system.Model
{
    class User
    {
        private int userId;
        private string email;
        private string password;
        private string fullname;

        public User()
        {
        }

        public User(string email, string password, string fullname)
        {
            this.email = email;
            this.password = password;
            this.fullname = fullname;
        }

        public User(int userId, string email, string password, string fullname)
        {
            this.UserId = userId;
            this.Email = email;
            this.Password = password;
            this.Fullname = fullname;
        }

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}
