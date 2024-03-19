using CodeFirst.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Data.Data
{
    public class CarsDbContext:DbContext
    {

        public DbSet<Car> Cars { get; set; }
        public DbSet<Engine> Engines { get; set; }

        public DbSet<EngineType> EngineTypes { get; set; }

        public CarsDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=VTRIFIC-INT;Database=Cars;Connect Timeout=30;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;User=sa;Password=31102001");
        }
    }
}
