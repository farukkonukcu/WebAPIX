using Business.Abstract;
using Core.Entities;
using Entities.Concrate;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIX.Controllers
{
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        [HttpPost("createappointment")]
        public IActionResult CreateAppointment(AppointmentDTO appointment)
        {
            if (_appointmentService.Add(appointment))
            {
                return Ok(new { message = "Randevu Eklendi" });
            }
            return BadRequest(new { message = "Randevu Eklenemedi" });
        }

        [HttpPost("cancelappointment")]
        public IActionResult CancelAppointment([FromBody] int appointmentId)
        {
            if (_appointmentService.Cancel(appointmentId))
            {
                return Ok(new { message = "Randevu İptal Edildi" });
            }
            return BadRequest(new { message = "Randevu İptal Edilemedi !" });
        }

        [HttpGet("getallappointment")]
        public IActionResult GetAllAppointment(string email)
        {
            var appointments = _appointmentService.GetAllByEmail(email);
            if (appointments == null || !appointments.Any())
            {
                return NotFound(new { message = "Randevu bulunamadı." });
            }
            return Ok(appointments);
        }
    }
}
