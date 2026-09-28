using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Webapppelda.Models;

namespace Webapppelda.Controllers
{
    public class HomeController : Controller
    {
      
        List<Costumer> costumers = new List<Costumer> { new Costumer
        {
            Id = 1,
            Name = "Johny",
            Phone = "123-456",
            Score = 85
        },  new Costumer
        {
            Id = 2,
            Name = "Fos",
            Phone = "234-345",
            Score = 12
        }};

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Sajat()
        {
            
            return View(costumers);
        }

        public IActionResult Vasarlo(int id)
        {
            Costumer costumer = costumers.FirstOrDefault(x => x.Id == id);
            return View(costumer);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
