using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mamun_SchoolApp.Data
{
    public class Countries : BaseEntity
    {
        //public int id { get; set; }
        //public string name { get; set; }

        public ICollection<Students> Students { get; set; }

    }
}
