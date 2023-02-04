using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    public class encryption
    {
        public encryption()
        {

        }

        /// <summary>
        /// Encrypts the given string
        /// </summary>
        /// <param name="password">the string that is to be Encrypted</param>
        /// <returns>The Encrypted string</returns>
        public string encrypt(string password)
        {
            string encrypted = "";
            byte[] data = UTF8Encoding.UTF8.GetBytes(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("password"));
                using (TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = trip.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    encrypted = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            return encrypted;
        }



        //public string decrypt(string password)
        //{
        //    string decrypted = "";
        //    byte[] data = Convert.FromBase64String(password);
        //    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
        //    {
        //        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("password"));
        //        using (TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
        //        {
        //            ICryptoTransform transform = trip.CreateDecryptor();
        //            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
        //            decrypted = UTF8Encoding.UTF8.GetString(results);
        //        }
        //    }
        //    return decrypted;
        //}
    }
}
