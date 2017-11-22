using System;
using System.Collections.Generic;

namespace ReversedSequence
{
    public class Kata
    {
        public static int[] ReverseSeq (int n)
        {
            List<int> result = new List<int>();
            while (n > 0)
            {
                result.Add(n);
                n--;
            }
            return result.ToArray();
        }
    }
}
