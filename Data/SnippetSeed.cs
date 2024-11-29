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
        // Method to seed sample snippets into the database
        public static void SeedSampleSnippets(AppDbContext context) // Use your actual DbContext name
        {
            // Check if the table already has data
            if (!context.Snippets.Any())
            {
                var sampleSnippets = new List<Snippet>
                {
                    new Snippet
                    {
                        SnippetName = "Hello World Example",
                        SnippetDescription = "A simple Hello World example in C#",
                        CodeSnippetText = "Console.WriteLine(\"Hello, World!\");",
                        AnalysisText = "This is a basic Hello World program in C#.",
                        LanguageId = 2
                    },
                    new Snippet
                    {
                        SnippetName = "Basic Loop",
                        SnippetDescription = "A simple for loop in C#",
                        CodeSnippetText = "for(int i = 0; i < 10; i++) { Console.WriteLine(i); }",
                        AnalysisText = "This loop iterates 10 times and prints the value of i.",
                        LanguageId = 2
                    }
                };

                // Add the sample snippets to the database context
                context.Snippets.AddRange(sampleSnippets);
                context.SaveChanges(); // Save changes to the database
            }
        }
    }
}
