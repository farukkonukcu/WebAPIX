using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }


        public Customer(string name, string email, string telNumber, string address, string password)
        {
            Name = name;
            Email = email;
            TelNumber = telNumber;
            Address = address;
            Password = password;
        }


    }
}
