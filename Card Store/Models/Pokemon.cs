using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Card_Store.Models
{
    public class Pokemon
    {
        [Key]
        public string Name { get; set; }

        public string Rarety { get; set; }

        public double MarketPrice { get; set; }

        public string ImagePath { get; set; }
    }
}