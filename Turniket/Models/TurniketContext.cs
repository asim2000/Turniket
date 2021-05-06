using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turniket.Models
{
    public class TurniketContext:DbContext
    {
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Exit> Exits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.\sqlexpress;database=Turniket;integrated security=true");
        }
    }
}
