using CodeSnippetTool.Data;
using CodeSnippetTool.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeSnippetTool.Services.Authentication
{
    public class AuthHelper
    {
        public static void SeedRoles()
        {
            using var context = new AppDbContext();
            if (!context.Roles.Any())
            {
                context.Roles.AddRange(
                    new Role { RoleName = "Admin" },
                    new Role { RoleName = "Reviewer" },
                    new Role { RoleName = "User" }
                 );
                context.SaveChanges();
            }

        }

        public static void AssignRoleToUser(string username, string roleName)
        {
            using var context = new AppDbContext();
            var user = context.Users.Include(u => u.Roles).FirstOrDefault(u => u.Username == username);
            var role = context.Roles.FirstOrDefault(r => r.RoleName == roleName);

            if (user == null || role == null)
                throw new Exception("User or Role not found.");

            if (!user.Roles.Contains(role))
            {
                user.Roles.Add(role);
                context.SaveChanges();
            }
        }

        public static bool UserHasRole(string username, string roleName)
        {
            using var context = new AppDbContext();
            var user = context.Users.Include(u => u.Roles)
                                    .FirstOrDefault(u => u.Username == username);

            return user != null && user.Roles.Any(r => r.RoleName == roleName);
        }

    }
}
