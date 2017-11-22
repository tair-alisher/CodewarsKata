using System.Collections.Generic;

namespace AreWeAlternate
{
    public class Kata
    {
        private static readonly Dictionary<char, int> rank = new Dictionary<char, int>() {
            {'a', 0}, {'e', 0}, {'i', 0}, {'o', 0}, {'u', 0}, {'b', 1}, {'c', 1}, {'d', 1},
            {'f', 1}, {'g', 1}, {'h', 1}, {'j', 1}, {'k', 1}, {'l', 1}, {'m', 1}, {'n', 1},
            {'p', 1}, {'q', 1}, {'r', 1}, {'s', 1}, {'t', 1}, {'v', 1}, {'w', 1}, {'x', 1},
            {'y', 1}, {'z', 1}
        };

        public static bool IsAlt (string word)
        {
            for (int i = 1; i < word.Length; i++)
                if (rank[word[i]] == rank[word[i - 1]])
                    return false;

            return true;
        }
    }
}
