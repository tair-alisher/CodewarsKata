using System;
using System.Collections.Generic;

namespace SplitStrings
{
    public class SplitString
    {
        public static string[] Solution (string str)
        {
            List<string> resultList = new List<string>();
            string tempString = "";

            for (int i = 0; i < str.Length; i+=2)
            {
                tempString = "";
                if (i != str.Length-1)
                {
                    tempString += str[i];
                    tempString += str[i + 1];
                } else
                {
                    tempString += str[i];
                    tempString += '_';
                }
                resultList.Add(tempString);
            }
            return resultList.ToArray();
        }
    }
}
