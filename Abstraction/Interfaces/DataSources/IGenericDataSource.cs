using System.Linq.Expressions;

namespace Abstraction.Interfaces.DataSources;

public interface IGenericDataSource<T>
{
    IQueryable<T> GetItems(Expression<Func<T, bool>>? filter = null);

    // IQueryable<T> GetTrackedItemsAsync(Expression<Func<T, bool>> filter);
    //
    // T GetItemAsync(int id);
    //
    // T GetTrackedItemAsync(int id);
    //
    Task<T> AddAsync(T item);
    //
    // Task<T> UpdateItemAsync(T item);

    Task SaveChangesAsync();
}