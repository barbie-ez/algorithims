using System;
namespace problemsolving
{
    public class PlusMinus
    {
        public PlusMinus()
        {
        }
        public static void plusMinus(int[] arr)
        {
            int posCount = 0;
            int negCount = 0;
            int zerCount = 0;

            foreach(var item in arr)
            {
                if (item > 0)
                {
                    posCount += 1;
                }
                if (item< 0)
                {
                    negCount += 1;
                }
                if (item == 0)
                {
                    zerCount += 1;
                }
            }

            double pos = posCount / (double)arr.Length;
            double neg = negCount / (double)arr.Length;
            double zer = zerCount / (double)arr.Length;

            Console.WriteLine(Math.Round(pos,6));
            Console.WriteLine(Math.Round(neg,6));
            Console.WriteLine(Math.Round(zer,6));
        }
    }
}
