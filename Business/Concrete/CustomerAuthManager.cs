using Business.Abstract;
using Core.Entities;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerAuthManager : ICustomerAuthService
    {
        ICustomerService _customerService;
        public CustomerAuthManager(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public Customer Login(CustomerForLogin customerForLogin)
        {
            var customerToCheck = _customerService.GetByMail(customerForLogin.Email);

            if (customerToCheck == null)
            {
                return null;
            }
            if (customerForLogin.Password != customerToCheck.Password)
            {
                return null;
            }
            return customerToCheck;
        }

        public bool Register(CustomerForRegister customerForRegister)
        {
            _customerService.Add(new Customer(
                customerForRegister.Name,
                customerForRegister.Email, 
                customerForRegister.TelNumber,
                customerForRegister.Address,
                customerForRegister.Password
                ));
            return true;
        }

        public bool UserExists(string email)
        {
            if (_customerService.GetByMail(email) != null)
            {
                return true;
            }
            return false;
        }
    }
}
