using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mamun_SchoolApp.Data;

namespace mamun_SchoolApp.Models
{
    [Table("Classes")]
    public class Classes : IEntity
    {
        public int Id { get; set; }
        public string class_name { get; set; }

        public ICollection<Students> Students { get; set; }


    }
}
