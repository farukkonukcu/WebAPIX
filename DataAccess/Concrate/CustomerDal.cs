using Core.Entities;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate
{
    public class CustomerDal : ICustomerDal
    {
        public List<Customer> _customerList;
        public CustomerDal()
        {
            _customerList = new List<Customer>{new Customer("asd", "asd@asd", "asd", "asd", "asdasd")};
        }

        public void Add(Customer entity)
        {
            _customerList.Add(entity);
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            return _customerList.AsQueryable().FirstOrDefault(filter);
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            if (filter == null)
            {
                return _customerList;
            }
            return _customerList.AsQueryable().Where(filter).ToList();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
