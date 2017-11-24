using System;
using System.Collections.Generic;
using System.Linq;

namespace WhereMyAnagramsAt
{
    public class Kata
    {
        public static List<string> Anagrams(string word, List<string> words) => words.Where(part => String.Concat(part.OrderBy(b => b)) == String.Concat(word.OrderBy(c => c))).ToList();
    }
}
