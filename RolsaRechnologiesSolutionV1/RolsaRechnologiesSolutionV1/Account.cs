using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolsaRechnologiesSolutionV1
{
    internal class Account
    {
        private bool loggedIn = false;
        private string username;

        public void logIn(string userUsername)
        {
            loggedIn = true;
            username = userUsername;
        }

        public bool displayLoggedIn()
        {
            return loggedIn;
        }

        public string displayUsername()
        {
            return username;
        }
    }
}
