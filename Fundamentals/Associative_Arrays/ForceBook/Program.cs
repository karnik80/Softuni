using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> register = new Dictionary<string, string>();
            // user, side

            string input = string.Empty;

            while((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Contains(" | "))
                {
                    //Console.WriteLine("pipe");
                    string[] com = input.Split(" | ");
                    string side = com[0];
                    string user = com[1];

                    if (!register.ContainsKey(user))
                    {
                        register.Add(user, side);
                    }

                }
                else if (input.Contains(" -> "))
                {
                    //Console.WriteLine("arrow");
                    string[] com = input.Split(" -> ");
                    string side = com[1];
                    string user = com[0];

                    if (register.ContainsKey(user))
                    {
                        register[user] = side;
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        register.Add(user, side);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
            }//end while

            Dictionary<string, List<string>> converted = new Dictionary<string, List<string>>();

            foreach (var pair in register)
            {
                if(converted.ContainsKey(pair.Value))
                {
                    converted[pair.Value].Add(pair.Key);
                }
                else
                {
                    converted.Add(pair.Value, new List<string>() { pair.Key });
                }
            }

            var filter = converted.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var pair in filter)
            {
                Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.Count}");
                List<string> users = pair.Value;
                users.Sort();
                foreach (var item in users)
                {
                    Console.WriteLine($"! {item}");
                }
            }

        }
    }
}
