using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenNumber = int.Parse(Console.ReadLine());
            int fishNumber = int.Parse(Console.ReadLine());
            int vegeNumber = int.Parse(Console.ReadLine());

            double total = 0.0;

            total = (chickenNumber * 10.35) + (fishNumber * 12.40) + (vegeNumber * 8.15);
            total += (total * 0.2);
            total += 2.50;

            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
