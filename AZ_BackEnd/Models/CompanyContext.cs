using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_BackEnd.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .OwnsMany(property => property.pumps);
        }
        
        public IEnumerable<Company> getRussCompanies()
        {
            return
                from f in Companies
                where f.Country == "Russia"
                select f;

        }
    }
}
