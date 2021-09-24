using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int penNumber = int.Parse(Console.ReadLine());
            int markerNumber = int.Parse(Console.ReadLine());
            double liter = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double total = (penNumber * 5.80) + (markerNumber * 7.20) + (liter * 1.20);
            double disc = (discount*1.0 / 100) * total;
            total = total - disc;

            Console.WriteLine("{0:F3}", total);
        }
    }
}
