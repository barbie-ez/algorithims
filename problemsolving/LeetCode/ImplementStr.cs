using System;
namespace problemsolving.LeetCode
{
    public class ImplementStr
    {
        public ImplementStr()
        {
        }

        public static int StrStr(string haystack, string needle)
        {
            if (!haystack.Contains(needle))
            {
                return -1;
            }


            int index = 0;
            int indexAt = 0;
            
            for(int i = 0; i < haystack.Length; i++)
            {
                while (index < needle.Length)
                {
                    
                    if (haystack[i] == needle[index])
                    {
                        indexAt = i;
                        index++;
                        i++;
                        continue;
                    }
                    break;
                }
            }

            return indexAt;
        }
    }
}
