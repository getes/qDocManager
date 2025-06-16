using qDocManager.Core.Models;

namespace qDocManager.Services.Contracts
{
    public interface ITagService
    {
        Task<IEnumerable<Tag>> GetAllTagsAsync();
        Task<Tag?> GetTagByNameAsync(string tagName);
        Task AddTagAsync(Tag document);
        Task UpdateTagAsync(Tag document);
        Task DeleteTagAsync(string tagName);
    }
}
