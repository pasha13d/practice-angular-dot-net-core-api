using APIBE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBE.Context
{
    public class PaymentDetailContext: DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options)
        {

        }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<APIBE.Models.Login> Login { get; set; }
    }
}
