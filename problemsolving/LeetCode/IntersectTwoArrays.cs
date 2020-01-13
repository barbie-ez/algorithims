using System;
using System.Collections.Generic;
using System.Linq;

namespace problemsolving.LeetCode
{
    public class IntersectTwoArrays
    {
        public IntersectTwoArrays()
        {
        }
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 || nums2.Length == 0)
            {
                return null;
            }

            Array.Sort(nums1);
            Array.Sort(nums2);

            int i = 0;
            int j = 0;

            List<int> dup = new List<int>();

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    i++;
                }
                if (nums1[i] > nums2[j])
                {
                    j++;
                }
                if(nums1[i] == nums2[j])
                {
                    dup.Add(nums1[i]);
                    i++;
                    j++;
                }
            }

            return dup.ToArray();
        }
    }
}
