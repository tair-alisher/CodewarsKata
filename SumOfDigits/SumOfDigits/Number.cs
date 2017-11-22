using System;

namespace SumOfDigits
{
    public class Number
    {
        public int DigitalRoot (long n)
        {
            int sum;
            string strNum = n.ToString();
            while (strNum.Length > 1)
            {
                sum = 0;
                foreach (char num in strNum)
                    sum += Convert.ToInt32(num.ToString());
                strNum = sum.ToString();
            }
            return Convert.ToInt32(strNum);
        }
    }
}
