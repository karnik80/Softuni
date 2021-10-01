using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> sorted = new SortedDictionary<double, int>();

            foreach (var item in numbers)
            {
                if (sorted.ContainsKey(item))
                {
                    sorted[item]++;
                }
                else
                {
                    sorted.Add(item, 1);
                }
            }

            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
