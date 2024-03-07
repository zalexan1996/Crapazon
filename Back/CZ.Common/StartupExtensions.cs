using System.Reflection;
using CZ.Common.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CZ.Common;

public static class StartupExtensions
{
    public static void AddCommon(this IServiceCollection services, IConfigurationRoot config)
    {
        
    }

    public static IConfigurationBuilder BuildCrapazonConfiguration(this IConfigurationBuilder builder)
    {
        string basePath = Path.GetDirectoryName(typeof(AppSettings).Assembly.Location) ?? "C:\\";
        builder.AddJsonFile(Path.Combine(basePath, "appsettings.json"), false, true);
        return builder;
    }
}