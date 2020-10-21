using HeroesLib;
using System;

namespace HeroesUI.Menus
{
    /// <summary>
    /// The welcome menu for people who come in and stuff
    /// </summary>

    public class MainMenu : IMenu
    {
        public void Start() {

            do{
                System.Console.WriteLine("Welcome friend! What would you like to do today?");

                //Options
                System.Console.WriteLine("[0] Create a hero");

            } while(!System.Console.ReadLine().Equals("0"));

            Hero newHero = GetHeroDetails();
            System.Console.WriteLine($"Hero {newHero.name} was created with a superpower of {Hero.superPowers.Pop()}");
        }

        public Hero GetHeroDetails() {
            Hero hero = new Hero();
            System.Console.WriteLine("Enter hero name: ");
            hero.name = System.Console.ReadLine();
            System.Console.WriteLine("Enter to add a super power to your hero: ");
            hero.AddSuperPowers(Console.ReadLine());
            System.Console.WriteLine("Hero created!"); //use logging software to log this
            //Add step that pushes this hero's details to the BL
            return hero;
        }
    }
}