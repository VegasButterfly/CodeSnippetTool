using CodeSnippetTool.Data;
using CodeSnippetTool.Services.Authentication;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Transactions;

namespace CodeSnippetTool
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using var context = new AppDbContext();

            context.Database.Migrate();

            
            // Seed roles and users
            try
            {
                AuthHelper.SeedRoles(context);
                AuthHelper.SeedUsers(context);
                LanguageSeed.SeedLanguages(context);
                ///Debug.WriteLine("Starting snippet seeding...");
                SnippetSeed.SeedSampleSnippets(context);
               /// Debug.WriteLine("Snippet seeding completed.");
            
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error during seeding: {ex.Message}");
            
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginForm());
        }
    }
}