using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailShop.Models;

namespace RetailShop.Data
{
    public class RetailShopContext : DbContext
    {
        public RetailShopContext (DbContextOptions<RetailShopContext> options)
            : base(options)
        {
        }

        public DbSet<RetailShop.Models.Mlist> Mlist { get; set; } = default!;
        public DbSet<RetailShop.Models.Mitarbeiter> Mitarbeiter { get; set; } = default!;
    }
}
