using System;
using System.Text;

namespace Base64Encoding
{
    public class Base64Utils
    {
        public static string ToBase64(string s)
        {
            byte[] bytesArr = Encoding.UTF8.GetBytes(s);
            return Convert.ToBase64String(bytesArr);
        }

        public static string FromBase64(string s)
        {
            byte[] bytesArr = Convert.FromBase64String(s);
            return Encoding.UTF8.GetString(bytesArr);
        }
    }
}
