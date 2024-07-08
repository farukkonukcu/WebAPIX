using Business.Abstract;
using Core.Entities;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public bool Add(Customer customer)
        {
            _customerDal.Add(customer);
            return true;
        }

        public Customer GetByMail(string email)
        {
            return _customerDal.Get(c => c.Email == email);
        }
    }
}
