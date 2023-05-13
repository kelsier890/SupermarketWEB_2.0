using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Models;
using System.ComponentModel;

namespace SupermarketWEB.Data
{
    public class SumpermarketContext : DbContext
    {
        public SumpermarketContext(DbContextOptions options) : base(options)
        {
        }
        public  DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
