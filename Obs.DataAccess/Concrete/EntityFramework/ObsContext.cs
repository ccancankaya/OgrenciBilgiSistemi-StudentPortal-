using Microsoft.EntityFrameworkCore;
using Obs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obs.DataAccess.Concrete.EntityFramework
{
    public class ObsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Obs;Integrated Security=True;");

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Faculty> Faculties { get; set; }

        public DbSet<Lecture> Lectures { get; set; }

        public DbSet<Program> Programs { get; set; }
        public DbSet<Teacher> Teachers { get; set; }



    }
}
