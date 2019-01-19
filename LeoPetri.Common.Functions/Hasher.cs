using System;
using System.Security.Cryptography;
using System.Text;

namespace LeoPetri.Common.Functions
{
    public static class Hasher
    {
        public static string GetHash(string value, Guid? guid = null)
        {
            using (var sha512 = SHA512.Create())
            {
                var hashedBytes = sha512.ComputeHash(Encoding.ASCII.GetBytes(value + (guid.HasValue ? " | " + guid.Value.ToString() : string.Empty)));

                return Convert.ToBase64String(hashedBytes, 0, hashedBytes.Length);
            }
        }
        
        public static bool IsMatch(string hashValue, string valueProvided, Guid? guid = null)
        {
            var hashProvided = GetHash(valueProvided, guid);
            return hashValue == hashProvided;
        }
    }
}
