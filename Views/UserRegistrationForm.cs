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
    public partial class UserRegistrationForm : Form
    {
        private User user;
        private string confirmPassword;
        private UserService userService;
        public UserRegistrationForm()
        {
            this.user = new User();
            this.userService = new UserService();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.user.Fullname = (sender as TextBox).Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.user.Email = (sender as TextBox).Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.user.Password = (sender as TextBox).Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.confirmPassword = (sender as TextBox).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validateUser())
            {
                if (this.userService.createUser(this.user) == true)
                {
                    MessageBox.Show("User registration successful");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User registration Failed");
                }
            }
        }

        private bool validateUser()
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
            if (string.IsNullOrEmpty(this.user.Fullname))
            {
                MessageBox.Show("Fullname is required");
                return false;
            }
            if (string.IsNullOrEmpty(this.confirmPassword) || this.user.Password != this.confirmPassword)
            {
                MessageBox.Show("Passwords must match");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.user = new User();
            this.confirmPassword = "";
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
        }
    }
}
