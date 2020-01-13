using System;
namespace problemsolving
{
    public class TimeConversion
    {
        public TimeConversion()
        {
        }
        public static string timeConversion(string s)
        {
            if (s.Substring(s.Length - 2) == "AM")
            {
                if(s.Substring(0, 2) == "12")
                {
                    return "00"+s.Substring(2, s.Length - 4);
                }
                return s.Substring(0, s.Length - 2);
            }

            var hour = s.Substring(0, 2);

            var intHour = Convert.ToInt32(hour);

            if(intHour!=12)
                intHour += 12;

            return intHour + s.Substring(2, s.Length - 4);

     
        }
    }
}
