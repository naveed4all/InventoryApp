using Microsoft.EntityFrameworkCore;
using InventoryApp.Models;

namespace InventoryApp.Database
{
    public class INV_DBContext : DbContext
    {

        public INV_DBContext(DbContextOptions<INV_DBContext> dbContext) : base(dbContext)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("INVAppConnection");
        }

        public DbSet<Item> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

    }
}
