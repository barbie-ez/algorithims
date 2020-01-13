using System;
namespace problemsolving
{
    public class SimpleArraySum
    {
        public SimpleArraySum()
        {
        }

        static int simpleArraySum(int[] ar)
        {
            int sum = 0;

            foreach(var item in ar)
            {
                sum += item;
            }

            return sum;

        }
    }
}
