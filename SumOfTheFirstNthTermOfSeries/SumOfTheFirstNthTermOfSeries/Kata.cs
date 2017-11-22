using System;

namespace SumOfTheFirstNthTermOfSeries
{
    public class Kata
    {
        public static string SeriesSum (int n)
        {
            double sum = 1, divider = 4;

            if (n < 1)
                return "0.00";
            else if (n < 2)
                return "1.00";
            else {
                for (int i = 0; i < n - 1; i++)
                {
                    sum += 1 / divider;
                    divider += 3;
                }
            }
            return Math.Round(sum, 2).ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
