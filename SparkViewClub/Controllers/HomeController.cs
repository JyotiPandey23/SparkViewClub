using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SparkViewClub.Models;

namespace SparkViewClub.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About_us()
        {
            return View();
        }
        public IActionResult Contact_us()
        {
            return View();
        }
        public IActionResult MembershipPlan()
        {
            return View();
        }
        public IActionResult Domestic_destination()
        {
            return View();
        }
        public IActionResult Internation_destination()
        {
            return View();
        }

        public IActionResult MembershipLogin()
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
