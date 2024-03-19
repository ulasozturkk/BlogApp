using DataAccess.Repositories.concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Extensions;

public static class DataLayerExtensions
{
    public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services,IConfiguration configuration) {
        services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
        return services;
    }
}
