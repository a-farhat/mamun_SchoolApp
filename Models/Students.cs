using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mamun_SchoolApp.Data;

namespace mamun_SchoolApp.Models 
{
    [Table("Students")]
    public class Students : IEntity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
       
        public string name { get; set; }

        public DateTime date_of_birth { get; set; }

       


        public int? ClassId { get; set; }
        public Classes Class { get; set; }

        public int? CountryId { get; set; }
        public Countries Country { get; set; }

    }
}
