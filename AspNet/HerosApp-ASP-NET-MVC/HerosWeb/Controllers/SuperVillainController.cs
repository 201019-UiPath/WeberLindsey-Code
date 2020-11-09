using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerosDB;
using Microsoft.AspNetCore.Mvc;

namespace HerosWeb.Controllers
{
    public class SuperVillainController : Controller
    {
        private readonly IVillainRepo _repo;
        public SuperVillainController(IVillainRepo repo)
        {
            _repo = repo;
        }
        public IActionResult GetVillains()
        {
            var superVillians = _repo.GetAllVillains();
            return View(superVillians);
        }

        public IActionResult GetVillainByName(string name)
        {
            var superVillain = _repo.GetVillainByName(name);
            return View(superVillain);
        }
    }
}