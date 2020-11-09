using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HerosWeb.Models
{
    public class SuperHero
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Real Name")]
        public string RealName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        //[Range(1,1000)] use this for integers only, not strings
        [StringLength(10, ErrorMessage = "Alias should be at least 2 letters up to 10", MinimumLength = 2)]
        //[RegularExpression(@"^[a-zA-Z]{2,10}", ErrorMessage = "Alias should be at least 2 letters up to 10")]
        public string Alias { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Hide Out")]
        public string HideOut { get; set; }

        public List<SuperPower> SuperPowers { get; set; }
    }
}
