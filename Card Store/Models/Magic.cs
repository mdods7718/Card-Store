using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Card_Store.Models
{
    public class Magic
    {
        [Key]
        public string Name { get; set; }

        public string Rarety { get; set; }

        public double MarketPrice { get; set; }

        public string ImagePath { get; set; }
    }

    public class MagicDBContext : DbContext
    {
        public DbSet<Magic> Magic { get; set; }
    }
}