// DocumentRepository.cs
using qDocManager.Repository.Contracts;
using qDocManager.Repository.Models;

namespace qDocManager.Repository.Repositories
{
    public class DocumentRepository : IGenericRepository<Document>
    {
        // For demonstration, using in-memory storage
        //private readonly List<Document> _documents = new();
        private readonly AppDbContext _context;

        public DocumentRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Document>> GetAllAsync() => Task.FromResult(_context.Documents.AsEnumerable());

        public Task<Document?> GetByNameAsync(string documentTitle) =>
            Task.FromResult(_context.Documents.FirstOrDefault(d => d.Title == documentTitle));

        public Task AddAsync(Document entity)
        {
            _context.Documents.Add(entity);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Document entity)
        {
            // Update logic here
            return Task.CompletedTask;
        }

        public Task DeleteAsync(string documentTitle)
        {
            var doc = _context.Documents.FirstOrDefault(d => d.Title == documentTitle);
            if (doc != null) _context.Documents.Remove(doc);
            return Task.CompletedTask;
        }
    }
}
