using System.Linq;
using System.Collections.Generic;

namespace MovingZerosToTheEnd
{
    public class Kata
    {
        public static int[] MoveZeroes (int[] arr)
        {
            List<int> compArr = arr.Where(val => val != 0).ToList();
            while (compArr.Count < arr.Length)
                compArr.Add(0);
            return compArr.ToArray();
        }
    }
}
