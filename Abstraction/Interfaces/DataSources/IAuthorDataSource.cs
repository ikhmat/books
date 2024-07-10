using System.Linq.Expressions;
using Models.Entities;

namespace Abstraction.Interfaces.DataSources;

public interface IAuthorDataSource : IGenericDataSource<Author>
{
    /// <summary>
    /// Asynchronously returns Author with include Books
    /// </summary>
    /// <param name="filter">Expression to filter entities</param>
    /// <returns>Author with Books</returns>
    Task<Author?> GetAuthorWithBooks(Expression<Func<Author, bool>> filter);
}