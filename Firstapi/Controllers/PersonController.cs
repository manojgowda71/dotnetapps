using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Firstapi.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Firstapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IApiLogger _logger;
        public PersonController(IApiLogger logger)
        {
            _logger = logger;
        }
        [HttpGet("/api/people")]
        public IActionResult GetPeople()
        {
            _logger.Log("start logging GetPeople()!");
            _logger.Log("GetPeople() api call Successfull!");
            return Ok(PersonOperations.GetPeople());
        }

        [HttpPost("/api/create")]
        public IActionResult CreatePerson([FromForm] Person p)
        {
            PersonOperations.CreateNew(p);
            _logger.Log("CreatePerson() api call Successfull!");
            return Created($"Created person with aadhar {p.Aadhar} successfully", p);
        }

        [HttpPut("/api/update/{pAadhar}")]
        public IActionResult UpdatePerson([FromRoute] string pAadhar, [FromForm][FromBody] Person p)
        {
            try
            {
                PersonOperations.Update(pAadhar, p);
                _logger.Log("UpdatePerson() api call Successfull!");
                return Ok("Update Successfully");
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
                return NotFound(ex.Message);//when we get an error
            }
        }

        [HttpDelete("/api/delete")]//Ex:https//localhost:7012/api/delete?pAadhar=320oi42p3oi4&p2=0239 '?' indicates 
        public IActionResult DeletePerson([FromQuery] string pAadhar)
        {
            try
            {
                PersonOperations.Delete(pAadhar);
                _logger.Log("DeletePerson() api call Successfull!");
                return Ok("Deleted successuflly");
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
                return NotFound(ex.Message);
            }


        }


    }
}