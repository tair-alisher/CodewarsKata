using System;
using System.Linq;

namespace FnidTheMiddleElement
{
    public class Kata
    {
        public static int Gimme (double[] inputArray)
        {
            double middle = inputArray.Where(x => x != inputArray.Max())
                .Where(x => x != inputArray.Min())
                .First();

            return Convert.ToInt32(Array.IndexOf(inputArray, middle));
        }
    }
}
