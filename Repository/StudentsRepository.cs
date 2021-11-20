
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
            var student = _contextDB.students.FirstOrDefault(x => x.id == id);
            _contextDB.students.Remove(student);
            _contextDB.SaveChanges();
            return "Deleted";
        }

        public Students Get(int id)
        {
            return _contextDB.students.FirstOrDefault(x => x.id == id);
        }

        public List<Students> Gets()
        {
            return _contextDB.students.ToList();
        }

        public Students Save(Students students)
        {
            _contextDB.students.Add(students);
            _contextDB.SaveChanges();
            return this.Get(students.id);
        }

        public Students Update(Students students)
        {
            _contextDB.students.Update(students);
            _contextDB.SaveChanges();
            return this.Get(students.id);
        }
    }
}
