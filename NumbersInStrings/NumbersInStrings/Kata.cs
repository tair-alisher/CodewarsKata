using System;
using System.Linq;

namespace NumbersInStrings
{
    public class Kata
    {
        public static int Solve (string s)
        {
            string result = "";
            
            foreach (char letter in s)
            {
                if (Char.IsDigit(letter))
                {
                    result += letter;
                } else
                {
                    if (result.Length > 0 && result[result.Length-1] != ' ')
                    {
                        result += ' ';
                    }
                }
            }
            return result.Trim().Split(' ').Select(int.Parse).Max();
        }
    }
}
