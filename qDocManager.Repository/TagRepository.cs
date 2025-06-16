
using qDocManager.Repository.Contracts;
using qDocManager.Repository.Models;

namespace qDocManager.Repository.Repositories
{
    public class TagRepository : IGenericRepository<Tag>
    {
        // For demonstration, using in-memory storage
        private readonly List<Tag> _tags = new();

        public Task<IEnumerable<Tag>> GetAllAsync() => Task.FromResult(_tags.AsEnumerable());

        public Task<Tag?> GetByNameAsync(String tagName) =>
            Task.FromResult(_tags.FirstOrDefault(t => t.TagName == tagName));

        public Task AddAsync(Tag entity)
        {
            _tags.Add(entity);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Tag entity)
        {
            // Update logic here
            return Task.CompletedTask;
        }

        public Task DeleteAsync(string tagName)
        {
            var tag = _tags.FirstOrDefault(t => t.TagName == tagName);
            if (tag != null) _tags.Remove(tag);
            return Task.CompletedTask;
        }
    }
}