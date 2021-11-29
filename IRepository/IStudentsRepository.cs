using mamun_SchoolApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mamun_SchoolApp.IRepository
{
    public interface IStudentsRepository
    {
        public Students Save(Students student);
        public Students Update(Students student);
        public Students Get(int id);
        public List<Students> Gets();
        public string Delete(int id);
    }

    
}
