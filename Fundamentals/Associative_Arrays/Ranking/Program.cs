using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            //<contest, pass>
            Dictionary<string, string> courses = new Dictionary<string, string>();

            string input = string.Empty;

            while((input = Console.ReadLine()) != "end of contests")
            {
                string[] token = input.Split(":");
                string contest = token[0];
                string pass = token[1];

                if (!courses.ContainsKey(contest))
                {
                    courses.Add(contest, pass);
                }
            }
            //<user, Dictionary<contest, points>>
            Dictionary<string, Dictionary<string, int>> users = 
                new Dictionary<string, Dictionary<string, int>>();

            while((input = Console.ReadLine()) != "end of submissions")
            {
                string[] com = input.Split("=>");
                string contest = com[0];
                string pass = com[1];
                string user = com[2];
                int points = int.Parse(com[3]);

                if(courses.ContainsKey(contest) && courses[contest] == pass)
                {
                    if (users.ContainsKey(user))
                    {
                        if (users[user].ContainsKey(contest))
                        {
                            if(points > users[user][contest])
                            {
                                users[user][contest] = points;
                            }
                        }
                        else
                        {
                            users[user].Add(contest, points);
                        }
                    }
                    else
                    {
                        users.Add(user, new Dictionary<string, int>());
                        users[user].Add(contest, points);
                    }
                }
            }//end while end submission
            //Console.WriteLine();
            Dictionary<string, int> pointsUsers = new Dictionary<string, int>();//<user, points>
            foreach (var pair in users)
            {
                pointsUsers.Add(pair.Key, pair.Value.Sum(x => x.Value));
                
            }
            pointsUsers = pointsUsers.OrderByDescending(x => x.Value)
                .ToDictionary(a => a.Key, b => b.Value);
            var temp = pointsUsers.First();
            Console.WriteLine($"Best candidate is {temp.Key} with total {temp.Value} points.");

            Console.WriteLine("Ranking: ");
            users = users.OrderBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            foreach (var pair in users)
            {
                Console.WriteLine($"{pair.Key}");
                var descPoints = pair.Value;
                descPoints = descPoints.OrderByDescending(x => x.Value).ToDictionary(a => a.Key, b => b.Value);
                foreach (var item in descPoints)
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }

    }
}
