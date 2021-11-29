using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;


namespace mamun_SchoolApp.Data
{
    public class SchoolDbContext : DbContext
    {
        #region Contructor
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }
        #endregion


        #region Public properties
        public DbSet<Classes> classes { get; set; }
        public DbSet<Countries> countries { get; set; }
        public DbSet<Students> students { get; set; }
        #endregion


        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

           modelBuilder.Entity<Classes>(entity =>
           {
               entity.HasKey(e => e.id);
               entity.Property(e => e.class_name);

           });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.name);

            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.name);
                entity.Property(e => e.date_of_birth);
                entity.Property(e => e.country_id);
                entity.Property(e => e.class_id);


            });





            modelBuilder.Entity<Classes>().HasData(GetClasses());
            modelBuilder.Entity<Countries>().HasData(GetCountries());
            modelBuilder.Entity<Students>().HasData(GetStudents());
           // base.OnModelCreating(modelBuilder);
        }
        #endregion


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    optionsBuilder.UseSqlite(@"DataSource=studentsdatabase.db;");
        //}

        #region Private methods
        private List<Classes> GetClasses()
        {
            return new List<Classes>
            {
                new Classes { id = 1, class_name = "KGI"},
                new Classes { id = 2, class_name = "KGII"},
                new Classes { id = 3, class_name = "Grade1"},
                new Classes { id = 4, class_name = "Grade2"}
            };
        }

        private List<Countries> GetCountries()
        {
            return new List<Countries>
            {
                new Countries { id = 1, name = "United States"},
                new Countries { id = 2, name = "Oman"},
                new Countries { id = 3, name = "Canada"},
                new Countries { id = 4, name = "United Kindgom"}
            };
        }

       
        private List<Students> GetStudents()
        {
            return new List<Students>
            {
                new Students { id = 1, class_id = 1, country_id =1, name = "Peter Smith", date_of_birth = new DateTime(2012,12,12)},
                new Students { id = 2, class_id = 2, country_id =2, name = "John Doe", date_of_birth =new DateTime(2010,10,10)},
                new Students { id = 3, class_id = 3, country_id =3, name = "Danny Doe", date_of_birth =new DateTime(2009,09,09)},
                new Students { id = 4, class_id =4, country_id = 4, name = "Clark Smith", date_of_birth =new DateTime(2008,08,08)}
            };
        }
     





        #endregion




    }
}
