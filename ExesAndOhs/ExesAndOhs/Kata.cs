using System;

namespace ExesAndOhs
{
    public class Kata
    {
        public static bool XO (string input)
        {
            int oCount = 0, xCount = 0;

            foreach (char character in input.ToLower())
            {
                if (character == 'x')
                    xCount++;
                if (character == 'o')
                    oCount++;
            }

            if (oCount == xCount)
                return true;

            return false;
        }
    }
}
