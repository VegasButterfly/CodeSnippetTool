using CodeSnippetTool.Data;
using CodeSnippetTool.Models;
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
                .Include(u => u.Roles)
                .Select(u => new
                {
                    Id = u.Id,
                    Username = u.Username,
                    RoleNames = string.Join(", ", u.Roles.Select(r => r.RoleName)) 
                })
                .Cast<dynamic>()
                .ToList();
        }

        
        public void AddUser(User user)
        {
            using var context = new AppDbContext();
            context.Users.Add(user);
            context.SaveChanges();
        }

        
        public void UpdateUser(int userId, string userName, string userRole)
        {
            using var context = new AppDbContext();
            var user = context.Users.Include(u => u.Roles).FirstOrDefault(u => u.Id == userId);

            if (user != null)
            {
                user.Username = userName;
                                
                var role = context.Roles.FirstOrDefault(r => r.RoleName == userRole); // Assuming you use RoleName for matching
                if (role != null)
                {
                    user.Roles.Clear(); 
                    user.Roles.Add(role);
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
