using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.EF
{
    // Add new EShopDBContext class extend DbContext (class of Microsoft.EntityFrameworkCore)
    public class EShopDBContext : DbContext 
    {
        // extend processing of contructor
        public EShopDBContext(DbContextOptions options) : base(options)
        {
            
        }

        // Define Entity
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
