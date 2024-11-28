namespace CodeSnippetTool.Models
{
    public class Snippet
    {
        public int Id { get; set; }

        public required string SnippetName { get; set; }
        public string? SnippetDescription { get; set; }

        public DateTime CreatedDate { get; set; }
        public int CreatedById { get; set; }
        public User? CreatedBy { get; set; }

        public DateTime? ReviewedDate { get; set; }
        public int? ReviewedById { get; set; }
        public User? ReviewedBy { get; set; }

        public bool IsAnalyzed { get; set; }
        public bool IsReviewed { get; set; }
        public bool IsDeleted { get; set; }

        public int? LanguageId { get; set; }
        public Language? Language { get; set; }

        public string? AnalysisText { get; set; }
        public string? CodeSnippetText { get; set; }

    }
}
