using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallRent = double.Parse(Console.ReadLine());

            double cakePrice = (hallRent/100) * 20;
            double drinksPrice = cakePrice - ((cakePrice / 100)*45);
            double animator = hallRent * (1 / 3.0);

            double total = cakePrice + drinksPrice + animator + hallRent;

            Console.WriteLine(total);
        }
    }
}
