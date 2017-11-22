using System;

namespace EasyTimeConvert
{
    public class Kata
    {
        public static string TimeConvert (int num)
        {
            if (num < 1) return "00:00";

            int hours = num / 60;
            int minutes = num % 60;

            string strHours = hours.ToString();
            string strMinutes = minutes.ToString();

            if (strHours.Length < 2)
                strHours = '0' + strHours;

            if (strMinutes.Length < 2)
                strMinutes = '0' + strMinutes;

            return (strHours + ':' + strMinutes);
        }
    }
}
