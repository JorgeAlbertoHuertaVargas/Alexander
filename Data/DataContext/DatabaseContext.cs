
using ENTIDADES.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataContext
{
    public class DatabaseContext:DbContext
    {
        public class OptionsBuild
        {
            public OptionsBuild()
            {
                settings = new AppConfiguration();
                opsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                opsBuilder.UseSqlServer(settings.sqlConnectionString);
                dbOptions = opsBuilder.Options;
            } 
            public DbContextOptionsBuilder<DatabaseContext> opsBuilder { get; set; }
            public DbContextOptions<DatabaseContext> dbOptions { get; set; }
            private AppConfiguration settings { get; set; }
        }
        public static OptionsBuild ops = new OptionsBuild();

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        //DBSETS GO HERE
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


           
            modelBuilder.Entity<Levell>().HasData(
                new Levell { Id = 1, Levelname = "PRIMARY", Turn = "LATE" },
                new Levell { Id = 2, Levelname = "HIGH SCHOOL", Turn = "MORNING" }
            );


        
        }

        public DbSet<Levell> levels { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Apoderado> Apoderados { get; set; }
        public DbSet<Course> Courses { get; set; }
      
        public DbSet<ParametersSystem> ParametersSystems { set; get; }




      
           


          
        }
       


    }  

