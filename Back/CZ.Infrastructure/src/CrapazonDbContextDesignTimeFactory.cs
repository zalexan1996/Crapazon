using CZ.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CZ.Infrastructure;

public class CrapazonDbContextDesignTimeFactory : IDesignTimeDbContextFactory<CrapazonDbContext>
{
    public CrapazonDbContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationManager()
            .BuildCrapazonConfiguration()
            .Build();
            
        var optionsBuilder = new DbContextOptionsBuilder<CrapazonDbContext>()
            .UseSqlServer(config.GetConnectionString("Default"))
            .EnableDetailedErrors()
            .EnableSensitiveDataLogging();

        return new CrapazonDbContext(optionsBuilder.Options);
    }
}