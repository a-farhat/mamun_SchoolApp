using System;
using System.Collections.Generic;
using System.Linq;
using mamun_SchoolApp.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.IO;
using System.Text;


namespace mamun_SchoolApp.Data.EFCore
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
        {
        }
        #region Contructor
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }
        #endregion

        #region Public properties
        public DbSet<Classes> _Classes { get; set; }
        public DbSet<Countries> _Countries { get; set; }
        public DbSet<Students> _Students { get; set; }
        #endregion


        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Classes>().HasData(GetClasses());
            modelBuilder.Entity<Countries>().HasData(GetCountries());
            modelBuilder.Entity<Students>().HasData(GetStudents());
           // base.OnModelCreating(modelBuilder);
        }
        #endregion




       



        #region Private methods
        private List<Classes> GetClasses()
        {
            return new List<Classes>
            {
                new Classes { Id = 1, class_name = "KGI"},
                new Classes { Id = 2, class_name = "KGII"},
                new Classes { Id = 3, class_name = "Grade1"},
                new Classes { Id = 4, class_name = "Grade2"},
                new Classes { Id = 5, class_name = "Grade3"},
                new Classes { Id = 6, class_name = "Grade4"}
            };
        }

        private List<Countries> GetCountries()
        {
            return new List<Countries>
            {
                new Countries { Id = 1, name = "United States"},
                new Countries { Id = 2, name = "Oman"},
                new Countries { Id = 3, name = "Canada"},
                new Countries { Id = 4, name = "United Kindgom"}
            };
        }

       
        private List<Students> GetStudents()
        {
            return new List<Students>
            {
                new Students { Id = 1, ClassId = 1, CountryId =1, name = "Peter Smith", date_of_birth = new DateTime(2012,12,12)},
                new Students { Id = 2, ClassId = 2, CountryId =2, name = "John Doe", date_of_birth =new DateTime(2010,10,10)},
                new Students { Id = 3, ClassId = 3, CountryId =3, name = "Danny Doe", date_of_birth =new DateTime(2009,09,09)},
                new Students { Id = 4, ClassId =4, CountryId = 1, name = "Clark Boy1", date_of_birth =new DateTime(2008,08,08)},
                new Students { Id = 5, ClassId =4, CountryId = 1, name = "Clark Smith2", date_of_birth =new DateTime(2012,01,08)},
                new Students { Id = 6, ClassId =4, CountryId = 1, name = "Clark Smith3", date_of_birth =new DateTime(2012,02,08)},
                new Students { Id = 7, ClassId =4, CountryId = 1, name = "Clark Smith4", date_of_birth =new DateTime(2012,03,08)},
                new Students { Id = 8, ClassId =4, CountryId = 1, name = "Clark Smith5", date_of_birth =new DateTime(2012,04,08)},
                new Students { Id = 9, ClassId =4, CountryId = 1, name = "Clark Smith6", date_of_birth =new DateTime(2012,05,08)},
                new Students { Id = 10, ClassId =4, CountryId = 1, name = "Clark Smith7", date_of_birth =new DateTime(2012,06,08)},
                new Students { Id = 11, ClassId =6, CountryId = 1, name = "Clark Smith8", date_of_birth =new DateTime(2014,06,08)},
                new Students { Id = 12, ClassId =6, CountryId = 1, name = "Clark Smith9", date_of_birth =new DateTime(2014,07,08)},
                new Students { Id = 14, ClassId =6, CountryId = 1, name = "Clark Smith10", date_of_birth =new DateTime(2014,08,08)},
                new Students { Id = 15, ClassId =6, CountryId = 1, name = "Clark Smith11", date_of_birth =new DateTime(2014,09,08)},
                new Students { Id = 16, ClassId =6, CountryId = 1, name = "Clark Smith12", date_of_birth =new DateTime(2014,10,08)},
                new Students { Id = 17, ClassId =6, CountryId = 1, name = "Clark Smith13", date_of_birth =new DateTime(2014,11,08)},
                new Students { Id = 18, ClassId =6, CountryId = 1, name = "Clark Smith14", date_of_birth =new DateTime(2014,12,08)},
                new Students { Id = 19, ClassId =6, CountryId = 1, name = "Clark Smith15", date_of_birth =new DateTime(2014,08,08)},
                new Students { Id = 20, ClassId =6, CountryId = 1, name = "Clark Smith16", date_of_birth =new DateTime(2014,08,08)}
            };
        }
     





        #endregion




    }
}
