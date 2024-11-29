using CodeSnippetTool.Models;

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
