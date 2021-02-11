using Microsoft.EntityFrameworkCore;
using Parcial1_AP2_WilbertAntigua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_AP2_WilbertAntigua.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=DATA\ProductoDB3.db");
        }
    }
}
