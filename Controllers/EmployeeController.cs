using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstDemo.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult EMployeeDetails()
        {
            List<string> cities = new List<string>()
            {
                "mumbai","pune","satara","kolhapur","nashik"
            };
            ViewData["cities"]= new SelectList(cities);

            List<string> depatment = new List<string>()
            {
                "junior","Hr","Admin","Development","Manager"
            };
            ViewData["department"] = new SelectList(depatment);

            return View();
        }
        [HttpPost]
        public IActionResult EMployeeDetails(IFormCollection form, ICollection<string> skills)
        {


            ViewBag.Name = form["empname"];
            ViewBag.Id = form["Id"];
            ViewBag.Gender = form["Gender"];
            ViewBag.City = form["cities"];
            ViewBag.Department = form["department"];
            ViewBag.Skills = skills;
            return View("DisplayEmp");
           
        }
    }
}
