using System;
using System.Collections.Generic;
using System.Linq;

namespace problemsolving.LeetCode
{
    public class PascalsTri
    {
        public PascalsTri()
        {
        }
        public static IList<IList<int>> Generate(int numRows)
        {
            List<List<int>> final = new List<List<int>>();

            for (int i = 1; i < numRows; i++)
            {
                List<int> n = new List<int>();
                List<int> lastLev = final.LastOrDefault();

                if (i == 1)
                {
                    n.Add(1);
                    final.Add(n);
                    continue;
                }

                n.Add(1);

                for (int j = 1; j <i; j++)
                {
                    n.Add(lastLev[j] + lastLev[j-1]);
                }

                n.Add(1);

                final.Add(n);
            }

            return (IList<IList<int>>) final;
        }
    }
}
