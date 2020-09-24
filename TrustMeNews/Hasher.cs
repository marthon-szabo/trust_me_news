using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace TrustMeNews
{
    public class Hasher
    {
        public static string[] HashMe(string plainText)
        {
            string salt = GetSalt(plainText);
            string hashedPw = ComputeSHA256Hash(salt, plainText);

            return new string[] { salt, hashedPw };

        }

        private static string ComputeSHA256Hash(string salt, string plainText)
        {
            using (SHA256 algorithm = SHA256.Create())
            {
                byte[] hashBytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(salt + plainText));
                return ConvertToString(hashBytes);
            }
        }
        private static string GetSalt(string plainText)
        {
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[plainText.Length];
                rngCsp.GetBytes(salt);
                return ConvertToString(salt);
            }
        }

        private static string ConvertToString(byte[] hashBytes)
        {
            StringBuilder sb = new StringBuilder();

            foreach (byte number in hashBytes)
            {
                sb.Append(number.ToString("X2"));
            }
            return sb.ToString();
        }

        public static bool Authenticate(string plainText, string referenceSalt, string referencePw)
        {
            string loginPw = ComputeSHA256Hash(referenceSalt, plainText);

            if (loginPw == referencePw)
            {
                return true;
            }

            return false;
        }

    }
}
