using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstDemo.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult StudentDetails()
        {
            List<string> cities = new List<string>()
            {
                "Pune","Mumbai","Delhi","Nashik","Sangli","Satara"
            };
            ViewData["cities"] = new SelectList(cities);
            return View();
        }
        [HttpPost]
        public IActionResult StudentDetails(IFormCollection form, ICollection<string> subject)
        {
            ViewBag.Name = form["Username"];
            ViewBag.RollNo = form["RollNo"];
            ViewBag.Gender = form["gender"];
            ViewBag.City = form["cities"];
            ViewBag.Subjects = subject;
            return View("DisplayStudent");

        }
    }
}
