using System;

namespace ConvertStringToCamelCase
{
    public class Kata
    {
        public static string ToCamelCase (string str)
        {
            string[] wordsArray = str.Split(new char[] { '-', '_' });
            for (int i = 1; i < wordsArray.Length; i++)
                wordsArray[i] = Char.ToUpper(wordsArray[i][0]) + wordsArray[i].Substring(1);
            return string.Join("", wordsArray);
        }
    }
}
