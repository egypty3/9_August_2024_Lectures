using C_Sharp_Lect6_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace C_Sharp_Lect6_Web.Controllers
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
            //return Content("Mya messa 3la el nas el kewysa");
            //return Json(
            //            new
            //            {
            //                name = "Hamada",
            //                age = 45,
            //                carOwner = false
            //            }
            //        );
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
