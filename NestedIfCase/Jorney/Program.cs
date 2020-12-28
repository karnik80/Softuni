using System;

namespace Jorney
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double availMoney = 0.0;
            string destination = string.Empty;
            string type = string.Empty;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if(season == "summer")
                {
                    availMoney = budget * 0.3;
                    type = "Camp";
                }
                else if(season == "winter")
                {
                    availMoney = budget * 0.7;
                    type = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    availMoney = budget * 0.4;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    availMoney = budget * 0.8;
                    type = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                availMoney = budget * 0.9;
                type = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {availMoney:F2}");
        }
    }
}
