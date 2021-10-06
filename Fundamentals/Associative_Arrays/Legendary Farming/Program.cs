using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            materials.Add("motes", 0);
            Dictionary<string, int> junk = new Dictionary<string, int>();

            string input = string.Empty;

            while (true)
            {
                string[] token = Console.ReadLine().Split().ToArray();

                for (int i = 0; i < token.Length; i = i + 2)
                {
                    int quantity = int.Parse(token[i]);
                    string material = token[i + 1].ToLower();

                    if (materials.ContainsKey(material))
                    {
                        materials[material] += quantity;
                    }
                    else
                    {
                        if (junk.ContainsKey(material))
                        {
                            junk[material] += quantity;
                        }
                        else
                        {
                            junk.Add(material, quantity);
                        }
                    }
                }

                if(materials.Any(x => x.Value >= 250))
                {
                    var element = materials.FirstOrDefault(x => x.Value >= 250);

                    materials[element.Key] -= 250;

                    if (element.Key == "shards")
                    {
                        Console.WriteLine($"Shadowmourne obtained!");
                    }
                    else if (element.Key == "fragments")
                    {
                        Console.WriteLine($"Valanyr obtained!");
                    }
                    else if (element.Key == "motes")
                    {
                        Console.WriteLine($"Dragonwrath obtained!");
                    }
                    Console.WriteLine($"{element.Key}: {materials[element.Key]}");

                    materials.Remove(element.Key);

                    Dictionary<string, int> filter = 
                        materials.OrderByDescending(x => x.Value)
                        .ThenBy(x => x.Key)
                        .ToDictionary(a => a.Key, b => b.Value);


                    foreach (var item in filter)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }

                    junk = junk.OrderBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
                    foreach (var item in junk)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }

                    break;
                }
            }
        }
    }
}
