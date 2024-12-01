using CodeSnippetTool.Data;
using CodeSnippetTool.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeSnippetTool.Services.Authentication
{
    public class AuthHelper
    {
        public static void SeedRoles(AppDbContext context)
        {            
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

        public static void SeedUsers(AppDbContext context)
        {            
            {
                if (!context.Users.Any())
                {
                    var adminSalt = SaltIt.GenerateSalt();
                    var demoSalt = SaltIt.GenerateSalt();
                    var adminPasswordHash = SaltIt.HashPassword("Admin123*", adminSalt);
                    var demoPasswordHash = SaltIt.HashPassword("Demo123*", demoSalt);
                    var adminRole = context.Roles.SingleOrDefault(r => r.RoleName == "Admin");
                    var demoRole = context.Roles.SingleOrDefault(r => r.RoleName == "User");

                    if (adminRole != null && demoRole != null)
                    {
                        var users = new List<User>
                        {
                            new User
                            {
                                Username = "Admin",
                                PasswordHash = adminPasswordHash,
                                Salt = adminSalt,
                                RoleId = adminRole.Id
                            },
                             new User
                            {
                                Username = "Demo",
                                PasswordHash = demoPasswordHash,
                                Salt = demoSalt,
                                RoleId = demoRole.Id
                            }
                        };
                        context.Users.AddRange(users);
                        context.SaveChanges();
                    }
                }
            }
        }

        public static void AssignRoleToUser(AppDbContext context, string username, string roleName)
        {
            var user = context.Users.FirstOrDefault(u => u.Username == username);
            var role = context.Roles.FirstOrDefault(r => r.RoleName == roleName);

            if (user == null || role == null)
                throw new Exception("User or Role not found.");
                        
            user.RoleId = role.Id;
            context.SaveChanges();
        }

        public static bool UserHasRole(AppDbContext context, string username, string roleName)
        {
            var user = context.Users.Include(u => u.Role)
                                    .FirstOrDefault(u => u.Username == username);

            return user != null && user.Role != null && user.Role.RoleName == roleName;
        }

    }
}
