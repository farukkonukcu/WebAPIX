using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAppointmentService
    {
        bool Add(AppointmentDTO appointment);
        bool Cancel(int appointmentId);
        List<Appointment> GetAllByEmail(string email);
    }
}
