
using mamun_SchoolApp.Data;
using mamun_SchoolApp.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mamun_SchoolApp.Repository
{
    public class ClassesRepository : IClassesRepository
    {

        SchoolDbContext _contextDB;
        public ClassesRepository(SchoolDbContext contextDB)
        {
            _contextDB = contextDB;
        }
        public string Delete(int id)
        {
            var student = _contextDB.classes.FirstOrDefault(x => x.id == id);
            _contextDB.classes.Remove(student);
            _contextDB.SaveChanges();
            return "Deleted";
        }

        public Classes Get(int id)
        {
            return _contextDB.classes.FirstOrDefault(x => x.id == id);
        }

        public List<Classes> Gets()
        {
            return _contextDB.classes.ToList();
        }

        public Classes Save(Classes Classes)
        {
            _contextDB.classes.Add(Classes);
            _contextDB.SaveChanges();
            return this.Get(Classes.id);
        }

        public Classes Update(Classes Classes)
        {
            _contextDB.classes.Update(Classes);
            _contextDB.SaveChanges();
            return this.Get(Classes.id);
        }
    }
}
