using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AnyPing.utils
{
    internal class Conversion
    {
        private static readonly byte[] optionalEntropy = Encoding.ASCII.GetBytes("AnyPing");

        public static int Clamp(int value, int min, int max)
        {
            return Math.Min(Math.Max(value, min), max);
        }

        public static string Protect(string plainText)
        {
            if (String.IsNullOrEmpty(plainText))
            {
                return "";
            }

            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] cipherBytes = ProtectedData.Protect(plainBytes, optionalEntropy, DataProtectionScope.CurrentUser);
            string cipherText = Convert.ToBase64String(cipherBytes);

            Debug.Assert(Unprotect(cipherText) == plainText, "暗号化に失敗しました。");

            return cipherText;
        }

        public static string Unprotect(string cipherText)
        {
            if (String.IsNullOrEmpty(cipherText))
            {
                return "";
            }

            try
            {
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                byte[] plainBytes = ProtectedData.Unprotect(cipherBytes, optionalEntropy, DataProtectionScope.CurrentUser);
                string plainText = Encoding.UTF8.GetString(plainBytes);
                return plainText;
            }
            catch (Exception ex)
            {
                Debug.Print("復号に失敗しました: {0}", ex);
                return "";
            }
        }
    }
}
