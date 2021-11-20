using mamun_SchoolApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mamun_SchoolApp.IRepository
{
    public interface IStudentsRepository
    {
        IEnumerable<Students> GetAll();
        Students Get(long id);
        void Insert(Students students);
        void Update(Students students);
        void Delete(Students students);  
    {

    
}
