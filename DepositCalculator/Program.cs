using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double interestPerYear = deposit * (0.01 * percent);
            double interestPerMonth = interestPerYear / 12;

            double totalInterest = interestPerMonth * months;
            double totalAmount = deposit + totalInterest;

            Console.WriteLine(totalAmount);
        }
    }
}
