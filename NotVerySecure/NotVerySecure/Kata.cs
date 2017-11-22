using System.Text.RegularExpressions;

namespace NotVerySecure
{
    public class Kata
    {
        public static bool Alphanumeric (string str)
        {
            return new Regex(@"^[a-zA-Z0-9]+$").Matches(str).Count > 0;
        }
    }
}
