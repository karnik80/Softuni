using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDays = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancake = int.Parse(Console.ReadLine());

            double priceCakeperDay = cake * 45.0;
            double priceWafflesPerDay = waffles * 5.8;
            double pricePancakePerDay = pancake * 3.2;

            double bakersIncomePerDay = (priceCakeperDay + priceWafflesPerDay + pricePancakePerDay) * bakers;

            double totalIncome = bakersIncomePerDay * totalDays;
            double expences = totalIncome * (1 / 8.0);

            double total = totalIncome - expences;

            Console.WriteLine(total);
        }
    }
}
