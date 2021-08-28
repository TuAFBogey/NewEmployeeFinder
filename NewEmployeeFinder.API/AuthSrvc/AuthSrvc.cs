using NewEmployeeFinder.API.IAuthService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.API.AuthService
{
    public class AuthSrvc : IAuthSrvc
    {
        public bool CheckUser(string username, string password)
        {
            return username.Equals("Bogey") && password.Equals("123");
        }
    }
}
