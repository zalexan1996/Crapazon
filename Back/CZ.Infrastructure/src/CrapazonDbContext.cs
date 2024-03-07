using CZ.Core.Common.Services;
using CZ.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CZ.Infrastructure;

public class CrapazonDbContext : DbContext, IDatabaseService
{
    public CrapazonDbContext(DbContextOptions<CrapazonDbContext> options) 
        : base(options)
    {
        
    }

    IQueryable<T> IDatabaseService.Set<T>() => Set<T>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Test).Assembly);
    }
}