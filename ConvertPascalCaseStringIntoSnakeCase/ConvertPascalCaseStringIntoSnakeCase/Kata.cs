using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConvertPascalCaseStringIntoSnakeCase
{
    public class Kata
    {
        public static string ToUnderscore(int str) => str.ToString();

        public static string ToUnderscore(string str)
        {
            string result = "";
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != Char.ToLower(str[i]))
                    result += '_';

                result += Char.ToLower(str[i]);
            }

            return Char.ToLower(str[0]) + result;
        }
    }
}
