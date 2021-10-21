using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = string.Empty;

            Dictionary<string, string> cars = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] tokens = input.Split();
                string com = tokens[0];
                string user = tokens[1];

                if(com == "register")
                {
                    if (cars.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {cars[user]}");
                    }
                    else
                    {
                        string plate = tokens[2];
                        cars.Add(user, plate);
                        Console.WriteLine($"{user} registered {plate} successfully");
                    }
                }
                else if(com == "unregister")
                {
                    if (cars.ContainsKey(user))
                    {
                        cars.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                }
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
