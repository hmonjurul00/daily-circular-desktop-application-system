using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using daily_circular_desktop_application_system.Model;
using daily_circular_desktop_application_system.Service;

namespace daily_circular_desktop_application_system.Views
{
    public partial class LoginForm : Form
    {
        private User user;
        private UserService userService;
        public LoginForm()
        {
            this.user = new User();
            this.userService = new UserService();
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            UserRegistrationForm userRegistrationForm = new UserRegistrationForm();
            userRegistrationForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.user.Email = (sender as TextBox).Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.user.Password = (sender as TextBox).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isVaildCredential())
            {
                MessageBox.Show("Welcome to Daily Circular");
                /*DailyCircularHome dailyCircularHome = new DailyCircularHome();
                dailyCircularHome.Show();*/
                DailyCircularAppForm dailyCircularAppForm = new DailyCircularAppForm();
                dailyCircularAppForm.Show();
            }
        }

        private bool isVaildCredential()
        {
            if (string.IsNullOrEmpty(this.user.Email))
            {
                MessageBox.Show("Email is required");
                return false;
            }
            if (string.IsNullOrEmpty(this.user.Password))
            {
                MessageBox.Show("Password is required");
                return false;
            }
            User userFromDb = this.userService.getUserByEmail(this.user.Email);
            if (userFromDb == null || userFromDb.Password != this.user.Password)
            {
                MessageBox.Show("Incorrect email and password");
                return false;
            }
            Session.LoggedUser = userFromDb;
            return true;
        }
    }
}
