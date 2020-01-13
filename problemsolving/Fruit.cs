using System;
namespace problemsolving
{
    public class Fruit
    {
        public Fruit()
        {
        }
        public static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int countApples = 0;
            int countOranges = 0;

            foreach(int item in apples)
            {
                int distance = a + item;

                if(distance>=s&& distance <= t)
                {
                    countApples++;
                }
            }

            foreach (int item in oranges)
            {
                int distance = b + item;

                if (distance >= s && distance <= t)
                {
                    countOranges++;
                }
            }

            Console.WriteLine(countApples);
            Console.WriteLine(countOranges);
        }
    }
}
