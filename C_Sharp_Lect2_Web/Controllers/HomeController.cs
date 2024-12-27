using C_Sharp_Lect1_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Sharp_Lect1_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        public IActionResult DayOfTheWeek()
        {
            DateTime myDate = DateTime.Now;
            int day = (int)myDate.DayOfWeek;
            Console.WriteLine(day);

            string dayName = "";

            switch (day)
            {
                case 0:
                    dayName = "الأحد";
                    break;
                case 1:
                    dayName = "الإثنين";
                    break;
                case 2:
                    dayName = "الثلاثاء";
                    break;
                case 3:
                    dayName = "الأربعاء";
                    break;
                case 4:
                    dayName = "الخميس";
                    break;
                case 5:
                    dayName = "الجمعة";
                    break;
                case 6:
                    dayName = "السبت";
                    break;
                default:
                    break;
            }
            ViewBag.dayName = dayName;
            return View();
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
