﻿using COFFEE_SHOP_REGISTRATION.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace COFFEE_SHOP_REGISTRATION.Controllers
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

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Result(Coffee c)
        {
            return View(c);
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