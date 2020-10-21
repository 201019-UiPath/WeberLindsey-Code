using System;
using System.Collections.Generic;

namespace HeroesLib
{

    #region old way of creating class members
    /*public class Hero
    {
        int id; //value type -> System.Int32

        public int Id{
            get{ return id;}
            set{ id = value; }
        }

        // public int Id{get; set;} // Autonomous property

        public string name;

        //Default Constructor
        public Hero() {
            id = 1;
            name = "Batman";
        }

        public Hero(int id, string name)
        {
            this.id = id;
            this.name = name;
            
        }
    }*/
    #endregion

    #region modern way of creating class members
    public class Hero{
        public int Id { get; set; }

        public string name { get; set; }

        #region Arrays
        //public string[] superPowers = new string[10]; //1-D array
        //public int[][] ja = new int[3][]; //Jagged array
        #endregion

        // public static List<string> superPowers = new List<string>();

        public static Stack<string> superPowers = new Stack<string>(); //LIFO

        public Hero() {
            superPowers.Push("Strength"); //Use Add when using Lists, Push when using Stacks
            superPowers.Push("Flying");
            superPowers.Push("Invisibility");
            superPowers.Push("X-Ray Vision");
        }

        //Method
        public static IEnumerable<string> GetSuperPowers() {
           return superPowers;
        }

        public void AddSuperPowers(string superPower) {
            if(superPower != null && superPower != "") {
                superPowers.Push(superPower);
            }
        }

        public void RemoveSuperPowers(/*string superPower*/) {
            // if(superPowers.Contains(superPower)) {
                // superPowers.Remove(superPower); 
            // }

            superPowers.Pop(); // Use pop when using Stacks, will remove item from the top
        }

    }
    #endregion
}
