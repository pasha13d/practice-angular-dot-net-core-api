using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AnCore.Models
{
    public class Employee
    {
        [Key]
        public int? EmpId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [Column(TypeName = "nvarchar(250)")]
        public string EmpName { get; set; }

        [Required]
        [Display(Name = "Contact")]
        [Column(TypeName = "nvarchar(50)")]
        public string EmpContact { get; set; }

        [Required]
        [Display(Name = "Email")]
        [Column(TypeName = "nvarchar(250)")]
        public string EmpEmail { get; set; }

        [Required]
        [Display(Name = "Address")]
        [Column(TypeName = "nvarchar(250)")]
        public string EmpAddress { get; set; }
    }
}
