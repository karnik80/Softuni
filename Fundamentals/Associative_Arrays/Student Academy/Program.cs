using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students.Add(name, new List<double>() { grade });
                }
            }

            Dictionary<string, double> average = new Dictionary<string, double>();

            foreach (var item in students)
            {
                double avg = item.Value.Average();
                average.Add(item.Key, avg);
            }

            average = average.Where(x => x.Value >= 4.50).OrderByDescending(x => x.Value)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var pair in average)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");
            }
        }
    }
}
