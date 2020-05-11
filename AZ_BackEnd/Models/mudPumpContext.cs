using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AZ_BackEnd.Models
{
    public class mudPumpContext : DbContext
    {
        public mudPumpContext(DbContextOptions<mudPumpContext> options)
            : base(options)
        {
        }
        public DbSet<mudPump> mudPumps { get; set; }

        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<mudPump>()
                .OwnsMany(property => property.mudP);
        }
        public IEnumerable<mudPump> getIsHere()
        {
            return 
                from p in mudPumps
                where (p.isHere == true)
                select p;
        }
    }
}
