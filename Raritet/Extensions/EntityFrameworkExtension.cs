using DAL.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Raritet.Extensions;

public static class EntityFrameworkExtension
{
    public static void AddEntityFramework
        (this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
    }
}