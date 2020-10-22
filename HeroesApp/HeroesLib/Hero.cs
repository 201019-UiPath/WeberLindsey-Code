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

        #region Collections
        // public static List<string> superPowers = new List<string>();
        public static Stack<string> superPowers = new Stack<string>(); //LIFO
        // public static Dictionary<string, string> hideOuts = new Dictionary<string, string>();

        public Hero() {
            superPowers.Push("Strength"); //Use Add when using Lists, Push when using Stacks
            superPowers.Push("Flying");
            superPowers.Push("Invisibility");
            superPowers.Push("X-Ray Vision");

            // hideOuts.Add("Deadpool", "Everywhere");
            // hideOuts.Add("Batman", "Bat Cave");
            // hideOuts.Add("Superman", "Fortress of Solitude");
        }

        //Method
        public static IEnumerable<string> GetSuperPowers() {
           return superPowers;
        }

        
        public void RemoveSuperPowers(/*string superPower*/) {
            // if(superPowers.Contains(superPower)) {
                // superPowers.Remove(superPower); 
            // }
            superPowers.Pop(); // Use pop when using Stacks, will remove item from the top
            #endregion
        }

        public void AddSuperPowers(string superPower) {
            if(superPower != null && superPower != "") {
                superPowers.Push(superPower);
            } else throw new ArgumentException("Super power shouldn't be null");
        }

    }
    #endregion
}
