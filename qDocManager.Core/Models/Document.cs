using qDocManager.Services.Models;

namespace qDocManager.Models
{
    public class Document
    {
        public string Title { get; set; }

        public string[] flags { get; set; }

        public Category categories { get; set; }
    }
}
