 using System;
using System.Collections.Generic;
using System.Text;

namespace problemsolving.LeetCode
{
    class LeadLife
    {
        public static int MaxProfit(int e, List<int>earning, List<int>cost, int n)
        {
            if (n == 0 || e == 0)
                return 0;

            List<int> val = new List<int>();
            List<List<int>> valfood = new List<List<int>>();

            for(int i = 0; i < n; i++)
            {
                valfood.Add(AfterWork(i, e, e, earning[i], cost[i], n));
            }

            return valfood.Count;
            
        }
        public static List<List<int>> eps = new List<List<int>>();
        
        public static List<int> AfterWork(int dayIndex, int energy, int maxEnergy, int earning, int cost, int numOfDays)
        {
            List<int> ep = new List<int>();
            if (dayIndex == 0)
            {
                for (int i = energy; i >= 0; i--)
                {

                    ep.Add(earning * (maxEnergy - energy));
                    energy = energy - 1;
                }
                
            }

            else
            {
                for (int i = 0; i< eps[eps.Count - 1].Count; i++)
                {
                    ep.Add(getWork(earning, eps[eps.Count - 1], i));
                }
            }

            if (dayIndex == numOfDays - 1)
            {
                return ep;
            }

            List<int> finalep = new List<int>();

            if (dayIndex == 0)
            {
                for (int i = 0; i < ep.Count; i++)
                {
                    finalep.Add(getMin(cost, ep, i));
                }
            }
            else
            {
                for (int i = 0; i < ep.Count; i++)
                {
                    finalep.Add(getFood(cost, ep, i));
                }
            }

            eps.Add(finalep);

            return finalep;
        }

        public static int getMin(int cost, List<int> ep, int startIndex)
        {
            int min = int.MaxValue;
            int count = 0;
            int si = startIndex;

            while (count < ep.Count - startIndex)
            {
                var a = ep[si] - (count * cost);
                si++;
                count++;
                if (a < min)
                {
                    min = a;
                }
            }
            return min < 0 ? 0:min ;
        }

        public static int getFood(int cost, List<int> ep, int startIndex)
        {
            int max = int.MinValue;
            int count = 0;
            int si = startIndex;

            while (count < ep.Count - startIndex)
            {
                var a = ep[si] - (count * cost);
                si++;
                count++;
                if (a > max)
                {
                    max = a;
                }
            }
            return max;
        }

        public static int getWork(int earning, List<int> ep, int startIndex)
        {
            int max = int.MinValue;
            int count = 0;
            int si = startIndex;
            int index = 0;
            while (si>=count)
            {
                var a = ep[index] + (si * earning);
                si--;
                index++;
                if (a > max)
                {
                    max = a;
                }
            }
            return max;
        }
 

    }                                       
}
