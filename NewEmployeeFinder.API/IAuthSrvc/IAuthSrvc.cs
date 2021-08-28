using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.API.IAuthService
{
    public interface IAuthSrvc
    {
        bool CheckUser(string username, string password);
    }
}
