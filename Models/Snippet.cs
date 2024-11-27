using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippetTool.Models
{
    public class Snippet
    {
        public required string SnippetName { get; set; }
        public string? SnippetDescription { get; set; }

        public DateTime CreatedDate { get; set; }
        public required User CreatedBy { get; set; }
        
        
        public DateTime ReviewedDate { get; set; }
        public User? ReviewedBy { get; set; }

        public bool IsAnalyzed { get; set; }
        public bool IsReviewed { get; set; }
        public bool IsDeleted { get; set; }

    }
}
