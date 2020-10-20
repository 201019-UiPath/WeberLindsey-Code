using System;

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

        public string[] superPowers = new string[10]; //1-D array

        public int[][] ja = new int[3][]; //Jagged array
        
    }
    #endregion
}
