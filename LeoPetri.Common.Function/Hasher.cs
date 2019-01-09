using System;
using System.Security.Cryptography;
using System.Text;

namespace LeoPetri.Common.Function
{
    public static class Hasher
    {
        public readonly static string DefaultGuid = "| 70e41a1b-c9e8-4517-8c5b-d68e39be6693";

        public static string GetHash(string value, string guid = null)
        {
            using (var sha512 = SHA512.Create())
            {
                var hashedBytes = sha512.ComputeHash(Encoding.ASCII.GetBytes(value + (guid ?? DefaultGuid)));

                return Convert.ToBase64String(hashedBytes, 0, hashedBytes.Length);
            }
        }
        
        public static bool IsMatch(string hashValue, string valueProvided)
        {
            var hashProvided = GetHash(valueProvided);
            return hashValue == hashProvided;
        }
    }
}
