using System.Diagnostics;
using Assignment3Portfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult TechSkills()
        {
            return View();
        }

        public IActionResult Download()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return Redirect("https://drive.google.com/file/d/1y49Ge9_gE4euw7XeGj4C-nikVbUdLZa7/view?usp=sharing");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
