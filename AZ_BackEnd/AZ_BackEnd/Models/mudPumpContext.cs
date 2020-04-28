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


    }
}
