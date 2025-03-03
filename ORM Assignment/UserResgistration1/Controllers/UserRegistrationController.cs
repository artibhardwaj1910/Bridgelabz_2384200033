using BusinessLayer1.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using RepositoryLayer1.Entity;

namespace UserResgistration1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private IUserRegistrationBL _userBl;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public UserRegistrationController(IUserRegistrationBL _userBl)
        {
            this._userBl = _userBl; 
        }


        [HttpPost("register")]
        public IActionResult Register(UserEntity user)
        {
            try
            {
                _userBl.Register(user);
                return Ok(new { Message = "User registered successfully!" });
            }
            catch (Exception ex)
            {
                _logger.Error("Error in Register: " + ex.Message);
                return BadRequest(new { Error = ex.Message });
            }
        }

       

    }
}
