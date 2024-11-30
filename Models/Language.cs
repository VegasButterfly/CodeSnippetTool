namespace CodeSnippetTool.Models
{
    public class Language
    {
        public int Id { get; set; }
        public required string LanguageName { get; set; }
        public ICollection<Snippet> Snippets { get; set; } = new List<Snippet>();
    }
}
