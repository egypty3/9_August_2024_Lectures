using Microsoft.AspNetCore.Mvc;

namespace C_Sharp_Lect3_Web.Controllers
{
    public class ElectricityBillController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int customerId,string customerName, int numberOfKiloWattsConsumed)
        {
            double billAmountAfterAddingEachStage = 0;

            if (numberOfKiloWattsConsumed <= 199)
            {
                billAmountAfterAddingEachStage = numberOfKiloWattsConsumed * 1.20;
            }
            else
            {
                billAmountAfterAddingEachStage = 199 * 1.20;
            }
            if (numberOfKiloWattsConsumed >= 200) // if the consumption is greater than 260 kw
            {
                billAmountAfterAddingEachStage += (numberOfKiloWattsConsumed - 199) * 1.50;
            }
            if (numberOfKiloWattsConsumed >= 400) // if the consumption is greater than 535 kw
            {
                billAmountAfterAddingEachStage += (numberOfKiloWattsConsumed - 399) * 1.80;
            }

            if (numberOfKiloWattsConsumed >= 600)
            {
                billAmountAfterAddingEachStage += (numberOfKiloWattsConsumed - 599) * 2.00;
            }



            double salesTax = billAmountAfterAddingEachStage * 0.14;
            double totalBill = billAmountAfterAddingEachStage + salesTax;

            ViewBag.customerId = customerId;
            ViewBag.customerName = customerName;
            ViewBag.numberOfKiloWattsConsumed = numberOfKiloWattsConsumed;
            ViewBag.NetAmount = Math.Round( totalBill);

            return View();
        }
    }
}
