using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Cloudrip
{
    public static class Core
    {

        public static string ToMD5(this string input, string salt)
        {
            return ToMD5(input + salt);
        }

        public static string ToMD5(this string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)

            {

                sb.Append(hash[i].ToString("X2"));

            }

            return sb.ToString().ToLower();

        }
    }
}
