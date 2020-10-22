using HeroesLib;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace HeroesDB
{

    /// <summary>
    /// Data access interface for hero stuff
    /// </summary>
    
    public interface IRepository
    {
        /// <summary>
        /// Adds hero to data storage place
        /// </summary>
        /// <param name="hero"></param>
         void AddHeroAsync(Hero hero);

        /// <summary>
        /// Get all heroes from data storage place
        /// </summary>
        /// <returns></returns>
         Task<List<Hero>> GetAllHeroesAsync();
    }
}