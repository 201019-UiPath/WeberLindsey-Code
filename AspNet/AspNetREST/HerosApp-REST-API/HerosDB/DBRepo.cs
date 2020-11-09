using System.Collections.Generic;
using System.Threading.Tasks;
using HerosDB.Models;
using HerosDB.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace HerosDB
{
    public class DBRepo : ISuperHeroRepo, IVillainRepo
    {
        private readonly HeroContext context;
        private readonly IMapper mapper;

        public DBRepo(HeroContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public void AddAHeroAsync(SuperHero hero)
        {
            context.Superpeople.AddAsync(mapper.ParseSuperHero(hero));
            context.SaveChanges();
        }

        public void UpdateHero(SuperHero hero)
        {
            var toUpdate = context.Superpeople.Single(s => s.Id == hero.Id);
            toUpdate.Hideout = hero.HideOut;
            toUpdate.Realname = hero.RealName;
            toUpdate.Workname = hero.Alias;
            context.SaveChanges();
        }


        public void AddAVillain(SuperVillain superVillain)
        {
            context.Superpeople.Add(mapper.ParseSuperVillain(superVillain));
            context.SaveChanges();
        }

        public Task<List<SuperHero>> GetAllHeroesAsync()
        {
           return Task.Run<List<SuperHero>>(
               () => mapper.ParseSuperHero(
                   context.Superpeople
                   .Include("Powers")
                   .Where(x => x.Chartype == context.Charactertype.Single(c => c.Chartype == "Superhero").Id)
                   .ToList()
               ));
        }

        public List<SuperVillain> GetAllVillains()
        {
            return mapper.ParseSuperVillain(
                    context.Superpeople
                    .Where(x => x.Chartype == context.Charactertype.Single(y => y.Chartype == "Supervillain").Id)
                    .Include("Powers")
                    .ToList());
        }

        public SuperHero GetHeroByName(string name)
        {
            return mapper.ParseSuperHero(context.Superpeople.Include("Powers").First(x => x.Workname == name));
        }

        public SuperVillain GetVillainByName(string name)
        {
            return mapper.ParseSuperVillain(context.Superpeople.Include("Powers").SingleOrDefault(x => x.Workname == name));
        }


    }
}