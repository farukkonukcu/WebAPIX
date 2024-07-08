using Business.Abstract;
using Core.Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserAuthManager : IUserAuthService
    {
        private IUserService _userService;

        public UserAuthManager(IUserService userService) 
        {
            _userService = userService;
        }
        public bool Login(UserForLogin userForLogin)
        {
            var userToCheck = _userService.GetByMail(userForLogin.Email);
            if (userToCheck == null)
            {
                return false;
            }
            if (userForLogin.Password != userToCheck.Password)
            {
                return false;
            }
            return true;
        }

        public bool Register(UserForRegister userForRegister)
        {
            _userService.Add(new User(userForRegister.Name, userForRegister.Email, userForRegister.Password));
            return true;
        }

        public bool UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return true;
            }
            return false;
        }
    }
}
