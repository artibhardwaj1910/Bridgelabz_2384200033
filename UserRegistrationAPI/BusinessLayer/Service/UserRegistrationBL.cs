using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Layer.Service;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL
    {
        UserRegistrationRL _repoLayer;
        public UserRegistrationBL(UserRegistrationRL _repoLayer)
        {
            this._repoLayer = _repoLayer;
        }
        public string RegistrationBL(string username, string password)
        {
            var (user, pass) = _repoLayer.RegistrationRL(username, password);
            if (username == user && password == pass)
            {
                return "login successfull";
            }
            else 
            {
                return "Invalid username or password";
            }
        }
    }
}
