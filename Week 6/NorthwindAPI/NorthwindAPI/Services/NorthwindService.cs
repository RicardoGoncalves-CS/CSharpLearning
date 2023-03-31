using NorthwindAPI.Controllers;
using NorthwindAPI.Data.Repositories;

namespace NorthwindAPI.Services
{
    public class NorthwindService<T> : INorthwindService<T> where T : class
    {
        private readonly ILogger _logger;
        private readonly INorthwindRepository<T> _repository;

        public NorthwindService(ILogger<INorthwindService<T>> logger, INorthwindRepository<T> repository)
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

        public async Task<T?> GetAsync(int id)
        {
            if (_repository.IsNull)
            {
                return null;
            }

            var entity = await _repository.FindAsync(id);
            
            if (entity == null)
            {
                _logger.LogWarning($"{typeof(T).Name} with id:{id} was not found");
                return null;
            }

            _logger.LogInformation($"{typeof(T).Name} with id:{id} was found");
            return entity;
        }

        public Task<bool> UpdateAsync(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
