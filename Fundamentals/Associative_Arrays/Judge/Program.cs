using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            //<contest, <user, points>>
            Dictionary<string, Dictionary<string, int>> judge = 
                new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while((input = Console.ReadLine()) != "no more time")
            {
                string[] com = input.Split(" -> ");
                string user = com[0];
                string contest = com[1];
                int points = int.Parse(com[2]);

                if (judge.ContainsKey(contest))
                {
                    if (judge[contest].ContainsKey(user))
                    {
                        if(points > judge[contest][user])
                        {
                            judge[contest][user] = points;
                        }
                    }
                    else
                    {
                        judge[contest].Add(user, points);
                    }
                }
                else
                {
                    judge.Add(contest, new Dictionary<string, int>());
                    judge[contest].Add(user, points);
                }
            }//end of while

            List<string> dif = new List<string>();

            foreach (var pair in judge)
            {
                if (!dif.Exists(x => x == pair.Key))
                {
                    dif.Add(pair.Key);
                    dif.Last();

                    var count = pair.Value.Count;
                    Console.WriteLine($"{pair.Key}: {count} participants");

                    var userPoint = pair.Value;
                    
                    userPoint = userPoint.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                                         .ToDictionary(a => a.Key, b => b.Value);
                    int countUser = 1;
                    foreach (var item in userPoint)
                    {
                        Console.WriteLine($"{countUser}. {item.Key} <::> {item.Value}");
                        countUser++;
                    }
                }
            }
            Console.WriteLine("Individual standings:");
            //<user, points>
            Dictionary<string, int> individual = new Dictionary<string, int>();

            foreach (var element in judge)
            {
                foreach (var pair in element.Value)
                {
                    if (individual.ContainsKey(pair.Key))
                    {
                        individual[pair.Key] += pair.Value;
                    }
                    else
                    {
                        individual.Add(pair.Key, pair.Value);
                    }
                }
            }
            individual = individual.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

            int countInd = 1;
            foreach (var item in individual)
            {
                Console.WriteLine($"{countInd}. {item.Key} -> {item.Value}");
                countInd++;
            }
        }
    }
}
