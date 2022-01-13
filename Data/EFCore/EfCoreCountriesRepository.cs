using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mamun_SchoolApp.Data.EFCore
{
    public class EfCoreCountriesRepository : EfCoreRepository<Countries, SchoolDbContext>
    {
        public EfCoreCountriesRepository(SchoolDbContext context) : base(context)
        {

        }
    }
}
