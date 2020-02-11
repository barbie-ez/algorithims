using System;
using System.Collections.Generic;
using problemsolving.LeetCode;

namespace problemsolving
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> markings = new List<List<int>>();

            markings.Add(new List<int> { 3, 5, 7 });
            markings.Add(new List<int> { 6, 8, 9 });
            markings.Add(new List<int> { 3, 5, 6 });

            //Console.WriteLine(Flask.chooseFlask(new List<int> { 4,6,6,7},3,markings));
            Console.WriteLine(LeadLife.MaxProfit(5,new List<int> { 1,2,4}, new List<int> { 1,3,6} ,3));
            Console.ReadLine();
        }
    }
}
