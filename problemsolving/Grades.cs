using System;
using System.Collections.Generic;

namespace problemsolving
{
    public class Grades
    {
        public Grades()
        {
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> finalResult = new List<int>();

            foreach(var grade in grades)
            {
                int finalGrade = grade;

                if (grade < 38)
                {
                    finalResult.Add(finalGrade);
                    continue;
                }

                if (grade % 5 >= 3)
                {
                    finalGrade += 5 - (grade % 5);
                }

                finalResult.Add(finalGrade);
            }

            return finalResult;
        }
    }
}
