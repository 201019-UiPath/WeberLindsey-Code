using System;
using System.Threading.Tasks;

namespace HeroesLib
{
    public delegate void HeroDel();

    public class HeroTasks : IHeroOperations, IHeroSuperPowers
    {
        string path = "../SuperPowers";

        public event HeroDel workDone;

        public async void DoWork() {
            System.Console.WriteLine("Work started...");
            await Task.Run( new Action(GetPowers));
            System.Console.WriteLine("Saving humanity is my work");
            System.Console.WriteLine("Work Finished");
            OnWorkDone();
        }

        public void OnWorkDone() {
            workDone?.Invoke();

            // if(workDone != null) { workDone(); }//Raising the event
        }

        public void ManageLife() {
            System.Console.WriteLine("I have a cranky partner to manage");
        }

        public void GetPowers() {
            System.Console.WriteLine("Getting powers");
            System.Threading.Thread.Sleep(6000);
            string superPower = System.IO.File.ReadAllText(path);
            System.Console.WriteLine($"Power obtained {superPower}");
        }
        
    }
}
