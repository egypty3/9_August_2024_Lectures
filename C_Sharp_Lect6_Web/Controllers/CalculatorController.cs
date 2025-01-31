using Microsoft.AspNetCore.Mvc;

namespace C_Sharp_Lect6_Web.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(
            string firstNumber,
            string secondNumber,
            string operation
            )
        {
            ViewBag.firstNumber = firstNumber;
            ViewBag.secondNumber = secondNumber;
            ViewBag.operation = operation;

            int result = 0;
            try
            {
                int intFirstNumber = int.Parse(firstNumber);
                int intSecondNumber = int.Parse(secondNumber);
                switch (operation)
                {
                    case "Add":
                        result = intFirstNumber + intSecondNumber;
                        break;
                    case "Subtract":
                        result = intFirstNumber - intSecondNumber;
                        if (result < 0)
                        {
                            throw new 
                                ApplicationException("الرقم الاولاني لازم يكون اكبر من او يساوي الرقم الثاني");
                        }
                        break;
                    case "Multiply":
                        result = checked( intFirstNumber * intSecondNumber);
                        break;
                    case "Divide":
                        result = intFirstNumber / intSecondNumber;
                        break;
                }
                ViewBag.result = result;
                ViewBag.resultColor = "text-success";
            }
            catch (OverflowException)
            {
                ViewBag.result ="لو سمحت ما تكتبش ارقام كبيرة... الجهاز ما يقدرش عليها";
                ViewBag.resultColor = "text-danger";
            }
            catch (FormatException)
            {
                ViewBag.result = "اكتب ارقام علشان اعرف اطلعلك نتيجة ";
                ViewBag.resultColor = "text-danger";
            }
            catch (DivideByZeroException)
            {
                ViewBag.result = "علمونا في المدارس انه القسمة علي صفر حاجة مش تمام ";
                ViewBag.resultColor = "text-danger";
            }
            catch (Exception ex)
            {
                ViewBag.result = ex.Message;
                ViewBag.resultColor = "text-danger";
            }
            
            return View();
        }
    }
}
