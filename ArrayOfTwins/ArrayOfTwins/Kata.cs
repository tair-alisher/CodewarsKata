using System;
using System.Collections.Generic;

namespace ArrayOfTwins
{
    public class Kata
    {
        public static bool Twins (int[] arr)
        {
            Dictionary<int, int> ocNum = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (ocNum.ContainsKey(arr[i]))
                    ocNum[arr[i]] += 1;
                else
                    ocNum.Add(arr[i], 1);
            }

            foreach (KeyValuePair<int, int> entry in ocNum)
                if (entry.Value != 2)
                    return false;

            return true;
        }
    }
}
