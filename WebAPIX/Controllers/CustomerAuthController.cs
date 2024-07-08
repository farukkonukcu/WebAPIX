using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIX.Controllers
{
    [ApiController]
    public class CustomerAuthController : ControllerBase
    {
        private ICustomerAuthService _customerAuthService;
        public CustomerAuthController(ICustomerAuthService customerAuthService)
        {
            _customerAuthService = customerAuthService;
        }

        [HttpPost("login")]
        public IActionResult Login(CustomerForLogin customerForLogin)
        {
            if (_customerAuthService.Login(customerForLogin) != null)
            {
                string _email = _customerAuthService.Login(customerForLogin).Email;
                return Ok(new { email= _email, message = "Giriş Başarılı" });
            }
            return BadRequest(new { message = "Giriş Yapılamadı !" });
        }

        [HttpPost("register")]
        public IActionResult Register(CustomerForRegister customerForRegister)
        {
            if (!_customerAuthService.UserExists(customerForRegister.Email))
            {
                return BadRequest(new { message = "Bu Email Mevcut !" });
            }

            var result = _customerAuthService.Register(customerForRegister);
            if (result)
            {
                return Ok(new { message = "Kayıt Başarılı" });
            }
            else
            {
                return BadRequest(new { message = "Kayıt Yapılamadı !" });
            }
        }
    }
}
