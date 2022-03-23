using ExampleSqlCacheDependencyAPI.Models;
using ExampleSqlCacheDependencyAPI.Models.Repository.Telephone;

namespace ExampleSqlCacheDependencyAPI.Business.Concrete;
public class TelephoneManager : ITelephoneManager
{
    private readonly ITelephoneRepository _telephoneRepository;

    public TelephoneManager(ITelephoneRepository telephoneRepository)
    {
        _telephoneRepository = telephoneRepository;
    }

    public Task TelehoneAddAsync(Telephone telephone)
    {
        return _telephoneRepository.AddAsync(telephone);
    }
}
