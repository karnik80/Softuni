using System;

namespace Excursion_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            int sea = int.Parse(Console.ReadLine());
            int mountain = int.Parse(Console.ReadLine());

            double profit = 0.0;

            while (true)
            {
                string packet = Console.ReadLine();
                if(packet == "Stop")
                {
                    Console.WriteLine($"Profit: {profit} leva.");
                    break;
                }

                if(packet == "sea" && sea != 0)
                {
                    profit += 680.00;
                    sea--;
                }
                else if(packet == "mountain" && mountain != 0)
                {
                    profit += 499.00;
                    mountain--;
                }

                if(sea == 0 && mountain == 0)
                {
                    Console.WriteLine($"Good job! Everything is sold.");
                    Console.WriteLine($"Profit: {profit} leva.");
                    break;
                }
            }
        }
    }
}
