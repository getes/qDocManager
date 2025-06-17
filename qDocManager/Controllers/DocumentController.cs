using Microsoft.AspNetCore.Mvc;
using qDocManager.Core.Models;
using qDocManager.Models;
using qDocManager.Services.Contracts;

namespace qDocManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly ILogger<DocumentController> _logger;
        private readonly IDocumentService _documentService;
        private readonly ICategoryService _categoryService;
        private readonly ITagService _tagService;

        public DocumentController(
            ILogger<DocumentController> logger,
            IDocumentService documentService,
            ICategoryService categoryService,
            ITagService tagService)
        {
            _logger = logger;
            _documentService = documentService;
            _categoryService = categoryService;
            _tagService = tagService;
        }

        [HttpGet(Name = "GetDocuments")]
        public IEnumerable<Document> GetDocuments()
        {
            return null;
        }

        [HttpGet("categories", Name = "GetCategories")]
        public IEnumerable<Category> GetCategories()
        {
            return null;
        }

        [HttpGet("tags", Name = "GetTags")]
        public IEnumerable<Tag> GetTags()
        {
            return null;
        }

        [HttpGet("by-category/{categoryName}", Name = "GetDocumentsByCategory")]
        public async Task<ActionResult<IEnumerable<Document>>> GetDocumentsByCategory(string categoryName)
        {
            Category? category = await _categoryService.GetCategoryByCategoryNameAsync(categoryName);
            if (category == null)
            {
                return NotFound($"Category '{categoryName}' not found.");
            }

            var documents = _documentService.GetDocumentsByCategory(category.CategoryName);
            return Ok(documents);
        }

        [HttpGet("by-tag/{tagName}", Name = "GetDocumentsByTag")]
        public async Task<ActionResult<IEnumerable<Document>>> GetDocumentsByTag(string tagName)
        {
            Tag? tag = await _tagService.GetTagByNameAsync(tagName);
            if (tag == null)
            {
                return NotFound($"Tag '{tagName}' not found.");
            }

            var documents = _documentService.GetDocumentsByTag(tag.TagName);
            return Ok(documents);
        }
    }
}
