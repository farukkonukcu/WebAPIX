using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate
{
    public class AppointmentDal : IAppointmentDal
    {
        public List<Appointment> _appointmentList;

        public AppointmentDal()
        {
            _appointmentList = new List<Appointment>();
        }
        public void Add(Appointment entity)
        {
            _appointmentList.Add(entity);
        }

        public bool Cancel(int appointmentId)
        {
            var appointment = _appointmentList.FirstOrDefault(a => a.Id == appointmentId);
            if (appointment != null)
            {
                appointment.Statu = Appointment.Status.Canceled;
                return true;
            }
            return false;
        }
        public void Delete(Appointment entity)
        {
            _appointmentList.Remove(entity);
        }

        public Appointment Get(Expression<Func<Appointment, bool>> filter)
        {
            return _appointmentList.AsQueryable().FirstOrDefault(filter);
        }

        public List<Appointment> GetAll(Expression<Func<Appointment, bool>> filter = null)
        {
            if (filter == null)
            {
                return _appointmentList;
            }
            return _appointmentList.AsQueryable().Where(filter).ToList();
        }

        public void Update(Appointment entity)
        {
            throw new NotImplementedException();
        }
    }
}
