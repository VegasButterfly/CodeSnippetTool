﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippetTool.Services.Authentication
{
    public class SaltIt
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

        public static string HashPassword(string password), string salt)
           {
            using (var sha256 = SHA256.Create())
            {
            byte[] combinedBytes = Encoding.UTF8.GetBytes(password + salt);
            byte[] hashBytes = SHA256.ComputerHash(combinedBytes);
            return Convert.ToBase64String(hashBytes);
            }
        }   
}
