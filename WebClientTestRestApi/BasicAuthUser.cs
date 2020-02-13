using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClientTestRestApi
{
    public class BasicAuthUser
    {
        private string _login;
        private string _password;

        public BasicAuthUser(string login, string password)
        {
            _login = login;
            _password = password;
        }

        public string GetLogin => _login;
        public string GetPassword => _password;
        public string GetCredential => Convert.ToBase64String(Encoding.ASCII.GetBytes(_login + ":" + _password));
    }
}
