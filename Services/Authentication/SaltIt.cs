using System.Security.Cryptography;
using System.Text;


namespace CodeSnippetTool.Services.Authentication
{
    public static class SaltIt
    {

        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        public static string HashPassword(string password, string salt)
        {
            byte[] combinedBytes = Encoding.UTF8.GetBytes(password + salt);
            byte[] hashBytes = SHA256.HashData(combinedBytes);
            return Convert.ToBase64String(hashBytes);
        }
    }
}

