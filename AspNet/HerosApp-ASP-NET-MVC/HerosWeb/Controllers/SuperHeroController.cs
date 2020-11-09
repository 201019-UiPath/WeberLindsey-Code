using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HerosDB;
using db=HerosDB.Models;
using HerosWeb.Models;

namespace HerosWeb.Controllers
{
    public class SuperHeroController : Controller
    {
        private readonly ISuperHeroRepo _repo;
        private db.SuperHero hero = new db.SuperHero();
        public SuperHeroController(ISuperHeroRepo repo)
        {
            _repo = repo;
        }
        public async Task<IActionResult> GetHeros()
        {
            var superHeros = await _repo.GetAllHeroesAsync();
            return View(superHeros);
        }

        public IActionResult GetHeroByName(string name)
        {
            var superHero = _repo.GetHeroByName(name);
            return View(superHero);
        }

        /// <summary>
        /// This action returns the form
        /// </summary>
        /// <returns></returns>
        public ViewResult AddHero() 
        {
            return View();
        }

        /// <summary>
        /// This action will submit the form values received to the DB
        /// </summary>
        /// <param name="superHero"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddHero(SuperHero superHero) 
        {
            if (ModelState.IsValid)
            {
                hero.Alias = superHero.Alias;
                hero.RealName = superHero.RealName;
                hero.HideOut = superHero.HideOut;

                _repo.AddAHeroAsync(hero);
                return RedirectToAction("GetHeros");
            }
            else
            {
                return View();
            }
        }

        public ViewResult EditHero(string name)
        {
            /*var superHero =;
            SuperHero selectedHero = new SuperHero();
            superHero.Id = selectedHero.Id;
            superHero.Alias = selectedHero.Alias;
            superHero.RealName = selectedHero.RealName;
            superHero.HideOut = selectedHero.HideOut;*/

            return View(_repo.GetHeroByName(name));
        }

        [HttpPost]
        public IActionResult EditHero(db.SuperHero superHero)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateHero(superHero);
                return RedirectToAction("GetHeros");
            }
            else
            {
                return View();
            }
        }

    }
}
