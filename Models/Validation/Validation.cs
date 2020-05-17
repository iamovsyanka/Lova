using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Models.Validation
{
    public static class Validation
    {
        public static Regex regexLogin = new Regex(@"^[A-zА-я\d]+$");
        public static Regex regexPassword = new Regex(@"^[A-z\d]+$");

        public static Guid GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            var CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }

            return new Guid(hash);
        }
    }
}
