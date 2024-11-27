using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippetTool.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public string? Email { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}
