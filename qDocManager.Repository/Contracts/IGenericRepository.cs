// IGenericRepository.cs
namespace qDocManager.Repository.Contracts
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByNameAsync(String tagName);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(String tagName);
    }
}
