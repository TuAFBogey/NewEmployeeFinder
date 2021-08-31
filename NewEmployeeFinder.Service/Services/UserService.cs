using NewEmployeeFinder.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewEmployeeFinder.Service.Services
{
    public class UserService : IUserService
    {
        public bool CheckUser(string username, string password)
        {
            return username.Equals("Bogey") && password.Equals("123");
        }
    }
}
