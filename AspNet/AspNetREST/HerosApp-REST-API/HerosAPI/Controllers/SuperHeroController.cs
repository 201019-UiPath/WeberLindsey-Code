using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerosDB.Models;
using HerosLib;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HerosAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly IHeroService _heroService;
        public SuperHeroController(IHeroService heroService)
        {
            _heroService = heroService;
        }

        [HttpGet("get")]
        [Produces("application/json")]
        [EnableCors("_myAllowSpecificOrigins")]
        public IActionResult GetAllHeros()
        {
            try
            {
                return Ok(_heroService.GetAllHeroes());
            } catch(Exception) {
                return StatusCode(500);
            }
        }

        [HttpGet("get/{name}")]
        [Produces("application/json")]
        [EnableCors("_myAllowSpecificOrigins")]
        //[FormatFilter]
        public IActionResult GetHeroByName(string name)
        {
            try
            {
                return Ok(_heroService.GetHeroByName(name));
            } catch(Exception) {
                return NotFound();
            }
        }

        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult AddHero(SuperHero newSuperHero) 
        { 
            try
            {
                _heroService.AddHero(newSuperHero);
                return CreatedAtAction("AddHero", newSuperHero);
            } catch(Exception)
            {
                return BadRequest();
            }
        }

        //[HttpGet("Get")]
        //public ContentResult Get() { return Content("Hello world"); }


    }
}
