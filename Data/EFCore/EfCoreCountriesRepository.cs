
using mamun_SchoolApp.Models;

namespace mamun_SchoolApp.Data.EFCore
{
    public class EfCoreCountriesRepository : EfCoreRepository<Countries, SchoolDbContext>
    {
        public EfCoreCountriesRepository(SchoolDbContext context) : base(context)
        {

        }
    }
}
