using System;

namespace Easter_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int startEggs = int.Parse(Console.ReadLine());

            int soldEggs = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Close")
                {
                    Console.WriteLine($"Store is closed!");
                    Console.WriteLine($"{soldEggs} eggs sold.");
                    break;
                }
                int eggs = int.Parse(Console.ReadLine());
                int temp = 0;
                if(input == "Buy")
                {
                    temp = startEggs - eggs;
                    if(temp >= 0)
                    {
                        startEggs -= eggs;
                        soldEggs += eggs;
                    }
                    else
                    {
                        Console.WriteLine($"Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {startEggs}.");
                        break;
                    }
                }
                else if(input == "Fill")
                {
                    startEggs += eggs;
                }
            }
        }
    }
}
