using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserAuthService
    {
        bool Login(UserForLogin userForLogin);
        bool Register(UserForRegister userForRegister);
        bool UserExists(string email);

    }
}
