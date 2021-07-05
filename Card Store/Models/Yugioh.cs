using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Card_Store.Models
{
    public class Yugioh
    {
        [Key]
        public string Name { get; set; }

        public string Rarety { get; set; }

        public double MarketPrice { get; set; }

        public string ImagePath { get; set; }
    }

    public class YugiohDBContext : DbContext
    {
        public DbSet<Yugioh> Magic { get; set; }
    }
}