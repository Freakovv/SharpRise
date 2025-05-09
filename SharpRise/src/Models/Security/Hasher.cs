﻿using System.Security.Cryptography;
using System.Text;

namespace SharpRise.src.Models.Security
{
    public static class Hasher
    {
        public static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();

            // Convert pass in bytes
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            byte[] hashBytes = sha256.ComputeHash(passwordBytes);

            // Convert hash in string (Base64)
            return Convert.ToBase64String(hashBytes);
        }

        public static bool VerifyPassword(string inputPassword, string storedHash)
        {
            string inputHash = HashPassword(inputPassword);
            return inputHash == storedHash;
        }
    }
}