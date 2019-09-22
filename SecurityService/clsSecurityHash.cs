using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Security.Cryptography;
using System.Text;

namespace SecurityService
{
    public static class clsSecurityHash
    {
        /// <summary>
        /// méthode de hashage en MD5
        /// </summary>
        /// <param name="value">chaîne à crypter</param>
        /// <returns>chaîne hashée </returns>
        public static string getMD5(string value)
        {
            MD5 md = MD5.Create();
            byte[] data = md.ComputeHash(Encoding.Default.GetBytes(value));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// méthode de hashage en SHA1
        /// </summary>
        /// <param name="value">chaîne à crypter</param>
        /// <returns>chaîne hashée </returns>
        public static string getSHA1(string value)
        {
            SHA1 sha = SHA1.Create();
            byte[] data = sha.ComputeHash(Encoding.Default.GetBytes(value));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// méthode de hashage en SHA256
        /// </summary>
        /// <param name="value">chaîne à crypter</param>
        /// <returns>chaîne hashée </returns>
        public static string getSHA256(string value)
        {
            SHA256 sha = SHA256.Create();
            byte[] data = sha.ComputeHash(Encoding.Default.GetBytes(value));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}