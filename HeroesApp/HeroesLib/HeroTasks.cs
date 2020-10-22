namespace HeroesLib
{
    public delegate void HeroDel();

    public class HeroTasks : IHeroOperations, IHeroSuperPowers
    {
        string path = "../SuperPowers";

        public void DoWork() {
            System.Console.WriteLine("Saving humanity is my work");
        }

        public void ManageLife() {
            System.Console.WriteLine("I have a cranky partner to manage");
        }

        public void GetPowers() {
            string superPower = System.IO.File.ReadAllText(path);
            System.Console.WriteLine(superPower);
        }
        
    }
}
