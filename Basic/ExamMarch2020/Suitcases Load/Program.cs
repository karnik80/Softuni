using System;

namespace Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());

            int suitcasesCount = 0;
            int count = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "End")
                {
                    Console.WriteLine("Congratulations! All suitcases are loaded!");
                    Console.WriteLine($"Statistic: {suitcasesCount} suitcases loaded.");
                    break;
                }
                double volume = double.Parse(input);
                if (count == 2)
                {
                    volume += (volume * 0.1);
                    count = 0;
                }

                capacity -= volume;

                if(capacity < 0)
                {
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {suitcasesCount} suitcases loaded.");
                    break;
                }
                else
                {
                    suitcasesCount++;
                }
                count++;
            }
        }
    }
}
