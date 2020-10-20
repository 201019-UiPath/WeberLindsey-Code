using System;
using HeroesLib;

namespace HeroesUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Hero obj = new Hero();
            Console.WriteLine($"{obj.id} {obj.name}");

        }
    }
}
