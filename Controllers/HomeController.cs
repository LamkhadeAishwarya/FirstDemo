using System.Diagnostics;
using FirstDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Index()
        {
            ViewData["Message"] = "This is sample text in view";
            List<string> names = new List<string>()
            {
                    "pooja","Aishwarya","Sakshi","Madhura"
            };
            ViewData["list"]=names;
            ViewData["msg"] = "City List";

            List<string> city = new List<string>()
            {
                "pune","mumbai","nashik"
            };
            ViewData["list1"]=city;
            ViewBag.year = "2023";
            ViewBag.Names = names;
            ViewBag.City= city;
            ViewData["Message3"] = "ColorName";
            List<string> color = new List<string>()
            {
                "pink","red","white","black","yellow","green","blue"
            };
            ViewData["Color"]=color;

            TempData["company"] = "Think Quotient";
            TempData.Keep("company");
            return View();
        }

        public IActionResult Privacy()
        {
            var name = TempData["company"];
           TempData.Clear();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}