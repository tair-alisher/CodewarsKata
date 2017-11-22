using System;

namespace TheHighestProfitWins
{
    public class Kata
    {
        public static int[] MinMax (int[] lst)
        {
            if (lst.Length == 1)
                return new int[] { lst[0], lst[0] };

            Array.Sort(lst);
            return new int[] { lst[0], lst[lst.Length - 1] };
        }
    }
}
