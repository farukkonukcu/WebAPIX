using Microsoft.AspNetCore.Mvc;
using DataAccess.Abstract;
using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace WebAPIX.Controllers
{
    [Route("admin")]
    [ApiController]
    public class AdminAuthController : ControllerBase
    {

        private IUserAuthService _authService;

        public AdminAuthController(IUserAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(UserForLogin userForLogin)
        {
            if (_authService.Login(userForLogin))
            {
                return Ok("Giriş Başarılı");
            }
            return BadRequest("Giriş Yapılamadı !");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("register")]
        public IActionResult Register(UserForRegister userForRegister)
        {
            if (!_authService.UserExists(userForRegister.Email)) 
            {
                return BadRequest("Kayıt Yapılamadı !");
            } 

            var result = _authService.Register(userForRegister);
            if (result)
            {
                return Ok("Kayıt Başarılı");
            }
            else
            {
                return BadRequest("Kayıt Yapılamadı !");
            }
        }
    }
}
