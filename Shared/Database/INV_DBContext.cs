using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Shared.Database
{
    public class NV_DBContext : DbContext
    {

        public NV_DBContext(DbContextOptions<NV_DBContext> dbContext) : base(dbContext)
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
