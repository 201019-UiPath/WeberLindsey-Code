using System;
using System.Collections.Generic;
using System.Net.Http;
using ConsumeHerosApp.Models;

namespace ConsumeHerosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAllHeros();
        }

        public static void GetAllHeros()
        {
            string url = "https://localhost:44385/superhero/get";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var response = client.GetAsync("");
                response.Wait();

                var result = response.Result;
                if(result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<SuperHero[]>();
                    readTask.Wait();

                    var superHeros = readTask.Result;
                    foreach(var superHero in superHeros)
                    {
                        Console.WriteLine($"{superHero.Id} {superHero.Alias} ");
                    }
                }
            }
        }

    }
}
