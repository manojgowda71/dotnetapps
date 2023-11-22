using Microsoft.AspNetCore.Mvc;

namespace samplewebapp.Controllers
{

    public class FirstController : Controller
    {
        [HttpGet("/greet")]
        public IActionResult Greet()
        {
            return Ok("hello, im a web function");
        }
        [HttpGet("/greet2/{pname}")]
        public string Simplegreet(string pname)
        {
            return $"welcome to mvc,{pname}";
        }
        [HttpGet("/getnames")]
        public List<string> getnames()
        {
            var names = new List<string>() { "eena", "meena", "deeka" };
            return names;
        }
        [HttpGet("/addData/{pname}/{pmarks}/{ispassed?}")]
        public string addData(string pname, int pmarks, bool ispassed = true)
        {
            return $"{pname} secured {pmarks} in the exam and status of passing is {ispassed}";

        }
        [HttpGet("/main")]
        public IActionResult GetIndexPage()
        {
            ViewBag.ReturnValue = "data passed in its view";
            return View("mainpage");
        }
    }
}
