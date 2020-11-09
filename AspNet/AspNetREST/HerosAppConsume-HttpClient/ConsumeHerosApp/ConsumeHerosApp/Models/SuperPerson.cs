using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumeHerosApp.Models
{
    class SuperPerson
    {
        public int Id { get; set; }
        public string RealName { get; set; }
        public string Alias { get; set; }
        public string HideOut { get; set; }
        public List<SuperPower> SuperPowers { get; set; }
    }
}
