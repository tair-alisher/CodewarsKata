using System;

namespace BreakCamelCase
{
    public class Kata
    {
        public static string BreakCamelCase (string str)
        {
            string resultString = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str, i))
                    resultString += ' ';
                resultString += str[i];
            }

            return resultString;
        }
    }
}
