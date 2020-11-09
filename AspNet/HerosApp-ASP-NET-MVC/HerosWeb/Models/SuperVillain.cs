using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerosWeb.Models
{
    public class SuperVillain
    {
        public int Id { get; set; }
        public string RealName { get; set; }
        public string Alias { get; set; }
        public string HideOut { get; set; }
        public List<SuperPower> SuperPowers { get; set; }
    }
}
