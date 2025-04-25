using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SharpRise.src.Models.Data
{
    public class ShariRiseContextFactory : IDesignTimeDbContextFactory<SharpRiseContext>
    {
        public SharpRiseContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory());

            var configFile = "appsettings.json";
            if (File.Exists(configFile))
            {
                builder.AddJsonFile(configFile);
            }

            var configuration = builder.Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<SharpRiseContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new SharpRiseContext(optionsBuilder.Options);
        }
    }
}
