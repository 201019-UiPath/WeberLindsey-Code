//Predefined namespace
using System;

//To create custom defined namespace using namespace keyword
namespace helloworld
{
    class Program
    {
        //Execution starts here
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! " + DateTime.Now);

            string firstname, lastname;
            Console.WriteLine("Please enter your first name: ");
            firstname = Console.ReadLine(); //Takes user's input in string form
            Console.WriteLine("Please enter your last name: ");
            lastname = Console.ReadLine();
            // Console.WriteLine("Welcome, " + name);
            Console.WriteLine($"Welcome, {firstname} {lastname}"); //string interpolation
        }
    }
}
