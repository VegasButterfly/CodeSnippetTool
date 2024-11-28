namespace CodeSnippetTool.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string PasswordHash { get; set; }
        public string Salt { get; set; } = string.Empty;
        public string? Email { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public ICollection<Role> Roles { get; set; } = new List<Role>();
        public ICollection<Snippet> Snippets { get; set; } = new List<Snippet>();
        public ICollection<Snippet>? ReviewedSnippets { get; set; }
    }
}
