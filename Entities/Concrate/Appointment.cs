using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Appointment : IEntity
    {
        public int Id { get; set; }
        public string CustomerEmail { get; set; }
        public int ServiceId { get; set; }
        public DateTime Date { get; set; }
        public Status Statu { get; set; }


        public enum Status
        {
            Pending,
            Approved,
            Canceled
        }
    }
}
