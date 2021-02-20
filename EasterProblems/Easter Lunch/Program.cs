using System;

namespace Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int cozunak = int.Parse(Console.ReadLine());
            int eags = int.Parse(Console.ReadLine());
            int cookies = int.Parse(Console.ReadLine());

            double budget = (cozunak * 3.20) + (eags * 4.35) + (cookies * 5.40) + (eags * 12 * 0.15);
            Console.WriteLine($"{budget:F2}");
        }
    }
}
