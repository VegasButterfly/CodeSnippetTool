using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippetTool.Models
{
    public class Translation
    {
        public int Id { get; set; }
        public int SnippetId { get; set; } 
        public string Language { get; set; }
        public string TranslationText { get; set; } 
        public bool Reviewed { get; set; } 
        public int? ReviewerId { get; set; }
        public DateTime? ReviewDate { get; set; }
        
        public User? Reviewer { get; set; } 
        public virtual Snippet Snippet { get; set; }
    }
}
