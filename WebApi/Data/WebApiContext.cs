using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class WebApiContext : DbContext
    {
        public WebApiContext (DbContextOptions<WebApiContext> options)
            : base(options)
        {
        }

        public DbSet<WebApi.Models.Pais> Pais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pais>().HasData(
                new Pais { Nombre = "España", Habitantes = 46000000},
                new Pais { Nombre = "Alemania", Habitantes = 468200000 },
                new Pais { Nombre = "Francia", Habitantes = 1500000 },
                new Pais { Nombre = "Italia", Habitantes = 62820000 }
                );
        }
    }
}
