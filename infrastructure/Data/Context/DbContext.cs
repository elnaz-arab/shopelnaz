using System;
using core.Domain;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Data.Context
{
    public class Context : DbContext
    {

        public DbSet<MCategory> categories { get; set; }
         public DbSet<MProduct> Products { get; set; }
         public DbSet<MColor> colors { get; set; }
         public DbSet<MSize> Sizes { get; set; }
        // public DbSet<Slider> Sliders { get; set; }
        // public DbSet<Baner> Baners { get; set; }
         public DbSet<MUser> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder db)
        {
            db.UseSqlServer("Data source =. ; initial Catalog = Shoop ; integrated Security = true ;");
        }
        
    }
}