using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        UserRegistrationBL _businessLayer;
        public UserRegistrationController(UserRegistrationBL _businessLayer)
        {
            this._businessLayer = _businessLayer;
        }

        [HttpGet]
        public string Registration()
        {
            {
                string username = "root";
                string password = "root1";
                string msg = _businessLayer.RegistrationBL(username, password);
                return msg;
                
            }
        }
    }
}
