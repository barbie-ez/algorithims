using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problemsolving.LeetCode
{
    class Flask
    {

        public static int chooseFlask(List<int> requirements, int flaskTypes, List<List<int>> markings)
        {

            for(int i = 0; i < flaskTypes; i++)
            {
                Dictionary<int, int> marked = new Dictionary<int, int>();
                for (int j = 0; j < markings[0].Count; j++)
                {
                    if (requirements.Max() > markings[i].Max())
                    {
                        continue;
                    }
                    for(int k = 0; k < requirements.Count; k++)
                    {
                        int loss = 0;

                        if (markings[i][j] >= requirements[k] && (!marked.ContainsKey(requirements[k])))
                        {
                            loss += markings[i][j] - requirements[k];
                            Console.WriteLine($"Loss for requirement {requirements[k]} and marking {markings[i][j]} is {loss} " );
                            marked.Add(requirements[k], markings[i][j]);
                            continue;
                        }
                        if (marked.ContainsKey(requirements[k]))
                        {
                            if (marked[requirements[k]] == markings[i][j])
                            {
                                loss += markings[i][j] - requirements[k];
                                Console.WriteLine($"Loss for requirement {requirements[k]} and marking {markings[i][j]} is {loss} ");
                            }
                        }
                    }

                }
            }

            return 0;
        }

    }
}
