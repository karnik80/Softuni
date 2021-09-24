using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double iagodiPrice = double.Parse(Console.ReadLine());
            double bananasKG = double.Parse(Console.ReadLine());
            double orangeKG = double.Parse(Console.ReadLine());
            double maliniKG = double.Parse(Console.ReadLine());
            double iagodiKG = double.Parse(Console.ReadLine());

            double maliniPrice = iagodiPrice / 2;
            double orangePrice = maliniPrice - (maliniPrice * 0.4);
            double bananasPrice = maliniPrice - (maliniPrice * 0.8);

            double totalPrice = (iagodiKG * iagodiPrice) + (maliniKG * maliniPrice) + (orangeKG * orangePrice)
                + (bananasKG * bananasPrice);

            Console.WriteLine( Math.Round(totalPrice, 2));
        }
    }
}
