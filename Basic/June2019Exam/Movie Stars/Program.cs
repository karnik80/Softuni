using System;

namespace Movie_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            while (true)
            {
                string name = Console.ReadLine();
                if(name == "ACTION")
                {
                    Console.WriteLine($"We are left with {budget:F2} leva.");
                    break;
                }
                int symbols = name.Length;
                if(symbols > 15)
                {
                    budget = budget - (budget * 0.2);
                }
                else
                {
                    double salary = double.Parse(Console.ReadLine());
                    budget -= salary;
                }

                if (budget < 0)
                {
                    Console.WriteLine($"We need {Math.Abs(budget):F2} leva for our actors.");
                    break;
                }
            }
        }
    }
}
