using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIBE.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public string cityName { get; set; }

        public int StateId { get; set; }

        public virtual State State { get; set; }
    }
}
