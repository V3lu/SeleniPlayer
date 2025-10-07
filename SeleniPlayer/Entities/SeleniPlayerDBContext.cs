using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniPlayer.Entities
{
    public class SeleniPlayerDBContext : DbContext
    {
        public SeleniPlayerDBContext() { }
        public SeleniPlayerDBContext(DbContextOptions<SeleniPlayerDBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Medium> Media { get; set; }
        public DbSet<Playlist> Playlists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
            base.OnModelCreating(modelBuilder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Example: SQLite
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SeleniPlayerDB;Trusted_Connection=True;");
            }
        }
    }
}
