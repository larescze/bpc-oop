using cv12_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace cv12_WebApp.Controllers
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
        public IActionResult Index(string operation, double operand1, double operand2)
        {
            CalculationData calcData = new CalculationData(operation, operand1, operand2);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7070/");

            HttpResponseMessage response = client.PostAsJsonAsync("values", calcData).Result;

            if (response.IsSuccessStatusCode)
            {
                ViewData["result"] = response.Content.ReadAsAsync<double>().Result;
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