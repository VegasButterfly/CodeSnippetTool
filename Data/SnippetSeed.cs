using CodeSnippetTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippetTool.Data
{
    public class SnippetSeed
    {
        public static void SeedSampleSnippets(AppDbContext context)
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                if (!context.Snippets.Any())
                {
                    context.Snippets.AddRange(
                         new Snippet
                         {
                             SnippetName = "Hello World Example",
                             SnippetDescription = "A simple Hello World example in C#",
                             CreatedDate = DateTime.Now,
                             CreatedById = 1,
                             CodeSnippetText = "Console.WriteLine(\"Hello, World!\");",
                             AnalysisText = "This is a basic Hello World program in C#.",
                             LanguageId = 2
                         },
                         new Snippet
                         {
                             SnippetName = "Basic Loop",
                             SnippetDescription = "A simple for loop in C#",
                             CreatedDate = DateTime.Now,
                             CreatedById = 1,
                             CodeSnippetText = "for(int i = 0; i < 10; i++) { Console.WriteLine(i); }",
                             AnalysisText = "This loop iterates 10 times and prints the value of i.",
                             LanguageId = 2
                         });
                    context.SaveChanges();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                {
                    Console.WriteLine($"Error seeding sample snippets: {ex.Message}");
                    transaction.Rollback();
                }

            }
        }
    }
}
