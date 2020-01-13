using System;
namespace problemsolving
{
    public class MinMaxSum
    {
        public MinMaxSum()
        {
        }
        public static void miniMaxSum(int[] arr)
        {
            long max = 0;
            long min = long.MaxValue;
            long sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        sum += arr[j];
                    }

                    
                }

                if (sum < min)
                {
                    min = sum;
                }
                if (sum > max)
                {
                    max = sum;
                }

                sum = 0;
            }

            Console.WriteLine(min + "  "+max);

        }
    }
}
