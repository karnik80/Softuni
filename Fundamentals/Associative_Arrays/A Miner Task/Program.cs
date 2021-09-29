using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, uint> myTask = new Dictionary<string, uint>();

            string key = string.Empty;

            while((key = Console.ReadLine()) != "stop")
            {
                uint val = uint.Parse(Console.ReadLine());

                if (myTask.ContainsKey(key))
                {
                    myTask[key] += val;
                }
                else
                {
                    myTask.Add(key, val);
                }
            }

            foreach (var item in myTask)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
