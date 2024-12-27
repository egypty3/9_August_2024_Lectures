using C_Sharp_Lect1_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace C_Sharp_Lect1_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double moneyAmount,
            double profitPercentage)
        {

            double totalAmountAfterProfit =
                moneyAmount + (moneyAmount * profitPercentage / 100);

            ViewBag.totalAmountAfterProfit = totalAmountAfterProfit;
            ViewBag.moneyAmount = moneyAmount;
            ViewBag.profitPercentage = profitPercentage;
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
