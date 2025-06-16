using qDocManager.Repository.Contracts;
using qDocManager.Repository.Models;

namespace qDocManager.Repository.Repositories
{
    public class CategoryRepository : IGenericRepository<Category>
    {
        // For demonstration, using in-memory storage
        private readonly List<Category> _categories = new();

        public Task<IEnumerable<Category>> GetAllAsync() => Task.FromResult(_categories.AsEnumerable());

        public Task<Category?> GetByNameAsync(string categoryName) =>
            Task.FromResult(_categories.FirstOrDefault(c => c.CategoryName == categoryName));

        public Task AddAsync(Category entity)
        {
            _categories.Add(entity);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Category entity)
        {
            // Update logic here
            return Task.CompletedTask;
        }

        public Task DeleteAsync(string categoryName)
        {
            var cat = _categories.FirstOrDefault(c => c.CategoryName == categoryName);
            if (cat != null) _categories.Remove(cat);
            return Task.CompletedTask;
        }
    }
}
