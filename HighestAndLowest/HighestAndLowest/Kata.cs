using System;
using System.Linq;

namespace HighestAndLowest
{
    public class Kata
    {
        public static string HighAndLow (string numbers)
        {
            int[] nums = numbers.Split(' ').Select(x => int.Parse(x)).ToArray();
            return String.Format("{0} {1}", nums.Max(), nums.Min());
        }
    }
}
