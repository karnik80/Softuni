using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                decimal temp = Math.Round(Convert.ToDecimal(input[i]), MidpointRounding.AwayFromZero);
                Console.WriteLine($"{Convert.ToDecimal(input[i])} => {temp}");
            }
        }
    }
}
