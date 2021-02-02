using System;

namespace Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            double bed = double.Parse(Console.ReadLine());
            double toilet = double.Parse(Console.ReadLine());

            double food = toilet + (toilet * 0.25);
            double toys = food - (food * 0.5);
            double medical = toys + (toys * 0.1);

            double monthTotal = toilet + food + toys + medical;
            double additionalExpense = monthTotal * 0.05;

            double yearlyExpense = bed + (12 * monthTotal) + (12 * additionalExpense);

            Console.WriteLine($"{yearlyExpense:F2} lv.");
        }
    }
}
