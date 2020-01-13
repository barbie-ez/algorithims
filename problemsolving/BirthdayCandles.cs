using System;
using System.Linq;

namespace problemsolving
{
    public class BirthdayCandles
    {
        public BirthdayCandles()
        {
        }
        public static int birthdayCakeCandles(int[] ar)
        {
            var max = ar.Max();
            int count = 0;

            foreach(var item in ar)
            {
                if (item == max)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
