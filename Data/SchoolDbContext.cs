using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 


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
        public DbSet<classes> classes { get; set; }
        public DbSet<countries> countries { get; set; }
        public DbSet<students> students { get; set; }
        #endregion


        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<classes>().HasData(GetClasses());
            modelBuilder.Entity<countries>().HasData(GetCountries());
            modelBuilder.Entity<students>().HasData(GetStudents());
            base.OnModelCreating(modelBuilder);
        }
        #endregion


        #region Private methods
        private List<classes> GetClasses()
        {
            return new List<classes>
            {
                new classes { id = 1, class_name = "KGI"},
                new classes { id = 2, class_name = "KGII"},
                new classes { id = 3, class_name = "Grade1"},
                new classes { id = 4, class_name = "Grade2"}
            };
        }

        private List<countries> GetCountries()
        {
            return new List<countries>
            {
                new countries { id = 1, name = "United States"},
                new countries { id = 2, name = "Oman"},
                new countries { id = 3, name = "Canada"},
                new countries { id = 4, name = "United Kindgom"}
            };
        }

       
        private List<students> GetStudents()
        {
            return new List<students>
            {
                new students { id = 1, class_id = 1, country_id =1, name = "Peter Smith", date_of_birth = new DateTime(2012,12,12)},
                new students { id = 2, class_id = 2, country_id =2, name = "John Doe", date_of_birth =new DateTime(2010,10,10)},
                new students { id = 3, class_id = 3, country_id =3, name = "Danny Doe", date_of_birth =new DateTime(2009,09,09)},
                new students { id = 4, class_id =4, country_id = 4, name = "Clark Smith", date_of_birth =new DateTime(2008,08,08)}
            };
        }
     





        #endregion




    }
}
