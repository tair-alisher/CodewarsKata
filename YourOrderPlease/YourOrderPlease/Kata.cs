using System;
using System.Collections.Generic;
using System.Linq;

namespace YourOrderPlease
{
    public class Kata
    {
        public static string Order (string words)
        {
            if (words.Length == 0) return "";

            double numericValue;
            Dictionary<double, string> resultDct = new Dictionary<double, string>();
            string[] wordsArr = words.Split(' ');

            foreach (string word in wordsArr)
            {
                foreach (char letter in word)
                {
                    numericValue = Char.GetNumericValue(letter);
                    if (numericValue != (-1))
                        resultDct.Add(numericValue, word);
                }
            }

            return string.Join(" ", resultDct.OrderBy(item => item.Key).Select(item => item.Value));
        }
        
    }
}
