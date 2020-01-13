using System;
namespace problemsolving
{
    public class AVeryBigSum
    {
        public AVeryBigSum()
        {
        }

        static long aVeryBigSum(long[] ar)
        {
            long res = 0;
            foreach(var item in ar)
            {
                res += item;
            }
            return res;
        }
    }
}
