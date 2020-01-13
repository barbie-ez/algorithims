using System;
using System.Collections.Generic;

namespace problemsolving
{
    public class Sets
    {
        public Sets()
        {
        }
        public static int getTotalX(List<int> a, List<int> b)
        {
            List<int> num = new List<int>();

            for(int i = a[a.Count - 1]; i <= b[0]; i++)
            {
                bool valid = true;
                foreach(var item in a)
                {
                    if (i % item != 0)
                    {
                        valid =false;
                    }
                }

                if (valid)
                {
                    num.Add(i);
                }

            }

            List<int> finalNum = new List<int>();

            foreach (var item in num)
            {
                bool valid = true;

                foreach (var val in b)
                {
                    if (val % item != 0)
                    {
                        valid = false;
                    }
                }
                if (valid)
                {
                    finalNum.Add(item);
                }
            }

            return finalNum.Count;
        }
    }
}
