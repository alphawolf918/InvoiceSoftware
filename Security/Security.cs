using System;
using System.Security.Cryptography;
using System.Text;

namespace InvoiceSoftware {
    public class Security {
        private static string EncodePasswordToBase64(string password) {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }

        private static string CreateMD5(string input) {
            using (MD5 md5 = MD5.Create()) {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++) {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static string HashSecureEncryption(string input) {
            string encrypt = Security.EncodePasswordToBase64(input);
            string md5 = Security.CreateMD5(encrypt);
            return md5;
        }
    }
}