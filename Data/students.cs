using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mamun_SchoolApp.Data
{
    public class Students : BaseEntity
    {
       
        //public int id { get; set; }
        public int? class_id { get; set; }
        public int? country_id { get; set; }
        //public string name { get; set; }

        public DateTime date_of_birth { get; set; }

        public ICollection<Countries> Countries { get; set; }
        public ICollection<Classes> Classes { get; set; }

        public Classes Class { get; set; }
        public Countries Country { get; set; }

    }
}
