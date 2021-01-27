using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int LenghtSM = int.Parse(Console.ReadLine());
            int WidthSM = int.Parse(Console.ReadLine());
            int HeightSM = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volumeSMccubic = LenghtSM * WidthSM * HeightSM;
            double volumeLiters = volumeSMccubic / 1000.0;
            double volumeOthers = (volumeLiters / 100.0) * percent;
            double liters = volumeLiters - volumeOthers;

            Console.WriteLine(liters);
        }
    }
}
