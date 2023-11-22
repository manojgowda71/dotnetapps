using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Firstapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsingAsyncController : ControllerBase
    {
        public UsingAsyncController()
        {
            System.IO.File.WriteAllText("SomeFile.txt", "fjashfdsajbshadb");
        }
        [HttpGet("/async")]
       public async Task<string> ReadFile()
        {
            using (StreamReader r = new StreamReader(@"SomeFile.txt"))
            {
                return await r.ReadToEndAsync();
            }
        }
        [HttpGet("/delay")]
        public async Task<IActionResult> dosomething()
        {
            await Task.Delay(1000);
            return Ok("delayed task");
        }
    }

}
