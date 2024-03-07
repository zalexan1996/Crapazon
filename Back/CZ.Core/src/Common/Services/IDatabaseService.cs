namespace CZ.Core.Common.Services;

public interface IDatabaseService
{
    public IQueryable<T> Set<T>() where T : class;
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}