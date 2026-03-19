using System;
using System.Security.Cryptography;
using System.Text;

namespace BUS
{
    public static class PasswordHasher
    {
        // Hàm này giúp biến mật khẩu "123" thành một dãy ký tự bảo mật
        public static string HashMD5(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}