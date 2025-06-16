// DocumentRepository.cs
using qDocManager.Repository.Contracts;
using qDocManager.Repository.Models;

namespace qDocManager.Repository.Repositories
{
    public class DocumentRepository : IGenericRepository<Document>
    {
        // For demonstration, using in-memory storage
        private readonly List<Document> _documents = new();

        public Task<IEnumerable<Document>> GetAllAsync() => Task.FromResult(_documents.AsEnumerable());

        public Task<Document?> GetByNameAsync(string documentTitle) =>
            Task.FromResult(_documents.FirstOrDefault(d => d.Title == documentTitle));

        public Task AddAsync(Document entity)
        {
            _documents.Add(entity);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Document entity)
        {
            // Update logic here
            return Task.CompletedTask;
        }

        public Task DeleteAsync(string documentTitle)
        {
            var doc = _documents.FirstOrDefault(d => d.Title == documentTitle);
            if (doc != null) _documents.Remove(doc);
            return Task.CompletedTask;
        }
    }
}
