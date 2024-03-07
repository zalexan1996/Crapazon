using CZ.Infrastructure;
using System.Diagnostics;

namespace CZ.API;


record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

public static class ApiStartupExtensions
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfigurationRoot config)
    {
        services.AddInfrastructure(config);
        services.AddApi(config);
        return services;
    }

    public static IServiceCollection AddApi(this IServiceCollection services, IConfigurationRoot config)
    {
        services.AddControllers().AddApplicationPart(typeof(Program).Assembly);
        services.AddHttpContextAccessor();
        services.AddSwaggerDocument();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddCors(o =>
        {
            o.AddDefaultPolicy(b =>
            {
                b.WithOrigins("http://localhost:4200", "https://localhost:7139").AllowAnyMethod().AllowAnyHeader();
            });
        });
        
        return services;
    }

    public static WebApplication Configure(this WebApplication app)
    {
        app.UseOpenApi();
        app.UseSwagger();
        app.UseSwaggerUi();
        app.UseHttpsRedirection();

        app.UseCors();
        app.MapControllers();

        return app;
    }
}