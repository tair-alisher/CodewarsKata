using System;
using System.Collections.Generic;
using System.Linq;

namespace StopSpinningMyWords
{
    public class Kata
    {
        public static string SpinWords (string sentence)
        {
            char[] tempArray = new char[] { };
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 5)
                {
                    tempArray = words[i].ToCharArray();
                    Array.Reverse(tempArray);
                    words[i] = new string(tempArray);
                }
            }

            return string.Join(" ", words);
        }
    }
}
