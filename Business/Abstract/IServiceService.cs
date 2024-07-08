using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IServiceService
    {
        void Add(Service service);
        List<Service> GetAll();
        Service GetById(int id);
    }
}
