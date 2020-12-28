using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceFlowers = 0.0;

            if(flower == "Roses")
            {
                priceFlowers = countFlowers * 5;
                if (countFlowers > 80)
                {
                    priceFlowers = priceFlowers * 0.9;
                }
            }
            else if(flower == "Dahlias")
            {
                priceFlowers = countFlowers * 3.80;
                if(countFlowers > 90)
                {
                    priceFlowers = priceFlowers * 0.85;
                }
            }
            else if(flower == "Tulips")
            {
                priceFlowers = countFlowers * 2.80;
                if(countFlowers > 80)
                {
                    priceFlowers = priceFlowers * 0.85;
                }
            }
            else if(flower == "Narcissus")
            {
                priceFlowers = countFlowers * 3.00;
                if(countFlowers < 120)
                {
                    priceFlowers = priceFlowers * 1.15;
                }
            }
            else if(flower == "Gladiolus")
            {
                priceFlowers = countFlowers * 2.50;
                if(countFlowers < 80)
                {
                    priceFlowers = priceFlowers * 1.20;
                }
            }
            else
            {

            }

            if((budget - priceFlowers) >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {flower} and {(budget - priceFlowers):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget - priceFlowers):F2} leva more.");
            }
        }
    }
}
