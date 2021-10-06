using System;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();

            n = n.OrderByDescending(x => x).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", n));
        }
    }
}
