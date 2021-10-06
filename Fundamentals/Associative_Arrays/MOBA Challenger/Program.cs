using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            //<player, <position, skill>>
            Dictionary<string, Dictionary<string, int>> players =
                new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while((input = Console.ReadLine()) != "Season end")
            {
                if(input.Contains(" -> ")) // Add players
                {
                    string[] com = input.Split(" -> ");
                    string player = com[0];
                    string position = com[1];
                    int skill = int.Parse(com[2]);

                    if (!players.ContainsKey(player))
                    {
                        players.Add(player, new Dictionary<string, int>());
                    }
                    if (!players[player].ContainsKey(position))
                    {
                        players[player].Add(position, 0);
                    }
                    if(players[player][position] <= skill)
                    {
                        players[player][position] = skill;
                    }
                }
                else if(input.Contains(" vs "))// Fight
                {
                    string[] com = input.Split(" vs ");
                    string player1 = com[0];
                    string player2 = com[1];

                    if(players.ContainsKey(player1) == false || players.ContainsKey(player2) == false)
                    {
                        continue;
                    }
                    bool commonPosition = false;
                    foreach (var item in players[player1])
                    {
                        if (players[player2].ContainsKey(item.Key))
                        {
                            commonPosition = true;
                        }
                    }
                    int totalSkills1 = 0;
                    int totalSkills2 = 0;
                    if (commonPosition)
                    {
                        totalSkills1 = players[player1].Values.Sum();
                        totalSkills2 = players[player2].Values.Sum();
                        if(totalSkills1 > totalSkills2)
                        {
                            players.Remove(player2);
                        }
                        else if(totalSkills2 > totalSkills1)
                        {
                            players.Remove(player1);
                        }
                    }
                }
            }

            foreach (var item in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()} skill");
                foreach (var pair in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {pair.Key} <::> {pair.Value}");
                }
            }

            ////<name, total skill>
            //Dictionary<string, int> nameSkill = new Dictionary<string, int>();
            //foreach (var pair in players)
            //{
            //    int total = pair.Value.Sum(x => x.Value);
            //    nameSkill.Add(pair.Key, total);
            //}

            //nameSkill = nameSkill.OrderByDescending(x => x.Value)
            //    .ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

            ////Print statistics
            //foreach (var pair in nameSkill)
            //{
            //    Console.WriteLine($"{pair.Key}: {pair.Value} skill");
            //    foreach (var item in players[pair.Key].OrderByDescending(x => x.Value))
            //    {
            //        Console.WriteLine($"- {item.Key} <::> {item.Value}");
            //    }
            //}
        }
    }
}
