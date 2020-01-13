using System;
namespace problemsolving.LeetCode
{
    public class BuyAndSell
    {
        public BuyAndSell()
        {
        }

        
        public static int MaxProfit(int[] prices)
        {

            int max = 0;

            for(int i = 0; i < prices.Length; i++)
            {
                for (int j = i; j < prices.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (prices[i] < prices[j])
                    {
                        if(max< prices[j]- prices[i])
                        {
                            max = prices[j] - prices[i];
                        }
                    }
                }
            }

            return max;
        }
    }
}
