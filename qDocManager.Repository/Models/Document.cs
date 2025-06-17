

namespace qDocManager.Repository.Models
{
    public class Document
    {
        public string Title { get; set; }

        public string[]? tags { get; set; }

        public Category? categories { get; set; }
    }
}
