using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstDemo.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult PersonDetails()
        {
            List<string> cities = new List<string>()
            {
                "pune","mumbai","nashik","kolhapur","satara"
            };
            ViewData["Cities"] = new SelectList(cities);
            return View();
        }
        [HttpPost]
        public IActionResult PersonDetails(IFormCollection form ,ICollection<string>hobbies)
        {
            ViewBag.Name = form["username"];
            ViewBag.ID = form["ID"];
            ViewBag.Gender = form["Gender"];
            ViewBag.Cities = form["cities"];
            ViewBag.Hobbies = hobbies;
            return View("DisplayPerson");

        }



    }
}
