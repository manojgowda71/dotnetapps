using Microsoft.AspNetCore.Mvc;
using employeecontroller.Models;

namespace employeecontroller.Controllers
{
    public class employeeController : Controller
    {
        [HttpGet("/employee")]
        public IActionResult getemployee()
        {
            var found = employeeoperations.getemployee();
            return View("employeelist", found);
        }
        [HttpGet("/search/{pempid}")]
        public IActionResult getemployeedetail(int pempid)
        {
            var found1 = employeeoperations.search(pempid);
            return View("search", found1);
        }
        [HttpGet("/create")]
        public IActionResult create()
        {
            return View("create", new employee());
        }
        [HttpPost("/create")]
        public IActionResult create([FromForm] employee p)
        {
            employeeoperations.createNew(p);
            return View("employeelist", employeeoperations.getemployee());
        }
        [HttpGet("/edit/{pempid}")]
        public IActionResult edit(int pempid)
        {
            var found2 = employeeoperations.search(pempid);
            return View("edit", found2);
        }
        [HttpPost("/edit/{pempid}")]
        public IActionResult edit(int pempid, [FromForm] employee p)
        {
            var found3 = employeeoperations.search(p.empId);
            found3.email = p.email;
            found3.empName = p.empName;
            found3.isactive = p.isactive;
            return View("employeelist", employeeoperations.getemployee());
        }
    }
}
