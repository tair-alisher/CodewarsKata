using System;
using System.Linq;

namespace DoesMyNumberLookBigInThis
{
    public class Kata
    {
        public static bool Narcissistic(int value) => value == value.ToString().Select(x => Convert.ToInt64(Math.Pow(Char.GetNumericValue(x), value.ToString().Length))).Sum();
    }
}
