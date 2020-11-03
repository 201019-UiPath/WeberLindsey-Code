using System.Collections.Generic;
using System.Threading.Tasks;
using HerosDB.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HerosDB
{
    public class DBRepo : ISuperHeroRepo, IVillainRepo
    {
        private HerosContext context;

        public DBRepo(HerosContext context)
        {
            this.context = context;
        }
        public void AddAHeroAsync(SuperHero hero)
        {
            context.SuperHeroes.AddAsync(hero);
            context.SaveChangesAsync();
        }

        public void AddAVillain(SuperVillain superVillain)
        {
            context.SuperVillains.AddAsync(superVillain);
            context.SaveChangesAsync();
        }

        public Task<List<SuperHero>> GetAllHeroesAsync()
        {
           return context.SuperHeroes.Select(x => x).Include("SuperPowers").ToListAsync();
        }

        public List<SuperVillain> GetAllVillains()
        {
            return context.SuperVillains.Select(x=>x).Include("SuperPowers").ToList();
        }

        public SuperHero GetHeroByName(string name)
        {
            return (SuperHero) context.SuperHeroes.Where(x => x.Alias == name);
        }

        public SuperVillain GetVillainByName(string name)
        {
            return (SuperVillain) context.SuperVillains.Where(x => x.Alias == name);
        }
    }
}