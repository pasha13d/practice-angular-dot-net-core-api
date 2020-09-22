using AnCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnCore.Context
{
    public class PaymentDetailContext: DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options): base(options)
        {

        }
        public DbSet<PaymentDetail> paymentDetails { get; set; }
    }
}
