using mamun_SchoolApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mamun_SchoolApp.IRepository
{
    public interface IClassesRepository
    {
        public Classes Save(Classes c);
        public Classes Update(Classes c);
        public Classes Get(int id);
        public List<Classes> Gets();
        public string Delete(int id);
    }

    
}
