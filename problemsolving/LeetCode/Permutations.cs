using System;
using System.Collections.Generic;
using System.Text;

namespace problemsolving.LeetCode
{
    class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if(nums==null || nums.Length == 0)
            {
                return result;
            }

            IList<int> currentSol = new List<int>();

            bool[] check = new bool[nums.Length];

            dfs(result, currentSol, nums, 0, check);

            return result;
        }

        public static void dfs(IList<IList<int>> result, IList<int> currentSol, int[] array, int index, bool[] check)
        {
            if (array.Length == index)
            {
                result.Add(currentSol);
                return;
            }

            for(int i = index; i < array.Length; i++)
            {
                
            }
        }
    }
}
