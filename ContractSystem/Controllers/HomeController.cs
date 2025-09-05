using System.Diagnostics;
using System.Security.Claims;
using ContractSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContractSystem.Controllers
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

        public IActionResult Lecturer_Dashboard()
        {
            return View();
        }

        public IActionResult Manager_Dashboard()
        {
            return View();
        }

        public IActionResult NewClaim(Claims model)
        {
            return View();
        }
        public IActionResult NewClaimForm(Claims model)
        {
            return RedirectToAction("Lecturer_Dashboard");
        }

        public IActionResult ManageClaim()
        {
            return View();
        }

        public IActionResult Claim_Tracking()
        {
            return View();
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
