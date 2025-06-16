// DocumentService.cs
using qDocManager.Core.Models;
using qDocManager.Services.Contracts;
namespace qDocManager.Services.Services
{
    public class TagService : ITagService
    {
        public Task AddTagAsync(Tag document)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTagAsync(string tagName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tag>> GetAllTagsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Tag?> GetTagByNameAsync(string tagName)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTagAsync(Tag document)
        {
            throw new NotImplementedException();
        }
    }
}
