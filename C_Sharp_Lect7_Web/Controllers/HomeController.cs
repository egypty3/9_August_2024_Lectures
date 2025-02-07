using C_Sharp_Lect7_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace C_Sharp_Lect7_Web.Controllers
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
        [HttpPost]
        public IActionResult Index(string theType,int noOfElements, string theOrder)
        {
            ViewBag.noOfElements = noOfElements;
            ViewBag.theType = theType;

            // the button clicked was 'create'
            if (theOrder == "create")
            {
                ViewBag.theOrder = "create";
            }
            // the button clicked was 'save'
            else if (theOrder == "save")
            {
                ViewBag.theOrder = "save";
                List<string> elements = new List<string>();

                for (int i = 0; i < noOfElements; i++)
                {
                    string elementName = $"element_{i}";
                    string elementValue = Request.Form[elementName];
                    elements.Add(elementValue);
                }

                // Process the elements list as needed
                string resultToView = "";

                if (theType == "int")
                {
                    SampleGenericArray<int> intArray =
                        new SampleGenericArray<int>(noOfElements);

                    // Setting up values
                    for (int i = 0; i < noOfElements; i++)
                    {
                        intArray.setMyItem(i, int.Parse(elements[i]));
                    }

                    // Retreiving the values
                    for (int i = 0; i < noOfElements; i++)
                    {
                        resultToView += intArray.getMyItem(i) + "<br/>";
                    }

                }
                else if (theType == "char")
                {
                    SampleGenericArray<char> intArray =
                       new SampleGenericArray<char>(noOfElements);

                    // Setting up values
                    for (int i = 0; i < noOfElements; i++)
                    {
                        intArray.setMyItem(i, char.Parse(elements[i]));
                    }

                    // Retreiving the values
                    for (int i = 0; i < noOfElements; i++)
                    {
                        resultToView += intArray.getMyItem(i) + "<br/>";
                    }
                }

                ViewBag.resultToView = resultToView;

                // Save resultToView to a file
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "myArray.txt");
                System.IO.File.WriteAllText(filePath, resultToView.Replace("<br/>", "\r\n"));
            }
            // the button clicked was 'load'
            else if (theOrder == "load")
            {
                ViewBag.theOrder = "load";
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "myArray.txt");
                string resultToView = System.IO.File.ReadAllText(filePath);
                ViewBag.noOfElements = resultToView.Split("\r\n").Count();
                ViewBag.resultToView = resultToView.Replace("\r\n","<br/>");

            }


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
