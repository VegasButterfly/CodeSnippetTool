using CodeSnippetTool.Models;
using System;
using System.Collections.Generic;
using CodeSnippetTool.Data;
using CodeSnippetTool.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeSnippetTool.Data
{
    public class LanguageSeed
    {
        public static void SeedLanguages(AppDbContext context)
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                if (!context.Languages.Any())
                {
                    context.Languages.AddRange(
                        new Language { LanguageName = "AutoIt" },
                        new Language { LanguageName = "C#" },
                        new Language { LanguageName = "Powershell" }
                    );
                    context.SaveChanges();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding languages: {ex.Message}");
                transaction.Rollback();
            }
        }
    }
}
