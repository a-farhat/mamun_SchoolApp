
using mamun_SchoolApp.Data;
using mamun_SchoolApp.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mamun_SchoolApp.Repository
{
    public class StudentsRepository : IStudentsRepository
    {

        SchoolDbContext _contextDB;
        public StudentsRepository(SchoolDbContext contextDB)
        {
            _contextDB = contextDB;
        }
        public string Delete(int id)
        {
            var student = _contextDB.Students.FirstOrDefault(x => x.id == id);
            _contextDB.Students.Remove(student);
            _contextDB.SaveChanges();
            return "Deleted";
        }

        public Students Get(int id)
        {
            return _contextDB.Students.FirstOrDefault(x => x.id == id);
        }

        public List<Students> Gets()
        {
            return _contextDB.Students.ToList();
        }

        public Students Save(Students students)
        {
            _contextDB.Students.Add(students);
            _contextDB.SaveChanges();
            return this.Get(students.id);
        }

        public Students Update(Students students)
        {
            _contextDB.Students.Update(students);
            _contextDB.SaveChanges();
            return this.Get(students.id);
        }
    }
}
