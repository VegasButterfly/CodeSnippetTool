using CodeSnippetTool.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippetTool.Controllers
{
    public class SnippetController
    {

        public List<dynamic> GetAllSnippets()
        {
            using var context = new AppDbContext();
            var snippets = context.Snippets
            .Select(s => new
             { 
                 s.Id,
                 s.SnippetName,
                 s.SnippetDescription,
                 s.CreatedDate
             })
            .ToList<dynamic>();
            return snippets;
        }

    }
}
