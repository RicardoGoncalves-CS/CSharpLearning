using NorthwindAPI.Data.Repositories;

namespace NorthwindAPI.Services
{
    public class NorthwindService<T> : INorthwindService<T>
    {
        private readonly ILogger _logger;
        private readonly INorthwindRepository<T> _repository;

        public NorthwindService(ILogger logger, INorthwindRepository<T> repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public Task<bool> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>?> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
