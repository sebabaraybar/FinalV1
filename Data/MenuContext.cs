using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalV1.Models;

namespace FinalV1.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options)
            : base(options)
        {
        }

        public DbSet<FinalV1.Models.Menu> Menu { get; set; } = default!;
        public DbSet<FinalV1.Restaurant> Restaurant { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
            .HasMany(r => r.Restaurants)
            .WithMany(m => m.Menus)
            .UsingEntity("MenuRestaurant");
            //Tabla intermedia que vincula los ids de las dos tablas
        }
    }
}
