using System;

namespace SimplePigLatin
{
    public class Kata
    {
        public static string PigIt (string str)
        {
            string[] strArr = str.Split(' ');
            for (int i = 0; i < strArr.Length; i++)
                if (strArr[i].Length > 1)
                    strArr[i] = strArr[i].Substring(1) + strArr[i][0] + "ay";
            return string.Join(" ", strArr);
        }
    }
}
