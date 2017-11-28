using System;
using System.Numerics;

namespace AddingBigNumbers
{
    public class Kata
    {
        public static string Add (string a, string b)
        {
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }
    }
}
