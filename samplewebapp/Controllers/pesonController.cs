using Microsoft.AspNetCore.Mvc;
using samplewebapp.Models;

namespace samplewebapp.Controllers
{
    public class pesonController : Controller
    {
        [HttpGet("/people")]
        public IActionResult getpeople()
        {
            var people = personoperations.getpeople();
            return View("peoplelist",people);
            
        }
        [HttpGet("/search/{padhar}")]
        public IActionResult getpersondetail(string padhar)
        {
            //call model class method
            var found = personoperations.search(padhar);

            //return the view with matching person object
            return View("search", found);
        }
        [HttpGet("/people/of/age/{startage}/{endage}")]
        public IActionResult getpeople2(int startage,int endage)
        {
            var people2 = personoperations.getpeople2(startage, endage);
            return View("search2", people2);
        }
        [HttpGet("/create")]
        public IActionResult create()
        {
            return View("create", new person());
        }
        [HttpPost("/create")]
        public IActionResult create([FromForm] person p)
        {
            personoperations.createNew(p);
            return View("peoplelist", personoperations.getpeople());
        }
        [HttpGet("/edit/{padhar}")]
        public IActionResult edit(string padhar)
        {
            var found3 = personoperations.search(padhar);
            return View("edit", found3);
        }
        [HttpPost("/edit/{padhar}")]
        public IActionResult edit(string padhar, [FromForm] person p)
        {
            var found4 = personoperations.search(p.adhar);
            found4.email = p.email;
            found4.age = p.age;
            found4.name = p.name;
            return View("peoplelist", personoperations.getpeople());
        }

    }
}
