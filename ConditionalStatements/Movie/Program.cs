using System;

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double Dress = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double priceDress = Dress * people;

            if(people > 150)
            {
                priceDress = priceDress * 0.9;
            }

            double moneyRemain = budget - (decor + priceDress);

            if(moneyRemain >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyRemain:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(moneyRemain):F2} leva more.");
            }
        }
    }
}
