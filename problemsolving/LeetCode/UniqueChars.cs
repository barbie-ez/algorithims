using System;
using System.Collections.Generic;
using System.Linq;

namespace problemsolving.LeetCode
{
    public class UniqueChars
    {
        public UniqueChars()
        {
        }

        public static int FirstUniqChar(string s)
        {
            if (s.Length < 1)
            {
                return -1;
            }

            Dictionary<char,int> uniq = new Dictionary<char, int>();
            HashSet<char> duplicates = new HashSet<char>();

            int count = 0;

            foreach(var item in s)
            {
                if (duplicates.Contains(item))
                {
                    count++;
                    continue;
                }
                if (uniq.ContainsKey(item))
                {
                    uniq.Remove(item);
                    duplicates.Add(item);
                }
                else
                {
                    uniq.Add(item,count);
                }

                count++;
            }

            if (uniq.Count == 0)
            {
                return -1;
            }

            return uniq.OrderBy(r=>r.Value).First().Value;
        }
    }
}
