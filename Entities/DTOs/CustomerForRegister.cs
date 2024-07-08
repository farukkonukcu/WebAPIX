using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CustomerForRegister
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Password2 { get; set; }
    }
}
