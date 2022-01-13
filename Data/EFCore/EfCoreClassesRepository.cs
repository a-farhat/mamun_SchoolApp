using mamun_SchoolApp.Models;
using mamun_SchoolApp.Data.EFCore;

namespace mamun_SchoolApp.Data.EFCore
{
    public class EfCoreClassesRepository : EfCoreRepository <Classes,SchoolDbContext>
    {
        public EfCoreClassesRepository(SchoolDbContext context) : base(context)
        {

        }

    }
}
