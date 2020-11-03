using System;
using HerosDB.Models;
using HerosDB;
using System.Collections.Generic;
using System.Threading.Tasks;
using HerosDbADO;

namespace HeroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling method from HerosDbADO to show ADO functionality
            Data dbCon = new Data();
            dbCon.GetSuperPersonConnected();

            //Calling disconnected method
            Data db = new Data();
            db.GetSuperPersonDisconnected();


            IMenu main = new MainMenu();
            main.start();
        }

    }
}
