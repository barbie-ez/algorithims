using System;
namespace problemsolving
{
    public class Jumps
    {
        public Jumps()
        {
        }
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v2 > v1 && x2 > x1)
            {
                return "NO";
            }

            while (x1 <= 1000000000 && x2 <= 1000000000)
            {
                x1 += v1;
                x2 += v2;

                if (x1 == x2)
                {
                    return "YES";
                }
            }

            return "NO";
        }
    }
}
