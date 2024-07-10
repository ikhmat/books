using System.Linq.Expressions;
using Abstraction.Interfaces.DataSources;
using DAL.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataSource;

public class GenericDataSource<T> : IGenericDataSource<T> where T : class
{
    protected readonly AppDbContext DbContext;

    public GenericDataSource(AppDbContext dbContext)
    {
        DbContext = dbContext;
    }

    protected DbSet<T> Set => DbContext.Set<T>();

    /// <inheritdoc />
    public IQueryable<T> GetItems(Expression<Func<T, bool>>? filter = null)
    {
        if (filter is not null)
            return Set.Where(filter).AsNoTracking();
        return Set.AsNoTracking();
    }
    
    /// <inheritdoc />
    public async Task<T> AddAsync(T item)
    {
        await Set.AddAsync(item);
        return item;
    }
    
    /// <inheritdoc />
    public async Task SaveChangesAsync()
        => await DbContext.SaveChangesAsync();
}