using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb15WelcomeApp1
{
     public class SignIn
    {
        public string Authenticate(string username, string password)
        {
            string msg;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                msg = "Username and Password required";
            }
            else
            {
                if ((username == "admin") && (password == "admin@12345"))
                {
                    msg = "Authentication Pass";
                }
                else
                {
                    msg = "Authentication Fail";
                }

            }
            return msg;
        }
    }
}
