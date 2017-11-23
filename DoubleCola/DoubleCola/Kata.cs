using System;
namespace DoubleCola
{
    public class Kata
    {
        public static string WhoIsNext (string[] names, long n)
        {
            long i = n - 1;
            while (i >= names.Length)
                i = (i - names.Length) / 2;
            return names[i];
        }
    }
}
