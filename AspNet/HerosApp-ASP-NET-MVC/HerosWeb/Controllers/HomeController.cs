using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HerosWeb.Models;

namespace HerosWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id=0, string name="Avengers") //Default parameters
        {
            //SuperHero hero = new SuperHero() { Id = 1, name = "Peter Parker", alias = "Spiderman" };
            //ViewData["SuperHeroName"] = hero;
            //ViewBag.SuperHeroName = hero;
            //ViewBag.SuperHeroName = "Batman";
            //ViewData["SuperHeroName"] = "Thor";
            //return View(hero);
            ViewBag.id = id;
            ViewBag.name = name;
            return View();
        }

        //[HttpGet]
        //[HttpPost]
        //[Route("{Controller=Home}")]
        //[Route("{Controller=Home}/{action=About}/{id?}")]
        public IActionResult About()
        {
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
