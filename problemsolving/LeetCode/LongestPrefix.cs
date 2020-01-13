using System;
using System.Linq;

namespace problemsolving.LeetCode
{
    public class LongestPrefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length <= 0)
            {
                return string.Empty;
            }
            var min = strs.Min(r => r.Length);

            int index = 0;

            string prefix = string.Empty;

            bool isPre = true;

            while (index < min)
            {
                char initPre = ' ';

                foreach(var letter in strs)
                {
                    if (initPre ==' ')
                    {
                        initPre = letter[index];
                        continue;
                    }

                    if(initPre != letter[index])
                    {
                        initPre = ' ';
                        isPre =false;
                        break;
                    }
                }
                if (!isPre)
                {
                    break;
                }
                if(initPre!=' ')
                {
                    prefix+=initPre;
                }
                

                index++;
            }

            return prefix;

        }
    }
}
