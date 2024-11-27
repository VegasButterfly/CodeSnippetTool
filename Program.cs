using CodeSnippetTool.Services.Authentication;

namespace CodeSnippetTool
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            AuthHelper.SeedRoles();
            AuthHelper.SeedUsers();
            Application.Run(new LoginForm());
        }
    }
}