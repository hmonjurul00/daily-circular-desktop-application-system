using System;
using System.Collections.Generic;
using System.Text;
using daily_circular_desktop_application_system.Model;

namespace daily_circular_desktop_application_system.Service
{
    static class Session
    {
        private static User loggedUser = new User();

        public static User LoggedUser { get => loggedUser; set => loggedUser = value; }
    }
}
