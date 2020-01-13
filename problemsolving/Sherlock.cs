using System;
using System.Collections.Generic;
using System.Linq;

namespace problemsolving
{
    public class Sherlock
    {
        public Sherlock()
        {
        }
        public static string isValid(string s)
        {
            Dictionary<char, int> pairs = new Dictionary<char, int>();

            foreach(var item in s)
            {
                if (pairs.ContainsKey(item))
                {
                    pairs[item] += 1;
                    
                }
                else
                {
                    pairs.Add(item, 1);
                }
            }

            
            var min = pairs.Values.Min();

            var ones = pairs.Values.Count(r=>r.Equals(1));

            var distinct = pairs.Values.Distinct().Count();

            int countRemoval = 0;

            if (distinct <= 2 && ones==1)
            {
                return "YES";
            }

            foreach(var item in pairs.Values)
            {

                if (item != min)
                {
                    var check = item - 1;

                    if(check == min){
                        countRemoval++;
                    }

                    else
                    {
                        return "NO";
                    }
                    
                }

                if (countRemoval > 1)
                {
                    return "NO";
                }
            }

            return "YES";
        }
    }
}
