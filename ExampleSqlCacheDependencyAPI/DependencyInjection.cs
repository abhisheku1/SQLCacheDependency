using ExampleSqlCacheDependencyAPI.Business;
using ExampleSqlCacheDependencyAPI.Business.Concrete;
using ExampleSqlCacheDependencyAPI.Models.MyDbContext;
using ExampleSqlCacheDependencyAPI.Models.Repository.Telephone;

namespace ExampleSqlCacheDependencyAPI;
public static class DependencyInjection
{
    public static void AddMyServices(this IServiceCollection services)
    {
        services.AddSingleton<ITelephoneManager, TelephoneManager>();
        services.AddSingleton<ITelephoneRepository, TelephoneRepository>();
        services.AddSingleton<ProjectDbContext>();
       
    }
}
