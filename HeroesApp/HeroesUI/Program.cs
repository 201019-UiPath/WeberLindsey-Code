using System;
using HeroesLib;

namespace HeroesUI
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Hero obj = new Hero();

            /*Console.Write("Please enter your hero ID: ");
            obj.Id = Int32.Parse(Console.ReadLine());

            Console.Write("Please enter your superhero name: ");
            obj.name = Console.ReadLine();

            Console.Write("Enter the first power: ");
            obj.superPowers[0] = Console.ReadLine();

            Console.Write($"{obj.Id} {obj.name} {obj.superPowers[0]}");*/
            #endregion

            #region Accessing Jagged arrays
            obj.ja[0] = new int[2]; //first column
            obj.ja[1] = new int[3]; //second column
            obj.ja[2] = new int[1]; //third column

            obj.ja[0][0] = 10; //initialize value of first row and first column to 10
            obj.ja[1][2] = 15;
            
            Console.Write(obj.ja.Rank); //rank is the dimension of the array
            Console.Write(obj.ja.Length); //length is elements of the arrays
            #endregion

        }
    }
}
