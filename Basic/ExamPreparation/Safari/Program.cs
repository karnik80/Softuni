using System;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double liters = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double total = 0.0;
            total = (liters * 2.10) + 100;

            if(day == "Saturday")
            {
                total = total - (total * 0.1);
            }
            else if(day == "Sunday")
            {
                total = total - (total * 0.2);
            }

            double left = left = budget - total;

            if(budget >= total)
            {
                
                Console.WriteLine($"Safari time! Money left: {left:F2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {Math.Abs(left):F2} lv.");
            }
        }
    }
}
