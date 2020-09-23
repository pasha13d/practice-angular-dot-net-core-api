using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIBE.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PMId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Card Owner Name")]
        public string CardOwnerName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(16)")]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(5)")]
        [Display(Name = "Expiration Date")]
        public string ExpirationDate { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(3)")]
        public string CVV { get; set; }

    }
}
