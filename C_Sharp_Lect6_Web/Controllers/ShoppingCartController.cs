using Microsoft.AspNetCore.Mvc;

namespace C_Sharp_Lect6_Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View("Shopping");
        }


        public IActionResult IncreaseProductCount()
        {
            ViewBag.Message = "More Products added";
            return View("Shopping");
        }

        public IActionResult DecreaseProductCount()
        {
            ViewBag.Message = "Less Products added";
            return View("Shopping");
        }
    }
}
