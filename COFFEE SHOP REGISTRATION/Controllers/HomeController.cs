using COFFEE_SHOP_REGISTRATION.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;

namespace COFFEE_SHOP_REGISTRATION.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ProductDbContext dbContext = new ProductDbContext();
        //allow access

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Product> result = dbContext.Products.ToList();  //had to ass s to product, dont forget
            return View(result);
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Result(Coffee c)
        {
            return View(c);
        }

        public IActionResult ProductDetails(int id)
        {
            Product result = dbContext.Products.FirstOrDefault(p => p.Id == id); //built in default, avoids breaking code

            return View(result);
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