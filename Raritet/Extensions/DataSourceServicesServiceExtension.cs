using Abstraction.Interfaces.DataSources;
using DAL.DataSource;

namespace Raritet.Extensions;

public static class DataSourceServicesServiceExtension
{
    public static void AddDataSourceServices(this IServiceCollection services)
    {
        services
            .AddScoped(typeof(IGenericDataSource<>), typeof(GenericDataSource<>))
            .AddScoped<IAuthorDataSource, AuthorDataSource>();
    }
}