using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while((input = Console.ReadLine()) != "end")
            {
                string[] com = input.Split(" : ");
                string course = com[0];
                string name = com[1];

                if (courses.ContainsKey(com[0]))
                {
                    courses[com[0]].Add(com[1]);
                }
                else
                {
                    courses.Add(com[0], new List<string>() {com[1]});
                }
            }

            var filter = courses.OrderByDescending(x => x.Value.Count)
                                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var item in filter)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                List<string> students = item.Value;
                students.Sort();
                foreach (var name in students)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
