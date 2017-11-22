using System;

namespace ShortestWord
{
    public class Kata
    {
        public static int FindShort (string s)
        {
            string[] words = s.Split(' ');
            int shortest = words[0].Length;

            foreach (string word in words)
                if (word.Length < shortest) shortest = word.Length;

            return shortest;
        }
    }
}
