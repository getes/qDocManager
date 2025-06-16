// IDocumentService.cs
using qDocManager.Models;

namespace qDocManager.Services.Contracts
{
    public interface IDocumentService
    {
        Task<IEnumerable<Document>> GetAllDocumentsAsync();
        Task<Document?> GetDocumentByTitleAsync(string documentTitle);
        Task AddDocumentAsync(Document document);
        Task UpdateDocumentAsync(Document document);
        Task DeleteDocumentAsync(string documentTitle);
    }
}
