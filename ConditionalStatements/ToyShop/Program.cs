using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVacation = double.Parse(Console.ReadLine());
            int countPuzles = int.Parse(Console.ReadLine());
            int countDolls = int.Parse(Console.ReadLine());
            int countTeddyBear = int.Parse(Console.ReadLine());
            int countMinions = int.Parse(Console.ReadLine());
            int countTrucks = int.Parse(Console.ReadLine());

            double pricePuzels = countPuzles * 2.60;
            double priceDolls = countDolls * 3.00;
            double priceTeddyBears = countTeddyBear * 4.10;
            double priceMinions = countMinions * 8.20;
            double priceTrucks = countTrucks * 2.00;

            int totalSoldToys = countPuzles + countDolls + countTeddyBear + countMinions + countTrucks;

            double totalIncome = pricePuzels + priceDolls + priceTeddyBears + priceMinions + priceTrucks;

            if(totalSoldToys >= 50)
            {
                totalIncome = totalIncome * 0.75;
            }

            double rent = totalIncome * 0.1;

            totalIncome = totalIncome - rent;

            if(totalIncome >= priceVacation)
            {
                Console.WriteLine($"Yes! {totalIncome - priceVacation:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceVacation - totalIncome:F2} lv needed.");
            }
        }
    }
}
