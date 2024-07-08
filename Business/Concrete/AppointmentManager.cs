using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        IAppointmentDal _appointmentDal;

        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        public bool Add(AppointmentDTO appointment)
        {

            Random random = new Random();
            _appointmentDal.Add(new Appointment()
            {
                Id = random.Next(1, 1000000),
                CustomerEmail = appointment.CustomerEmail,
                ServiceId = appointment.ServiceId,
                Date = appointment.Date,
                Statu = Appointment.Status.Pending
            });
            return true;
        }
        public bool Cancel(int appointmentId)
        {
            return _appointmentDal.Cancel(appointmentId);
        }
        public List<Appointment> GetAllByEmail(string email)
        {
            return _appointmentDal.GetAll(u => u.CustomerEmail == email);
        }
    }
}
