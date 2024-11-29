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
            if (!context.Languages.Any())
            {
                context.Languages.AddRange(
                    new Language { LanguageName = "AutoIt" },
                    new Language { LanguageName = "C#" },
                    new Language { LanguageName = "Powershell" }
                 );
                context.SaveChanges();
            }
        }
    }
}
