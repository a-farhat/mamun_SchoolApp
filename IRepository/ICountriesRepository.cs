using mamun_SchoolApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mamun_SchoolApp.IRepository
{
    public interface ICountriesRepository
    {
        public Countries Save(Countries country);
        public Countries Update(Countries country);
        public Countries Get(int id);
        public List<Countries> Gets();
        public string Delete(int id);
    }

    
}
