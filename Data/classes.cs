using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mamun_SchoolApp.Data
{
    public class Classes : BaseEntity
    {
        //public int id { get; set; }
        public string class_name { get; set; }

        public ICollection<Students> Students { get; set; }

    }
}
