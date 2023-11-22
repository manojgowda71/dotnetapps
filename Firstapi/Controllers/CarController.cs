using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Firstapi.Models;
namespace Firstapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private Car _car;
        private IApiLogger _logger;
        private IAccessories _accessories;
        public CarController(Car c,IApiLogger logger, IAccessories accessories)
        { 
            _car = c;
            _logger = logger;
            _logger.Log("CarController instance is created");
            _accessories = accessories;

        }
        [HttpGet("/drive")]
        public IActionResult drive()
        {
            _logger.Log("driving() api called successfully");
            return Ok("driving at 100kmph");
        }
    }
}
