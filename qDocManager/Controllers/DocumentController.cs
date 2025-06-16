using Microsoft.AspNetCore.Mvc;
using qDocManager.Models;

namespace qDocManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly ILogger<DocumentController> _logger;

        public DocumentController(ILogger<DocumentController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetDocuments")]
        public IEnumerable<Document> GetDocuments()
        {

            return null;
        }

        [HttpGet(Name = "GetCategories")]
        public IEnumerable<Document> GetCategories()
        {

            return null;
        }

        [HttpGet(Name = "GetTags")]
        public IEnumerable<Document> GetTags()
        {

            return null;
        }
    }
}
