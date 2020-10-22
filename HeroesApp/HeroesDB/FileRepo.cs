using HeroesLib;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HeroesDB
{

    /// <summary>
    /// Repository using files
    /// </summary>
    public class FileRepo : IRepository
    {
       
       string filepath = "HeroesDB/HeroesDataPlace/Heroes.txt";
       /// <summary>
       /// Adds hero to file
       /// </summary>
       /// <param name="hero"></param>
       public async void AddHeroAsync(Hero hero) {
           using(FileStream fs =  new FileStream(filepath, FileMode.Append, FileAccess.Write)) {
               await JsonSerializer.SerializeAsync(fs, hero);
               System.Console.WriteLine("Hero is being written to file");
           }
       }
       
       /// <summary>
       /// Gets all heroes from file
       /// </summary>
       /// <returns></returns>
       public async Task<List<Hero>> GetAllHeroesAsync() {
           List<Hero> allHeroes = new List<Hero>();
           using(FileStream fs = File.OpenRead(filepath)) {
               allHeroes.Add(await JsonSerializer.DeserializeAsync<Hero>(fs));
           }

           return allHeroes;
       }

    }
}