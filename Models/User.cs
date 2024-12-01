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
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Snippet> Snippets { get; set; } = new List<Snippet>();
        public ICollection<Snippet>? ReviewedSnippets { get; set; }
    }
}
