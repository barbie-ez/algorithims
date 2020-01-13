using System;
using System.Collections.Generic;

namespace problemsolving
{
    public class CompareTriplets
    {
        public CompareTriplets()
        {
        }
        static List<int> compareTriplets(List<int> a, List<int> b)
        {


            int resA = 0;
            int resB = 0;

            for (int i = 0; i <= a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    resA += 1;
                }

                if (a[i] < b[i])
                {
                    resB += 1;
                }
            }

            return new List<int>() { resA , resB };
        }
    }
}
