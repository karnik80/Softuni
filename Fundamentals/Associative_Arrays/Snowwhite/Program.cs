using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();

            string command = string.Empty;

            while((command = Console.ReadLine()) != "Once upon a time")
            {
                string[] com = command.Split(" <:> ");
                string name = com[0];
                string color = com[1];
                int physics = int.Parse(com[2]);

                if(dwarfs.ContainsKey(color + " " + name))
                {
                    if(physics > dwarfs[color + " " + name])
                    {
                        dwarfs[color + " " + name] = physics;
                    }
                }
                else
                {
                    dwarfs.Add(color + " " + name, physics);
                }
            }


            foreach (var dwarf in dwarfs.OrderByDescending(x => x.Value)
                .ThenByDescending(x => dwarfs.Where(y => y.Key.Split()[0] == x.Key.Split()[0]).Count()))
            {
                string color = dwarf.Key.Split()[0];
                string name = dwarf.Key.Split()[1];

                Console.WriteLine($"({color}) {name} <-> {dwarf.Value}");
            }

        }
    }
}
