using System;
using System.Collections.Generic;
using System.Text;

namespace problemsolving.LeetCode
{
    class RemoveAllDuplicates
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int current = 0;
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    current = nums[i];
                    index = i;
                }

                if (current != nums[i])
                {
                    current = nums[i];
                    nums[index + 1] = current;
                    index = index + 1;
                }
            }

            return index+1;
        }
    }
}
