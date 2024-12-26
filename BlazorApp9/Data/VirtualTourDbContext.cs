using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlazorApp9.Data
{
    public class VirtualTourDbContext : DbContext
    {
        public VirtualTourDbContext(DbContextOptions<VirtualTourDbContext> options) : base(options)
        {
        }

        public DbSet<Place> Places { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=virtualtour.db");
            }
        }
    }
}
