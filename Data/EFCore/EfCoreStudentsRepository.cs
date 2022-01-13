
using mamun_SchoolApp.Models;
using mamun_SchoolApp.Data.EFCore;

namespace mamun_SchoolApp.Data.EFCore
{
    public class EfCoreStudentsRepository : EfCoreRepository <Students, SchoolDbContext>
    {
        public EfCoreStudentsRepository(SchoolDbContext context) : base(context)
        {

        }

    }

    
}
