using System;
using System.Text.RegularExpressions;

namespace WordA10n
{
    public class Kata
    {
        public static string Abbreviate (string input)
        {
            return Regex.Replace(input, @"\w{4,}", delegate (Match match)
            {
                string m = match.ToString();
                return m[0] + (m.Length - 2).ToString() + m[m.Length - 1];
            });
        }
    }
}
