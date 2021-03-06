﻿using System;
using HeroesLib;
using HeroesUI.Menus;

namespace HeroesUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero obj = new Hero();

            #region default constructor
            /*Hero obj = new Hero();
            Console.WriteLine($"{obj.id} {obj.name}");*/
            #endregion

            #region paramaterized constructor
            // Hero obj1 = new Hero(2, "Deadpool");
            // Console.WriteLine($"{obj1.id} {obj1.name}"); //Cannot access the variables if they're not public
            #endregion

            #region Access via Properties
            // Console.WriteLine(obj1.Id); //read property value
            // obj1.Id = 3;
            // Console.WriteLine($"New ID = {obj1.Id}"); //Write into a property
            #endregion

            #region accessing 1-D arrays
            

            /*Console.Write("Please enter your hero ID: ");
            obj.Id = Int32.Parse(Console.ReadLine());

            Console.Write("Please enter your superhero name: ");
            obj.name = Console.ReadLine();

            Console.Write("Enter the first power: ");
            obj.superPowers[0] = Console.ReadLine();

            Console.Write($"{obj.Id} {obj.name} {obj.superPowers[0]}");*/
            #endregion

            #region Accessing Jagged arrays
            /*obj.ja[0] = new int[2]; //first column
            obj.ja[1] = new int[3]; //second column
            obj.ja[2] = new int[1]; //third column

            obj.ja[0][0] = 10; //initialize value of first row and first column to 10
            obj.ja[1][2] = 15;

            int[,,] td = new int[2,3,4];
            Console.WriteLine($"Dimension of the array - {td.Rank}D");
            Console.WriteLine($"Number of elements in the Array - {td.Length}");

            Console.Write(obj.ja.Rank); //rank is the dimension of the array
            Console.Write(obj.ja.Length); //length is elements of the arrays

            //Loop through the jagged array
            foreach (var rows in obj.ja) { //looping through all rows

                //looping through all columns of every row
                for(int i = 0; i < rows.Length; i++){
                Console.Write($" {rows[i]} ");
                }
                Console.WriteLine();
            }*/
            #endregion

            #region List<T> Example & Stack<T> & Dictionary<Tkey, Value> Example
            // Console.WriteLine("Please enter the super power to be removed: ");
            // string sp = Console.ReadLine();
            // Hero.superPowers.Remove(sp);

            // foreach(var superPowers in Hero.GetSuperPowers()) {
            //     Console.WriteLine(superPowers);
            // } 

            /*Console.WriteLine("Super Hero     Hideout");
            foreach(var superHeroes in Hero.hideOuts) {
                // Console.WriteLine($"{superHeroes.Key}  {superHeroes.Value}");
                Console.WriteLine($"{superHeroes.Key}  {Hero.hideOuts[superHeroes.Key]}"); //can also do this way
            }*/
            #endregion
            #region Calling Hero menu
            IMenu startMenu = new MainMenu();
            startMenu.Start();
            #endregion

            HeroTasks heroTasks = new HeroTasks();

            #region Delegate, Anonymous methods, Lambda
            // HeroDel del = new HeroDel(heroTasks.GetPowers);
            // Action del = new Action(heroTasks.GetPowers);
            // Func<string, string> fd = new Func<string,string>(some method);
            // Predicate<string> predicate = new Predicate<string>(some method);
            // del += heroTasks.DoWork; // += subscribe to a method
            // del += heroTasks.ManageLife;
            // del();
            // del -= heroTasks.ManageLife; // -= unsubscribe
            // del();

            //Anonymous methods
            // Action<string> am = delegate(string name) {
                // System.Console.WriteLine("Hello anonymous");
            // };
            // am("Lindsey");

            //Lambda Expression - shorthand notation to anonymous methods
            // Action result = () => System.Console.WriteLine("Hello Lambda");
            // result();
            #endregion

            #region  Async VS synchronous programming
            //Subscribing to publisher
            /*heroTasks.workDone += EmailService.SendEmail;
            heroTasks.workDone += TextMessageService.SendText;
            heroTasks.workDone += PushNotification.SendPushNotification;

            heroTasks.DoWork();
            heroTasks.ManageLife();
            Console.Read(); //Holds the stream until a key is pressed (& waits for the other thread instead of ending execution)*/
            #endregion
        }
    }
}
