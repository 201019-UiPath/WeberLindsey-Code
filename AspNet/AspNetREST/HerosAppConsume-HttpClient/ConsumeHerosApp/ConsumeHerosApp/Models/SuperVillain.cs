using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumeHerosApp.Models
{
    class SuperVillain : SuperPerson
    {
        public List<SuperHero> Nemesis { get; set; }
    }
}
