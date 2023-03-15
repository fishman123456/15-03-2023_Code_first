using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_03_2023_Code_first
{
    internal class Human_Context: DbContext

    {
        public DbSet<Human> Human { get; set; } = null!;

        public Human_Context() 
        {
        Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Human_Base"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}
