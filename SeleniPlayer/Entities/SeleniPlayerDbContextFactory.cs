using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniPlayer.Entities
{
    internal class SeleniPlayerDbContextFactory : IDesignTimeDbContextFactory<SeleniPlayerDBContext>
    {
        public SeleniPlayerDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SeleniPlayerDBContext>();
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=SeleniPlayerDB;Trusted_Connection=True;");

            return new SeleniPlayerDBContext(optionsBuilder.Options);
        }
    }
}
