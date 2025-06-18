using qDocManager.Models;
using qDocManager.Repository.Contracts;
using qDocManager.Services.Contracts;

namespace qDocManager.Services.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IGenericRepository<Document> _documentRepository;

        //Renaming Documents

        //Sorting by (Date, Category, Tags, extensions, size..)

        //move files



        public DocumentService(IGenericRepository<Document> documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public Task<IEnumerable<Document>> GetAllDocumentsAsync() => _documentRepository.GetAllAsync();

        public Task<Document?> GetDocumentByTitleAsync(string documentTitle) => _documentRepository.GetByNameAsync(documentTitle);

        public Task AddDocumentAsync(Document document) => _documentRepository.AddAsync(document);

        public Task UpdateDocumentAsync(Document document) => _documentRepository.UpdateAsync(document);

        public Task DeleteDocumentAsync(string documentTitle) => _documentRepository.DeleteAsync(documentTitle);

        public async Task<IEnumerable<Document>> GetDocumentsByCategory(string categoryName)
        {
            var documents = await _documentRepository.GetAllAsync();
            return documents.Where(d => d.categories != null && d.categories.CategoryName == categoryName);
        }

        public async Task<IEnumerable<Document>> GetDocumentsByTag(string tagName)
        {
            var documents = await _documentRepository.GetAllAsync();
            return documents.Where(d => d.tags != null && d.tags.Contains(tagName));
        }
    }
}
