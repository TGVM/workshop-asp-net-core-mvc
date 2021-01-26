using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebApplicationMVC.Models
{
    public class SalesWebApplicationMVCContext : DbContext
    {
        public SalesWebApplicationMVCContext (DbContextOptions<SalesWebApplicationMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
