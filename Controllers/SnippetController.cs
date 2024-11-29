using CodeSnippetTool.Data;
using CodeSnippetTool.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeSnippetTool.Controllers
{
    public class SnippetController
    {
        public List<dynamic> GetAllSnippets()
        {
            using var context = new AppDbContext();
            var snippets = context.Snippets
                .Join(context.Users,
                snippet => snippet.CreatedById,
                user => user.Id,
                (snippet, user) => new
                {
                    snippet.Id,
                    snippet.SnippetName,
                    snippet.SnippetDescription,
                    snippet.CreatedDate,
                    CreatedBy = user.Username
                })
                .ToList<dynamic>();

            return snippets;
        }              

        public void SaveSnippet(Snippet snippet)
        {
            using var context = new AppDbContext();
            
            if (snippet.Id == 0) // New snippet
            {
                snippet.CreatedDate = DateTime.Now; // Set CreatedDate when creating new snippet
                snippet.CreatedById = (int)UserSession.CurrentUserId;
            }

            if (snippet.Id == 0)
            {
                context.Snippets.Add(snippet); // Add new snippet
            }
            else
            {
                context.Snippets.Update(snippet); // Update existing snippet
            }

            context.SaveChanges(); // Save changes to database
        }

        public void DeleteSnippet(int snippetId)
        {
            using var context = new AppDbContext();
            var snippet = context.Snippets.FirstOrDefault(s => s.Id == snippetId);
            if (snippet != null)
            {
                context.Snippets.Remove(snippet); // Remove snippet from database
                context.SaveChanges();
            }
        }
    }
}
