using qDocManager.Services.Contracts;
using qDocManager.Core.Models;

namespace qDocManager.Services.Services
{
    public class CategoryService : ICategoryService
    {
        public Task AddCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(string categoryName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category?> GetCategoryByCategoryNameAsync(string categoryName)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
