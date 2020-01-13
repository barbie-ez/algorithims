using System;
namespace problemsolving
{
    public class RecordBreaker
    {
        public RecordBreaker()
        {
        }
        public static int[] breakingRecords(int[] scores)
        {
            int maxCount = 0;
            int minCount = 0;

            int max = scores[0];
            int min = scores[0];

            foreach(var item in scores)
            {
                if (item < min)
                {
                    minCount++;
                    min = item;
                }

                if (item > max)
                {
                    maxCount++;
                    max = item;
                }
            }

            return new int[] { maxCount, minCount };

        }
    }
}
