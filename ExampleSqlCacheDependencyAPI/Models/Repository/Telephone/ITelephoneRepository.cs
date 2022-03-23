namespace ExampleSqlCacheDependencyAPI.Models.Repository.Telephone;
using ExampleSqlCacheDependencyAPI.Models;
public interface ITelephoneRepository
{
    public Task AddAsync(Telephone telephone);
}
