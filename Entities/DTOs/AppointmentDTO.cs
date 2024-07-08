using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AppointmentDTO : IEntity
    {
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
