using ExampleSqlCacheDependencyAPI.Models.MyDbContext;

namespace ExampleSqlCacheDependencyAPI.Models.Repository.Telephone
{
    public class TelephoneRepository : ITelephoneRepository
    {
        private readonly ProjectDbContext _projectDbContext;

        public TelephoneRepository(ProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }

        public Task AddAsync(Models.Telephone telephone)
        {
            _projectDbContext.AddAsync(telephone);
            _projectDbContext.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
