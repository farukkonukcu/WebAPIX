using Core.Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerAuthService
    {
        Customer Login(CustomerForLogin customerForLogin);
        bool Register(CustomerForRegister customerForRegister);
        bool UserExists(string email);
    }
}
