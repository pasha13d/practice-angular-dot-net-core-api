using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIBE.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Gender { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Department { get; set; }

        
        public decimal Salary { get; set; }
    }
}
