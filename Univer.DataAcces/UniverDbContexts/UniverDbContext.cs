using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Domein.Entity;

namespace Univer.DataAcces.UniverDbContexts
{
    public class UniverDbContext : DbContext
    {
        public DbSet<Course> courses { get; set; }

        public DbSet<Faculity> faculities { get; set; }

        public DbSet<Student> students { get; set; }

        public DbSet<Teacher> teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server = localhost; Username = postgres; Port = 5432; Password = bekzod28072009; Database = Univer");
        }
    }
}
