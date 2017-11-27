using System;
using System.Linq;

namespace BitCalculator
{
    public static class Kata
    {
        public static int Calculate (string num1, string num2)
        {
            return CustomConverter(num1) + CustomConverter(num2);
        }

        public static int CustomConverter (string num)
        {
            return num.Reverse()
                .Select((s, i) => new { i, s })
                .Where(t => t.s == '1')
                .Select(t => t.i)
                .Select(t => (int)Math.Pow(2, t))
                .Sum();
        }

        public static string Reverse (this string word)
        {
            char[] charWord = word.ToCharArray();
            Array.Reverse(charWord);
            return new string(charWord);
        }
    }
}
