using CodeSnippetTool.Data;
using CodeSnippetTool.Services.Authentication;
using Microsoft.EntityFrameworkCore;

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
            AuthHelper.SeedRoles(context);
            AuthHelper.SeedUsers(context);
          

            Application.Run(new LoginForm());
        }
    }
}