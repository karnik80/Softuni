using System;

namespace Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalBudget = double.Parse(Console.ReadLine());

            double budget = totalBudget;
            double total = 0.0;
            int productCount = 0;
            int count = 1;

            while (true)
            {
                string product = Console.ReadLine();
                if(product == "Stop")
                {
                    Console.WriteLine($"You bought {productCount} products for {total:F2} leva.");
                    break;
                }
                double price = double.Parse(Console.ReadLine());

                if (count == 3)
                {
                    total += price/2;
                    budget -= price/2;
                    count = 1;
                }
                else
                {
                    total += price;
                    budget -= price;
                    count++;
                }
                productCount++;

                if(budget < 0)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {Math.Abs(totalBudget - total):F2} leva!");
                    break;
                }
                
            }
        }
    }
}
