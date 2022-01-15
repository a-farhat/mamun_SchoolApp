
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mamun_SchoolApp.Data;

namespace mamun_SchoolApp.Models
{
    [Table("Countries")]
    public class Countries : IEntity
    {
        public int Id { get; set; }
        public string name { get; set; }

        public ICollection<Students> Students { get; set; }
        

    }
}
