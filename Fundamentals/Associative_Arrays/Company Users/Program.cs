using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employees = new Dictionary<string, List<string>>();

            string input = string.Empty;
            while((input = Console.ReadLine()) != "End")
            {
                string[] com = input.Split(" -> ");
                string company = com[0];
                string id = com[1];

                if (employees.ContainsKey(company))
                {
                    if(!employees[company].Exists(x => x == id))
                    {
                        employees[company].Add(id);
                    }
                }
                else
                {
                    employees.Add(company, new List<string>() { id });
                }
            }

            employees = employees.OrderBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var item in employees)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var elem in item.Value)
                {
                    Console.WriteLine($"-- {elem}");
                }
            }
        }
    }
}
