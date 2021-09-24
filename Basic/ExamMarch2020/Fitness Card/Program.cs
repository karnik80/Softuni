using System;

namespace Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double price = 0.0;

            if(gender == "m")
            {
                switch (sport)
                {
                    case "Gym":
                        price = 42.00;
                        break;
                    case "Boxing":
                        price = 41.00;
                        break;
                    case "Yoga":
                        price = 45.00;
                        break;
                    case "Zumba":
                        price = 34.00;
                        break;
                    case "Dances":
                        price = 51.00;
                        break;
                    case "Pilates":
                        price = 39.00;
                        break;
                }
            }
            else if(gender == "f")
            {
                switch (sport)
                {
                    case "Gym":
                        price = 35.00;
                        break;
                    case "Boxing":
                        price = 37.00;
                        break;
                    case "Yoga":
                        price = 42.00;
                        break;
                    case "Zumba":
                        price = 31.00;
                        break;
                    case "Dances":
                        price = 53.00;
                        break;
                    case "Pilates":
                        price = 37.00;
                        break;
                }
            }

            if(age <= 19)
            {
                price = price - (price * 0.2);
            }

            if(budget >= price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${Math.Abs(budget - price):F2} more.");
            }
        }
    }
}
