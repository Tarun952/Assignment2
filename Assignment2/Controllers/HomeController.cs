using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment2.Controllers
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
            List<products> list=new List<products>() { new products {Id=1,Name="IPhone",Description="Apple product and price 100000" },new products { Id = 2, Name = "Television", Description = "LG product and price 55000"}, new products { Id = 3, Name = "Bedsheet", Description = "cotton bedsheet very cimfortable price 2000" }, new products { Id = 4, Name = "chair", Description = "plastic body chair product and price 5000" } };
            return View(list);
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
