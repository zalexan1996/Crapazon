using CZ.Core.Common.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CZ.Infrastructure;

public static class StartupExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfigurationRoot config)
    {
        services.AddDbContext<IDatabaseService, CrapazonDbContext>(b => {
            b.UseSqlServer(config.GetConnectionString("Default"))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        });
    }
}