using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eShop.Data.EF
{
    public class EShopDBContextFactory : IDesignTimeDbContextFactory<EShopDBContext>
    {
        public EShopDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            var connectStr = configuration.GetConnectionString("eShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<EShopDBContext>();
            optionsBuilder.UseSqlServer(connectStr);
            return new EShopDBContext(optionsBuilder.Options);
        }
    }
}
