using System;
using System.Text;

namespace Mumbling
{
    public class Acumul
    {
        public static string Accum (string s)
        {
            StringBuilder resultString = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                resultString.Append(s[i].ToString().ToUpper());
                for (int j = 0; j < i; j++)
                    resultString.Append(s[i].ToString().ToLower());
                resultString.Append("-");
            }
            resultString.Length -= 1;
            return resultString.ToString();
        }
    }
}
