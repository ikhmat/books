using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DAL.EntityFramework;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    #region MyRegion

    public DbSet<Author> Authors { get; set; }

    public DbSet<Book> Books { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var applicationContextAssembly = typeof(AppDbContext).Assembly;

        modelBuilder.ApplyConfigurationsFromAssembly(applicationContextAssembly);
    }
}