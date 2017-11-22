using System;
using System.Linq;

namespace DuplicateEncoder
{
    public class Kata
    {
        public static string DuplicateEncode (string word)
        {
            word = word.ToLower();
            string resultString = "";

            foreach (char character in word)
            {
                if (word.Count(x => x == character) > 1)
                    resultString += ')';
                else
                    resultString += '(';
            }

            return resultString;
        }
    }
}
