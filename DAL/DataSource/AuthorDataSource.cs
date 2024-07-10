using System.Linq.Expressions;
using Abstraction.Interfaces.DataSources;
using DAL.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DAL.DataSource;

public class AuthorDataSource : GenericDataSource<Author>, IAuthorDataSource
{
    public AuthorDataSource(AppDbContext dbContext) : base(dbContext) { }

    public async Task<Author?> GetAuthorWithBooks(Expression<Func<Author, bool>> filter)
    {
        return await Set.Include(x => x.Books).FirstOrDefaultAsync(filter);
    }
}
