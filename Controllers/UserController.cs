using CodeSnippetTool.Data;
using CodeSnippetTool.Models;
using CodeSnippetTool.Services.Authentication;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CodeSnippetTool.Controllers
{
    public class UserController 
    {
        public List<dynamic> GetAllUsers()
        {
            using var context = new AppDbContext();
            return context.Users
                .Include(u => u.Role)  
                .Select(u => new
                {
                    Id = u.Id,
                    Username = u.Username,
                    RoleName = u.Role.RoleName
                })
                .Cast<dynamic>()
                .ToList();
        }

        public List<Role> GetAllRoles()
        {
            using var context = new AppDbContext();
            return context.Roles.ToList();
        }

        public Role GetRoleById(int roleId)
        {
            using var context = new AppDbContext();
            return context.Roles.FirstOrDefault(r => r.Id == roleId);
        }

        public void AddUser(string userName, string password, string email, Role role)
        {
            using var context = new AppDbContext();

            // Hash the password with the generated salt
            string salt = SaltIt.GenerateSalt();
            string hashedPassword = SaltIt.HashPassword(password, salt);

            var user = new User
            {
                Username = userName,
                PasswordHash = hashedPassword,
                Salt = salt,
                Email = email,
                Role = role  
            };

            context.Users.Add(user);
            context.SaveChanges();
        }

        public void UpdateUser(int userId, string userName, string email, Role role, string? newPassword = null)
        {
            using var context = new AppDbContext();
            var user = context.Users.Include(u => u.Role).FirstOrDefault(u => u.Id == userId);

            if (user != null)
            {
                user.Username = userName;
                user.Email = email;
                user.Role = role;

                // If there's a new password, hash it and update the password and salt
                if (!string.IsNullOrEmpty(newPassword))
                {
                    string newSalt = SaltIt.GenerateSalt();
                    string newHashedPassword = SaltIt.HashPassword(newPassword, newSalt);
                    user.PasswordHash = newHashedPassword;
                    user.Salt = newSalt;
                }                                               

                context.SaveChanges();
            }
        }

        public void DeleteUser(int userId)
        {
            using var context = new AppDbContext();
            var user = context.Users.Find(userId);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

    }
}
