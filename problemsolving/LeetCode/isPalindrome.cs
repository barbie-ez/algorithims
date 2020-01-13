using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace problemsolving.LeetCode
{
    public class isPalindrome
    {
        public isPalindrome()
        {
        }
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0)
            {
                return true;
            }

            Regex rgx = new Regex("[^a-zA-Z0-9]");
            s = rgx.Replace(s, "").ToLower();

            int leftPointer = 0;

            int rightPointer = s.Length-1;

            while (leftPointer < rightPointer)
            {
                var left = s[leftPointer];
                var right = s[rightPointer];

                if (s[leftPointer] != s[rightPointer])
                {
                    return false;
                }

                leftPointer++;
                rightPointer--;
            }

            return true;
        }
    }
}
