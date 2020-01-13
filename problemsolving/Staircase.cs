using System;
namespace problemsolving
{
    public class Staircase
    {
        public Staircase()
        {
        }
        public static void staircase(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = n; j >= 0; j--)
                {
                    
                    if (j <= i)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
