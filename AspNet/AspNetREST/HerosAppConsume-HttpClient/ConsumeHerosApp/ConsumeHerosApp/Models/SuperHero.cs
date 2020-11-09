using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumeHerosApp.Models
{
    class SuperHero : SuperPerson
    {
        public List<SuperVillain> Nemesis { get; set; }
    }
}
