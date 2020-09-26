using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIBE.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        public string stateName { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
