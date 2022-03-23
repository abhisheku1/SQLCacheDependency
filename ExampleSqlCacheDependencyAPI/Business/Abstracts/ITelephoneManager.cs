using ExampleSqlCacheDependencyAPI.Models;

namespace ExampleSqlCacheDependencyAPI.Business;

public interface ITelephoneManager
{
    Task TelehoneAddAsync(Telephone telephone);
}
