
using mamun_SchoolApp.Models;
using mamun_SchoolApp.Data.EFCore;
using System.Linq;

namespace mamun_SchoolApp.Data.EFCore
{
    public class EfCoreStudentsRepository : EfCoreRepository <Students, SchoolDbContext>
    {
        private SchoolDbContext ctx ;
        public EfCoreStudentsRepository(SchoolDbContext context) : base(context)
        {
            this.ctx = context;
        }

        //public string StudentsCountPerClass(int? classid)
        //{
        //    string count = string.Empty;
        //    using (var ctx1 = ctx )
        //    {
        //        var studentByClass = from s in ctx1._Students
        //                             where s.ClassId == classid
        //                             group s by s.ClassId into studentsByClass
        //                             select studentsByClass
        //                             .FirstOrDefault();
        //        count = studentByClass. 
               
        //    }

        //    return count;
        //}

    }

    
}
