using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_03_2023_Code_first
{
    public class Human_Context : DbContext

    {
        public DbSet<Human> Humans { get; set; } 

        public Human_Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Human_Base"].ConnectionString);
            optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial catalog = Humanbase; integrated security = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Human>(builder =>
            {
                builder.ToTable("Humans");

                builder.Property(p => p.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

                builder.Property(p => p.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();

                builder.Property(p => p.Fname)
               .HasColumnName("Fname")
               .HasMaxLength(50)
               .IsRequired();

                builder.Property(p => p.Gender)
               .HasColumnName("Gender")
               .HasMaxLength(10)
               .IsRequired();

                builder.Property(p => p.Age)
             .HasColumnName("Age")
             .HasDefaultValue(18);

            });
        }
    }
}
