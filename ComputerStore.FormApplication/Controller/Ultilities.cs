using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.FormApplication.Controller
{
    public class Ultilities
    {
        public static string ip;
        public static int port;
        public static string idUser;

        public static string ToHashString(string str)
        {
            byte[] inputByte = Encoding.UTF8.GetBytes(str);
            SHA256 sha256Hash = SHA256.Create();
            byte[] outputByte = sha256Hash.ComputeHash(inputByte);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in outputByte)
            {
                sb.Append(b.ToString("X2").ToLower());
            }
            return sb.ToString();
        }
    }
}
