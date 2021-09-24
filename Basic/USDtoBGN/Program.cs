using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountUSD = double.Parse(Console.ReadLine());
            
            Console.WriteLine(amountUSD * 1.79549);
        }
    }
}
