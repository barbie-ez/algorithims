using System;
using System.Collections.Generic;
using System.Linq;

namespace problemsolving.LeetCode
{
    public class MissingNum
    {
        public MissingNum()
        {
        }
        public static int MissingNumber(int[] nums)
        {
            if (nums.Length == 0)
            {
                return -1;
            }
            if (nums.Length == 1)
            {
                return 1;
            }

            Array.Sort(nums);

            int max = nums.Max();

            for(int i = 0; i <= max; i++)
            {
                if (nums[i] != i)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
